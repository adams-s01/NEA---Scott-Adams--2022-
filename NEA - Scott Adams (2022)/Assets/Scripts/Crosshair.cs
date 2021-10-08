using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {

	GameObject crosshair;
	GameObject player;

	// Use this for initialization
	void Start () {
		crosshair = GameObject.FindGameObjectWithTag ("crosshair");
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);
		Vector2 mouseOnScreen = Camera.main.ScreenToViewportPoint (Input.mousePosition);
		float angle = AngleBetweenTwoPoints (positionOnScreen, mouseOnScreen);
		transform.RotateAround (player.transform.position, new Vector3 (0f, 0f, angle),Quaternion.Euler);
	}
	float AngleBetweenTwoPoints(Vector2 a,Vector2 b)
	{
		return Mathf.Atan2 (a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
