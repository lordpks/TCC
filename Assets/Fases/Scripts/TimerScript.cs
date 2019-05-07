using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {
    public GameObject Bateria5;
    public GameObject Bateria4;
    public GameObject Bateria3;
    public GameObject Bateria2;
    public GameObject Bateria1;
    public GameObject Bateria0;
    public GameObject pilha1;
    public GameObject pilha2;
    public GameObject pilha3;
    public GameObject pilha4;
    public GameObject pilha5;
    public GameObject pilha6;
    public GameObject pilha7;
    bool controlePilha1 = false;
    bool controlePilha2 = false;
    bool controlePilha3 = false;
    bool controlePilha4 = false;
    bool controlePilha5 = false;
    bool controlePilha6 = false;
    bool controlePilha7 = false;
    double timer = 600;
    public Text timeText;
    string timerFix;






    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!(pilha1.activeInHierarchy))
        {
            if (controlePilha1 == false)
            {
                Carrega();
                controlePilha1 = true;
            }
        }

        if (!(pilha2.activeInHierarchy))
        {
            if (controlePilha2 == false)
            {
                Carrega();
                controlePilha2 = true;
            }
        }

        if (!(pilha3.activeInHierarchy))
        {
            if (controlePilha3 == false)
            {
                Carrega();
                controlePilha3 = true;
            }
        }

        if (!(pilha4.activeInHierarchy))
        {
            if (controlePilha4 == false)
            {
                Carrega();
                controlePilha4 = true;
            }
        }

        if (!(pilha5.activeInHierarchy))
        {
            if (controlePilha5 == false)
            {
                Carrega();
                controlePilha5 = true;
            }
        }
        if (!(pilha6.activeInHierarchy))
        {
            if (controlePilha6 == false)
            {
                Carrega();
                controlePilha6 = true;
            }
        }
        if (!(pilha7.activeInHierarchy))
        {
            if (controlePilha7 == false)
            {
                Carrega();
                controlePilha7 = true;
            }
        }
        timer -= Time.deltaTime ;
        //timerFix = string.Format("{0:0.00}", timer);

        //t = timer.toFixed();
        //timeText.text = timerFix;
        if(timer >= 600)
        {
            Bateria5HUD();
        }
        if (timer < 500)
        {
            Bateria4HUD();
        }
        if (timer < 400)
        {
            Bateria3HUD();
        }
        if (timer < 300)
        {
            Bateria2HUD();
        }
        if (timer < 200)
        {
            Bateria1HUD();
        }
        if (timer < 100)
        {
            Bateria0HUD();
        }
        if (timer < 0)
        {
            SceneManager.LoadScene("Derrota");
        }
    }

void Carrega()
{

    timer += 60;
}

    void Bateria0HUD()
    {
        Bateria0.SetActive(true);

        Bateria5.SetActive(false);
        Bateria4.SetActive(false);
        Bateria3.SetActive(false);
        Bateria2.SetActive(false);
        Bateria1.SetActive(false);

    }

    void Bateria1HUD()
    {
        Bateria1.SetActive(true);

        Bateria5.SetActive(false);
        Bateria4.SetActive(false);
        Bateria3.SetActive(false);
        Bateria2.SetActive(false);
        Bateria0.SetActive(false);

    }


    void Bateria2HUD()
    {
        Bateria2.SetActive(true);

        Bateria5.SetActive(false);
        Bateria4.SetActive(false);
        Bateria3.SetActive(false);
        Bateria0.SetActive(false);
        Bateria1.SetActive(false);

    }


    void Bateria3HUD()
    {
        Bateria3.SetActive(true);

        Bateria5.SetActive(false);
        Bateria4.SetActive(false);
        Bateria0.SetActive(false);
        Bateria2.SetActive(false);
        Bateria1.SetActive(false);

    }


    void Bateria4HUD()
    {
        Bateria4.SetActive(true);

        Bateria5.SetActive(false);
        Bateria0.SetActive(false);
        Bateria3.SetActive(false);
        Bateria2.SetActive(false);
        Bateria1.SetActive(false);

    }


    void Bateria5HUD()
    {
        Bateria5.SetActive(true);

        Bateria0.SetActive(false);
        Bateria4.SetActive(false);
        Bateria3.SetActive(false);
        Bateria2.SetActive(false);
        Bateria1.SetActive(false);

    }

}
