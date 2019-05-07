#pragma strict

//var personagem: UnityEngine.GameObject;
var efeitoSom: AudioSource;

var enemy: Transform;
var player: Transform; 
var enemyX: float;
var enemyY: float;

var perto: boolean;
var proximidade: float;

var velocidade: float;

var AnimadorMonstro: Animator;


function Start () {
	/*
	enemyX = 0;

	while(enemyX > -22 && enemyX < 25){
		enemyX = Random.Range(-40.0f,45.0f );
	}

	enemyY = Random.Range(25.0f, 80.0f);
	enemy.transform.position.x = enemyX;
	enemy.transform.position.y = enemyY;
	enemy.transform.position.z = 0;
	*/


    //enemy.transform.position.x = 740;
	//enemy.transform.position.y = 120;
	//enemy.transform.position.z = 0;

	perto = false;
	proximidade = 210;
	velocidade = 1.34;

}

function Update () {
	//enemy.transform.position.z = 0;

	// ******** Ativa/ Desativa movimentação

	if ((enemy.transform.position.x - player.transform.position.x < proximidade)&&(enemy.transform.position.z - player.transform.position.z < proximidade)&&(enemy.transform.position.x - player.transform.position.x > -proximidade)&&(enemy.transform.position.z - player.transform.position.z > -proximidade)){

		perto = true;
		AnimadorMonstro.SetBool("corre", true);
	}
	else{
		perto = false;
		AnimadorMonstro.SetBool("corre", false);
	}

	if (Input.GetKeyDown("left shift")) {
		proximidade = proximidade * 1.5;
	}
	if (Input.GetKeyUp("left shift")) {
		proximidade = proximidade / 1.5;
	}




	// 	******** MOVIMENTAÇÃO
	if (perto == true) {

		efeitoSom.enabled = true;

		if (player.transform.position.x > enemy.transform.position.x) {

			enemy.transform.position.x = enemy.transform.position.x + velocidade;


		}
		else {
			if (player.transform.position.x < enemy.transform.position.x) {

				enemy.transform.position.x = enemy.transform.position.x - velocidade;
			}

		}

		if (player.transform.position.z > enemy.transform.position.z) {

			enemy.transform.position.z = enemy.transform.position.z + velocidade;
			if (player.transform.position.z > enemy.transform.position.z + 1) enemy.rotation.eulerAngles.y = 0;  // IF Para não dar bug de rotação "baixo / cima / baixo / cima"

		}
		else {
			if (player.transform.position.z < enemy.transform.position.z) {

				enemy.transform.position.z = enemy.transform.position.z - velocidade;
				enemy.rotation.eulerAngles.y = -180;
			}


		}

		Lado();
		//TocaTrilha();

	}
	else {
		efeitoSom.enabled = false;
	}
}


function Lado(){

	if ((player.transform.position.z - enemy.transform.position.z > -1 && player.transform.position.z - enemy.transform.position.z < 1) && player.transform.position.x > enemy.transform.position.x+1){

			enemy.rotation.eulerAngles.y = 90;

		}
		else{
				if ((player.transform.position.z - enemy.transform.position.z > -1 && player.transform.position.z - enemy.transform.position.z < 1) && player.transform.position.x < enemy.transform.position.x){


			enemy.rotation.eulerAngles.y = -90;

			}

		}

}

     function OnCollisionEnter(hit: Collision)
     {
        if(hit.gameObject.name == "Personagem")
		{
           //Application.LoadLevel("GameOver");
           SceneManagement.SceneManager.LoadScene("GameOver");
      	}
     }

	 /*function OnTrigger(hit: Collision)
     {
        if(hit.gameObject.name == "Personagem")
		{
           //Application.LoadLevel("GameOver");
           SceneManagement.SceneManager.LoadScene("GameOver");
      	}
     }*/

/*
function TocaTrilha() {

		source = GetComponent(AudioSource);
		source.Play();
		trilhaTocando = true;

}*/


