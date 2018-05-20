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
	public PolygonCollider2D PlayerGO;

	public void RespawnPlayer(){
	
		StartCoroutine ("RespawnPlayerCorrutine");
	}
	//respawn player
	public IEnumerator RespawnPlayerCorrutine(){
		//disable respawnPartical
		//enable and play death partical
		respawnPartical.SetActive(false);
		deathPartical.SetActive (true);

		//PlayerController script is disabled
		player.enabled = false;
		//player game object disabled
		PlayerGO.enabled = false;
		//Player Health manager disable
		healthManager.isDead = false;
		player.Move (0);
		SocreManager.AddPoints (-deathPanalty);

		player.GetComponent<Renderer> ().enabled = false;
		camera.isFollowing = false;
		Debug.Log ("Player respawn !!!! xxxx");
		yield return new WaitForSeconds (respawnDelay);
		//player.GetComponent<Rigidbody2D> ().gravityScale = gravityStore;
		player.transform.position = currentCheckPoint.transform.position;
		player.enabled = true;
		PlayerGO.enabled = true;
		try {
			player.GetComponent<Renderer> ().enabled = true;
		} catch (System.Exception ex) {
			StaticData.ErrorLogList.Add (ex.ToString ());
		}
		healthManager.FullHelath ();
		healthManager.isDead = false;
		//disable death partical
		//enable and play respawn partical
		respawnPartical.SetActive(true);
		camera.isFollowing = true;
		deathPartical.SetActive (false);
	}
}
