using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public static Action<StateMachine.State> OldKingIsDead = delegate { };

    private void OnEnable()
    {
        GetComponent<HealthManager>().Death += DeathMethod;
    }

    private void OnDisable()
    {
        GetComponent<HealthManager>().Death -= DeathMethod;
    }

    void DeathMethod()
    {
        PlayerController.partyList.Remove(gameObject);

        if (GetComponent<PlayerController>())
            OldKingIsDead(GetComponent<PlayerController>().currentState);

        gameObject.SetActive(false);
    }
}
