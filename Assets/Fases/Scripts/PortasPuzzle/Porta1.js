#pragma strict

var porta: UnityEngine.GameObject;
var chave1: UnityEngine.GameObject;
var luzVermelha: UnityEngine.GameObject;
var luzVerde: UnityEngine.GameObject;

var AnimadorPortaE: Animator;
var AnimadorPortaD: Animator;
var portaTrancada;
var portaFechada;

var acao;


function Start() {
	portaTrancada = true;
	portaFechada = true;
	acao = false;
	AnimadorPortaE.SetBool("Abre", false);
	AnimadorPortaE.SetBool("Fecha", true);
	AnimadorPortaD.SetBool("Abre", false);
	AnimadorPortaD.SetBool("Fecha", true);
}

function Update() {
	acao = false;
	if (!(chave1.activeInHierarchy)) {
		portaTrancada = false;
	}
	if (!portaTrancada) {
		if (Input.GetKeyUp("space")) acao = true;
	}
}


function OnTriggerStay(other: Collider) {
	//AnimadorPorta51_52.SetBool("Teste", true);
	//AnimadorPorta51_52.SetBool("Teste2", PortaFechada);

	if (!portaTrancada) {
		if (portaFechada) {
			if (acao) {
				AnimadorPortaE.SetBool("Abre", true);
				AnimadorPortaE.SetBool("Fecha", false);
				AnimadorPortaD.SetBool("Abre", true);
				AnimadorPortaD.SetBool("Fecha", false);
				portaFechada = false;
				acao = false;

				luzVermelha.SetActive(false);
				luzVerde.SetActive(true);

			}
		}
		else {
			if (acao) {
				AnimadorPortaE.SetBool("Abre", false);
				AnimadorPortaE.SetBool("Fecha", true);
				AnimadorPortaD.SetBool("Abre", false);
				AnimadorPortaD.SetBool("Fecha", true);
				portaFechada = true;
				acao = false;
			}
		}
	}
}


/*function OnTriggerExit(other: Collider) {
	AnimadorPorta51_52.SetBool("Teste", false);
}*/