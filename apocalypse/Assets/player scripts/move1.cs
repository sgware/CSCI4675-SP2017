using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour {
	public float moveSpeed = 100f;
	public float turnSpeed = 50f;

	// Use this for initialization
	void Start () {
		
	}



	void Update(){

		if(Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.S))
			transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.A))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.D))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

	}

	

}
