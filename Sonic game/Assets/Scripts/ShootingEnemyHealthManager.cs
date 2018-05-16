using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemyHealthManager : MonoBehaviour {

	public int enemyHealth;
	public GameObject deathEffect;
	public int pointsOnDeath;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (enemyHealth <= 0) {
		
			Instantiate (deathEffect, transform.position, transform.rotation);
			SocreManager.AddPoints (pointsOnDeath);
			//TO DO: optimise
			Destroy (gameObject.GetComponentInParent<GameObject>());
		
		}
	}

	public void GivenDamage(int damageToGive){
	
		enemyHealth -= damageToGive;
	}
}
