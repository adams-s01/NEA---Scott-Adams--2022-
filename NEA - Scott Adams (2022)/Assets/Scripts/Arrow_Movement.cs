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
		other2 = other.GetComponent<Crosshair> ();
		rb.velocity=transform.right;




	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision col)
	{
		Debug.Log ("destroy");
		Destroy (gameObject);

	}
}
