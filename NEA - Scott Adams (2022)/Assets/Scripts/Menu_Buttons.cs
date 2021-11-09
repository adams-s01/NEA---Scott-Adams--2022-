/*
	 * Created: Sprint 1
	 * Last Edited: Sprint 7
	 * Purpose: Start menu buttons
	 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour {

	private GameObject menu;
	GameObject settings;
	// Initialises menu and settings canvases
	void Start () {
		menu = GameObject.FindGameObjectWithTag ("menu");
		settings = GameObject.FindGameObjectWithTag ("settingsmenu");
		settings.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Activates when start button clicked
	public void Startbutton()
	{
		Debug.Log ("Start");
		SceneManager.LoadScene (2);
	}
	//Activates when tutorial button clicked
	public void Tutorialbutton()
	{
		Debug.Log ("Tutorial");
		SceneManager.LoadScene (1);
	}
	//Activates when settings button clicked,changes to settings menu
	public void Settingsbutton()
	{
		Debug.Log ("Settings");
		menu.SetActive (false);
		settings.SetActive (true);
	}
	//Sets the difficulty for other levels
	public void Settings(string settings2)
	{
		Debug.Log (settings2);
		PlayerPrefs.SetString ("setting", settings2);
	}
}
