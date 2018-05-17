using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControlls : MonoBehaviour {
	private PlayerController thePlayer;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
	}
	
	public void LeftArrow(){
	
		thePlayer.Move (-1);
	}
	public void RightArrow(){

		thePlayer.Move (1);
	}
	public void UnpressedArrow(){

		thePlayer.Move (0);
	}
	public void Fire(){

		thePlayer.Fire ();
	}

	public void Jump(){
		thePlayer.Jump ();

	}
	public void PowerUp(){
	
		thePlayer.speedPowerUp = true;
	}

	public void PowerUpUnPress(){

		thePlayer.speedPowerUp = false;
	}
}
