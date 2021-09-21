﻿/*
* Created: Sprint 1
* Last Edited: Sprint 1
* Purpose: Cause the player to move
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour {

	Rigidbody2D rb;
	GameObject leg1;
	GameObject leg;
	GameObject vase;
	public Image speedbar;
	public GameObject bow;
	bool resting;
	int speed;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		leg1 = GameObject.FindGameObjectWithTag ("leg1");
		leg = GameObject.FindGameObjectWithTag ("leg");
		vase = GameObject.FindGameObjectWithTag ("vase");
		resting = false;

		speed = 1;


	}
	
	// Update is called once per frame
	void Update () {
		//Moves right
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate (Vector3.right * speed * Time.deltaTime * 3);
			if(leg1.transform.eulerAngles.y==0)
				{
				leg1.transform.localEulerAngles = new Vector3 (0, 180, 0);
				leg.transform.localEulerAngles = new Vector3 (0, 180, 0);
				}
		}
		//Moves left
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime * 3);
			if(leg1.transform.eulerAngles.y==180)
				{
				leg1.transform.localEulerAngles = new Vector3 (0, 0, 0);
				leg.transform.localEulerAngles = new Vector3 (0, 0, 0);
				}
		}
		//Jumps
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			rb.AddForce (new Vector2 (0, 2) * 2, ForceMode2D.Impulse);

		}
		//Sprint
		if (Input.GetKey (KeyCode.LeftShift)&&resting==false) {
			speed = 10;
			speedbar.transform.localScale -= new Vector3 (0.002f, 0, 0);
			if (speedbar.transform.localScale.x <= 0) {
				StartCoroutine (restingcoroutine ());
			}
			
		}
		//Stops sprint
		if (Input.GetKey (KeyCode.LeftShift) == false) {
			speed = 1;
		}



	}
	IEnumerator restingcoroutine()
	{
		resting=true;
		speed = 1;
		speedbar.transform.localScale = new Vector3(0,0,0);
		yield return new WaitForSecondsRealtime(10);
		resting=false;
		speedbar.transform.localScale = new Vector3(1,1,1);
	}
	public void OnCollisionStay2D(Collision2D col)
	{
		if(Input.GetKeyDown(KeyCode.Mouse0)&&col.gameObject.tag=="vase")
		{
			Destroy (vase);
			Instantiate (bow, new Vector2 (vase.transform.position.x, vase.transform.position.y), Quaternion.identity);
		}
	}

}
