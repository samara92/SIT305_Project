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

	public void GiveLife(){
	
		lifeCounter ++;
		txtLife.text = "x " + lifeCounter;
		PlayerPrefs.SetInt ("playerCurrentLives", lifeCounter);
	}

	public void TakeLife(){
		lifeCounter--;
		txtLife.text = "x " + lifeCounter;
		PlayerPrefs.SetInt ("playerCurrentLives", lifeCounter);
	}
}
