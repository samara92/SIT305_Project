using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifeManager : MonoBehaviour {

	//public int startLives;
	private int lifeCounter;
	private Text txtLife;

	public GameObject gameOverScreen;
	public PlayerController player;
	// Use this for initialization
	void Start () {
		txtLife = GetComponent<Text> ();
		// get the values in XML file using key value paires
		lifeCounter = PlayerPrefs.GetInt("playerCurrentLives");
		txtLife.text = "x " + lifeCounter;
	}
	
	// Update is called once per frame
	void Update () {

		if (lifeCounter == 0) {
			player.gameObject.SetActive (false);
			gameOverScreen.SetActive (true);
		}
	}
	//this will called when player pick up a life.life count increases
	public void GiveLife(){
	
		lifeCounter ++;
		txtLife.text = "x " + lifeCounter;
		// save it in XML file using key value paires
		PlayerPrefs.SetInt ("playerCurrentLives", lifeCounter);
	}
	//this will called when player loose a life.life count decreases
	public void TakeLife(){
		lifeCounter--;
		txtLife.text = "x " + lifeCounter;
		// save it in XML file using key value paires
		PlayerPrefs.SetInt ("playerCurrentLives", lifeCounter);
	}
}
