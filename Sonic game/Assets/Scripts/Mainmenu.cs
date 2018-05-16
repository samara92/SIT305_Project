using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour {

	public void NewGame(){
		SceneManager.LoadScene ("Level1");
	}

	public void QuitGame(){
	
		Application.Quit ();
	}

	public void LoadMainMenu(){
	
		SceneManager.LoadScene ("MainMenu");
	}

	public void Retry(string sceneName){
		
		SceneManager.LoadScene (sceneName);
	}
}
