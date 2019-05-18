using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool card1 = false;
    public bool card2 = false;
    public bool card3 = false;
    public bool chave = false;
    public GameObject cardA;
    public GameObject cardB;
    public GameObject cardC;
    public GameObject key;

    public void OnTriggerStay(Collider other)
    {
       
        if (Input.GetKeyUp("space"))
        {
           
            if (other.gameObject.CompareTag("card1"))
            {
                other.gameObject.SetActive(false);
                card1 = true;
                cardA.SetActive(false);
            }

            if (other.gameObject.CompareTag("card2"))
            {
                other.gameObject.SetActive(false);
                card2 = true;
                cardB.SetActive(false);
            }

            if (other.gameObject.CompareTag("card3"))
            {
                other.gameObject.SetActive(false);
                card3 = true;
                cardC.SetActive(false);
            }

            if (other.gameObject.CompareTag("chave"))
            {
                other.gameObject.SetActive(false);
                chave = true;
                key.SetActive(false);
            }
        }
        
    }

}
