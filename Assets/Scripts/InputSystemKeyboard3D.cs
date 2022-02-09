using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystemKeyboard3D : MonoBehaviour
{
    [HideInInspector] public float hor = 0f;

    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
    }
}
