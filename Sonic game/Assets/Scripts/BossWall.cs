using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//In the game find the game object that attached BossHealthManagerScript if its available do nothing.
		if (FindObjectOfType<BossHealthManager> ()) {
		
			return;
		}

		//else distroy the game object that this script attached
		Destroy (gameObject);
	}
}
