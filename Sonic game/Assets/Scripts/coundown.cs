using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coundown : MonoBehaviour {
	public float curCountDownValue;
	public PlayerController player;
	// Use this for initialization
	void Start () {
		StartCoroutine(StartCountdown());
	}
	// Update is called once per frame
	void Update () {
		//this will check if timer goes to zero.if it is player power up boolean get false and power up button also deactivated.
		if (curCountDownValue == 0) {
		
			player.speedPowerUp = false;
			this.gameObject.SetActive (false);
		}
	}
	//the timer that button will stay activated
	public IEnumerator StartCountdown(float countdownValue = 10){
	
		curCountDownValue = countdownValue;
		while (curCountDownValue > 0) {
		
			yield return new WaitForSeconds (1f);
			curCountDownValue--;
		}
	}


}
