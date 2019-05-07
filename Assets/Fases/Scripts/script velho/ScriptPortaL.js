#pragma strict

var source: AudioSource;
source = GetComponent(AudioSource);
var chave: UnityEngine.GameObject;
var cube: UnityEngine.GameObject;

function Start () {

}

function Update () {

	/*
	if(Input.GetKey("space")){
		
		GetComponent.<Animation>().Play("portaAbre2");
	}*/


	
}

function OnCollisionEnter(hit: Collision)
{
        if (!(chave.activeInHierarchy)){

        	source.Play();
        	cube.SetActive(false);
			GetComponent(BoxCollider).enabled = false;
			yield WaitForSeconds (1);
			gameObject.SetActive(false);

		}
}

