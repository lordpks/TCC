var Camera: Transform;
var Player: Transform;
var altura = 170;


function Start() {

	Camera.transform.position.x = Player.transform.position.x;
	Camera.transform.position.y = Player.transform.position.y + altura;
	Camera.transform.position.z = Player.transform.position.z;


	//Camera.transform.position.y = -11;

}

function Update() {

	Camera.transform.position.x = Player.transform.position.x;
	//Camera.transform.position.y = Player.transform.position.y;
	Camera.transform.position.z = Player.transform.position.z;

	


}
