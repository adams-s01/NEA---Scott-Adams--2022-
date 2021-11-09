/*
* Created: Sprint 1
* Last Edited: Sprint 7
* Purpose: Settings menu buttons,changes difficulty and goes back to menu
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings_Menu : MonoBehaviour {

	public Toggle easy;
	public Toggle medium;
	public Toggle hard;
	GameObject menu;
	GameObject settings;
	public string settings2;

	// Initialises menu and settings canvases, toggles medium and hard off
	void Start () {
		
		medium.isOn = false;
		hard.isOn = false;
	}
	//Initialises menu and settings when they are awake
	void Awake()
	{
		menu = GameObject.FindGameObjectWithTag ("menu");
		settings = GameObject.FindGameObjectWithTag ("settingsmenu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Checks if easy is toggled on,toggles others off
	public void Easytoggle()
	{
		if(easy.isOn)
		{
			Debug.Log ("Easy");
			medium.isOn = false;
			hard.isOn = false;
			settings2 = "easy";
			gameObject.SendMessage ("Settings", settings2);
		}
	}
	//Checks if medium is toggled on, toggles others off
	public void Mediumtoggle()
	{
		if (medium.isOn) {
			Debug.Log ("Medium");
			easy.isOn = false;
			hard.isOn = false;
			settings2 = "medium";
			gameObject.SendMessage ("Settings", settings2);
		}
	}
	//Checks if hard is toggled on, toggles others off
	public void Hardtoggle()
	{
		if(hard.isOn)
		{
			Debug.Log ("Hard");
			easy.isOn = false;
			medium.isOn = false;
			settings2 = "hard";
			gameObject.SendMessage ("Settings", settings2);
		}
	}
	//Activates when exit button clicked, exits back to menu
	public void Exit()
	{
		Debug.Log ("Exit");
		menu.SetActive (true);
		settings.SetActive (false);

	}
}
