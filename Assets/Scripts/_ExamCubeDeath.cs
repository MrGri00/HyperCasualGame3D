using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ExamCubeDeath : PlayerDeath
{
    protected override void DeathMethod()
    {
        gameObject.SetActive(false);
    }
}
