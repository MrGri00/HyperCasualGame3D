using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

[CreateAssetMenu(menuName = "StateMachine/Player/Action/Dance")]
public class PlayerDanceAction : StateMachine.Action
{
    public override void Act(FatherController controller)
    {
        controller.SetAnimation("isWaiting", false);
        controller.SetAnimation("isGrounded", true);
        controller.SetAnimation("hasFinished", true);
    }
}