using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaL : MonoBehaviour {


    public AudioSource source;
    //--------------> source = GetComponent(AudioSource); <-----------------------
    public GameObject chave;
    public GameObject cube;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter(Collision hit)
    {
        if (!(chave.activeInHierarchy))
        {

            source.Play();
            cube.SetActive(false);
            GetComponent<BoxCollider>().enabled = false;
            gameObject.SetActive(false);

        }
    }
}
