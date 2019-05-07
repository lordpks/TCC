using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScriptMudaIdioma : MonoBehaviour
{
    public Button BotaoPortugues;
    public Button BotaoIngles;

    public GameObject TituloPort;
    public GameObject TitleEnglish;

    public GameObject JogarPort;
    public GameObject PlayEnglish;

    public GameObject OpcoesPort;
    public GameObject OptionsEnglish;

    public GameObject CreditosPort;
    public GameObject CreditsEnglish;

    public GameObject SairPort;
    public GameObject ExitEnglish;

    public GameObject VoltarPort;
    public GameObject BackEnglish;


    public void clicaEnglish()
    {
        TituloPort.SetActive(false);
        TitleEnglish.SetActive(true);

        JogarPort.SetActive(false);
        PlayEnglish.SetActive(true);

        OpcoesPort.SetActive(false);
        OptionsEnglish.SetActive(true);

        CreditosPort.SetActive(false);
        CreditsEnglish.SetActive(true);

        SairPort.SetActive(false);
        ExitEnglish.SetActive(true);

        VoltarPort.SetActive(false);
        BackEnglish.SetActive(true);

        BotaoPortugues.enabled = true;
        BotaoIngles.enabled = false;

    }

    public void clicaPortuguês()
    {
        TitleEnglish.SetActive(false);
        TituloPort.SetActive(true);


        PlayEnglish.SetActive(false);
        JogarPort.SetActive(true);

        OptionsEnglish.SetActive(false);
        OpcoesPort.SetActive(true);


        CreditsEnglish.SetActive(false);
        CreditosPort.SetActive(true);


        ExitEnglish.SetActive(false);
        SairPort.SetActive(true);


        BackEnglish.SetActive(false);
        VoltarPort.SetActive(true);


        BotaoPortugues.enabled = false;
        BotaoIngles.enabled = true;


    }
}
