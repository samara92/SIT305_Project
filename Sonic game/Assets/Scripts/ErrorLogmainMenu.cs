using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ErrorLogmainMenu : MonoBehaviour {
	public Text txtErrorLog;
	// Use this for initialization
	void Start () {
		if (StaticData.ErrorLogList.Count > 0) {
		
			txtErrorLog.text = StaticData.ErrorLogList [0];

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
