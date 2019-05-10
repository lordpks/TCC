using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batimentos : MonoBehaviour
{
    public AudioClip Bslow;
    public AudioClip Bfast;

    public AudioSource audioSource;

    public void Stop()
    {
        audioSource.Stop();
    }

    public void BatimentoCalmo()
    {
        Debug.Log("play calm");
        audioSource.clip = Bslow;
        audioSource.Play();
    }

    public void BatimentoRapido()
    {
        Debug.Log("play fast");
        audioSource.clip = Bfast;
        audioSource.Play();
    }

}
