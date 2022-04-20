using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ExamOnCollisionAddSpeed : CollisionSystem
{
    protected override void OnCollision(Collision other)
    {
        GetComponent<_ExamMethods>().E2_AddSpeed();

        GetComponent<HealthManager>().ReduceHealth(1);
    }
}
