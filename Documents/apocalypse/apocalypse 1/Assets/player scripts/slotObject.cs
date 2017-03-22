using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotObject : MonoBehaviour {
	public float position;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Collider[] findOverlap = Physics.OverlapSphere(this.transform.position, position); 			//radius of capture = 0.2 units
		float xoff = -1f;																		//offset = 0.0625,0.0702,0.0607
		float yoff = -1f;
		float zoff = 0f;

		for (int i = 0; i < findOverlap.Length; i++) {
			if (findOverlap [i].gameObject.tag == "symbol") {
				findOverlap [i].gameObject.transform.position = new Vector3(this.transform.position.x + xoff, this.transform.position.y + yoff, this.transform.position.z + zoff);

			}
		}



}
}
