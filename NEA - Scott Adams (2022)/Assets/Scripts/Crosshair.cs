/*
* Created: Sprint 3
* Last Edited: Sprint 6
* Purpose: Creates a moving crosshair for the bow
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {

	GameObject player;
	public float angle;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);
		Vector2 mouseOnScreen = Camera.main.ScreenToViewportPoint (Input.mousePosition);
		angle = AngleBetweenTwoPoints (positionOnScreen, mouseOnScreen);
		//transform.RotateAround (player.transform.position, new Vector3 (0f, 0f, angle), Time.deltaTime * 20);
		//Sets rotation of crosshair
		transform.rotation=Quaternion.Euler(new Vector3(0f,0f,angle-90));
	}
	//Finds angle mouse is pointed in
	float AngleBetweenTwoPoints(Vector2 a,Vector2 b)
	{
		return Mathf.Atan2 (b.y - a.y, b.x - a.x) * Mathf.Rad2Deg;
	}
}
