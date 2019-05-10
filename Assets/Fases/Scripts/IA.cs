using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IA : MonoBehaviour
{
    public Transform Player;
    public int MoveSpeed;
    public int MinDist;
    public int MaxDist;
    Animator anim;
    public MovePlayer other;
    bool notdead;
    bool calmBat;
    bool fastbat = false;
    bool inrangemin = false;
    bool inrangemax = false;
    bool isplaying = false;

    public Batimentos batimentos;


    void Start()
    {
        notdead = true;
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        
        if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {
            if(Vector3.Distance(transform.position, Player.position) <= MinDist)
            {
                if (!inrangemin)
                {
                    fastbat = true;
                    inrangemin = true;
                    
                }
            }else
            {
                if (inrangemin)
                {
                    inrangemax = false;
                }
                inrangemin = false;
            }

            if (fastbat)
            {
                batimentos.BatimentoRapido();
                fastbat = false;
                isplaying = true;
            }

            if (calmBat)
            {
                batimentos.BatimentoCalmo();
                calmBat = false;
                isplaying = true;
            }

            if (!inrangemax)
            {
                calmBat = true;
                inrangemax = true;

            }
           
            if (notdead)
            {
                
                //Debug.Log("aquiiii" + Vector3.Distance(transform.position, Player.position));
                transform.LookAt(Player);

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;
                anim.SetBool("walk", true);
            }
            


        }
        else
        {
            if (isplaying)
            {
                batimentos.Stop();
                isplaying = false;
                inrangemin = false;
                inrangemax = false;
                calmBat = false;
                fastbat = false;
            }
            if (anim.GetBool("walk"))
            {
                anim.SetBool("walk", false);
            }
                
        }
    }

    public void Kill()
    {
        other.Die();
        notdead = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("dentro");
            anim.SetBool("kill", true);
            anim.SetBool("walk", false);
        }
    }
}
