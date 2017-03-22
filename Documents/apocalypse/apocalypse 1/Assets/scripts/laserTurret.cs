using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DOESN'T CURRENTLY WORK!!

public class laserTurret : MonoBehaviour {

	public Rigidbody bulletPrefab;
	public Transform target;
	public GameObject bullet;
	public float speed;
	public float nextFire;
	private Quaternion targetPos;

	void OnTriggerEnter(Collider otherCollider) {
		if (otherCollider.CompareTag ("Player")) {
			Debug.Log ("Target In Range");
			target = otherCollider.transform;
			StartCoroutine ("fire");
		}
	}

	void OnTriggerExit(Collider otherCollider) {
		if (otherCollider.CompareTag ("Player")) {
			Debug.Log ("Lost Target");
			target = null;
			StopCoroutine ("Fire");
		}
	}

	IEnumerator Fire() {
		while (target != null) {
			nextFire = Time.time + 0.5f;
			while (Time.time < nextFire) {
				transform.LookAt (target);
				//targetPos = Quaternion.LookRotation (target.position);
				//transform.rotation = Quaternion.Slerp (transform.rotation, targetPos, Time.deltaTime * 5);
				//Vector3 dir = target - transform.position;
				//Quaternion targetRotation = Quaternion.LookRotation (dir);
				//transform.rotation = Quaternion.RotateTowards (transform.rotation, targetRotation, Time.deltaTime * speed);
				yield return new WaitForEndOfFrame ();
			}

			Debug.Log ("Fire");
			//bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
		}
	}
}
