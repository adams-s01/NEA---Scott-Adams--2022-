/*
* Created: Sprint 6
* Last Edited: Sprint 6
* Purpose: To make the spikes work
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

	GameObject spike;
	public int playerdamage;

	// Use this for initialization
	void Start () {
		spike = GameObject.FindGameObjectWithTag ("spikes");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Damages player when they land on the spikes
	void OnCollisionStay2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player"&&gameObject.tag=="spikes") {
			playerdamage = 1;
			col.gameObject.SendMessage ("Damage", playerdamage);
		}
	}
}
