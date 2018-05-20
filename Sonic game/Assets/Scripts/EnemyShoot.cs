using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {
	
	public Transform firePoint;
	public Transform firePoint2;
	public GameObject fireBall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){

		if (col.name == "Player") {

			Debug.Log (col.name + "Soot Player");
			//instantiate projctile
			try {
				Instantiate (fireBall,firePoint.position,firePoint.rotation);
			} catch (System.Exception ex) {
				StaticData.ErrorLogList.Add (ex.ToString ());
			}


			if(firePoint2 != null)
			Instantiate (fireBall, firePoint2.position, firePoint2.rotation);

		}
	}
}
