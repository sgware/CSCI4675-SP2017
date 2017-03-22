using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/**
 * TODO: gasStopper TAG will need to be applied to the gasStopper objects.
 */

public class KillGas : MonoBehaviour {
	
	public GameObject ventToCover;
	public GameObject itemToKill;

	void OnCollisionEnter(Collision col){
		print ("Collision Detected.");
		if (col.gameObject.tag == "gasStopper") {
			itemToKill.SetActive (false);
			print ("gas killed.");
			Destroy(col.gameObject.GetComponent<pickupable>());
			Destroy (col.gameObject.GetComponent<Rigidbody>());
			print("scripts destroyed.");
			col.collider.enabled = false;
			col.gameObject.transform.position = ventToCover.transform.position + Vector3.up * .95F;
			col.gameObject.transform.rotation = ventToCover.transform.rotation;
			print ("obj snapped");
			//advance ();

		}
	}

	/*void advance(){
		if(!GameObject.Find("greenSmoke"){
			GameObject.Find("portal").transform.localScale(1,1,1);
		}
	}*/
}


/**
 * if you want to make it more challenging
 * 
public class KillGas : MonoBehaviour {
	public GameObject boxToUse;
	public GameObject ventToCover;
	public GameObject itemToKill;

	void OnCollisionEnter(Collision col){
		print ("Collision Detected.");
		if (col.gameObject.name == boxToUse.name) {
			print ("gas killed.");
			itemToKill.SetActive (false);
			Destroy(col.gameObject.GetComponent<pickupable>());
			print("pickupable script destroyed.");
		}
	}
}
*/