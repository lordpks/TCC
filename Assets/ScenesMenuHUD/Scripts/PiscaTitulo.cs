using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiscaTitulo : MonoBehaviour
{
    public Text texto;
    public Color corAlpha;
    public float fadeTime = 0.01f;


    void Update()
    {

        Fade();

        if (corAlpha.a <= 0.01f)
        {
            fadeTime = fadeTime * (-1);
        }

        if (corAlpha.a >= 1.0f)
        {
            fadeTime = fadeTime * (-1);
        }


    }


    private void Fade()
    {
        corAlpha.a = corAlpha.a - fadeTime;
        texto.color = corAlpha;
    }



}
