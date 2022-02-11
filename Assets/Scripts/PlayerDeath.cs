using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
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

        gameObject.SetActive(false);
    }
}
