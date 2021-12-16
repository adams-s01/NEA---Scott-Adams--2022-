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
			if (other2.image.sprite != null) {
				PlayerPrefs.SetString ("inventory1", other2.image.sprite.name);
			}
			if (other2.image2.sprite != null) {
				PlayerPrefs.SetString ("inventory2", other2.image2.sprite.name);
			}
			if (other2.image3.sprite != null) {
				PlayerPrefs.SetString ("inventory3", other2.image3.sprite.name);
			}
			if (other2.image4.sprite != null) {
				PlayerPrefs.SetString ("inventory4", other2.image4.sprite.name);
			}
			if (other2.image5.sprite != null) {
				PlayerPrefs.SetString ("inventory5", other2.image5.sprite.name);
			}
			if (other2.armourimage.sprite != null) {
				PlayerPrefs.SetString ("armourimage", other2.armourimage.sprite.name);
			}
			if (other2.glovesimage.sprite != null) {
				PlayerPrefs.SetString ("glovesimage", other2.glovesimage.sprite.name);
			}
			if (other2.bootsimage.sprite != null) {
				PlayerPrefs.SetString ("bootsimage", other2.bootsimage.sprite.name);
			}
			if (other2.image.sprite == null) {
				PlayerPrefs.SetString ("inventory1", null);
			}
			if (other2.image2.sprite == null) {
				PlayerPrefs.SetString ("inventory2", null);
			}
			if (other2.image3.sprite == null) {
				PlayerPrefs.SetString ("inventory3", null);
			}
			if (other2.image4.sprite == null) {
				PlayerPrefs.SetString ("inventory4", null);
			}
			if (other2.image5.sprite == null) {
				PlayerPrefs.SetString ("inventory5", null);
			}
			if (other2.armourimage.sprite == null) {
				PlayerPrefs.SetString ("armourimage", null);
			}
			if (other2.glovesimage.sprite == null) {
				PlayerPrefs.SetString ("glovesimage", null);
			}
			if (other2.bootsimage.sprite == null) {
				PlayerPrefs.SetString ("bootsimage", null);
			}
			if (SceneManager.GetActiveScene ().buildIndex == 1) {
				SceneManager.LoadScene (0);
			}
			if (SceneManager.GetActiveScene ().buildIndex == 2) {
				SceneManager.LoadScene (3);
			}
			if (SceneManager.GetActiveScene ().buildIndex == 3) {
				SceneManager.LoadScene (0);
			}
		}
	}
}
