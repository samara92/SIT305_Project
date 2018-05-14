using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallController : MonoBehaviour {

	public float speed;
	public PlayerController player;
	public GameObject deathEffect;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
		if (player.transform.localScale.x < 0)
			speed = -speed;
	}
	void FixedUpdate(){
	
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
	}
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){


		if (col.tag == "Enemy") {
		
			Instantiate (deathEffect,col.transform.position,col.transform.rotation);

			//TO DO: Optimize code
			Destroy (col.gameObject);
		}
		//TO DO: Optimize code
		Destroy (gameObject);
	}
}
