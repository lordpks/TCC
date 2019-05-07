#pragma strict

var source: AudioSource;
//source = GetComponent(AudioSource);
var Tamanho: Transform;

var chave1: UnityEngine.GameObject;
var chave2: UnityEngine.GameObject;
var luzVermelha: UnityEngine.GameObject;
var luzVerde: UnityEngine.GameObject;
var luzVermelha2: UnityEngine.GameObject;
var luzVerde2: UnityEngine.GameObject;

var portaTrancada;
var portaFechada;

var acao;


function Start() {
	portaTrancada = true;
	portaFechada = true;
	acao = false;
}

function Update() {
	acao = false;
	if ((chave1.activeInHierarchy) || (chave2.activeInHierarchy)) {
		portaTrancada = true;
	}
	else {
		portaTrancada = false;
	}
	
}


function OnTriggerStay(other: Collider) {
	

	if (!portaTrancada) {
	
			
			if (Input.GetKeyUp("space")) {
				//source.Play();
				GetComponent(BoxCollider).enabled = false;
				Tamanho.transform.localScale.x = 0;
				Tamanho.transform.localScale.y = 0;
				Tamanho.transform.localScale.z = 0;

				luzVermelha.SetActive(false);
				luzVerde.SetActive(true);

				luzVermelha2.SetActive(false);
				luzVerde2.SetActive(true);

				//textFecha.SetActive(false);
				//textAbre.SetActive(true);
				yield WaitForSeconds(1);
				gameObject.SetActive(false);
			}

			
		
		
	}
}
