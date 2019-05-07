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




    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        

        if (Vector3.Distance(transform.position, Player.position) <= MinDist)
        {
            //Debug.Log("aquiiii" + Vector3.Distance(transform.position, Player.position));
            transform.LookAt(Player);

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            anim.SetBool("corre", true);


        }
        else
        {
            anim.SetBool("corre", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collide");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("dentro");
            SceneManager.LoadScene("Derrota");
        }
    }
}
