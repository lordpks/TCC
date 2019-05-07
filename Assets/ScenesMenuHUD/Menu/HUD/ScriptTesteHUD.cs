using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTesteHUD : MonoBehaviour
{
    public GameObject Bateria5;
    public GameObject Bateria4;
    public GameObject Bateria3;
    public GameObject Bateria2;
    public GameObject Bateria1;
    public GameObject Bateria0;
    public GameObject BarulhoAlto;
    public GameObject BarulhoBaixo;
    public GameObject CartaoAAtivo;
    public GameObject CartaoADesativado;
    public GameObject CartaoBAtivo;
    public GameObject CartaoBDesativado;
    public GameObject CartaoCAtivo;
    public GameObject CartaoCDesativado;
    public float timer = 10.0f; //Cronometro 10 segundos
    public bool timerAtivo = false;

    void Update()
    {

        if (Input.GetKey(KeyCode.T))
        {
            timerAtivo = true;

        }

        if (timerAtivo)
        {
            Timer();

        }


        if (Input.GetKey("0"))
        {
            Bateria0HUD();

        }


        if (Input.GetKey("1"))
        {
            Bateria1HUD();

        }


        if (Input.GetKey("2"))
        {
            Bateria2HUD();

        }


        if (Input.GetKey("3"))
        {
            Bateria3HUD();

        }


        if (Input.GetKey("4"))
        {
            Bateria4HUD();

        }


        if (Input.GetKey("5"))
        {
            Bateria5HUD();

        }


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            BarulhoAlto.SetActive(true);

            BarulhoBaixo.SetActive(false);

        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            BarulhoBaixo.SetActive(true);

            BarulhoAlto.SetActive(false);

        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            if (CartaoAAtivo.active)
            {
                CartaoADesativado.SetActive(true);

                CartaoAAtivo.SetActive(false);
            }
            else
            {
                CartaoAAtivo.SetActive(true);

                CartaoADesativado.SetActive(false);

            }
            
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            if (CartaoBAtivo.active)
            {
                CartaoBDesativado.SetActive(true);

                CartaoBAtivo.SetActive(false);
            }
            else
            {
                CartaoBAtivo.SetActive(true);

                CartaoBDesativado.SetActive(false);

            }

        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            if (CartaoCAtivo.active)
            {
                CartaoCDesativado.SetActive(true);

                CartaoCAtivo.SetActive(false);
            }
            else
            {
                CartaoCAtivo.SetActive(true);

                CartaoCDesativado.SetActive(false);

            }

        }

    }

    void Timer()
    {
        
        timer -= Time.deltaTime;


        if (timer > (8.0f)) //Bateria5
        {
            Bateria5HUD();

        }
        else
        {
            if (timer > (6.0f)) //Bateria4
            {
                Bateria4HUD();

            }
            else
            {
                if (timer > (4.0f)) //Bateria3
                {
                    Bateria3HUD();

                }
                else
                {
                    if (timer > (2.0f)) //Bateria2
                    {
                        Bateria2HUD();
                    }
                    else
                    {
                        if (timer > (0.1f)) //Bateria1
                        {
                            Bateria1HUD();

                        }
                        else
                        {
                            if (timer <= (0.0f)) //Bateria0
                            {
                                Bateria0HUD();

                            }
                        }

                    }
                }

            }

        }
      

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
