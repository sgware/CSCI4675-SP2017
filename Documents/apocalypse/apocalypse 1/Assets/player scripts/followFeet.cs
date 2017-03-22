using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followFeet : MonoBehaviour {

	public GameObject cameraHead;
	public GameObject cameraRig;
	public GameObject feet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		feet.transform.position = new Vector3 (cameraHead.transform.position.x, cameraRig.transform.position.y, cameraHead.transform.position.z);
	}
}
