using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerManager : MonoBehaviour {
	public GameObject powerUpButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.name == "Player") {
			powerUpButton.SetActive(true);
			//TO DO: Optimise
			Destroy (gameObject);
		}
	}
}
