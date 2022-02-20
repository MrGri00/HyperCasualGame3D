using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryBehaviour : FatherController
{
    private void Awake()
    {
        _movementBehaviour3D = GetComponent<MovementBehaviour3D>();
        _animatorController = GetComponent<Animator>();
    }

    private void Update()
    {
        currentState.UpdateState(this);

        _movementBehaviour3D.RotateY(90);
    }
}
