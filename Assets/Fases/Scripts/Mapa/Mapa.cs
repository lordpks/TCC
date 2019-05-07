using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour {

    public GameObject mapa;



    void OnCollisionEnter(Collision dataFromCollision)
    {
        if(dataFromCollision.gameObject.tag == "mapa")
        {
            if (Input.GetKeyUp("space"))
            {

                if (mapa.activeSelf)
                {
                    Debug.Log("entrou");
                    mapa.SetActive(false);
                    GetComponent<BoxCollider>().enabled = false;
                    GetComponent<BoxCollider>().enabled = true;
                }
                else
                {
                    Debug.Log("entro2u");
                    mapa.SetActive(true);
                    GetComponent<BoxCollider>().enabled = false;
                    GetComponent<BoxCollider>().enabled = true;
                }
            }
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        mapa.SetActive(false);
    }
}
