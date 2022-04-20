using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystemKeyboard3D : MonoBehaviour
{
    public static Action PauseGame = delegate { };

    [HideInInspector] public float hor = 0f;
    [HideInInspector] public bool jump = false;

    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
        jump = Input.GetKey(KeyCode.W);

        if (Input.GetKeyDown(KeyCode.Escape))
            PauseGame();

        if (Input.GetKeyDown(KeyCode.F5))
            _ExamMethods.E4_EndTeleport();
    }
}
