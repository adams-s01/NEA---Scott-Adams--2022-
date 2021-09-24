/*
* Created: Sprint 2
* Last Edited: Sprint 2
* Purpose: Causes an inventory to exist
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	public GameObject[] inventory;
	public bool[] full;
	public Sprite bow;
	GameObject inventorycanvas;
	public Image image;

	// Use this for initialization
	void Start () {
		inventory = GameObject.FindGameObjectsWithTag ("image");
		inventorycanvas = GameObject.FindGameObjectWithTag ("inventory");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player") {
			for (int i = 0; i < full.Length; i++) {
				if (full [i] == false) {
					inventory [i].GetComponent<Image> ().sprite = bow;
					GameObject bow1 = GameObject.FindGameObjectWithTag ("bow");
					Destroy (bow1);
					full [i] = true;
					break;
				}
			}
		}
	}
	public void Inventory1()
	{
		Debug.Log ("1");
	}
	public void Inventory2()
	{
		Debug.Log ("2");
	}
	public void Inventory3()
	{
		Debug.Log ("3");
	}
	public void Inventory4()
	{
		Debug.Log ("4");
	}
	public void Inventory5()
	{
		Debug.Log ("5");
	}

}
