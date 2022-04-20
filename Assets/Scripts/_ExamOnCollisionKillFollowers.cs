using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ExamOnCollisionKillFollowers : CollisionSystem
{
    protected override void OnCollision(Collision other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            GetComponent<_ExamMethods>().E3_LoseFollowers();

            GetComponent<HealthManager>().ReduceHealth(1);
        }
    }
}
