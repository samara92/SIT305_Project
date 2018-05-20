using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour {

	public int healthToGive; 

	public HealthManager helthManager;
	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){
	
		if (col.GetComponent<PlayerController> () == null)
			return;
		//HurtPlayer method will take the parameter and reduses the player helath according to the passed value;
		helthManager.HurtPlayer(-healthToGive);
		//TO DO Optimise
		Destroy(gameObject);
	}

}
