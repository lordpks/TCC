using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ScriptControlaVideoMenu : MonoBehaviour
{

    public VideoPlayer videoBackgroundCompleto;
    private double endVideo;


    void Start()
    {
        endVideo = 12.0f;
    }

    private void Update()
    {
        ControlaVideo();
    }



    void ControlaVideo()
    {
        if (videoBackgroundCompleto.time == endVideo)
        {
            videoBackgroundCompleto.time = 7.5f;

        }

    }
}
