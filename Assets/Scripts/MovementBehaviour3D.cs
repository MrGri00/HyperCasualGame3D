using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour3D : MonoBehaviour
{
    // EDITOR VARIABLES //
    [SerializeField] private float speed = 10f;

    // CALCULATIONS //
    Vector3 vect3 = new Vector3(0, 0, 0);

    public void Move(float input)
    {
        vect3.x = input;
        vect3.y = 0;
        vect3.z = 1;

        transform.Translate(vect3 * speed * Time.deltaTime);
    }
}
