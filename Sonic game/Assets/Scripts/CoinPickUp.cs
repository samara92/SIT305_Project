using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {
	//how much will give the player if he pick up a coin.
	public int pointToAdd;

	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D other){
	
		try {
			 var playercontroller = other.GetComponent<PlayerController> ();
		} catch (System.Exception ex) {
				//static list is used to create a high level error log to end user
			StaticData.ErrorLogList.Add ("The script playercontroller is not found");
		}

			

		SocreManager.AddPoints (pointToAdd);

		//Destroy the object this script attached
		Destroy (gameObject);
	}

}
