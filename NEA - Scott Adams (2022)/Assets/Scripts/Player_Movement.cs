/*
* Created: Sprint 1
* Last Edited: Sprint 1
* Purpose: Cause the player to move
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	Rigidbody2D rb;
	GameObject leg1;
	GameObject leg;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		leg1 = GameObject.FindGameObjectWithTag ("leg1");
		leg = GameObject.FindGameObjectWithTag ("leg");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate (Vector3.right * Time.deltaTime*2);
			if(leg1.transform.eulerAngles.y==0)
				{
				leg1.transform.Rotate(0,180,0);
				leg.transform.Rotate(0,180,0);
				}
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * Time.deltaTime * 2);
			if(leg1.transform.eulerAngles.y==180)
				{
				leg1.transform.Rotate(0,180,0);
				leg.transform.Rotate(0,180,0);
				}
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.Translate (Vector3.up);
		}
		
	}
}
