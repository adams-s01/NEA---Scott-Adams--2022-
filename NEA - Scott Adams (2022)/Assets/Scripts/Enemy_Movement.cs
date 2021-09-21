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
	public int slimehealth;
	public GameObject hitpoint;
	float slimex;
	float slimey;

	// Initialises variables
	void Start () {
		sleep = false;
		rb = GetComponent<Rigidbody2D>();
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
	//Collides with player
	public void OnCollisionStay2D(Collision2D col)
	{
		//Damages slime and creates hitpoint over slime
		if (col.gameObject.tag == "Player") {
			string slimename = gameObject.name;
			slime = GameObject.Find (slimename);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				slimehealth--;
				slimex = slime.transform.position.x;
				slimey = slime.transform.position.y+2;
				Instantiate (hitpoint, new Vector2 (slimex, slimey), Quaternion.identity);
			}
			//Destroys slime if health runs out
			if (slimehealth <= 0) {
				Destroy (slime);
			}
		}
	}
}
