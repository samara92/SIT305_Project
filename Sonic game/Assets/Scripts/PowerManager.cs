using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerManager : MonoBehaviour {
	public GameObject powerUpButton;
	public Sprite powerUpImage;
	public Image animImage;
	public GameObject GOpowerUpAnim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

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
