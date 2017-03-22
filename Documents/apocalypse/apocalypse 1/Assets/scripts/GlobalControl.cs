using UnityEngine;
using System.Collections;

// This script is intended to store the information between scenes.
//
public class GlobalControl: MonoBehaviour
{
	public static GlobalControl Instance;
	
	//To keep track of NextSceneCoords for next scene load
	//we can assign it to the coords of current coords of collision object
	public static float NextSceneXCoords;
	public static float NextSceneYCoords;
	public static float NextSceneZCoords;
	
	public static string SceneAfterPipe = "level3";
	
	public float HP;
	public float XP;
	//For later use to save player statistics
	//public PlayerStatistics savedPlayerData = new PlayerStatistics();
	
	void Awake(){
		if (Instance == null){
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
		else if (Instance != this){
			
			Destroy(gameObject);
		}	
	}



}