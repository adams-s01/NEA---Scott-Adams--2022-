/*
* Created: Sprint 6
* Last Edited: Sprint 6
* Purpose: Creates a tutorial screen
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Screen : MonoBehaviour {

	GameObject tutorialscreen;
	GameObject pausescreen;

	// Use this for initialization
	void Start () {
		tutorialscreen = GameObject.FindGameObjectWithTag ("tutorialcanvas");
		pausescreen = GameObject.FindGameObjectWithTag ("pausecanvas");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Activates when exit button clicked
	public void Exit()
	{
		tutorialscreen.SetActive (false);
		pausescreen.SetActive(true);
	}
}
