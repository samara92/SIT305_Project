using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControlls : MonoBehaviour {
	private PlayerController thePlayer;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
	}

	//these methods are the ouch controllers.Buttons will reference this as triggers
	public void LeftArrow(){
	//Move the player left when left button is pressed
		thePlayer.Move (-1);
	}
	public void RightArrow(){
		//Move the player right when left button is pressed
		thePlayer.Move (1);
	}
	public void UnpressedArrow(){
		// when putton press finished player move speed needs to be zero.
		thePlayer.Move (0);
	}
	public void Fire(){
		//when fire button press instantiate projectiles
		thePlayer.Fire ();
	}

	public void Jump(){
		//Jump touch button event
		thePlayer.Jump ();

	}
	public void PowerUp(){
		//Player power up button press event
		thePlayer.speedPowerUp = true;
	}

	public void PowerUpUnPress(){
		//Player power up button un press event
		thePlayer.speedPowerUp = false;
	}
}
