using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour {

	public int playerLives;

	public int playerHealth;
	public GameObject pauseMenu;
	public void NewGame(){
		PlayerPrefs.SetInt ("playerCurrentLives",playerLives);
		PlayerPrefs.SetInt ("CurrentPlayerScore",0);
		PlayerPrefs.SetInt ("PlayerCurrentHealth", playerHealth);
		PlayerPrefs.SetInt ("PlayerMaxHealth", playerHealth);
		SceneManager.LoadScene ("Level1");
	}

	public void QuitGame(){
	
		Application.Quit ();
	}

	public void LoadMainMenu(){
	
		SceneManager.LoadScene ("MainMenu");
	}

	public void Retry(string sceneName){
		PlayerPrefs.SetInt ("playerCurrentLives",playerLives);
		PlayerPrefs.SetInt ("CurrentPlayerScore",0);
		SceneManager.LoadScene (sceneName);
	}

	public void GamePause(){
		pauseMenu.SetActive (true);
		Time.timeScale = 0;
	}
	public void GameUnPause(){
		Time.timeScale = 1;
		pauseMenu.SetActive (false);
	}
}
