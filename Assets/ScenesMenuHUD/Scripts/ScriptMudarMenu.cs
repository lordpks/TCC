using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ScriptMudarMenu : MonoBehaviour
{

    public GameObject menuAtual;
    public GameObject menuProximo;
    public Button primeiroBotao;
    public VideoPlayer videoBackgroundCompleto;
    private bool botaoPressionado = false;
    private double endVideo;
  

    // Update is called once per frame

    void Start()
    {
        endVideo = 3.0f;
    }


    void Update()
    {

        ControlaVideo();

        if (Input.anyKeyDown)
        {
            botaoPressionado = true;
        }


        if (botaoPressionado)
        {
            videoBackgroundCompleto.time = 5.1f;
            menuAtual.SetActive(false);
            menuProximo.SetActive(true);
            primeiroBotao.Select();

        }
    }

    void ControlaVideo()
    {
        if (videoBackgroundCompleto.time == endVideo)
        {
            if (!botaoPressionado) { 
                videoBackgroundCompleto.time = 0.1f;
            }
            
        }

    }

}
