#pragma strict

var source: AudioSource;
source = GetComponent(AudioSource);
var Tamanho: Transform;
//var textFecha: UnityEngine.GameObject;
//var textAbre: UnityEngine.GameObject;
var acao = false;

function Start () {
	
}

function Update () {

	
}


function OnTriggerStay(other: Collider)
{
	if (Input.GetKeyUp("space")){
		source.Play();
		GetComponent(BoxCollider).enabled = false;
		Tamanho.transform.localScale.x = 0;
		Tamanho.transform.localScale.y = 0;
		Tamanho.transform.localScale.z = 0;
		//textFecha.SetActive(false);
		//textAbre.SetActive(true);
		yield WaitForSeconds(1);
		gameObject.SetActive(false);
	}

}