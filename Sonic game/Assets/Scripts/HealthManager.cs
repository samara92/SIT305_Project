using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour {

	public int maxPlayerHealth;
	public static int playerHelath;

	Text text;
	public LevelManager levelManager;

	public bool isDead;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		playerHelath = maxPlayerHealth;
		isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHelath <= 0 && !isDead) {
			playerHelath = 0;
			levelManager.RespawnPlayer ();
			isDead = true;
		}
		text.text = "" + playerHelath;
	}

	public static void HurtPlayer(int damageToGive){
		playerHelath -= damageToGive;
	}

	public void FullHelath(){
		
		playerHelath = maxPlayerHealth;
	}
}
