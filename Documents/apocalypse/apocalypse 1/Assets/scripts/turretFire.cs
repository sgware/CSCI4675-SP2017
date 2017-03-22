using UnityEngine;
using System.Collections;

// DOESN'T CURRENTLY WORK!!

public class turretFire : MonoBehaviour {

	public Transform target;
	public float turretSpeed;
	public float fireRate;
	public float lastShotTime = float.MinValue;
	public float laserHeight;
	public Rigidbody laserPrefab;
	public GameObject laser;
	public float range;
	float distance;

	void Start () {

	}

	void Update () {

		// Rotate turret to look at player.

		//Fire at player when in range.
		distance = Vector3.Distance(transform.position, target.position);

		//if (distance < range && Time.time > lastShotTime + (3.0f / fireRate)) {
		if (distance < range){

			//lastShotTime = Time.time;
			//print (Time.time);
			fireLaser();

		}
	}

	void fireLaser() {

		Vector3 position = new Vector3 (transform.position.x, transform.position.y + laserHeight, transform.position.z);

		Debug.Log ("Fire");

		laser = Instantiate (laser, position, transform.rotation) as GameObject;

		//laser.rigidbody.velocity = transform.forward * bulletSpeed;

	}



}