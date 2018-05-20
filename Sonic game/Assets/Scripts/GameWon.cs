using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameWon : MonoBehaviour {

	private bool playerInZone;
	public GameObject gameWonPanel;
	// Use this for initialization
	void Start () {
		playerInZone = false;
	}
	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){
		//if door triggered object name player game won panel displayed and load the next level
		if (col.name == "Player") {
		
			playerInZone = true;
			gameWonPanel.SetActive (true);
			Debug.Log ("GameWon");

		}
	}
	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerExit2D(Collider2D col){
	
		if (col.name == "Player") {
		
			playerInZone = false;
		}
	}
}
