using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAnimationStop : MonoBehaviour {

	public GameObject ImageHolder;

	public void StopAnimation(){
		ImageHolder.SetActive (false);
	}
}
