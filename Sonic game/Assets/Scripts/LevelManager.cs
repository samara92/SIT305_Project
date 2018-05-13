using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckPoint;
	public PlayerController player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RespawnPlayer(){
	
		Debug.Log ("Player respawn !!!! xxxx");
		player.transform.position = currentCheckPoint.transform.position;
	}
}
