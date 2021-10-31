/*
* Created: Sprint 5
* Last Edited: Sprint 5
* Purpose: To make the escape door work
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape_Door : MonoBehaviour {

	GameObject closeddoor;
	GameObject opendoor;
	public GameObject other;
	private Inventory_1 other2;

	// Use this for initialization
	void Start () {
		closeddoor = GameObject.FindGameObjectWithTag ("closeddoor");
		opendoor = GameObject.FindGameObjectWithTag ("opendoor");
		opendoor.SetActive (false);
		other2 = other.GetComponent<Inventory_1> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (other2.keytrue == true) {
			Debug.Log ("£");
			closeddoor.SetActive (false);
			opendoor.SetActive (true);
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag=="Player"&&other2.keytrue==true)
		{
			Debug.Log ("End");
		}
	}
}
