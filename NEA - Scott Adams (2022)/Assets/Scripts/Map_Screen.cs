/*
* Created: Sprint 8
* Last Edited: Sprint 8
* Purpose: Creates a map screen
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Screen : MonoBehaviour {

	GameObject mapscreen;
	GameObject pausescreen;

	// Use this for initialization
	void Start () {
		mapscreen = GameObject.FindGameObjectWithTag ("mapcanvas");
		pausescreen = GameObject.FindGameObjectWithTag ("pausecanvas");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Activates when exit button clicked
	public void Exit()
	{
		mapscreen.SetActive (false);
		pausescreen.SetActive(true);
	}
}
