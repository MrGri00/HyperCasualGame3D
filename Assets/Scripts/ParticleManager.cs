using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    private GameObject particleSystem;

    private void OnEnable()
    {
        PlayerDeath.Dead += PlayParticles;
    }

    private void OnDisable()
    {
        PlayerDeath.Dead -= PlayParticles;
    }

    public void PlayParticles(Vector3 particlesPos)
    {
        particleSystem = PoolingManager.Instance.GetPooledObject("DeathParticles");

        particleSystem.transform.position = particlesPos;

        particleSystem.SetActive(true);
    }
}
