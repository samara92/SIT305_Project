using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickUp : MonoBehaviour {

	public LifeManager lifeSystem;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
	
		if (col.name == "Player") {
			lifeSystem.GiveLife ();
			//TO DO: Optimise
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
