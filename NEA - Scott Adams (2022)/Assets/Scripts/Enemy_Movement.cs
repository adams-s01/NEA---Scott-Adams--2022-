﻿/*
* Created: Sprint 1
* Last Edited: Sprint 3
* Purpose: Causes the enemy to move
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour {

	Rigidbody2D rb;
	GameObject enemy;
	bool sleep;
	public int enemyhealth;
	public GameObject hitpoint;
	float enemyx;
	float enemyy;
	public GameObject other;
	int damage1;
	public int playerdamage;



	// Initialises variables
	void Start () {
		sleep = false;
		rb = GetComponent<Rigidbody2D>();



	}
	
	// Calls slime movement sets GameObject to call other script
	void Update () {
		if (gameObject.tag=="slime") {
			SlimeMovement ();
		}
		if (gameObject.tag=="slime2") {
			SlimeMovement2 ();
		}
		if (gameObject.tag == "bat") {
			BatMovement ();
		}
		other = GameObject.FindGameObjectWithTag ("inventory");



	}
	//Calls coroutine for slime to jump
	public void SlimeMovement()
	{
		if (sleep == false) {
			StartCoroutine (coroutine ());
		}


	}
	//Calls coroutine for slime2 to jump
	public void SlimeMovement2()
	{
		if (sleep == false) {
			StartCoroutine (coroutine2 ());
		}


	}
	//Calls coroutine for bat to move
	public void BatMovement()
	{
		if (sleep == false) {
			StartCoroutine (batcoroutine ());
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
	//Coroutine for causing the slime2 to move every 5 seconds
	IEnumerator coroutine2()
	{
		sleep = true;
		yield return new WaitForSecondsRealtime (5);
		rb.AddForce (new Vector2 (Random.Range(-1,2), 2) * 2, ForceMode2D.Impulse);
		sleep = false;
	}
	//Coroutine for causing the bat to move
	IEnumerator batcoroutine()
	{
		sleep = true;
		rb.AddForce (new Vector2 (-1, 0) * 2, ForceMode2D.Impulse);
		yield return new WaitForSecondsRealtime (4);
		rb.velocity = Vector2.zero;
		rb.AddForce (new Vector2 (1, 0) * 2, ForceMode2D.Impulse);
		yield return new WaitForSecondsRealtime (4);
		rb.velocity = Vector2.zero;
		sleep = false;
	}
	//Collides with player
	public void OnCollisionStay2D(Collision2D col)
	{
		//Damages enemy and creates hitpoint over enemy,setting damage from Inventory_1
		if (col.gameObject.tag == "Player") {
			
			string enemyname = gameObject.name;
			enemy = GameObject.Find (enemyname);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				damage1 = other.GetComponent<Inventory_1> ().damage;
				Debug.Log("Damage"+damage1);
				enemyhealth=enemyhealth-damage1;
				Debug.Log (enemyhealth);
				enemyx = enemy.transform.position.x;
				enemyy = enemy.transform.position.y+2;
				Instantiate (hitpoint, new Vector2 (enemyx, enemyy), Quaternion.identity);
			}
			//Destroys slime if health runs out
			if (enemyhealth <= 0) {
				Destroy (enemy);
			}
			//Sets the damage to the palyer
			if (gameObject.tag == "slime2") {
				playerdamage = 1;
			}
			if (gameObject.tag == "bat") {
				playerdamage = 1;
			}
		}
	}
	//Collides with the wall, stops the slime leaviing the room
	public void OnTriggerStay2D(Collider2D col)
	{
		if (col.gameObject.tag == "wall") {
			rb.velocity = Vector2.zero;
		}
	}
	//Ends collide with the player, stops the damage of the player
	public void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player") {
			if (gameObject.tag == "slime2") {
				playerdamage = 0;
			}
		}
	}
}
