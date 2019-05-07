using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaSom : MonoBehaviour {

    public AudioSource som;
    string a;
    string b;

	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        var animacao = GetComponent<Animator>();
       // animacao.
        //animacao.
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
    }

    public void TocarSom()
    {
        //som.Play();
    }
}
