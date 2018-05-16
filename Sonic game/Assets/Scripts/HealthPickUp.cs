using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour {

	public int healthToGive; 

	public HealthManager helthManager;
	void OnTriggerEnter2D(Collider2D col){
	
		if (col.GetComponent<PlayerController> () == null)
			return;

		helthManager.HurtPlayer(-healthToGive);
		//TO DO Optimise
		Destroy(gameObject);
	}

}
