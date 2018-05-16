using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireBall : MonoBehaviour {

	public float speed;
	public GameObject Enemy;
	public HealthManager healthManager;
	public int damageToGive;
	// Use this for initialization
	void Start () {
		if (speed < 0) {
			speed = speed * -1;
		}
		if (Enemy.transform.localScale.x > 0) {
			Debug.Log ("right");
			speed = -speed;

		}
	}
	void FixedUpdate(){
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
	}
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){


		if (col.tag == "Player") {

			//Instantiate (deathEffect,col.transform.position,col.transform.rotation);
			//Destroy (col.gameObject);
			//SocreManager.AddPoints (pointsForKill);
			healthManager.HurtPlayer(damageToGive);

		}

		//TO DO: Optimize code
		Destroy (gameObject);
	}

	void OnCollisionEnter2D(Collision2D col){
		Debug.Log (col.gameObject.tag);
		if (col.gameObject.tag == "Ground") {
			Debug.Log ("Aiyoo");
			Destroy (gameObject);
		}
	}
}
