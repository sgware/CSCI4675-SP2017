using UnityEngine;
using System.Collections;

public class VanishingBlocks : MonoBehaviour
{

	public int frame; 	//starting offset
	public int max;		//number of frames
	public float x,y,z;	//object scale values

	void Start(){
		transform.localScale = new Vector3 (x, y, z);
	}

	void Update(){
		if (frame < max) {
			//Debug.Log ("frame: " + frame);
			frame++;
			if (frame == max/2) {
				transform.localScale = new Vector3 (0f, 0f, 0f);
			}
		} 
		else {
			frame = 0;
			Start ();
		}
	}
}
