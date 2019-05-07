using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartupManager : MonoBehaviour
{

    // Use this for initialization
    private IEnumerator Start()
    {
        LocalizationManager.instance.LoadLocalizedText("localText_ptbr.json");
        while (!LocalizationManager.instance.GetIsReady())
        {
            Debug.Log("waiting");
            yield return null;
        }

        SceneManager.LoadScene("MainMenu");
    }

}