using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

	public int enemyHealth;
	public GameObject deathEffect;
	public int pointsOnDeath;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (enemyHealth <= 0) {
		//if enemy health equal or bellow zero points will be added to the player as well as instantiate a death partical on the destroyied object.'
			try {
				Instantiate (deathEffect, transform.position, transform.rotation);
			} catch (System.Exception ex) {
				StaticData.ErrorLogList.Add (ex.ToString());
			}

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
