/*
* Created: Sprint 4
* Last Edited: Sprint 9
* Purpose: To make the arrow shot work
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Movement : MonoBehaviour {

	GameObject arrow;
	Rigidbody2D rb;
	public GameObject other;
	private Crosshair other2;
	float angle1;

	// Use this for initialization
	void Start () {
		arrow = GameObject.FindGameObjectWithTag ("arrow");
		rb = GetComponent<Rigidbody2D> ();
		other2 = other.GetComponent<Crosshair> ();
		//Causes arrow to move at speed in the right direction
		rb.velocity=transform.right;




	}
	
	// Update is called once per frame
	void Update () {

	}
	//Destroys arrow when it collides with anything not the player
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag != "Player" && col.gameObject.tag != "arrow") {
			Debug.Log ("destroy");
			Destroy (gameObject);
		}

	}
}
