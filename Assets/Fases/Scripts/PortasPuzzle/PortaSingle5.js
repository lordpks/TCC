#pragma strict

var porta: UnityEngine.GameObject;
var chave1: UnityEngine.GameObject;
var luzVermelha: UnityEngine.GameObject;
var luzVerde: UnityEngine.GameObject;

var AnimadorPorta: Animator;
var portaTrancada;
var portaFechada;

var acao;


function Start() {
	portaTrancada = true;
	portaFechada = true;
	acao = false;
	AnimadorPorta.SetBool("Abre", false);
	AnimadorPorta.SetBool("Fecha", true);
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
				AnimadorPorta.SetBool("Abre", true);
				AnimadorPorta.SetBool("Fecha", false);
				portaFechada = false;
				acao = false;

				luzVermelha.SetActive(false);
				luzVerde.SetActive(true);

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
}


/*function OnTriggerExit(other: Collider) {
	AnimadorPorta51_52.SetBool("Teste", false);
}*/