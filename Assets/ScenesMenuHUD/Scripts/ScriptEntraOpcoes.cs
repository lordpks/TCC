using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptEntraOpcoes : MonoBehaviour
{

    public GameObject menuAtual;
    public GameObject menuProximo;
    public Button primeiroBotao;

    public Button BotaoPortugues;
    public Button BotaoIngles;


    public void EntraMenu()
    {
        menuAtual.SetActive(false);
        menuProximo.SetActive(true);
        primeiroBotao.Select();

        if (BotaoIngles.IsActive())
        {

            BotaoPortugues.enabled = false;
            BotaoIngles.enabled = true;

        }
        else
        {
            BotaoPortugues.enabled = true;
            BotaoIngles.enabled = false;

        }

        
    }


}
