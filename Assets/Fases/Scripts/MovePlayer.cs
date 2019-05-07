using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour {

    public float speed = 50f;            
    public float sped = 10f;
    public float speedback = 40f;
    public float turnSpeed = 150f;

    public Transform move;
    Vector3 movement;                   
    Animator anim;                      
    Rigidbody playerRigidbody;           

    void Awake()
    {
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        float r = Input.GetAxisRaw("Run");

        Move(v);
        Rotate(h);
        Animate(h, v, r);
    }

    void Move(float v)
    {
        if(v == 1)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (v == -1)
        {
            transform.Translate(Vector3.back * speedback * Time.deltaTime);
        }
    }

    void Rotate(float h)
    {
        if (h == -1) {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            //transform.Translate( Vector3.left * sped * Time.deltaTime);
        }

        if (h == 1)
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            //transform.Translate(Vector3.right * sped * Time.deltaTime);
        }
            
    }

    public void Die()
    {
        anim.SetBool("Die", true);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Derrota");
    }

    public void Animate(float h, float v, float r)
    {
        bool running = r != 0f && v == 1f;
        bool walking = v == 1f;
        bool run_turn = r != 0f && v == -1f;

        anim.SetBool("Run", running);
        anim.SetBool("Walk", walking);
        anim.SetBool("Run Turn", run_turn);

        //Debug.Log(run_turn + "Run turrrn");

        if (running)
        {
            speed = 50 * 2f;
        }
        else
        {
            speed = 50;
        }
        
    }

}