using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{

    //-------------------------->  source = GetComponent(AudioSource);  <---------------------------------

    public AudioSource source;
    public Transform tamanho;
    //bool acao = false;
    
    void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyUp("space"))
        {
            source.Play();
            Debug.Log("Tocandodasds");
            GetComponent<BoxCollider>().enabled = false;
            transform.localScale = new Vector3(0, 0, 0);
            //textFecha.SetActive(false);
            //textAbre.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
