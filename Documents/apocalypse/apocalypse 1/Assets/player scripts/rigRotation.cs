using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
	okay this guy will get the rotation factor of the camera and apply it to the rig
	so that the rig is always looking forward.
*/


public class rigRotation : MonoBehaviour {
	public GameObject headCamera;
	public GameObject myRig;

	// Use this for initialization
	void Start () {
		//headCamera = GameObject.FindWithTag("headCamera");
	}
	
	// Update is called once per frame
	void Update () {
		/////////Vector3 newRotation = new Vector3(myRig.transform.eulerAngles.x,   (headCamera.transform.eulerAngles.y - myRig.transform.eulerAngles.y) * 0.75f, myRig.transform.eulerAngles.z);
		Vector3 newRotation = new Vector3(myRig.transform.eulerAngles.x,  headCamera.transform.eulerAngles.y, myRig.transform.eulerAngles.z);

		//myRig.transform.rotation = headCamera.transform.rotation - (myRig.transform.rotation / headCamera.transform.rotation);
		myRig.transform.eulerAngles = newRotation;


			//progess
		//headCamera.transform.eulerAngles.y - myRig.transform.eulerAngles.y
		//o.transform.position = Vector3.Lerp(o.transform.position, Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, 4f)), Time.deltaTime * smooth);
	}
}
