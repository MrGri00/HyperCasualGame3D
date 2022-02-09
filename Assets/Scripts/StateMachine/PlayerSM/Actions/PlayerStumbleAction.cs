using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

[CreateAssetMenu(menuName = "StateMachine/Player/Action/Stumble")]
public class PlayerStumbleAction : StateMachine.Action
{
    public override void Act(FatherController controller)
    {
        controller.SetAnimation("hasCollided", true);
    }
}