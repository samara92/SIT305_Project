using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
	public AudioSource backgroundMusic;
	public bool soundButtonState = false;

	// Use this for initialization
	void Start () {
		// get saved int in XML file using key 
		if (PlayerPrefs.GetInt ("GameAudio") == 1) {
			soundButtonState = true;
			backgroundMusic.enabled = true;
		} else if (PlayerPrefs.GetInt ("GameAudio") == 0) {
			backgroundMusic.enabled = false;
			soundButtonState = false;
		}
	}
	//check set the state of the button using XML local storage file.
	public void SounOnOff(){
		//if button state is false set XML data to one and enable bboleans.we store the state of the button in local storage because we need to know the button state when we load a new secene.
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
