using UnityEngine;
using System.Collections;

public class cubeLift : MonoBehaviour{
	private Vector3 frometh;
	private Vector3 untoeth;
	private float secondsForOneLength = 5f;

	void Start(){
		frometh = transform.position;
		untoeth = transform.position + Vector3.up * 11.0F;
	}

	void Update(){
		transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f,1f, Mathf.PingPong(Time.time / secondsForOneLength, 1f)));
	}
}