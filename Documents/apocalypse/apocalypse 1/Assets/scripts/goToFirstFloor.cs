using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToFirstFloor : MonoBehaviour {

	private Vector3 thePositionToMoveTo;

	// Use this for initialization
	void Start () {
		thePositionToMoveTo = new Vector3 (0, 2, -8);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {
		
		if (other.gameObject.CompareTag ("Teleporter")) {

			gameObject.transform.position = thePositionToMoveTo;

		}

	}		

}
