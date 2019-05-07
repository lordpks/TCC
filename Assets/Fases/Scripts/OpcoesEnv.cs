using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class OpcoesEnv : MonoBehaviour {

    public AudioMixer audioMixer;

    public Dropdown resolucaoDrop;

    public Dropdown grafsDrop;

    Resolution[] resolucoes;

    public Slider slider;
    

    void Start()
    {

        

        float volume;
        bool result = audioMixer.GetFloat("MasterVolume", out volume);
        if(result)
        {
            slider.value = volume;
        }

        int qualityLevel = QualitySettings.GetQualityLevel();
        grafsDrop.value = qualityLevel;
        grafsDrop.RefreshShownValue();
        resolucaoDrop.Select();

        resolucoes = Screen.resolutions;
        resolucaoDrop.ClearOptions();
        List<string> opcoes = new List<string>();
        int currentResidx = 0;
        foreach(Resolution resolution in resolucoes)
        {
            //if (resolution.width == 800 || (resolution.width == 1280 && resolution.height == 1024 && resolution.refreshRate == 60) || resolution.width == 1600 || resolution.width == 1920)
            //{
                
            //}
            
            if(resolution.refreshRate == 60)
            {
                
            }
            resolucaoDrop.options.Add(new Dropdown.OptionData(resolution.ToString()));



        }

        for (int i = 0; i < resolucoes.Length; i++)
        {
            if (resolucoes[i].width == Screen.currentResolution.width && resolucoes[i].height == Screen.currentResolution.height)
            {
                currentResidx = i;
                resolucaoDrop.value = currentResidx;
                resolucaoDrop.RefreshShownValue();
            }
        }



        //for (int i = 0; i < resolucoes.Length; i++)
        //{
        // if(i % 2 == 0)
        // {
        //if (resolucoes[i].width == 800 || resolucoes[i].width == 1024 || (resolucoes[i].width == 1280 && resolucoes[i].height == 1024) || resolucoes[i].width == 1440 || resolucoes[i].width == 1600 || resolucoes[i].width == 1920)
        // {
        //     string opcao = resolucoes[i].width + "x" + resolucoes[i].height;
        //     opcoes.Add(opcao);


        // }


        // if (resolucoes[i].width == Screen.currentResolution.width && resolucoes[i].height == Screen.currentResolution.height)
        //{
        //    currentResidx = i;
        //}
        //}

        // }


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene("MainMenu");

        }
    }

    public void SetRes(int resolucaoidx)
    {
        // Resolution resolucao = resolucoes[resolucaoidx];
        Debug.Log(resolucoes[resolucaoDrop.value].width);
        Debug.Log(resolucoes[resolucaoDrop.value].height);
        Screen.SetResolution(resolucoes[resolucaoDrop.value].width, resolucoes[resolucaoDrop.value].height, Screen.fullScreen); 
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
    }

    public void SetQuality(int qualityidx)
    {
        QualitySettings.SetQualityLevel(qualityidx);
        

    }

    public void SetFullScr(bool isfull)
    {
        Screen.fullScreen = isfull;
    }
}
