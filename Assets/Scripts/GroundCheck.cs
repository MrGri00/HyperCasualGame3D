using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : CollisionSystem
{
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
            GetComponent<MovementBehaviour3D>().isGrounded = false;

        if (GetComponent<PlayerController>())
        {
            for (int i = 0; i < PlayerController.partyList.Count; i++)
            {
                if (PlayerController.partyList[i] != gameObject)
                    PlayerController.partyList[i].GetComponent<MovementBehaviour3D>().isGrounded = false;
            }
        }
    }

    protected override void OnCollision(Collision other)
    {
        if (other.gameObject.tag.Equals("Ground"))
            GetComponent<MovementBehaviour3D>().isGrounded = true;

        if (GetComponent<PlayerController>())
        {
            for (int i = 0; i < PlayerController.partyList.Count; i++)
            {
                if (PlayerController.partyList[i] != gameObject)
                    PlayerController.partyList[i].GetComponent<MovementBehaviour3D>().isGrounded = true;
            }
        }
    }
}
