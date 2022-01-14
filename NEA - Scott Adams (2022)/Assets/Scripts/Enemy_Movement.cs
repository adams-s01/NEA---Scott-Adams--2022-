/*
* Created: Sprint 1
* Last Edited: Sprint 13
* Purpose: Causes the enemy to move
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_Movement : MonoBehaviour {

	Rigidbody2D rb;
	GameObject enemy;
	bool sleep;
	public float enemyhealth;
	public GameObject hitpoint;
	public float enemyx;
	public float enemyy;
	public GameObject other;
	int damage1;
	public float playerdamage;
	public bool spawnerfalse;
	public GameObject coin;
	public GameObject coin2;
	public GameObject coin3;
	public GameObject ring2;
	string setting;
	public GameObject[] hitpoints;
	int enemyhealthdifficulty;
	int enemydamagedifficulty;
	public GameObject other2;
	Weakpotion other3;
	bool weaktrue;
	public GameObject blind;
	GameObject blindarea;
	public bool sleep1;
	Pumpkin_Raycast other4;
	float distance1;
	bool doubledamagetrue;
	public GameObject other5;
	Double_Damage other6;
	float timer;
	public GameObject blindinstantiated;
	public GameObject ring5;

	// Initialises variables
	void Start () {
		sleep = false;
		sleep1 = false;
		rb = GetComponent<Rigidbody2D> ();
		setting = PlayerPrefs.GetString ("setting", "easy");
		Debug.Log ("1"+setting);
		//Sets enemy settings for easy(low health and attack)
		if (setting == "easy") {
			enemyhealthdifficulty = 1;
			enemydamagedifficulty = 1;
		}
		//Sets enemy settings for medium(high health and low attack)
		if (setting == "medium") {
			enemyhealthdifficulty = 2;
			enemydamagedifficulty = 1;
		}
		//Sets enemy settings for hard(high health and attack)
		if (setting == "hard") {
			enemyhealthdifficulty = 2;
			enemydamagedifficulty = 2;
		}
		enemyhealth = enemyhealth * enemyhealthdifficulty;
		playerdamage = 1;
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
		if (gameObject.tag == "skeleton") {
			SkeletonMovement ();
		}
		other = GameObject.FindGameObjectWithTag ("inventory");
		//PlayerPrefs.SetInt ("playerdamage", playerdamage);
		//Determines distance between player and pumpkin
		if (gameObject.tag == "pumpkin") {
			other4 = GetComponent<Pumpkin_Raycast> ();
			distance1 = other4.distance;
			//Determines which way to move
			if (distance1 == 0) {
				rb.velocity = Vector2.zero;
			} else {
				if (other4.righttrue == true) {
					rb.velocity = Vector2.right;
				} else if (other4.lefttrue == true) {
					rb.velocity = Vector2.left;
				}
			}
		}



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
	//Calls coroutine for skeleton to move
	public void SkeletonMovement()
	{
		if (sleep == false) {
			StartCoroutine (skeletoncoroutine ());
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
	//Coroutine for causing the skeleton to move
	IEnumerator skeletoncoroutine()
	{
		sleep = true;
		rb.velocity = new Vector2 (Random.Range (-5, 6), 0);
		yield return new WaitForSecondsRealtime (2);
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
				//Debug.Log (enemyhealth);
				enemyx = enemy.transform.position.x;
				enemyy = enemy.transform.position.y+2;
				Instantiate (hitpoints[damage1], new Vector2 (enemyx, enemyy), Quaternion.identity);
			}
			//Destroys slime if health runs out
			if (enemyhealth <= 0) {
				Destroy (enemy);
				//Debug.Log (enemy);
				enemyx = enemy.transform.position.x;
				enemyy = enemy.transform.position.y;
				//Gives coin when slime2 types destroyed
				if(gameObject.tag=="slime2")
				{
					Instantiate (coin, new Vector2 (enemyx, enemyy), Quaternion.identity);
					//Gives ring 5 when in level 2
					if (SceneManager.GetActiveScene ().buildIndex == 3 && enemy.name == "Slime3") {
						Instantiate (ring5, new Vector2 (enemyx, enemyy), Quaternion.identity);
						Debug.Log ("22344");
					}
				}
				//Gives coin2 when bat types destroyed
				if(gameObject.tag=="bat")
				{
					Instantiate (coin2, new Vector2 (enemyx, enemyy), Quaternion.identity);
				}
				//Gives coin3 when skeleton types destroyed
				if(gameObject.tag=="skeleton")
				{
					Instantiate (coin3, new Vector2 (enemyx, enemyy), Quaternion.identity);
				}
				//Gives coin2 when pumpkin types destroyed and gives blind debuff
				if (gameObject.tag == "pumpkin") {
					Instantiate (coin2, new Vector2 (enemyx, enemyy), Quaternion.identity);
					Instantiate (ring2, new Vector2 (enemyx, enemyy), Quaternion.identity);
					blindinstantiated = Instantiate (blind, new Vector2 (enemyx, enemyy), Quaternion.identity);
				}
			}
			//Sets the damage to the player for slime2
			if (gameObject.tag == "slime2") {
				playerdamage = playerdamage * enemydamagedifficulty;
				col.gameObject.SendMessage ("Damage", playerdamage);
			}
			//Sets the damage to the player for skeleton
			if (gameObject.tag == "skeleton") {
				playerdamage = playerdamage * enemydamagedifficulty;
				col.gameObject.SendMessage ("Damage", playerdamage);
			}
			//Sets the damage to the player for pumpkin
			if (gameObject.tag == "pumpkin") {
				playerdamage = playerdamage * enemydamagedifficulty;
				col.gameObject.SendMessage ("Damage", playerdamage);
			}
		}

	}
	//Collides with the wall, stops the slime leaviing the room
	public void OnTriggerStay2D(Collider2D col)
	{
		//When enemy collides with wall
		if (col.gameObject.tag == "wall") {
			rb.velocity = Vector2.zero;
		}
		//When enemy collides with player
		if (col.gameObject.tag == "Player") {
			//Sets the damage for the player for bat
			if (gameObject.tag == "bat") {
				playerdamage = playerdamage * enemydamagedifficulty;
				col.gameObject.SendMessage ("Damage", playerdamage);
			}
			string enemyname = gameObject.name;
			enemy = GameObject.Find (enemyname);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				damage1 = other.GetComponent<Inventory_1> ().damage;
				Debug.Log("Damage"+damage1);
				enemyhealth=enemyhealth-damage1;
				Debug.Log (enemyhealth);
				enemyx = enemy.transform.position.x;
				enemyy = enemy.transform.position.y+2;
				Instantiate (hitpoints[damage1], new Vector2 (enemyx, enemyy), Quaternion.identity);
			}
			//Copy of code for collision
			if (enemyhealth <= 0) {
				Destroy (enemy);
				enemyx = enemy.transform.position.x;
				enemyy = enemy.transform.position.y;
				if(gameObject.tag=="slime2")
				{
					Instantiate (coin, new Vector2 (enemyx, enemyy), Quaternion.identity);
				}
				if(gameObject.tag=="bat")
				{
					Instantiate (coin2, new Vector2 (enemyx, enemyy), Quaternion.identity);
				}
				if(gameObject.tag=="skeleton")
				{
					Instantiate (coin3, new Vector2 (enemyx, enemyy), Quaternion.identity);
				}
				if (gameObject.tag == "pumpkin") {
					Instantiate (coin2, new Vector2 (enemyx, enemyy), Quaternion.identity);
					/*if (sleep1 == false) {
						StartCoroutine (removeblindcoroutine ());
						Debug.Log ("call made");
					}*/
				}
			}
		}
		//If enemy is in weakness field, make them weak
		if (col.gameObject.tag == "weak"&&weaktrue==false) {
			string enemyname = gameObject.name;
			enemy = GameObject.Find (enemyname);
			other2=col.gameObject;
			other3 = other2.GetComponent<Weakpotion> ();
			enemyhealth = other3.enemyhealth;
			playerdamage = other3.enemydamage;
			weaktrue = true;
		}
		//If enemy is in double damage field, make them have double damage
		if (col.gameObject.tag == "doubledamage") {
			string enemyname = gameObject.name;
			enemy = GameObject.Find (enemyname);
			other5=col.gameObject;
			other6 = other5.GetComponent<Double_Damage> ();
			playerdamage = other6.enemydamage;
		}
	}
	//Ends collide with the player, stops the damage of the player
	public void OnCollisionExit2D(Collision2D col)
	{
		//When enemy stops colliding with player
		if (col.gameObject.tag == "Player") {
			
			if (gameObject.tag == "slime2"||gameObject.tag=="bat"||gameObject.tag=="skeleton") {
				playerdamage = 0;
				col.gameObject.SendMessage ("Damage", playerdamage);
			}
		}
	}
	//Starts collision with the enemy, from the arrow
	public void OnTriggerEnter2D(Collider2D col)
	{
		//Damages enemy same way as player but when collides with arrow
		if (col.gameObject.name == "Arrow(Clone)") {
			string enemyname = gameObject.name;
			enemy = GameObject.Find (enemyname);
			enemyhealth = enemyhealth - 2;
			enemyx = enemy.transform.position.x;
			enemyy = enemy.transform.position.y + 2;
			Instantiate (hitpoints[2], new Vector2 (enemyx, enemyy), Quaternion.identity);
		}
		if (col.gameObject.name == "Arrow2(Clone)") {
			string enemyname = gameObject.name;
			enemy = GameObject.Find (enemyname);
			enemyhealth = enemyhealth - 4;
			enemyx = enemy.transform.position.x;
			enemyy = enemy.transform.position.y + 2;
			Instantiate (hitpoints[4], new Vector2 (enemyx, enemyy), Quaternion.identity);
		}
		if (col.gameObject.name == "Arrow3(Clone)") {
			string enemyname = gameObject.name;
			enemy = GameObject.Find (enemyname);
			enemyhealth = enemyhealth - 5;
			enemyx = enemy.transform.position.x;
			enemyy = enemy.transform.position.y + 2;
			Instantiate (hitpoints[5], new Vector2 (enemyx, enemyy), Quaternion.identity);
		}
	}
	//Waits for 5 seconds to remove the blind area
	IEnumerator removeblindcoroutine()
	{
		sleep1 = true;
		blindarea = Instantiate (blind, new Vector2 (enemyx, enemyy), Quaternion.identity);
		yield return new WaitForSecondsRealtime (5);
		Destroy (blindarea);
		sleep1 = false;
	}
}
