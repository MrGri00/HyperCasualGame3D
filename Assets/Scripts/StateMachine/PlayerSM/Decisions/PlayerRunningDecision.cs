using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

[CreateAssetMenu(menuName = "StateMachine/Player/Decisions/Running")]
public class PlayerRunningDecision : StateMachine.Decision
{
    public override bool Decide(FatherController controller)
    {
        FollowerController followerC = (FollowerController)controller;

        return PlayerController.partyList.Contains(followerC.gameObject);
    }
}