using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerController : FatherController
{
    public static Action<Transform> NewCamTarget = delegate { };

    private void Awake()
    {
        _movementBehaviour3D = GetComponent<MovementBehaviour3D>();
        _animatorController = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        PlayerDeath.OldKingIsDead += LongLiveTheKing;
    }

    private void OnDisable()
    {
        PlayerDeath.OldKingIsDead -= LongLiveTheKing;
    }

    private void LateUpdate()
    {
        currentState.UpdateState(this);

        if (PlayerController.partyList.Contains(gameObject))
            _movementBehaviour3D.Move();
    }

    static void LongLiveTheKing(StateMachine.State state)
    {
        if (PlayerController.partyList.Count > 0)
        {
            Destroy(PlayerController.partyList[0].GetComponent<FollowerController>());

            PlayerController.partyList[0].AddComponent<PlayerController>();
            PlayerController.partyList[0].AddComponent<InputSystemKeyboard3D>();

            PlayerController.partyList[0].GetComponent<PlayerController>().currentState = state;

            NewCamTarget(PlayerController.partyList[0].transform);

            for (int i = 1; i < PlayerController.partyList.Count; i++)
            {
                PlayerController.partyList[i].GetComponent<MovementBehaviour3D>().CalculatePlayerOffset();
            }

            ProgressionBar.UpdatePlayerRef(PlayerController.partyList[0].transform);
        }       
    }
}
