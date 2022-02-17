using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

[CreateAssetMenu(menuName = "StateMachine/Player/Decisions/Finished")]
public class PlayerFinishedDecision : StateMachine.Decision
{
    [SerializeField] float finishLineX = -615f;

    public override bool Decide(FatherController controller)
    {
        return controller.gameObject.transform.position.x <= finishLineX;
    }
}