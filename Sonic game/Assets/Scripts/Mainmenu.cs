using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour {

	public int playerLives;

	public int playerHealth;
	public GameObject pauseMenu;
	public GameObject gameoverMenu;
	//when new game button clicked load all the data from the locally saved xml file and load the level one
	public void NewGame(){
		// save it in XML file using key value paires
		PlayerPrefs.SetInt ("playerCurrentLives",playerLives);
		PlayerPrefs.SetInt ("CurrentPlayerScore",0);
		PlayerPrefs.SetInt ("PlayerCurrentHealth", playerHealth);
		PlayerPrefs.SetInt ("PlayerMaxHealth", playerHealth);
		SceneManager.LoadScene ("Level1");

		//clear the high level error log
		StaticData.ErrorLogList.Clear();
	}
	//this is the quit button clicking this will exit from the game
	public void QuitGame(){
	
		Application.Quit ();
	}
	//this method will load the main menu scene
	public void LoadMainMenu(){
	
		SceneManager.LoadScene ("MainMenu");
	}
	//when retry button click time scale is fixed to one and load all the data from the locally saved xml file 
	public void Retry(string sceneName){
		Time.timeScale = 1;
		PlayerPrefs.SetInt ("playerCurrentLives",playerLives);
		Debug.Log (playerLives + "Player Lives");
		PlayerPrefs.SetInt ("CurrentPlayerScore",0);

		SceneManager.LoadScene (sceneName);
	}
	//pause button
	public void GamePause(){
		pauseMenu.SetActive (true);
		Time.timeScale = 0;
	}
	//resume button
	public void GameUnPause(){
		Time.timeScale = 1;
		pauseMenu.SetActive (false);
	}
}
