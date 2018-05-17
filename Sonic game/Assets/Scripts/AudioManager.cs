using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
	public AudioSource backgroundMusic;
	public bool soundButtonState = false;

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetInt ("GameAudio") == 1) {
			soundButtonState = true;
			backgroundMusic.enabled = true;
		} else if (PlayerPrefs.GetInt ("GameAudio") == 0) {
			backgroundMusic.enabled = false;
			soundButtonState = false;
		}
	}
	public void SounOnOff(){
		
		if (soundButtonState == false) {
			
			PlayerPrefs.SetInt ("GameAudio", 1);
			backgroundMusic.enabled = true;
			soundButtonState = true;

		} else if(soundButtonState == true) {
			
			soundButtonState = false;
			PlayerPrefs.SetInt ("GameAudio", 0);
			backgroundMusic.enabled = false;
		}
	}

}
