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
		player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false;
		Debug.Log ("Player respawn !!!! xxxx");
		yield return new WaitForSeconds (respawnDelay);
		player.transform.position = currentCheckPoint.transform.position;
		player.enabled = true;
		player.GetComponent<Renderer> ().enabled = true;
		//disable death partical
		//enable and play respawn partical
		respawnPartical.SetActive(true);
		deathPartical.SetActive (false);
	}
}
