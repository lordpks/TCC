using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave2 : MonoBehaviour
{

    // -------------------------------->  source = GetComponent(AudioSource);  <-------------------------------------

    public AudioSource source;
    public Transform Tamanho;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp("space"))
        {
            source.Play();
            GetComponent<BoxCollider>().enabled = false;
            Tamanho.transform.localScale = new Vector3(0, 0, 0);
            //textFecha.SetActive(false);
            //textAbre.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
