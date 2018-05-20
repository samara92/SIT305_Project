using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {
	public int damageToGive;
	public HealthManager healthManager;
	// Use this for initialization
	void Start () {
		healthManager = FindObjectOfType<HealthManager> ();
	}
	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){
	
		if (col.name == "Player") {
			//if clashed collider name Player then Player helath is reduces
			try {
				healthManager.HurtPlayer (damageToGive);
			} catch (System.Exception ex) {
				StaticData.ErrorLogList.Add (ex.ToString ());
			}
		}
	}
}
