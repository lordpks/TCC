using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{

    //-------------------------->  source = GetComponent(AudioSource);  <---------------------------------

    public AudioSource source;
    public GameObject chave;
    public AudioClip audio;
    //bool acao = false;
    private void Start()
    {
        var Tamanho = chave.GetComponent<Transform>();
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (Input.GetKeyUp("space"))
        {
            source.PlayOneShot(audio);
            Debug.Log("Tocandodasds");
            GetComponent<BoxCollider>().enabled = false;
            transform.localScale = new Vector3(0, 0, 0);
            //textFecha.SetActive(false);
            //textAbre.SetActive(true);
            chave.SetActive(false);
        }
    }
}
