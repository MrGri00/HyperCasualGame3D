using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystemKeyboard3D : MonoBehaviour
{
    [HideInInspector] public float hor = 0f;
    [HideInInspector] public bool jump = false;

    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
        jump = Input.GetKey(KeyCode.W);
    }
}
