using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsRun : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] clips;
    public AudioSource audioSource;
    // Start is called before the first frame update


    private void StepRun()
    {
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }

    private AudioClip GetRandomClip()
    {
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }
}
