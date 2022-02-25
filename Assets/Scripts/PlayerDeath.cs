using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public static Action<Vector3> Dead = delegate { };
    public static Action GameOver = delegate { };
    public static Action<StateMachine.State, AudioClip> OldKingIsDead = delegate { };

    bool isDead = false;

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
        if (!isDead)
        {
            isDead = true;
            StartCoroutine(DeathCoroutine());
        }
    }

    IEnumerator DeathCoroutine()
    {
        if (PlayerController.partyList.Count <= 1)
        {
            GameOver();

            yield return null;
        }

        if (GetComponent<PlayerController>())
        {
            PlayerController.partyList.RemoveAt(0);
            OldKingIsDead(GetComponent<PlayerController>().currentState, GetComponent<JumpSFX>().sfxToPlay);
        }
        else
        {
            PlayerController.partyList.Remove(gameObject);
        }

        Dead(transform.position);

        gameObject.SetActive(false);

        yield return null;
    }
}
