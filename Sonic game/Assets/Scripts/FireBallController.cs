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
	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){
		//if clashed tag name Enemy then Enemy helath is reduces
		if (col.tag == "Enemy") {
			try {
				col.GetComponent<EnemyHealthManager> ().GivenDamage (damageToGive);
			} catch (System.Exception ex) {
				StaticData.ErrorLogList.Add (ex.ToString ());
			}

		}
		if (col.tag == "Boss") {
			//if clashed tag name Boss then Boss helath is reduces
			try {
				col.GetComponent<BossHealthManager> ().GivenDamage (damageToGive);
			} catch (System.Exception ex) {
				StaticData.ErrorLogList.Add (ex.ToString ());
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
