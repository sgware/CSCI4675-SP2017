using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//the logic.  the ball moves.  The camera(eyes) are connected to the ball.   
//here is my idea. I need 2 objects. one will be the point of reference for moving and
//the other ball will deal with collision detections.
public class followObject : MonoBehaviour {

	public GameObject myRig;//whole object
	public GameObject myCamera;//eye
	public GameObject myMoverSphere;//small sphere
	public GameObject collisionSphere;//big sphere

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myRig.transform.position = myMoverSphere.transform.position;//lets me move
		//myCamera.transform.position = myRig.transform.position;
		//myCamera.transform.position = collisionSphere.transform.position;
		collisionSphere.transform.position = myCamera.transform.position;//follows my head

		//myMoverSphere.transform.position = myCamera.transform.position;//attaches a ball to the eyes camera.
		//myCamera.transform.position = new Vector3(myMoverSphere.transform.position.x, myMoverSphere.transform.position.y - 0.5f, myMoverSphere.transform.position.z  + 0.25f);

	}
}
