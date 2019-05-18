﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portaCard1 : MonoBehaviour
{
    public Animator AnimadorPortaE;
    public Animator AnimadorPortaD;
    bool portaFechada;
    bool acao;
    public PlayerController player_ctrl;

    // Use this for initialization
    void Start()
    {
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

    }

    void OnTriggerStay(Collider other)
    {
        //AnimadorPorta51_52.SetBool("Teste", true);
        //AnimadorPorta51_52.SetBool("Teste2", PortaFechada);
        if (Input.GetKeyUp("space") && player_ctrl.card1)
        {
            Debug.Log("uidsdhsi" + player_ctrl.card1);
            acao = true;

        }
            if (acao )
            {
                AnimadorPortaE.SetBool("Abre", true);
                AnimadorPortaE.SetBool("Fecha", false);
                AnimadorPortaD.SetBool("Abre", true);
                AnimadorPortaD.SetBool("Fecha", false);
                portaFechada = false;
                acao = false;

            }
        else
        {
            if (acao && player_ctrl.chave)
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
