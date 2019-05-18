using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portaCard2 : MonoBehaviour
{
    public GameObject porta;
    public Animator AnimadorPorta;
    bool portaFechada;
    bool acao;
    public PlayerController ctrl;

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
        if (portaFechada)
        {
            Debug.Log("ok");
            if (acao && ctrl.card2)
            {
                Debug.Log("ctrk11");
                AnimadorPorta.SetBool("Abre", true);
                AnimadorPorta.SetBool("Fecha", false);
                portaFechada = false;
                acao = false;

            }
        }
        else
        {
            if (acao && ctrl.card2)
            {
                AnimadorPorta.SetBool("Abre", false);
                AnimadorPorta.SetBool("Fecha", true);
                portaFechada = true;
                acao = false;
            }
        }
    }
}
