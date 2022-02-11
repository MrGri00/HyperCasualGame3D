using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

[CreateAssetMenu(menuName = "StateMachine/Player/Action/Idle")]
public class PlayerIdleAction : StateMachine.Action
{
    public override void Act(FatherController controller)
    {
        controller.SetAnimation("isWaiting", true);
    }
}