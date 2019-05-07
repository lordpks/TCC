#pragma strict

import UnityEngine.UI;

var pilha1: UnityEngine.GameObject;
var controlePilha1 = 0;

var pilha2: UnityEngine.GameObject;
var controlePilha2 = 0;

var pilha3: UnityEngine.GameObject;
var controlePilha3 = 0;

var pilha4: UnityEngine.GameObject;
var controlePilha4 = 0;

var pilha5: UnityEngine.GameObject;
var controlePilha5 = 0;

var timer = 600.0;
var timeText: Text;
var cronometroTela: float;
var t;
var comeca;

function Start () {

	comeca = false;

}

function Update() {

	comeca = true;
	/*if (Input.GetKeyUp("t")) {
		comeca = true;
	}*/
	if (comeca) {

		if (!(pilha1.activeInHierarchy)) {
			if (controlePilha1 <= 0) {
				Carrega();
				controlePilha1 += 1;
			}
		}

		if (!(pilha2.activeInHierarchy)) {
			if (controlePilha2 <= 0) {
				Carrega();
				controlePilha2 += 1;
			}
		}

		if (!(pilha3.activeInHierarchy)) {
			if (controlePilha3 <= 0) {
				Carrega();
				controlePilha3 += 1;
			}
		}

		if (!(pilha4.activeInHierarchy)) {
			if (controlePilha4 <= 0) {
				Carrega();
				controlePilha4 += 1;
			}
		}

		if (!(pilha5.activeInHierarchy)) {
			if (controlePilha5 <= 0) {
				Carrega();
				controlePilha5 += 1;
			}
		}

		timer -= Time.deltaTime;
		//t = timer.toFixed();
		//timeText.text = timer + " segundos";

		cronometroTela = timer / 60;

		if (cronometroTela < 1) {
			
			t = Mathf.Floor(timer);
			timeText.text = t + " segundos";
		}
		else {
			
			t = Mathf.Floor(cronometroTela);

			if ((cronometroTela < 2) && (cronometroTela > 1)) {
				timeText.text = t + " minuto";
			}
			else {
				timeText.text = t + " minutos";
			}
		}



		if (timer < 0) {
			SceneManagement.SceneManager.LoadScene("GameOver");
		}
	}
	

}


function Carrega(){

	timer += 60;
}
