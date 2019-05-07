#pragma strict

var mapa: UnityEngine.GameObject;


function Start () {
	
}

function Update () {
	
}


function OnTriggerStay (other : Collider) {
        if(Input.GetKeyUp("space")){
        	if (mapa.activeSelf){
				mapa.SetActive(false);
				GetComponent(BoxCollider).enabled = false;
				yield WaitForSeconds(0.5);
				GetComponent(BoxCollider).enabled = true;
			}
			else{
				mapa.SetActive(true);
				GetComponent(BoxCollider).enabled = false;
				yield WaitForSeconds(0.5);
				GetComponent(BoxCollider).enabled = true;
			}
		}
}

function OnTriggerExit (other : Collider) {
       mapa.SetActive(false);
}

