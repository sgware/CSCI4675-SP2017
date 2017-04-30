using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanishingBlock : MonoBehaviour {

	public float fadeDelay = 0.0f; 
	public float fadeTime = 0.5f; 
	public bool fadeInOnStart = false; 
	public bool fadeOutOnStart = false;
	private bool logInitialFadeSequence = false; 

	// store colours
	private Color[] colors; 

	// allow automatic fading on the start of the scene
	IEnumerator Start (){
		//yield return null; 
		yield return new WaitForSeconds (fadeDelay); 

		if (fadeInOnStart){
			logInitialFadeSequence = true; 
			FadeIn (); 
		}

		if (fadeOutOnStart){
			FadeOut (fadeTime); 
		}
	}




	// check the alpha value of most opaque object
	float MaxAlpha(){
		float maxAlpha = 0.0f; 
		Renderer[] rendererObjects = GetComponentsInChildren<Renderer>(); 
		foreach (Renderer item in rendererObjects)
		{
			maxAlpha = Mathf.Max (maxAlpha, item.material.color.a); 
		}
		return maxAlpha; 
	}

	// fade sequence
	IEnumerator FadeSequence (float fadingOutTime)
	{
		// log fading direction, then precalculate fading speed as a multiplier
		bool fadingOut = (fadingOutTime < 0.0f);
		float fadingOutSpeed = 1.0f / fadingOutTime; 

		// grab all child objects
		Renderer[] rendererObjects = GetComponentsInChildren<Renderer>(); 
		//I added this array to turn off the colliders. (RWH)
		BoxCollider[] colliderBoxObjects = GetComponentsInChildren<BoxCollider>();
		if (colors == null){
			//create a cache of colors if necessary
			colors = new Color[rendererObjects.Length]; 

			// store the original colours for all child objects
			for (int i = 0; i < rendererObjects.Length; i++){
				colors[i] = rendererObjects[i].material.color; 
			}
		}

		// make all objects visible
		for (int i = 0; i < rendererObjects.Length; i++){
			rendererObjects[i].enabled = true;
		}


		// get current max alpha
		float alphaValue = MaxAlpha();  


		// This is a special case for objects that are set to fade in on start. 
		// it will treat them as alpha 0, despite them not being so. 
		if (logInitialFadeSequence && !fadingOut){
			alphaValue = 0.0f; 
			logInitialFadeSequence = false; 
		}

		// iterate to change alpha value 
		while ( (alphaValue >= 0.0f && fadingOut) || (alphaValue <= 1.0f && !fadingOut)) 
		{
			alphaValue += Time.deltaTime * fadingOutSpeed; 

			for (int i = 0; i < rendererObjects.Length; i++)
			{
				Color newColor = (colors != null ? colors[i] : rendererObjects[i].material.color);
				newColor.a = Mathf.Min ( newColor.a, alphaValue ); 
				newColor.a = Mathf.Clamp (newColor.a, 0.0f, 1.0f); 				
				rendererObjects[i].material.SetColor("_Color", newColor) ; 
			}

			yield return null; 
		}

		//I editted this to create a fading in and out loop.
		if (fadingOut){
			for (int i = 0; i < rendererObjects.Length; i++){
				rendererObjects[i].enabled = false;
				colliderBoxObjects[i].enabled = false;
			}
			yield return new WaitForSeconds(5);//leaves the box off for 5 seconds.
			//now I turn everything back on.
			for (int i = 0; i < rendererObjects.Length; i++){
				//this restores the alpha value of the color.
				Color tempColor = rendererObjects [i].material.color;
				tempColor.a = 1.0f;
				rendererObjects[i].material.SetColor("_Color", tempColor) ; 

				rendererObjects[i].enabled = true;
				colliderBoxObjects[i].enabled = true;
			}
			yield return new WaitForSeconds(3);//give you 3 seconds before the fading starts again.
			FadeOut(fadeTime);

		}

		Debug.Log ("fade sequence end : " + fadingOut); 

	}


	void FadeIn (){
		FadeIn (fadeTime); 
	}

	void FadeOut (){
		FadeOut (fadeTime); 		
	}

	void FadeIn (float newFadeTime){
		StopAllCoroutines(); 
		StartCoroutine("FadeSequence", newFadeTime); 
	}

	void FadeOut (float newFadeTime){
		StopAllCoroutines(); 
		StartCoroutine("FadeSequence", -newFadeTime); 
	}
}
