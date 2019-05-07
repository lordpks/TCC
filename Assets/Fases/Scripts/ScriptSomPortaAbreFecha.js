#pragma strict

var EfeitoAbre: AudioSource;
var EfeitoFecha: AudioSource;
var fechada = true;


function Start() {

	

}

function Update() {



}

function OnTriggerStay(hit: Collider) {


	if (Input.GetKeyUp("space")) {

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