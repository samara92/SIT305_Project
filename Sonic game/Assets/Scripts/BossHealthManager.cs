﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthManager : MonoBehaviour {

	public int enemyHealth;
	public GameObject deathEffect;
	public int pointsOnDeath;
	public GameObject bossPrefab;
	public float minSize;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (enemyHealth <= 0) {

			Instantiate (deathEffect, transform.position, transform.rotation);
			SocreManager.AddPoints (pointsOnDeath);

			if (transform.localScale.y > minSize) {
				Debug.Log ("Local Scale  " + transform.localScale.y * 0.5f);
				GameObject clone1 = Instantiate (bossPrefab, new Vector3 (transform.position.x + 1f, transform.position.y, transform.position.z), transform.rotation) as GameObject;
				GameObject clone2 = Instantiate (bossPrefab, new Vector3 (transform.position.x - 1f, transform.position.y, transform.position.z), transform.rotation) as GameObject;

				clone1.transform.localScale = new Vector3 (transform.localScale.x * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z * 0.5f);
				clone1.GetComponent<BossHealthManager> ().enemyHealth = 10;

				clone2.transform.localScale = new Vector3 (transform.localScale.x * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z * 0.5f);
				clone2.GetComponent<BossHealthManager> ().enemyHealth = 10;

			} 

			//TO DO: optimise
			Destroy (gameObject);

		}
	}

	public void GivenDamage(int damageToGive){

		enemyHealth -= damageToGive;
	}
}
