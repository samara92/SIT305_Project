using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemyHealthManager : MonoBehaviour {

	public int enemyHealth;
	public GameObject deathEffect;
	public int pointsOnDeath;
	
	// Update is called once per frame
	void Update () {

		if (enemyHealth <= 0) {
		
			Instantiate (deathEffect, transform.position, transform.rotation);
			SocreManager.AddPoints (pointsOnDeath);
			//TO DO: optimise
			Destroy (gameObject);
		
		}
	}
	//This method will take one parameter. Inside the method it will reduce the passed parameter from enemy health
	public void GivenDamage(int damageToGive){
	
		enemyHealth -= damageToGive;
	}
}
