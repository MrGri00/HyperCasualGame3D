using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public static Action<Vector3> Dead = delegate { };
    public static Action GameOver = delegate { };
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

        if (PlayerController.partyList.Count <= 0)
            GameOver();

        else if (GetComponent<PlayerController>())
            OldKingIsDead(GetComponent<PlayerController>().currentState);

        Dead(transform.position);

        gameObject.SetActive(false);
    }
}
