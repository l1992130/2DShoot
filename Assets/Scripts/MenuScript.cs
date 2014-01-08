﻿using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;

		if(GUI.Button(new Rect(
			Screen.width / 2 - (buttonWidth / 2),
		    (2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),"Start!"))
		{
			Application.loadedLevel("Level1");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
