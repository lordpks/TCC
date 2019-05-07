using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using System.Collections;

public class ScriptSomBotoes : MonoBehaviour, IPointerEnterHandler, ISelectHandler
{

    public AudioSource EfeitoTrocaBotao;

    public void OnPointerEnter(PointerEventData ped)
    {
        EfeitoTrocaBotao.Play();
    }

    public void OnSelect(BaseEventData eventData)
    {
        EfeitoTrocaBotao.Play();
    }
}
