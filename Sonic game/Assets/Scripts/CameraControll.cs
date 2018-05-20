using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour {

	//Player controller script that is available in the game hirachey.
	public PlayerController player;
	public bool isFollowing;
	//floats
	//Camera x and y offset values
	public float xOffSet;
	public float yOffSet;
	// Use this for initialization
	void Start () {
		
		isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		//is boolean isFollowing is true the game object that attaches this script will recive player position plus the X and Y offset values.
		if(isFollowing)
		transform.position = new Vector3 (player.transform.position.x+xOffSet
			,player.transform.position.y+yOffSet,transform.position.z);

	}
}
