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
	//We use for physics simulations.FixedUpdate() runs at a constant 50 frames per second to match the physics engine.
	void FixedUpdate(){
		//give the projectile a velocity
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
	}
	// Update is called once per frame
	void Update () {

	}

	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){
		//if clashed coliider name player then player helath is reduces
		if (col.tag == "Player") {
			//HurtPlayer method will take the parameter and reduses the player helath according to the passed value;
			try {
				healthManager.HurtPlayer(damageToGive);
			} catch (System.Exception ex) {
				StaticData.ErrorLogList.Add (ex.ToString());
			}


		}

		//distroy the game object(projectile)
		Destroy (gameObject);
	}

	//when projectile hit the ground it will destroy it
	void OnCollisionEnter2D(Collision2D col){
		Debug.Log (col.gameObject.tag);
		if (col.gameObject.tag == "Ground") {
			Debug.Log ("Aiyoo");
			Destroy (gameObject);
		}
	}
}
