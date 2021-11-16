/*
* Created: Sprint 8
* Last Edited: Sprint 8
* Purpose: Causes pumpkin to find location of player
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin_Raycast : MonoBehaviour {

	float startxright;
	float startxleft;
	float starty;
	public float distance;
	public bool righttrue;
	public bool lefttrue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 left = transform.TransformDirection (Vector2.left) * 10;
		Vector2 right = transform.TransformDirection (Vector2.right) * 10;
		startxright = transform.position.x + 1;
		startxleft = transform.position.x - 1;
		starty = transform.position.y;
		RaycastHit2D hitright = Physics2D.Raycast (new Vector2 (startxright, starty), right);
		RaycastHit2D hitleft = Physics2D.Raycast (new Vector2 (startxleft, starty), left);
		Debug.Log (hitright.collider.tag);
		Debug.Log (hitleft.collider.tag);
		Debug.DrawRay (new Vector2 (startxleft, starty), left, Color.green);
		Debug.DrawRay (new Vector2 (startxright, starty), right, Color.green);
		if (hitright.collider.tag == "Player") {
			distance = Mathf.Abs (hitright.point.x - transform.position.x);
			Debug.Log (distance);
			righttrue = true;
			lefttrue = false;
		}
		if (hitleft.collider.tag == "Player") {
			distance = Mathf.Abs (hitleft.point.x - transform.position.x);
			Debug.Log (distance);
			lefttrue = true;
			righttrue = false;
		}

	}
}
