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
	public Inventory_1 other;
	public int damage;

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
		//Damages enemy and creates hitpoint over enemy
		if (col.gameObject.tag == "Player") {
			
			string enemyname = gameObject.name;
			enemy = GameObject.Find (enemyname);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				other.Weapon (damage);
				slimehealth=slimehealth-damage;
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
