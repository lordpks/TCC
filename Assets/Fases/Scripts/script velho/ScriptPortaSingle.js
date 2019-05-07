#pragma strict

var porta: UnityEngine.GameObject;

var AnimadorPorta: Animator;
var portaFechada;

var acao;


function Start() {

	portaFechada = true;
	acao = false;
	AnimadorPorta.SetBool("Abre", false);
	AnimadorPorta.SetBool("Fecha", true);
}

function Update() {
	acao = false;
	
	if (Input.GetKeyUp("space")) acao = true;
}


function OnTriggerStay(other: Collider) {
	
		if (portaFechada) {
			if (acao) {
				AnimadorPorta.SetBool("Abre", true);
				AnimadorPorta.SetBool("Fecha", false);
				portaFechada = false;
				acao = false;

			}
		}
		else {
			if (acao) {
				AnimadorPorta.SetBool("Abre", false);
				AnimadorPorta.SetBool("Fecha", true);
				portaFechada = true;
				acao = false;
			}
		}
}


