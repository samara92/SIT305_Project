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
		//text = GetComponent<Text> ();
		healthBar = GetComponent<Slider>();
		//playerHelath = maxPlayerHealth;
		playerHelath = PlayerPrefs.GetInt("PlayerCurrentHealth");
		healthBar.value = playerHelath;
		//text.text = "" + playerHelath;
		isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HurtPlayer(int damageToGive){
		playerHelath -= damageToGive;
		PlayerPrefs.SetInt("PlayerCurrentHealth",playerHelath);
		if (playerHelath <= 0 && !isDead) {
			playerHelath = 0;
			lifeSystem.TakeLife ();
			//text.text = "" + playerHelath;
			healthBar.value = playerHelath;
			levelManager.RespawnPlayer ();
			isDead = true;

		} else {
			//text.text = "" + playerHelath;
			if (playerHelath > maxPlayerHealth) {
				
				playerHelath = maxPlayerHealth;
			}
			healthBar.value = playerHelath;
		}
	}

	public void FullHelath(){
		
		playerHelath = maxPlayerHealth;
		//text.text = "" + playerHelath;
		healthBar.value = playerHelath;
		PlayerPrefs.SetInt("PlayerCurrentHealth",playerHelath);
	}
}
