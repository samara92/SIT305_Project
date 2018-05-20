using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour {

	private bool playerInZone;
	public string levelToLoad;
	// Use this for initialization
	void Start () {
		playerInZone = false;
	}
	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){
	
		// if door trigger clash ith player collider load the next level
		if (col.name == "Player") {
		
			playerInZone = true;
			SceneManager.LoadScene (levelToLoad);
			Debug.Log ("loadlevel");

		}
	}
	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerExit2D(Collider2D col){
	
		if (col.name == "Player") {
		
			playerInZone = false;
		}
	}
}
