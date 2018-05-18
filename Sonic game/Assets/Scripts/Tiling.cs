﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Tiling : MonoBehaviour {

	public int offsetX = 2;
	public bool hasRightBuddy = false;
	public bool hasLeftBuddy = false;

	public bool reverseScale = false;
	private float spriteWidth = 0f;

	private Camera cam;
	private Transform myTransform;
	// Use this for initialization

	void Awake(){
	
		cam = Camera.main;
		myTransform = transform;
	}
	void Start () {
		SpriteRenderer sRenderer = GetComponent<SpriteRenderer> ();
		spriteWidth = sRenderer.sprite.bounds.size.x;
	}
	
	// Update is called once per frame
	void Update () {

		if (hasLeftBuddy == false || hasRightBuddy == false) {
			float camHorizontalExtend = cam.orthographicSize * Screen.width / Screen.height;

			float edgeVisiblePositionRight = (myTransform.position.x + spriteWidth / 2) - camHorizontalExtend;
		
			float edgeVisiblePositionLeft = (myTransform.position.x + spriteWidth / 2) + camHorizontalExtend;
		
			if (cam.transform.position.x >= edgeVisiblePositionRight - offsetX && hasRightBuddy == false) {
				MakeNewBuddy (1);
				hasRightBuddy = true;
			}else if(cam.transform.position.x <= edgeVisiblePositionLeft - offsetX && hasLeftBuddy == false){
				MakeNewBuddy (-1);
				hasLeftBuddy = true;
			}

		}
	}

	void MakeNewBuddy(int rightOrLeft){
	
		Vector3 newPosition = new Vector3 (myTransform.position.x + spriteWidth * rightOrLeft,
			                      myTransform.position.y, myTransform.position.z);
	
		Transform newBuddy = (Transform)Instantiate (myTransform, newPosition, myTransform.rotation)as Transform;
		newBuddy.parent = myTransform.parent;

		if (rightOrLeft > 0) {

			newBuddy.GetComponent<Tiling> ().hasLeftBuddy = true;
		} else {
		
			newBuddy.GetComponent<Tiling> ().hasRightBuddy = true;
		}
	}
}
