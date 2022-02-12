 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : FatherController
{
    InputSystemKeyboard3D _inputSystem;

    public static List<GameObject> partyList = new List<GameObject>();

    private void Start()
    {
        _inputSystem = GetComponent<InputSystemKeyboard3D>();
        _movementBehaviour3D = GetComponent<MovementBehaviour3D>();
        _animatorController = GetComponent<Animator>();

        partyList.Add(gameObject);
    }

    private void Update()
    {
        currentState.UpdateState(this);

        _movementBehaviour3D.Move(_inputSystem.hor);
    }
}
