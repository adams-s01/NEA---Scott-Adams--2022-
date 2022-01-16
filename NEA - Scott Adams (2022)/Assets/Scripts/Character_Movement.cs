/*
* Created: Sprint 13
* Last Edited: Sprint 13
* Purpose: Causes character in start screen to move
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour {

	Transform character;

	// Use this for initialization
	void Start () {
		character = GameObject.FindGameObjectWithTag ("character").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * 3);
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag=="teleport")
		{
			character.SetPositionAndRotation (new Vector2 (6.16f, -1.49f), Quaternion.identity);
		}
	}
}
