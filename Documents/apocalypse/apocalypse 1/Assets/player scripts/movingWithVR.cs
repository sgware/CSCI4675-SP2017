using System.Collections;
using UnityEngine;
using Valve.VR;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class movingWithVR : MonoBehaviour {

SteamVR_TrackedObject trackedObj;
SteamVR_Controller.Device device;
public float moveSpeed = 2.5f;
public	GameObject obj;
	//public Rigidbody rb;

	//public Camera mainCamera;
	//public GameObject player;
	//public GameObject followObj;
	//public GameObject trackerBall;
	//public float smooth = 4.0f;

void Awake(){
	trackedObj = GetComponent<SteamVR_TrackedObject>();
}


// Use this for initialization
void Start()
{
		//rb = obj.GetComponent<Rigidbody> ();
}

void FixedUpdate(){
	device = SteamVR_Controller.Input((int)trackedObj.index);
}

// Update is called once per frame
//I turned off rotation because your head moves you now.
void Update()
{
		if (device.GetHairTriggerDown()) {
			//obj.transform.Translate(Vector3.up * 7.0f * Time.deltaTime);
			//rb.AddForce(transform.up * 6.0f);
		
	}
	if (device.GetPress(SteamVR_Controller.ButtonMask.Touchpad)){
		Vector2 touchpad = (device.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0));
		//print("Pressing Touchpad");

		if (touchpad.y > 0.7f){
			obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
			//player.transform.position = trackerBall.transform.position;
			//player.transform.position = Vector3.Lerp(player.transform.position, mainCamera.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2)), Time.deltaTime * smooth);
			//player.transform.position = Vector3.Lerp(player.transform.position, followObj.transform.position, Time.deltaTime * smooth);
			//print("Moving Up");
		}

		else if (touchpad.y < -0.7f){
			obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
			//print("Moving Down");
		}

		if (touchpad.x > 0.7f){
			obj.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
			//obj.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
			//print("Moving Right");
		}

		else if (touchpad.x < -0.7f){
			obj.transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);
			//obj.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
			//print("Moving left");
		}

	}
}
}

