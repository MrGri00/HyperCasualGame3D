using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    void Update()
    {
        GetComponent<MovementBehaviour3D>().EnemyMove();
    }
}
