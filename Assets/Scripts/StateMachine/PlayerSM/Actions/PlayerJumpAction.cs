using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

[CreateAssetMenu(menuName = "StateMachine/Player/Action/Jump")]
public class PlayerJumpAction : StateMachine.Action
{
    public override void Act(FatherController controller)
    {
        controller.SetAnimation("isWaiting", false);
        controller.SetAnimation("isGrounded", false);
    }
}