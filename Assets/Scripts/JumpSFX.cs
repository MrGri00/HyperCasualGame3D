using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSFX : PlaySFX
{
    private void Update()
    {
        if (GetComponent<InputSystemKeyboard3D>().jump && GetComponent<MovementBehaviour3D>().isGrounded)
            PlayAudio();
    }
}
