using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionAlly : CollisionSystem
{
    [SerializeField] private Material playerMaterial = null;

    protected override void OnCollision(Collision other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            gameObject.tag = other.gameObject.tag;
            gameObject.layer = other.gameObject.layer;

            GetComponentInChildren<SkinnedMeshRenderer>().material = playerMaterial;

            GetComponent<MovementBehaviour3D>().LookForward();
            GetComponent<MovementBehaviour3D>().CalculatePlayerOffset();

            PlayerController.partyList.Add(gameObject);

            enabled = false;
        }
        
    }
}
