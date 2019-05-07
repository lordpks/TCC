using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ScriptMenuPrincipal : MonoBehaviour
{

    public GameObject menuAtual;
    public GameObject menuProximo;
    public Button primeiroBotao;
    public VideoPlayer videoBackgroundCompleto;
    private double endVideo = 10.0f;


    private void Update()
    {
        ControlaVideo();
    }

    public void EntraMenu()
    {
        menuAtual.SetActive(false);
        menuProximo.SetActive(true);
        primeiroBotao.Select();
    }


    void ControlaVideo()
    {
        if (videoBackgroundCompleto.time == endVideo)
        {
                videoBackgroundCompleto.time = 7.0f;

        }

    }
}
