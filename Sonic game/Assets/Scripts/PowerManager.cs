using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerManager : MonoBehaviour {
	public GameObject powerUpButton;
	public Sprite powerUpImage;
	public Image animImage;
	public GameObject GOpowerUpAnim;
	//The object must have a collider and set it's settings to Is trigger in order to run this  has this mettod.This method will get the collider that will clash with it.
	void OnTriggerEnter2D(Collider2D col){

		if (col.name == "Player") {
			powerUpButton.SetActive(true);
			animImage.sprite = powerUpImage;
			GOpowerUpAnim.GetComponent<Image> ().enabled = false;
			GOpowerUpAnim.SetActive (true);
			//TO DO: Optimise
			Destroy (gameObject);
		}
	}
}
