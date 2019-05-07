using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilha : MonoBehaviour
{

    //----------------------------->  source = GetComponent(AudioSource);  <--------------------------------

    public AudioSource source;
    public Transform Tamanho;
    bool acao = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp("space"))
        {
            source.Play();
            GetComponent<BoxCollider>().enabled = false;
            transform.localScale = new Vector3(0, 0, 0);
            //textFecha.SetActive(false);
            //textAbre.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
