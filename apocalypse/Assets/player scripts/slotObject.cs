using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Collider[] findOverlap = Physics.OverlapSphere(this.transform.position, 10); 			//radius of capture = 10 units
		float xoff = 6.25f;																		//offset = 6.25,7.02,-6.07
		float yoff = 7.02f;
		float zoff = -6.02f;

		for (int i = 0; i < findOverlap.Length; i++) {
			if (findOverlap [i].gameObject.tag == "symbol") {
				findOverlap [i].gameObject.transform.position = new Vector3(this.transform.position.x + xoff, this.transform.position.y + yoff, this.transform.position.z + zoff);
			}
		}

}
}
