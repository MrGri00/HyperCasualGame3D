using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlaySFX : MonoBehaviour
{
    public AudioClip sfxToPlay;

    bool canPlay = true;

    protected void PlayAudio()
    {
        if (canPlay)
        {
            AudioSource.PlayClipAtPoint(sfxToPlay, transform.position);
            canPlay = false;
            StartCoroutine(CooldownSFX());
        }
    }

    protected IEnumerator CooldownSFX()
    {
        yield return new WaitForSeconds(sfxToPlay.length);
        canPlay = true;
    }
}
