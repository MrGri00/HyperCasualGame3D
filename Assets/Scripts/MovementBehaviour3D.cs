using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour3D : MonoBehaviour
{
    // EDITOR VARIABLES
    [SerializeField] private float speed = 10f;

    // CALCULATIONS
    Vector3 vec3 = new Vector3(0, 0, 0);

    public void Move(float input)
    {
        vec3.x = input;
        vec3.y = 0;
        vec3.z = 1;

        transform.Translate(vec3 * speed * Time.deltaTime);
    }
}
