/*
* Created: Sprint 8
* Last Edited: Sprint 8
* Purpose: Causes enemies to have double damage
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Double_Damage : MonoBehaviour {

	GameObject enemy;
	public float enemydamage;
	public Enemy_Movement other2;
	bool sleep;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Increases damage for enemies within area
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag=="slime2"||col.gameObject.tag=="bat"||col.gameObject.tag=="skeleton"||col.gameObject.tag=="pumpkin")
		{
			string enemyname = col.gameObject.name;
			Debug.Log (enemyname);
			enemy = GameObject.Find (enemyname);
			other2 = enemy.GetComponent<Enemy_Movement> ();
			Debug.Log ("1");
			enemydamage = other2.playerdamage * 2;
			Debug.Log (enemydamage);
		}
	}
}
