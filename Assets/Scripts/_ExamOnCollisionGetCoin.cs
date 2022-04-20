using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ExamOnCollisionGetCoin : CollisionSystem
{
    protected override void OnCollision(Collision other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            GetComponent<_ExamMethods>().E5_CoinCollected(value);

            GetComponent<HealthManager>().ReduceHealth(1);
        }
    }
}
