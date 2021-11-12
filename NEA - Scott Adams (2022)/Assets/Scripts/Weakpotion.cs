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
	float enemyhealth;
	float enemydamage;
	public GameObject other;
	Enemy_Movement other2;

	// Use this for initialization
	void Start () {
		other2 = other.GetComponent<Enemy_Movement> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D col)
	{
		if(col.gameObject.tag=="slime2"||col.gameObject.tag=="bat"||col.gameObject.tag=="skeleton")
		{
			string enemyname = gameObject.name;
			enemy = GameObject.Find (enemyname);
			enemyhealth = other2.enemyhealth / 2;
			enemydamage = other2.playerdamage / 2;
		}
	}
}
