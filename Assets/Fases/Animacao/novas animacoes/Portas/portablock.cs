using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portablock : MonoBehaviour
{
    public GameObject porta;
    public Animator AnimadorPorta;
    bool portaFechada;
    bool acao;
    public BoxCollider coll;
    bool abrir = false;

    // Use this for initialization
    void Start()
    {
        
        portaFechada = true;
        acao = false;
        AnimadorPorta.SetBool("Abre", false);
        AnimadorPorta.SetBool("Fecha", true);
    }

    // Update is called once per frame
    void Update()
    {
        acao = false;
        if (Input.GetKeyUp("space"))
        {
            acao = true;
        }

    }


    void OnTriggerEnter(Collider other)
    {
        
        if (!abrir)
        {
            coll.enabled = !coll.enabled;
            abrir = false;
        }
        if (portaFechada)
        {
            if (acao)
            {
                AnimadorPorta.SetBool("Abre", true);
                AnimadorPorta.SetBool("Fecha", false);
                portaFechada = false;
                acao = false;

            }
        }
        else
        {
            if (acao)
            {
                AnimadorPorta.SetBool("Abre", false);
                AnimadorPorta.SetBool("Fecha", true);
                portaFechada = true;
                acao = false;
            }
        }
    }
}
