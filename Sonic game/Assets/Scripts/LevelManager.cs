using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckPoint;
	public PlayerController player;

	//Particals for demonstration 
	public GameObject deathPartical;
	public GameObject respawnPartical;

	public float respawnDelay;

	public int deathPanalty;

	public CameraControll camera;

	private float gravityStore;
	public HealthManager healthManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RespawnPlayer(){
	
		StartCoroutine ("RespawnPlayerCorrutine");
	}

	public IEnumerator RespawnPlayerCorrutine(){
		//disable respawnPartical
		//enable and play death partical
		respawnPartical.SetActive(false);
		deathPartical.SetActive (true);

//		gravityStore = player.GetComponent<Rigidbody2D> ().gravityScale;
//		player.GetComponent<Rigidbody2D> ().gravityScale = 0f;
//		player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;

		SocreManager.AddPoints (-deathPanalty);
		player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false;
		camera.isFollowing = false;
		Debug.Log ("Player respawn !!!! xxxx");
		yield return new WaitForSeconds (respawnDelay);
		//player.GetComponent<Rigidbody2D> ().gravityScale = gravityStore;
		player.transform.position = currentCheckPoint.transform.position;
		player.enabled = true;
		player.GetComponent<Renderer> ().enabled = true;
		healthManager.FullHelath ();
		healthManager.isDead = false;
		//disable death partical
		//enable and play respawn partical
		respawnPartical.SetActive(true);
		camera.isFollowing = true;
		deathPartical.SetActive (false);
	}
}
