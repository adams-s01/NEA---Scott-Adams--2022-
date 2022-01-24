/*
* Created: Sprint 6
* Last Edited: Sprint 8
* Purpose: Creates a pause menu
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Pause : MonoBehaviour {

	public GameObject pausescreen;
	public GameObject inventorycanvas;
	public GameObject shopcanvas;
	public GameObject tutorialscreen;
	public GameObject mapscreen;
	public GameObject soundcanvas;
	public TextMeshProUGUI timer;
	public TextMeshProUGUI lives;
	public TextMeshProUGUI gold;
	public GameObject other;
	Player_Movement other2;
	public GameObject other3;
	Shop other4;
	public GameObject unmutebutton;
	public GameObject unmutesoundbutton;

	// Use this for initialization
	void Start () {
		//pausescreen = GameObject.FindGameObjectWithTag ("pausecanvas");
		//inventorycanvas = GameObject.FindGameObjectWithTag ("inventory");
		//shopcanvas = GameObject.FindGameObjectWithTag ("shopmenu");
		//tutorialscreen = GameObject.FindGameObjectWithTag ("tutorialcanvas");
		//mapscreen = GameObject.FindGameObjectWithTag ("mapcanvas");
		pausescreen.SetActive (false);
		tutorialscreen.SetActive (false);
		mapscreen.SetActive (false);
		soundcanvas.SetActive (false);
		unmutebutton.SetActive (false);
		unmutesoundbutton.SetActive (false);
		other2 = other.GetComponent<Player_Movement> ();
		other4 = other3.GetComponent<Shop> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer.text = "Time: " + Time.fixedTime.ToString ("0.00");
		lives.text = "Lives: " + other2.lives;
		gold.text = "Gold: " + other4.gold;
		//Makes pause canvas visible if escape button clicked
		if (Input.GetKey (KeyCode.Escape)) {
			pausescreen.SetActive (true);
			inventorycanvas.SetActive (false);
			shopcanvas.SetActive (false);
			Time.timeScale = 0;
		}
	}
	//Activates when pause button pressed
	public void Pause1()
	{
		pausescreen.SetActive(true);
		inventorycanvas.SetActive (false);
		shopcanvas.SetActive (false);
		Time.timeScale=0;
	}
	//Activates when resume button clicked
	public void Resume()
	{
		pausescreen.SetActive (false);
		inventorycanvas.SetActive (true);
		Time.timeScale = 1;
	}
	//Activates when tutorial button clicked
	public void Tutorial()
	{
		pausescreen.SetActive (false);
		tutorialscreen.SetActive (true);
		mapscreen.SetActive (false);
	}
	//Activates when map button clicked
	public void Map()
	{
		pausescreen.SetActive (false);
		tutorialscreen.SetActive (false);
		mapscreen.SetActive (true);
	}
	//Activates when sound button clicked
	public void Sound()
	{
		pausescreen.SetActive (false);
		soundcanvas.SetActive (true);
	}
	//Activates when exit on sound canvas clicked
	public void ExitSound()
	{
		pausescreen.SetActive (true);
		soundcanvas.SetActive (false);
	}
	//Activates when exit button clicked
	public void Exit()
	{
		SceneManager.LoadScene (0);
	}
}
