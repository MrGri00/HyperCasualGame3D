using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

[CreateAssetMenu(menuName = "StateMachine/Player/Decisions/Grounded")]
public class PlayerGroundedDecision : StateMachine.Decision
{
    public override bool Decide(FatherController controller)
    {
        return controller._movementBehaviour3D.isGrounded;
    }
}