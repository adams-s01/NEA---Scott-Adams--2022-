/*
* Created: Sprint 4
* Last Edited: Sprint 4
* Purpose: To make the bow shoot an arrow
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow_Shooting : MonoBehaviour {

	GameObject arrow;
	float playerx;
	float playery;
	GameObject player;

	// Use this for initialization
	void Start () {
		arrow = GameObject.FindGameObjectWithTag ("arrow");
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		playerx = player.transform.position.x;
		playery = player.transform.position.y;
		if (Input.GetKey (KeyCode.Mouse0)) {
			Instantiate (arrow, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
}
