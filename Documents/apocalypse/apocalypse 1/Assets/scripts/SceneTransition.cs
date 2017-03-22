using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour {
	public string sceneToLoad;

	void OnTriggerEnter(Collider other){
			print ("Collision Detected");
			SceneManager.LoadScene (sceneToLoad);
	}
}