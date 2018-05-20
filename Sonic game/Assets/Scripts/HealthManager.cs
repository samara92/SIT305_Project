using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour {

	public int maxPlayerHealth;
	public  int playerHelath;

	//public  Text text;
	public Slider healthBar;

	public  LevelManager levelManager;

	public  bool isDead;
	public LifeManager lifeSystem;
	// Use this for initialization
	void Start () {
		//initilization player helath bar is loaded according to previously saved player health.
		try {
			healthBar = GetComponent<Slider>();	
		} catch (System.Exception ex) {
			StaticData.ErrorLogList.Add (ex.ToString ());
		}
		//loading the prevoiusly locally saved player health value.(saved in xml format,for getting the value we needs to pass the key of the data we need)
		playerHelath = PlayerPrefs.GetInt("PlayerCurrentHealth");
		healthBar.value = playerHelath;
		isDead = false;

	}

	//this will reduce player health according to passed int value
	public void HurtPlayer(int damageToGive){
		//redusing player healthBar from method passed value
		playerHelath -= damageToGive;
		//then save it in XML file using key value paires
		PlayerPrefs.SetInt("PlayerCurrentHealth",playerHelath);

		if (playerHelath <= 0 && !isDead) {
			
			playerHelath = 0;
			//reduce one life
			lifeSystem.TakeLife ();
			healthBar.value = playerHelath;
			//respawn the player
			levelManager.RespawnPlayer ();
			isDead = true;

		} else {

			if (playerHelath > maxPlayerHealth) {
				
				playerHelath = maxPlayerHealth;
			}
			healthBar.value = playerHelath;
		}
	}
	//restore players health full
	public void FullHelath(){
		
		playerHelath = maxPlayerHealth;
		healthBar.value = playerHelath;
		// save it in XML file using key value paires
		PlayerPrefs.SetInt("PlayerCurrentHealth",playerHelath);
	}
}
