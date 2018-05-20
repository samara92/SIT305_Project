using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SocreManager : MonoBehaviour {

	public static int score;
	Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		//score = 0;
		score = PlayerPrefs.GetInt("CurrentPlayerScore",0);
	}
	
	// Update is called once per frame
	void Update () {

		if (score < 0)
			score = 0;
		text.text = "" + score;
		
	}
	//add score to the player.gets an integer variable
	public static void AddPoints(int pointsToAdd){
	
		score += pointsToAdd;
		// save it in XML file using key value paires
		PlayerPrefs.SetInt ("CurrentPlayerScore",score);
	}
	//reset the score to zero
	public static void Reset(){
		score = 0;
		// save it in XML file using key value paires
		PlayerPrefs.SetInt ("CurrentPlayerScore",score);
	}
}
