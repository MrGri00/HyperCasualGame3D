using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour3D : MonoBehaviour
{
    // EDITOR VARIABLES //
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private float absoluteLimitZ = 11f;

    // CALCULATIONS //
    [HideInInspector] public bool isGrounded = false;
    Vector3 playerOffset = new Vector3(0, 0, 0);
    Vector3 vect3 = new Vector3(0, 0, 0);
    Quaternion quat = new Quaternion(0, 0, 0, 0);

    public void Move(float input)
    {
        if ((transform.position.z >= absoluteLimitZ && input > 0) || (transform.position.z <= -absoluteLimitZ && input < 0))
            input = 0;

        vect3.x = input;
        vect3.y = 0;
        vect3.z = 1;

        transform.Translate(vect3 * speed * Time.deltaTime);
    }

    public void Move()
    {
        GetComponent<Rigidbody>().MovePosition(GetPlayerPosition() - playerOffset);

        if (transform.position.z >= absoluteLimitZ || transform.position.z <= -absoluteLimitZ)
        {
            vect3.x = transform.position.x;
            vect3.y = transform.position.y;
            vect3.z = absoluteLimitZ * Mathf.Sign(transform.position.z);

            transform.position = vect3;
        }
    }

    public void CarMove()
    {
        vect3.x = 1;
        vect3.y = 0;
        vect3.z = 0;

        transform.Translate(vect3 * speed * Time.deltaTime);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            vect3.x = 0;
            vect3.y = jumpForce;
            vect3.z = 0;

            GetComponent<Rigidbody>().velocity = vect3;
            //GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void RotateY(float y)
    {
        quat = Quaternion.Euler(0, y, 0);

        transform.rotation = quat;
    }

    public void CalculatePlayerOffset()
    {
        playerOffset = GetPlayerPosition() - transform.position;
        playerOffset.y = 0;
    }

    public float GetPlayerPositionY()
    {
        for (int i = 0; i < PlayerController.partyList.Count; i++)
        {
            if (PlayerController.partyList[i].GetComponent<PlayerController>())
            {
                vect3 = PlayerController.partyList[i].transform.position;
                break;
            }
        }

        return vect3.y;
    }

    public Vector3 GetPlayerPosition()
    {
        for (int i = 0; i < PlayerController.partyList.Count; i++)
        {
            if (PlayerController.partyList[i].GetComponent<PlayerController>())
            {
                vect3 = PlayerController.partyList[i].transform.position;
                break;
            }
        }

        return vect3;
    }
}
