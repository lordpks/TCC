#pragma strict

var Animador: Animator;
var Movimento: Transform;
Movimento.rotation.z = 0;

var velocidade: float;



function Start () {
	Movimento.transform.position.x = 420;
	Movimento.transform.position.y = 1;
	Movimento.transform.position.z = 291;
	Animador.SetBool("setaCima", false);
	Movimento.rotation.z = 0;
	velocidade = 1;
}

function Update () {
	Animador.SetBool("setaCima", false);
	

	if(Input.GetKey("left")){
		//GirarEsquerda();
		MoveEsquerda();
		Animador.SetBool("setaCima", true);
	}
	
		
	if(Input.GetKey("right")){
		//GirarDireita();
		MoveDireita();
		Animador.SetBool("setaCima", true);
	}
	

	if(Input.GetKey("down")){
		//GirarBaixo();
		MoveTras();
		Animador.SetBool("setaCima", true);
	}

	if(Input.GetKey("up")){
		//GirarCima();
		MoveFrente();
		Animador.SetBool("setaCima", true);
	}
	/*
	if(Input.GetKey("up") && Input.GetKey("left")){
		GirarCimaEsq();
		Animador.SetBool("setaCima", true);
	}

	if(Input.GetKey("up") && Input.GetKey("right")){
		GirarCimaDir();
		Animador.SetBool("setaCima", true);
	}

	if(Input.GetKey("down") && Input.GetKey("left")){
		GirarBaixoEsq();
		Animador.SetBool("setaCima", true);
	}

	if(Input.GetKey("down") && Input.GetKey("right")){
		GirarBaixoDir();
		Animador.SetBool("setaCima", true);
	}
	*/

	//**************** CORRE
	if(Input.GetKeyDown("left shift")){
		velocidade = velocidade * 2;
		if (Input.GetKey("up") || Input.GetKey("down")) Animador.SetBool("Corre", true);
	}
	if(Input.GetKeyUp("left shift")){
		velocidade = velocidade * 0.5;
		Animador.SetBool("Corre", false);
	}



	/************** CORRE SUPER ---- apenas para teste

	if(Input.GetKeyDown("left ctrl")){
		velocidade = 0.9;
	}


	if(Input.GetKeyUp("left ctrl")){
		velocidade = 0.25;
	}*/


	
}

function MoveFrente() {
	Movimento.transform.position.z = Movimento.transform.position.z + velocidade;
}

function MoveTras() {
	Movimento.transform.position.z = Movimento.transform.position.z - velocidade;
}

function MoveEsquerda() {
	Movimento.transform.position.x = Movimento.transform.position.x - velocidade;
}

function MoveDireita() {
	Movimento.transform.position.x = Movimento.transform.position.x + velocidade;
}

function GirarEsquerda(){
		//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z + 5;
		Movimento.rotation.eulerAngles.z = 90;
		Movimento.transform.position.x = Movimento.transform.position.x - velocidade ;
}

function GirarDireita(){
		//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
		Movimento.rotation.eulerAngles.z = -90;
		Movimento.transform.position.x = Movimento.transform.position.x + velocidade ;
}

function GirarBaixo(){
		//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
		Movimento.rotation.eulerAngles.z = -180;
		Movimento.transform.position.y = Movimento.transform.position.y - velocidade ;
}

function GirarCima(){
		//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
		Movimento.rotation.eulerAngles.z = 0;
		Movimento.transform.position.y = Movimento.transform.position.y + velocidade ;
}

function GirarCimaEsq(){
		//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
		Movimento.rotation.eulerAngles.z = 45;
}
function GirarCimaDir(){
		//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
		Movimento.rotation.eulerAngles.z = -45;
}
function GirarBaixoEsq(){
		//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
		Movimento.rotation.eulerAngles.z = 135;
}
function GirarBaixoDir(){
		//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
		Movimento.rotation.eulerAngles.z = -135;
}


