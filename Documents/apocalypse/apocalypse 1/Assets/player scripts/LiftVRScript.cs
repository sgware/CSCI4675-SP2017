using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftVRScript : MonoBehaviour {
	public GameObject theRig;

	// Use this for initialization
	void Start () {
		
	}
	void OnCollisionStay(Collision col){
		if(col.gameObject.name == "cubeLift"){
			print("I hit you");

			theRig.transform.position = new Vector3(theRig.transform.position.x, col.gameObject.transform.position.y + 1.0f, theRig.transform.position.z);

		}
		print("testing 1 2 3");
	}
	// Update is called once per frame
	void Update () {

	}
}
