using UnityEngine;
using System.Collections;

// Attach it to the object with box collider
public class LevelChangeCollisionControl: MonoBehaviour
{
	
	public string SceneAfterPipe;
	
	//for initiaization
	void OnCollisionEnter( Collision other ) {
		GlobalControl.SceneAfterPipe = SceneAfterPipe; //set the next scene after pipe to be the scene specified
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");

    }

	void Awake(){


	}
	
	
}
