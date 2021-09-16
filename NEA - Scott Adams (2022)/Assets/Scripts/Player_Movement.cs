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
	int speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		leg1 = GameObject.FindGameObjectWithTag ("leg1");
		leg = GameObject.FindGameObjectWithTag ("leg");
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
				Debug.Log (leg1.transform.eulerAngles.y);
				leg1.transform.localEulerAngles = new Vector3 (0, 180, 0);
				leg.transform.localEulerAngles = new Vector3 (0, 180, 0);
				}
		}
		//Moves left
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime * 3);
			if(leg1.transform.eulerAngles.y==180)
				{
				Debug.Log (leg1.transform.eulerAngles.y);
				leg1.transform.localEulerAngles = new Vector3 (0, 0, 0);
				leg.transform.localEulerAngles = new Vector3 (0, 0, 0);
				}
		}
		//Jumps
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			rb.AddForce (new Vector2 (0, 2) * 2, ForceMode2D.Impulse);

		}
		//Sprint
		if (Input.GetKey (KeyCode.LeftShift)) {
			speed = 10;
		}
		if (Input.GetKey (KeyCode.LeftShift) == false) {
			speed = 1;
		}
	}
}
