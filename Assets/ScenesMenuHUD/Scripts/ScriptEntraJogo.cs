using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class ScriptEntraJogo : MonoBehaviour
{
    public GameObject menuAtual;
    public GameObject menuProximo;
    public GameObject tituloPort;
    public GameObject titleEnglish;
    //public VideoPlayer videoBackgroundCompleto;
    public AudioSource trilha;

   
    public void EntraJogo()
    {

        menuAtual.SetActive(false);
        tituloPort.SetActive(false);
        titleEnglish.SetActive(false);
        //videoBackgroundCompleto.time = 11.1f;
        trilha.Stop();
        menuProximo.SetActive(true);

        
    }

}
