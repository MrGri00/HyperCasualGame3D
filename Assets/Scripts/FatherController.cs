using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FatherController : MonoBehaviour
{
    public MovementBehaviour3D _movementBehaviour3D;
    protected Animator _animatorController;

    public StateMachine.State currentState;

    public void SetAnimation(string variable, bool t)
    {
        _animatorController.SetBool(variable, t);
    }

    public void Transition(StateMachine.State nextState)
    {
        if (nextState != null)
            currentState = nextState;
    }
}
