using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSFX : PlaySFX
{
    private void OnEnable()
    {
        GetComponent<HealthManager>().Death += PlayAudio;
    }

    private void OnDisable()
    {
        GetComponent<HealthManager>().Death -= PlayAudio;
    }
}
