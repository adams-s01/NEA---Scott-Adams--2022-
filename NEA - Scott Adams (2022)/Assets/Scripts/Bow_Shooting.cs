/*
* Created: Sprint 4
* Last Edited: Sprint 13
* Purpose: To make the bow shoot an arrow
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow_Shooting : MonoBehaviour {

	GameObject arrow;
	public GameObject arrow2;
	public GameObject arrow3;
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
		//Sets angle to shoot arrow based on crosshair
		angle1 = other2.angle;
		playerx = player.transform.position.x;
		playery = player.transform.position.y;
		if (Input.GetKeyDown (KeyCode.Mouse0)&&gameObject.name=="Bow11") {
			Instantiate (arrow, new Vector2 (playerx, playery), Quaternion.Euler (0, 0, angle1));
		}
		if (Input.GetKeyDown (KeyCode.Mouse0)&&gameObject.name=="bow2") {
			Instantiate (arrow2, new Vector2 (playerx, playery), Quaternion.Euler (0, 0, angle1));
		}
		if (Input.GetKeyDown (KeyCode.Mouse0)&&gameObject.name=="bow3") {
			Instantiate (arrow3, new Vector2 (playerx, playery), Quaternion.Euler (0, 0, angle1));
		}
	}
}
