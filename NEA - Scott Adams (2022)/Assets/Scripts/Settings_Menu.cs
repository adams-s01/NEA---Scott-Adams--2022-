/*
* Created: Sprint 1
* Last Edited: Sprint 1
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

	// Initialises menu and settings canvases, toggles medium and hard off
	void Start () {
		menu = GameObject.FindGameObjectWithTag ("menu");
		settings = GameObject.FindGameObjectWithTag ("settingsmenu");
		medium.isOn = false;
		hard.isOn = false;
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
		}
	}
	//Checks if medium is toggled on, toggles others off
	public void Mediumtoggle()
	{
		if (medium.isOn) {
			Debug.Log ("Medium");
			easy.isOn = false;
			hard.isOn = false;
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
		}
	}
	//Activates when exit button clicked, exits back to menu
	public void Exit()
	{
		Debug.Log ("Exit");
		settings.SetActive (false);
		menu.SetActive (true);
	}
}
