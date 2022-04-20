using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionAlly : CollisionSystem
{
    [SerializeField] private Material playerMaterial = null;

    bool hasConverted = false;

    protected override void OnCollision(Collision other)
    {
        if (other.gameObject.tag.Equals("Player") && !hasConverted)
        {
            gameObject.tag = other.gameObject.tag;
            gameObject.layer = other.gameObject.layer;

            Convert();
        }
    }

    public void OnCollision()
    {
        gameObject.tag = "Player";
        gameObject.layer = LayerMask.NameToLayer("Player");

        Convert();
    }

    void Convert()
    {
        hasConverted = true;

        GetComponentInChildren<SkinnedMeshRenderer>().material = playerMaterial;

        GetComponent<MovementBehaviour3D>().RotateY(-90);
        GetComponent<MovementBehaviour3D>().CalculatePlayerOffset();

        GetComponent<HealthManager>().SetImmortality(false);

        PlayerController.partyList.Add(gameObject);

        enabled = false;
    }
}
