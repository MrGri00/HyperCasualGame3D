using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour3D : MonoBehaviour
{
    // EDITOR VARIABLES //
    [SerializeField] private float speed = 10f;

    // CALCULATIONS //
    Vector3 playerOffset = new Vector3(0, 0, 0);
    Vector3 vect3 = new Vector3(0, 0, 0);
    Quaternion quat = new Quaternion(0, 0, 0, 0);

    public void Move(float input)
    {
        vect3.x = input;
        vect3.y = 0;
        vect3.z = 1;

        transform.Translate(vect3 * speed * Time.deltaTime);
    }

    public void Move()
    {
        GetComponent<Rigidbody>().MovePosition(GetPlayerPosition() - playerOffset);
    }

    public void LookForward()
    {
        quat = Quaternion.Euler(0, -90, 0);

        transform.rotation = quat;
    }

    public void CalculatePlayerOffset()
    {
        playerOffset = GetPlayerPosition() - transform.position;
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
