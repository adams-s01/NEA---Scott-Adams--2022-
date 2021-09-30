/*
* Created: Sprint 2
* Last Edited: Sprint 2
* Purpose: Causes a shop to exist
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

	GameObject shopmenu;

	//Initialises shopmenu and hides the shop menu canvas
	void Start () {
		shopmenu = GameObject.FindGameObjectWithTag ("shopmenu");
		shopmenu.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Collides with player and makes shop menu visible
	public void OnTriggerStay2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			shopmenu.SetActive (true);
		}
	}
			
	//Button to make shop menu disappear
	public void Exit()
	{
		shopmenu.SetActive (false);
	}
}
