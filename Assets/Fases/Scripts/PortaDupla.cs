using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaDupla : MonoBehaviour {

    public Animator AnimadorPortaE;
    public Animator AnimadorPortaD;
    bool portaFechada;
    bool acao;

    // Use this for initialization
    void Start() {
        portaFechada = true;
        acao = false;
        AnimadorPortaE.SetBool("Abre", false);
        AnimadorPortaE.SetBool("Fecha", true);
        AnimadorPortaD.SetBool("Abre", false);
        AnimadorPortaD.SetBool("Fecha", true);
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerStay(Collider other) {
        //AnimadorPorta51_52.SetBool("Teste", true);
        //AnimadorPorta51_52.SetBool("Teste2", PortaFechada);
        if (Input.GetKeyUp("space"))
        {
            acao = true;
            
        }
        Debug.Log("11");
        if (portaFechada)
            {
            Debug.Log("12222");
                if (acao)
                {
                Debug.Log("@#2233");
                    AnimadorPortaE.SetBool("Abre", true);
                    AnimadorPortaE.SetBool("Fecha", false);
                    AnimadorPortaD.SetBool("Abre", true);
                    AnimadorPortaD.SetBool("Fecha", false);
                    portaFechada = false;
                    acao = false;

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
