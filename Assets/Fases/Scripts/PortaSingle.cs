using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaSingle : MonoBehaviour
{
    public GameObject porta;
    public Animator AnimadorPorta;
    bool portaFechada;
    bool acao;

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
    

    void OnTriggerStay(Collider other)
    {
        Debug.Log("portaporta1" + other);
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
