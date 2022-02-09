using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

[CreateAssetMenu(menuName = "StateMachine/Player/Decisions/Test")]
public class PlayerTestDecision : StateMachine.Decision
{
    public override bool Decide(FatherController controller)
    {
        PlayerController playerC = (PlayerController)controller;

        return false;
    }
}