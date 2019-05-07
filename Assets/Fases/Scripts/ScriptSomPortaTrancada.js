#pragma strict

var EfeitoSonoro: AudioSource; 

function Start () {
	
}

function Update() {

	
	
}

function OnTriggerStay(hit: Collider) {


	if (Input.GetKeyUp("space")) {

		if (hit.gameObject.name == "Personagem") {
			EfeitoSonoro.Play();
		}
	}

}