using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour {

	// Use this for initialization
	int i = 1;
	void Start () {
		StartCoroutine (Active());

	}
	
	// Update is called once per frame
	IEnumerator Active(){
		
		if (i == 1) {
			gameObject.SetActive (false);
			yield return new WaitForSeconds (3);
			i = i * -1;
		} else {
			gameObject.SetActive (true);
			yield return new WaitForSeconds (3);
			i = i * -1;
		}
	}

	void Update () {
		
	}
}


