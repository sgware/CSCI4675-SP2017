using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goThroughWormhole : MonoBehaviour {

	void OnTriggerEnter (Collider other) {

		if (other.gameObject.CompareTag ("Wormhole")) {

			SceneManager.LoadScene ("MainMenu");
			Cursor.visible = true;

		}

	}	

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

}