/*
* Created: Sprint 1
* Last Edited: Sprint 1
* Purpose: Causes the enemy to move
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour {

	Rigidbody2D rb;
	GameObject slime;
	bool sleep;

	// Initialises variables
	void Start () {
		sleep = false;
		rb = GetComponent<Rigidbody2D>();
		slime = GameObject.FindGameObjectWithTag ("slime");
	}
	
	// Calls slime movement
	void Update () {
		SlimeMovement ();

	}
	//Calls coroutine for slime to jump
	public void SlimeMovement()
	{
		if (sleep == false) {
			StartCoroutine (coroutine ());
		}


	}
	//Coroutine for causing the slime to jump every 5 seconds
	IEnumerator coroutine()
	{
		sleep = true;
		yield return new WaitForSecondsRealtime (5);
		rb.AddForce (new Vector2 (0, 2) * 2, ForceMode2D.Impulse);
		sleep = false;
	}
}
