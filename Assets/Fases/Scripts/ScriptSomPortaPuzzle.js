#pragma strict

var chave: UnityEngine.GameObject;
var EfeitoAbre: AudioSource;
var EfeitoFecha: AudioSource;
var EfeitoTrancada: AudioSource;
var fechada = true;
var trancada = true;


function Start() {



}

function Update() {
	if (!(chave.activeInHierarchy)) {
		trancada = false;
	}


}

function OnTriggerStay(hit: Collider) {


	if (Input.GetKeyUp("space")) {
		if (!trancada) {
			EfeitoTrancada.Play();
		}
		else {

			if (hit.gameObject.name == "Personagem") {
				if (fechada) {
					EfeitoAbre.Play();
					fechada = false;
				}
				else {
					EfeitoFecha.Play();
					fechada = true;
				}
			}
		}
	}


}