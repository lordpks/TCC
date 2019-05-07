using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LocalizationManager : MonoBehaviour
{
    

    public static LocalizationManager instance;

    public Button idioma_btn;

    private Dictionary<string, string> localizedText;

    private bool isReady = false;

    private string missingTextString = "Localized text not found";

    private bool load = false;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void LoadLocalizedText(string fileName)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        localizedText = new Dictionary<string, string>();

        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath, System.Text.Encoding.Default);
            LocalizationData loadedData = JsonUtility.FromJson<LocalizationData>(dataAsJson);

            for (int i = 0; i < loadedData.items.Length; i++)
            {
                localizedText.Add(loadedData.items[i].key, loadedData.items[i].value);
                Debug.Log(loadedData.items[i].value);
            }
            
            Debug.Log("Data loaded, dictionary contains: " + localizedText.Count + " entries");
        }
        else
        {
            Debug.LogError("Cannot find file!");
        }

        if (sceneName == "Opcoes")
        {
            SceneManager.LoadScene("Opcoes");
        }

        isReady = true;
    }

    public string GetLocalizedValue(string key)
    {
        string result = missingTextString;
        if (localizedText.ContainsKey(key))
        {
            result = localizedText[key].ToString();
        }
        return result;

    }

    public bool GetIsReady()
    {
        return isReady;
    }

}