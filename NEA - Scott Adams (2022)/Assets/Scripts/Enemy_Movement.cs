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
	GameObject enemy;
	bool sleep;
	public int slimehealth;
	public GameObject hitpoint;
	float enemyx;
	float enemyy;
	public GameObject other;
	int damage1;


	// Initialises variables
	void Start () {
		sleep = false;
		rb = GetComponent<Rigidbody2D>();



	}
	
	// Calls slime movement sets GameObject to call other script
	void Update () {
		SlimeMovement ();
		other = GameObject.FindGameObjectWithTag ("inventory");



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
		//Damages enemy and creates hitpoint over enemy,setting damage from Inventory_1
		if (col.gameObject.tag == "Player") {
			
			string enemyname = gameObject.name;
			enemy = GameObject.Find (enemyname);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				damage1 = other.GetComponent<Inventory_1> ().damage;
				Debug.Log("Damage"+damage1);
				slimehealth=slimehealth-damage1;
				Debug.Log (slimehealth);
				enemyx = enemy.transform.position.x;
				enemyy = enemy.transform.position.y+2;
				Instantiate (hitpoint, new Vector2 (enemyx, enemyy), Quaternion.identity);
			}
			//Destroys slime if health runs out
			if (slimehealth <= 0) {
				Destroy (enemy);
			}
		}
	}
}
