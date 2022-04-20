using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ExamOnCollisionAddFollowers : CollisionSystem
{
    protected override void OnCollision(Collision other)
    {
        GetComponent<_ExamMethods>().E1_AddFollowers(value);
        GetComponent<HealthManager>().ReduceHealth(1);
    }
}
