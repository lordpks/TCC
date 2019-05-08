using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batimentos : MonoBehaviour
{
    public AudioClip Bslow;
    public AudioClip Bfast;

    public AudioSource audioSource;

    public void BatimentoCalmo()
    {
        audioSource.Stop();
        audioSource.clip = Bslow;
        audioSource.Play();
    }

    public void BatimentoRapido()
    {
        audioSource.Stop();
        audioSource.clip = Bfast;
        audioSource.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
