using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : FatherController
{
    InputSystemKeyboard3D _inputSystem;

    private void Awake()
    {
        _inputSystem = GetComponent<InputSystemKeyboard3D>();
        _movementBehaviour3D = GetComponent<MovementBehaviour3D>();
        _animatorController = GetComponent<Animator>();
    }

    private void Update()
    {
        currentState.UpdateState(this);

        _movementBehaviour3D.Move(_inputSystem.hor);
    }
}
