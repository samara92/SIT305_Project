using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadly : MonoBehaviour {

	public LevelManager levelManager;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
	
		if (col.name == "Player") {
		
			levelManager.RespawnPlayer ();
		}
	
	}
}
