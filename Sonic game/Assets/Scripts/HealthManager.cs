using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour {

	public int maxPlayerHealth;
	public  int playerHelath;

	public  Text text;
	public  LevelManager levelManager;

	public  bool isDead;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		playerHelath = maxPlayerHealth;
		text.text = "" + playerHelath;
		isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HurtPlayer(int damageToGive){
		playerHelath -= damageToGive;

		if (playerHelath <= 0 && !isDead) {
			playerHelath = 0;
			text.text = "" + playerHelath;
			levelManager.RespawnPlayer ();
			isDead = true;

		} else {
			text.text = "" + playerHelath;
		}
	}

	public void FullHelath(){
		
		playerHelath = maxPlayerHealth;
		text.text = "" + playerHelath;
	}
}
