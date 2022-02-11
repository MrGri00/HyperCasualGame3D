using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerController : FatherController
{
    private void Awake()
    {
        _movementBehaviour3D = GetComponent<MovementBehaviour3D>();
        _animatorController = GetComponent<Animator>();
    }

    private void Update()
    {
        currentState.UpdateState(this);

        if (PlayerController.partyList.Contains(gameObject))
        {
            _movementBehaviour3D.Move();
        }
    }   
}
