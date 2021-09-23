/*
* Created: Sprint 1
* Last Edited: Sprint 2
* Purpose: Change canvases holding tutorial
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorials : MonoBehaviour {

	GameObject move;
	GameObject sprint;
	GameObject jump;
	GameObject sprint2;

	bool left;
	bool right;
	bool moving;
	bool sprinting;

	// Initialises canvases and variables
	void Start () {
		move = GameObject.FindGameObjectWithTag ("move");
		sprint = GameObject.FindGameObjectWithTag ("sprint");
		jump = GameObject.FindGameObjectWithTag ("jump");
		sprint2 = GameObject.FindGameObjectWithTag ("sprint2");

		sprint.SetActive (false);
		jump.SetActive (false);
		sprint2.SetActive (false);
		left = false;
		right = false;
		moving = false;
		sprinting = false;
	}
	
	// Checks whether the requirements for tutorial canvas is met then switches canvas
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			left = true;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			right = true;
		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			sprinting = true;
		}
		if (left == true && right == true) {
			move.SetActive (false);
			sprint.SetActive (true);
			moving = true;
		}
		if (sprinting == true&&moving==true) {
			sprint.SetActive (false);
			jump.SetActive (true);
		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			sprint2.SetActive (true);

		}
		if (Input.GetKey (KeyCode.LeftShift) == false) {
			sprint2.SetActive (false);
		}

		
	}
}
