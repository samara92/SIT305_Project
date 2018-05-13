﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

	public int pointToAdd;

	void OnTriggerEnter2D(Collider2D other){
	
		if (other.GetComponent<PlayerController> () == null)
			return;

		SocreManager.AddPoints (pointToAdd);

		Destroy (gameObject);
	}

}
