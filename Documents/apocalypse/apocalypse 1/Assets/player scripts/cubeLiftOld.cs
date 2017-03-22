using UnityEngine;
using System.Collections;

public class cubeLiftOld : MonoBehaviour{
	private Vector3 frometh;
	private Vector3 untoeth;
	private float secondsForOneLength = 6.0f;

	void Start(){
		frometh = transform.position;
		untoeth = transform.position + Vector3.up * 7.0F;
	}

	void Update(){
		transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f,1f, Mathf.PingPong(Time.time / secondsForOneLength, 1f)));
	}
}