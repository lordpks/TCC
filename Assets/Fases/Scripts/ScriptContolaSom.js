#pragma strict

var Som: AudioSource; 

function Start () {
	Som.enabled = true;
}

function Update() {

	if (Input.GetKeyDown("s")) {
		if (Som.enabled) {
			Som.enabled = false;
		}
		else {
			Som.enabled = true;
		}

	}
	
}
