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

	void OnTriggerEnter2D(Collider2D col){

		if (col.name == "Player") {

			Debug.Log (col.name + "Soot Player");
			Instantiate (fireBall,firePoint.position,firePoint.rotation);

			if(firePoint2 != null)
			Instantiate (fireBall, firePoint2.position, firePoint2.rotation);

		}
	}
	public void Fire(){
		
	}
}
