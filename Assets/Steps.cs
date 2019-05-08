using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps : MonoBehaviour
{

    [SerializeField]
    private AudioClip[] clips;
    public AudioSource audioSource;
    // Start is called before the first frame update

    
    private void Step()
    {
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }

    private AudioClip GetRandomClip(){
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }
}
