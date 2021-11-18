/*
* Created: Sprint 5
* Last Edited: Sprint 6
* Purpose: To make the escape door work
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape_Door : MonoBehaviour {

	public GameObject closeddoor;
	public GameObject opendoor;
	public GameObject other;
	private Inventory_1 other2;

	// Use this for initialization
	void Start () {
		//closeddoor = GameObject.FindGameObjectWithTag ("closeddoor");
		//opendoor = GameObject.FindGameObjectWithTag ("opendoor");
		opendoor.SetActive (false);
		other2 = other.GetComponent<Inventory_1> ();
		Debug.Log ("2");
	}
	
	// Update is called once per frame
	void Update () {
		//Changes door from closed to open when got key
		if (other2.keytrue == true) {
			Debug.Log ("£");
			opendoor.SetActive (true);
			closeddoor.SetActive (false);

		}
	}
	//Sends player to start menu from the end door
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag=="Player"&&other2.keytrue==true)
		{
			Debug.Log ("End");
			SceneManager.LoadScene (0);
		}
	}
}
