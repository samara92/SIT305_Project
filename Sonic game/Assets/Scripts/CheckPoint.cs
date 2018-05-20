using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {
	//get the script "Levelmanager" from the active game object.
	public LevelManager levelManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){

		//if the collider clasing name is equal to player
		if (col.name == "Player") {
			//activate check point in level manager script.
			try {
				levelManager.currentCheckPoint = gameObject;
			} catch (System.Exception ex) {
				StaticData.ErrorLogList.Add (ex.ToString ());	
			}

			Debug.Log ("Checkpoint Activated");
		}
}
}
