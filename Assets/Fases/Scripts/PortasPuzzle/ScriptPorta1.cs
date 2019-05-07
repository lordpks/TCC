using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPorta1 : MonoBehaviour
{

    public GameObject porta;
    public GameObject chave1;
    public GameObject luzVermelha;
    public GameObject luzVerde;

    public Animator AnimadorPortaE;
    public Animator AnimadorPortaD;
    bool portaTrancada;
    bool portaFechada;
    bool acao;

    // Use this for initialization
    void Start()
    {
        portaTrancada = true;
        portaFechada = true;
        acao = false;
        AnimadorPortaE.SetBool("Abre", false);
        AnimadorPortaE.SetBool("Fecha", true);
        AnimadorPortaD.SetBool("Abre", false);
        AnimadorPortaD.SetBool("Fecha", true);
    }

    // Update is called once per frame
    void Update()
    {
        acao = false;
        if (!(chave1.activeInHierarchy))
        {
            portaTrancada = false;
        }
        if (!portaTrancada)
        {
            if (Input.GetKeyUp("space")) acao = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        //AnimadorPorta51_52.SetBool("Teste", true);
        //AnimadorPorta51_52.SetBool("Teste2", PortaFechada);

        if (!portaTrancada)
        {
            if (portaFechada)
            {
                if (acao)
                {
                    AnimadorPortaE.SetBool("Abre", true);
                    AnimadorPortaE.SetBool("Fecha", false);
                    AnimadorPortaD.SetBool("Abre", true);
                    AnimadorPortaD.SetBool("Fecha", false);
                    portaFechada = false;
                    acao = false;

                    luzVermelha.SetActive(false);
                    luzVerde.SetActive(true);

                }
            }
            else
            {
                if (acao)
                {
                    AnimadorPortaE.SetBool("Abre", false);
                    AnimadorPortaE.SetBool("Fecha", true);
                    AnimadorPortaD.SetBool("Abre", false);
                    AnimadorPortaD.SetBool("Fecha", true);
                    portaFechada = true;
                    acao = false;
                }
            }
        }
    }
}
