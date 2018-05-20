using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthManager : MonoBehaviour {

	//ints
	public int enemyHealth;
	public int pointsOnDeath;
	//floats
	public float minSize;
	//game objects
	public GameObject deathEffect;
	public GameObject bossPrefab;

	public GameObject clone1;
	public GameObject clone2;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (enemyHealth <= 0) {
			//this will create the death effect on the related object
			Instantiate (deathEffect, transform.position, transform.rotation);
			//added points to the player when enemy health reaches 0
			SocreManager.AddPoints (pointsOnDeath);
			//get the local scale of the enemy who died and compaire it with minimum size
			if (transform.localScale.y > minSize) {

				//create two game object clone of the boss enemy.
				try {
					clone1 = Instantiate (bossPrefab, new Vector3 (transform.position.x + 1f, transform.position.y, transform.position.z), transform.rotation) as GameObject;
					clone2 = Instantiate (bossPrefab, new Vector3 (transform.position.x - 1f, transform.position.y, transform.position.z), transform.rotation) as GameObject;

				} catch (System.Exception ex) {
					StaticData.ErrorLogList.Add (ex.ToString ());	
				}

				//change its scale to half of the scale
				clone1.transform.localScale = new Vector3 (transform.localScale.x * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z * 0.5f);
				//give that boss enemy a helath of 10.
				clone1.GetComponent<BossHealthManager> ().enemyHealth = 10;

				//change its scale to half of the scale
				clone2.transform.localScale = new Vector3 (transform.localScale.x * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z * 0.5f);
				//give that boss enemy a helath of 10.
				clone2.GetComponent<BossHealthManager> ().enemyHealth = 10;

			} 

			//Destroy the enemy game object
			Destroy (gameObject);

		}
	}

	//This method will take one parameter. Inside the method it will reduce the passed parameter from enemy health
	public void GivenDamage(int damageToGive){

		enemyHealth -= damageToGive;
	}
}
