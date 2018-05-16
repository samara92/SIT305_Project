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
	
	// Update is called once per frame
	void Update () {


			
	}
	void OnTriggerEnter2D(Collider2D col){
	
		if (col.name == "Player") {
		
			playerInZone = true;
			SceneManager.LoadScene (levelToLoad);
			Debug.Log ("loadlevel");

		}
	}

	void OnTriggerExit2D(Collider2D col){
	
		if (col.name == "Player") {
		
			playerInZone = false;
		}
	}

	public void EnableWon(){
		
	}
}
