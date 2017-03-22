using UnityEngine;
using System.Collections;

public class wallMoveForward : MonoBehaviour{
	private Vector3 frometh;
	private Vector3 untoeth;
	private float secondsForOneLength = 5f; //Haste

	void Start(){
		frometh = transform.position;
		untoeth = transform.position + Vector3.left * 5.0F; //Distance
	}

	void Update(){
		transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f,1f, Mathf.PingPong(Time.time / secondsForOneLength, 1f)));
	}
}