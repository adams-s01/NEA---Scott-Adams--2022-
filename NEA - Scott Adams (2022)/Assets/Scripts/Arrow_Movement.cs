/*
* Created: Sprint 4
* Last Edited: Sprint 4
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
		rb.AddForce (new Vector2 (1, 0), ForceMode2D.Impulse);
		other2 = other.GetComponent<Crosshair> ();



	}
	
	// Update is called once per frame
	void Update () {
		angle1 = other2.angle;
		Debug.Log (angle1);
	}
}
