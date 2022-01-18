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
	public GameObject coin;

	// Use this for initialization
	void Start () {
		character = GameObject.FindGameObjectWithTag ("character").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * 3);
	}
	//Teleports the player when they collide with the teleport
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag=="teleport")
		{
			character.SetPositionAndRotation (new Vector2 (6.16f, -1.49f), Quaternion.identity);
			Instantiate (coin, new Vector2 (1.2f, -3.37f), Quaternion.identity);
			Instantiate (coin, new Vector2 (-5.41f, -4.28f), Quaternion.identity);
			Instantiate (coin, new Vector2 (3.58f, -3.37f), Quaternion.identity);
			Instantiate (coin, new Vector2 (10.66f, -4.78f), Quaternion.identity);
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag=="coin")
		{
			Destroy (col.gameObject);
		}
	}
}
