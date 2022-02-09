using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    InputSystemKeyboard3D _inputSystem;
    MovementBehaviour3D _movementBehaviour3D;

    private void Awake()
    {
        _inputSystem = GetComponent<InputSystemKeyboard3D>();
        _movementBehaviour3D = GetComponent<MovementBehaviour3D>();
    }

    private void Update()
    {
        _movementBehaviour3D.Move(_inputSystem.hor);
    }
}
