using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {
	public int damageToGive;
	public HealthManager healthManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
	
		if (col.name == "Player") {
		
			healthManager.HurtPlayer (damageToGive);
		}
	}
}
