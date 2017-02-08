#pragma strict


var carBody:Rigidbody;
var forwardRate : float;
var turnRate : float;
//var testing : PlayerManager;

function Start(){
		carBody.centerOfMass = Vector3 (0, -3, 0);
}

function Update () {
	//top one works a little.
	/*
	//car's forward speed in action
	var forwardMoveAmount = Input.GetAxis("Vertical") * forwardRate;	

	//force of the car's turn
	var turnForce = Input.GetAxis("Horizontal") * turnRate;

	//rotate tank in actions
	transform.Rotate(0, turnForce, 0);

	transform.position += transform.right * forwardMoveAmount * Time.deltaTime;
	carBody.AddForce(0, -2, 0);//this == balance. works like a charm.
	*/

	/*
	Vector3 moveDir = Vector3.zero;
	moveDir.x = Input.GetAxis("Horizontal"); // get result of AD keys in X
   	moveDir.z = Input.GetAxis("Vertical"); // get result of WS keys in Z
  	// move this object at frame rate independent speed:
   	transform.position += moveDir * speed * Time.deltaTime;
   	*/

}