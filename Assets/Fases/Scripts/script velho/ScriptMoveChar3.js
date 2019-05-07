#pragma strict

var Animador: Animator;
var Movimento: Transform;
var Passos: AudioSource; 
Movimento.rotation.z = 0;

var velocidade: float;



function Start() {
	Movimento.transform.position.x = 300;
	Movimento.transform.position.y = 6;
	Movimento.transform.position.z = -300;
	Animador.SetBool("setaCima", false);
	Movimento.rotation.z = 0;
	velocidade = 1.2;
	Passos = GetComponent(AudioSource);
}

function Update() {
	Animador.SetBool("setaCima", false);


	if (Input.GetKey("left")) {
		GirarEsquerda();
		//MoveEsquerda();
		Animador.SetBool("setaCima", true);
	}


	if (Input.GetKey("right")) {
		GirarDireita();
		//MoveDireita();
		Animador.SetBool("setaCima", true);
	}


	if (Input.GetKey("down")) {
		GirarBaixo();
		//MoveTras();
		Animador.SetBool("setaCima", true);
	}

	if (Input.GetKey("up")) {
		GirarCima();
		//MoveFrente();
		Animador.SetBool("setaCima", true);
	}
	
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

	//**************** CORRE
	if (Input.GetKeyDown("left shift")) {
		velocidade = velocidade * 1.4;
		Animador.SetBool("Corre", true);
		Passos.enabled = true; 
		
	}
	if (Input.GetKeyUp("left shift")) {
		velocidade = velocidade / 1.4;
		Animador.SetBool("Corre", false);
		Passos.enabled = false;
	}

	if (Input.GetKeyUp("escape")) {
		//Application.Quit();
		SceneManagement.SceneManager.LoadScene("MainMenu");
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

function GirarEsquerda() {
	//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z + 5;
	Movimento.rotation.eulerAngles.y = -90;
	Movimento.transform.position.x = Movimento.transform.position.x - velocidade;
}

function GirarDireita() {
	//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
	Movimento.rotation.eulerAngles.y = 90;
	Movimento.transform.position.x = Movimento.transform.position.x + velocidade;
}

function GirarBaixo() {
	//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
	Movimento.rotation.eulerAngles.y = -180;
	Movimento.transform.position.z = Movimento.transform.position.z - velocidade;
}

function GirarCima() {
	//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
	Movimento.rotation.eulerAngles.y = 0;
	Movimento.transform.position.z = Movimento.transform.position.z + velocidade;
}

function GirarCimaEsq() {
	//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
	Movimento.rotation.eulerAngles.y = -45;
}
function GirarCimaDir() {
	//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
	Movimento.rotation.eulerAngles.y = 45;
}
function GirarBaixoEsq() {
	//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
	Movimento.rotation.eulerAngles.y = -135;
}
function GirarBaixoDir() {
	//Movimento.rotation.eulerAngles.z = Movimento.rotation.eulerAngles.z - 5;
	Movimento.rotation.eulerAngles.y = 135;
}


