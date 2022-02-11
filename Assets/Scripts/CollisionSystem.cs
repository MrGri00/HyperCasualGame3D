using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSystem : MonoBehaviour
{
    [SerializeField] protected int value = 1;

    private void OnCollisionEnter(Collision collision)
    {
        OnCollision(collision);
    }

    protected virtual void OnCollision(Collision other)
    {
        other.gameObject.GetComponent<HealthManager>()?.ReduceHealth(value);
    }
}
