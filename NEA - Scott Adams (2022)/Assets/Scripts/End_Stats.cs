/*
* Created: Sprint 11
* Last Edited: Sprint 11
* Purpose: Shows player's end stats
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class End_Stats : MonoBehaviour {

	public GameObject endstatscanvas;
	public TextMeshProUGUI endtimer;
	public TextMeshProUGUI endlives;
	public TextMeshProUGUI endgold;
	public GameObject other;
	Player_Movement other2;
	public GameObject other3;
	Shop other4;

	// Use this for initialization
	void Start () {
		endstatscanvas.SetActive (false);
		other2 = other.GetComponent<Player_Movement> ();
		other4 = other3.GetComponent<Shop> ();
	}
	
	// Update is called once per frame
	void Update () {
		endtimer.text = "End time: " + Time.fixedTime.ToString ("0.00");
		endlives.text = "End lives: " + other2.lives;
		endgold.text = "End gold: " + other4.gold;
	}
	//Button to send the player back to the start screen
	public void Return()
	{
		SceneManager.LoadScene (0);
	}
}
