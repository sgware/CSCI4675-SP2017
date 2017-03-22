using UnityEngine;
using System.Collections;


public class PipeScript : MonoBehaviour{

	private float timeStarted;
	
	//in seconds
	public float timeInsidePipe;
	
	private string nextLevel;
	
    IEnumerator Start()
    {
        timeStarted = Time.time;
        nextLevel = GlobalControl.SceneAfterPipe;
        yield return new WaitForSeconds(timeInsidePipe);
        //Destroyworld);
        //UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync("Game");
        Destroy(this);
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevel);
        //UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        
   }

}