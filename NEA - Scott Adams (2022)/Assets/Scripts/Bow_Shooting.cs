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
	public GameObject other;
	private Crosshair other2;
	float angle1;

	// Use this for initialization
	void Start () {
		arrow = GameObject.FindGameObjectWithTag ("arrow");
		player = GameObject.FindGameObjectWithTag ("Player");
		other2 = other.GetComponent<Crosshair> ();
	}
	
	// Update is called once per frame
	void Update () {
		angle1 = other2.angle;
		playerx = player.transform.position.x;
		playery = player.transform.position.y;
		if (Input.GetKey (KeyCode.Mouse0)) {
			Instantiate (arrow, new Vector2 (playerx, playery), Quaternion.identity, angle1);
		}
	}
}
