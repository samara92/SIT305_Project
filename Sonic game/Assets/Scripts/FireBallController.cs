using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallController : MonoBehaviour {

	public float speed;
	public PlayerController player;
	public GameObject deathEffect;
	public int pointsForKill;
	public int damageToGive;
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
		
			//Instantiate (deathEffect,col.transform.position,col.transform.rotation);
			//Destroy (col.gameObject);
			//SocreManager.AddPoints (pointsForKill);

			col.GetComponent<EnemyHealthManager> ().GivenDamage (damageToGive);
		}
		//TO DO: Optimize code
		Destroy (gameObject);
	}
}
