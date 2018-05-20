using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadly : MonoBehaviour {

	public LevelManager levelManager;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		
	}
	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){
	//if clashed coliider name player then player needs to be respawned
		if (col.name == "Player") {
		
			levelManager.RespawnPlayer ();
		}
	
	}
}
