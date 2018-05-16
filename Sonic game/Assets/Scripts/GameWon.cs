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
	
	// Update is called once per frame
	void Update () {


			
	}
	void OnTriggerEnter2D(Collider2D col){
	
		if (col.name == "Player") {
		
			playerInZone = true;
			gameWonPanel.SetActive (true);
			Debug.Log ("GameWon");

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
