#pragma strict

var porta: UnityEngine.GameObject;

var AnimadorPortaE: Animator;
var AnimadorPortaD: Animator;
var portaFechada;
var acao;


function Start() {
	portaFechada = true;
	acao = false;
	AnimadorPortaE.SetBool("Abre", false);
	AnimadorPortaE.SetBool("Fecha", true);
	AnimadorPortaD.SetBool("Abre", false);
	AnimadorPortaD.SetBool("Fecha", true);
}

function Update() {
	acao = false;
	if (Input.GetKeyUp("space")) acao = true;
}


function OnTriggerStay(other: Collider) {
	//AnimadorPorta51_52.SetBool("Teste", true);
	//AnimadorPorta51_52.SetBool("Teste2", PortaFechada);

	if (portaFechada) {
		if (acao) {
			AnimadorPortaE.SetBool("Abre", true);
			AnimadorPortaE.SetBool("Fecha", false);
			AnimadorPortaD.SetBool("Abre", true);
			AnimadorPortaD.SetBool("Fecha", false);
			portaFechada = false;
			acao = false;

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


/*function OnTriggerExit(other: Collider) {
	AnimadorPorta51_52.SetBool("Teste", false);
}*/