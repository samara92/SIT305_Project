using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickUp : MonoBehaviour {

	public LifeManager lifeSystem;

	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){
		//if player pick up this object his life count increses
		if (col.name == "Player") {
			lifeSystem.GiveLife ();
			//TO DO: Optimise
			Destroy (gameObject);
		}
	}
		
}
