﻿/*
* Created: Sprint 2
* Last Edited: Sprint 2
* Purpose: Causes an inventory to exist
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_1 : MonoBehaviour {

	public GameObject[] inventory;
	public bool[] full;
	public Sprite bow;
	GameObject inventorycanvas;
	public Image image;
	public Image image2;
	public Image image3;
	public Image image4;
	public Image image5;
	public string weaponname;
	public int damage;
	GameObject hidebow1;

	// Use this for initialization
	void Start () {
		inventory = GameObject.FindGameObjectsWithTag ("image");
		inventorycanvas = GameObject.FindGameObjectWithTag ("inventory");
		hidebow1 = GameObject.Find ("Bow11");
		hidebow1.SetActive (false);
	}
	
	// Sets damage to the damage in the function Weapon
	void Update () {
		damage=Weapon(damage);

		
	}
	//Collides with the player, causes them to pick up the item if space available
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
	//Activates when slot one clicked
	public void Inventory1()
	{
		Debug.Log ("1");
		weaponname = image.sprite.name;
		Debug.Log (weaponname);
	}
	//Acitvates when slot two clicked
	public void Inventory2()
	{
		Debug.Log ("2");
		weaponname = image2.sprite.name;
		Debug.Log (weaponname);
	}
	//Activates when slot three clicked
	public void Inventory3()
	{
		Debug.Log ("3");
		weaponname = image3.sprite.name;
		Debug.Log (weaponname);
	}
	//Activates when slot four clicked
	public void Inventory4()
	{
		Debug.Log ("4");
		weaponname = image4.sprite.name;
		Debug.Log (weaponname);
	}
	//Activated when slot five clicked
	public void Inventory5()
	{
		Debug.Log ("5");
		weaponname = image5.sprite.name;
		Debug.Log (weaponname);
	}
	//Function to set the damage of weapons for player
	public int Weapon(int damage)
	{
		//Sets damage for the bow
		if (weaponname == "Bow1") {
			
			damage = 2;
			hidebow1.SetActive (true);
			return damage;
		}
		//Sets damage for when nothing is selected
		else
		{
			
			damage = 0;
			return damage;
		}
	}

}
