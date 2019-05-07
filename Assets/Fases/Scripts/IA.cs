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
    Animator anim;
    public MovePlayer other;
    bool notdead;


    void Start()
    {
        notdead = true;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        

        if (Vector3.Distance(transform.position, Player.position) <= MinDist)
        {
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
            anim.SetBool("walk", false);
        }
    }

    public void Kill()
    {
        other.Die();
        notdead = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collide");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("dentro");
            anim.SetBool("kill", true);
            anim.SetBool("walk", false);
        }
    }
}
