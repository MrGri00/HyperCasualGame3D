using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour3D : MonoBehaviour
{
    // EDITOR VARIABLES
    [SerializeField] private float speed = 10f;

    // CALCULATIONS
    Vector3 vec3 = new Vector3(0, 0, 0);

    public void TranslateForwardZ()
    {
        vec3.z = 1;

        transform.Translate(vec3 * speed * Time.deltaTime);
    }
}
