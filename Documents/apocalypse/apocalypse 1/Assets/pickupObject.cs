using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupObject : MonoBehaviour {
	GameObject mainCamera;
	bool carrying;
	public float distance  = 3.0f;
	public float smooth = 4.0f;
	GameObject carriedObject;
	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update(){
		if (carrying) {
			carry(carriedObject);
			checkDrop();
		} else {
			pickup();		
		}
	}

	void carry(GameObject o){
		//Camera myCamera = mainCamera.GetComponent<Camera>();

		//myCamera.Screen
		//o.transform.position = mainCamera.transform.position + mainCamera.transform.forward + new Vector3(Screen.width / 2, Screen.height / 2,10f);
		//Lerp will smooth movement.
		o.transform.position = Vector3.Lerp(o.transform.position, Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, 4f)), Time.deltaTime * smooth);
			
	}
	void pickup(){
		if(Input.GetKeyDown(KeyCode.E)){
			int x = Screen.width / 2;
			int y = Screen.height / 2;

			Camera myCamera = mainCamera.GetComponent<Camera>();

			Ray ray = myCamera.ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit)){
				//print ("hit");
				pickupable p = hit.collider.GetComponent<pickupable>();
				if(p != null){
					carrying = true;
					carriedObject = p.gameObject;
					Rigidbody rb = p.gameObject.GetComponent<Rigidbody>();
					rb.isKinematic = true;
				}
			}
		}
	
	}

	void checkDrop(){
		if (Input.GetKeyDown (KeyCode.E)) {
			dropObject ();
		}
	}
	void dropObject(){
		carrying = false;
		Rigidbody rb = carriedObject.gameObject.GetComponent<Rigidbody>();
		rb.isKinematic = false;
		carriedObject = null;
	}
}
