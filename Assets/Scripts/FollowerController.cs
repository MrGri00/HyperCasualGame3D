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

    static void LongLiveTheKing(StateMachine.State state, AudioClip jump)
    {
        if (PlayerController.partyList.Count > 0)
        {
            Destroy(PlayerController.partyList[0].GetComponent<FollowerController>());

            if (!PlayerController.partyList[0].GetComponent<PlayerController>())
                PlayerController.partyList[0].AddComponent<PlayerController>();

            if (!PlayerController.partyList[0].GetComponent<InputSystemKeyboard3D>())
                PlayerController.partyList[0].AddComponent<InputSystemKeyboard3D>();

            if (!PlayerController.partyList[0].GetComponent<GroundCheck>())
                PlayerController.partyList[0].AddComponent<GroundCheck>();

            if (!PlayerController.partyList[0].GetComponent<JumpSFX>())
            {
                PlayerController.partyList[0].AddComponent<JumpSFX>();
                PlayerController.partyList[0].GetComponent<JumpSFX>().sfxToPlay = jump;
            }

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
