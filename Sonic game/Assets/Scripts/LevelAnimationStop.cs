using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAnimationStop : MonoBehaviour {

	public GameObject ImageHolder;
	//activating game load image Level Animation
	public void StopAnimation(){
		ImageHolder.SetActive (false);
	}
}
