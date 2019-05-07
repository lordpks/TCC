using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class ScriptControlaVideoJogo : MonoBehaviour
{

    public VideoPlayer videoBackgroundCompleto;
    
    private void Start()
    {
        videoBackgroundCompleto.time = 12.0f;
    }

    private void Update()
    {
        if (videoBackgroundCompleto.time == 17.0f)
        {
            SceneManager.LoadScene("Scene1");
        }
    }



}
