/*
* Created: Sprint 7
* Last Edited: Sprint 7
* Purpose: Causes enemies to be weakened in certain area
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weakpotion : MonoBehaviour {

	GameObject enemy;
	public float enemyhealth;
	public float enemydamage;
	Enemy_Movement other2;
	bool sleep;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Reduces stats for enemies when in weakness field
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag=="slime2"||col.gameObject.tag=="bat"||col.gameObject.tag=="skeleton"||col.gameObject.tag=="pumpkin")
		{
			string enemyname = col.gameObject.name;
			enemy = GameObject.Find (enemyname);
			other2 = enemy.GetComponent<Enemy_Movement> ();
			enemyhealth = other2.enemyhealth / 2;
			enemydamage = other2.playerdamage / 2;
		}
	}

}
