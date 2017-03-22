using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DOESN'T CURRENTLY WORK!!

public class laserTurretTwo : MonoBehaviour {

	public Rigidbody projectile = new Rigidbody();
	Rigidbody MyElement;

	public float delayTime = 2.0f;		// Time between shots.
	public bool shootEnabled;			// Toggle shooting off and on.
	bool shootRunning;

	void Start() {

		StartCoroutine (Shoot ());

	}

	IEnumerator Shoot() {

		while (true) {

			if (shootEnabled == true && shootRunning == false) {

				shootRunning = true;
				MyElement = projectile;
				Instantiate (MyElement, new Vector3 (1, 3, 224), new Quaternion (0, -180, -180, 0));
				MyElement.AddForce (Vector3.back, ForceMode.Impulse);

				yield return new WaitForSeconds (delayTime);

				shootRunning = false;

			}

			yield return null;

		}
	}
}
