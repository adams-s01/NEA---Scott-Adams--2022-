/*
* Created: Sprint 2
* Last Edited: Sprint 3
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
	public Sprite sword;
	public Sprite potion;
	public Sprite apple;
	public Sprite armour1;
	public Sprite armour2;
	public Sprite bat;
	public Sprite belt;
	public Sprite boots;
	public Sprite bow2;
	public Sprite club;
	public Sprite dagger;
	public Sprite gloves;
	public Sprite mage;
	public Sprite ring;
	public Sprite shield;
	GameObject inventorycanvas;
	public Image image;
	public Image image2;
	public Image image3;
	public Image image4;
	public Image image5;
	public string weaponname;
	public int damage;
	public int playerspeed;
	public GameObject hidebow1;
	GameObject hidesword;
	GameObject hidecrosshair;
	GameObject hidepotion;
	GameObject hideapple;
	GameObject hidearmour1;
	GameObject hidearmour2;
	GameObject hidebat;
	GameObject hidebelt;
	GameObject hideboots;
	GameObject hidebow2;
	GameObject hideclub;
	GameObject hidedagger;
	GameObject hidegloves;
	GameObject hidemage;
	GameObject hidering;
	GameObject hideshield;
	bool sleep;

	// Use this for initialization
	void Start () {
		inventory = GameObject.FindGameObjectsWithTag ("image");
		inventorycanvas = GameObject.FindGameObjectWithTag ("inventory");
		//hidebow1 = GameObject.Find ("Bow11");
		hidesword = GameObject.Find ("sword1");
		hidecrosshair = GameObject.FindGameObjectWithTag ("crosshair");
		hidepotion = GameObject.Find ("potion");
		hideapple = GameObject.Find ("apple");
		hidearmour1 = GameObject.Find ("armour1");
		hidearmour2 = GameObject.Find ("armour2");
		hidebat = GameObject.Find ("bat");
		hidebelt = GameObject.Find ("belt");
		hideboots = GameObject.Find ("boots");
		hidebow2 = GameObject.Find ("bow2");
		hideclub = GameObject.Find ("club");
		hidedagger = GameObject.Find ("dagger");
		hidegloves = GameObject.Find ("gloves");
		hidemage = GameObject.Find ("mage");
		hidering = GameObject.Find ("ring");
		hideshield = GameObject.Find ("shield");
		hidebow1.SetActive (false);
		hidesword.SetActive (false);
		hidecrosshair.SetActive (false);
		hidepotion.SetActive (false);
		hideapple.SetActive (false);
		hidearmour1.SetActive (false);
		hidearmour2.SetActive (false);
		hidebat.SetActive (false);
		hidebelt.SetActive (false);
		hideboots.SetActive (false);
		hidebow2.SetActive (false);
		hideclub.SetActive (false);
		hidedagger.SetActive (false);
		hidegloves.SetActive (false);
		hidemage.SetActive (false);
		hidering.SetActive (false);
		hideshield.SetActive (false);
		sleep = false;
	}
	
	// Sets damage to the damage in the function Weapon
	void Update () {
		damage=Weapon(damage);
		playerspeed = Speed (playerspeed);

		
	}
	//Collides with the player, causes them to pick up the item if space available
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player") {
			for (int i = 0; i < inventory.Length; i++) {
				if (full[i] == false) {
					Debug.Log ("0");
					full[i] = true;
					Debug.Log (full [i]);
					if (gameObject.name == "Bow1(Clone)") {
						Debug.Log ("1");
						inventory [i].GetComponent<Image> ().sprite = bow;
					}
					if (gameObject.name == "sword(Clone)") {
						Debug.Log ("2");
						inventory [i+1].GetComponent<Image> ().sprite = sword;
					}
					if (gameObject.name == "potion(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = potion;
					}
					if (gameObject.name == "apple(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = apple;
					}
					if (gameObject.name == "armour1(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = armour1;
					}
					if (gameObject.name == "armour2(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = armour2;
					}
					if (gameObject.name == "bat(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = bat;
					}
					if (gameObject.name == "belt(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = belt;
					}
					if (gameObject.name == "boots(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = boots;
					}
					if (gameObject.name == "bow2(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = bow2;
					}
					if (gameObject.name == "club(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = club;
					}
					if (gameObject.name == "dagger(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = dagger;
					}
					if (gameObject.name == "gloves(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = gloves;
					}
					if (gameObject.name == "mage(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = mage;
					}
					if (gameObject.name == "ring(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = ring;
					}
					if (gameObject.name == "shield(Clone)") {
						inventory [i + 1].GetComponent<Image> ().sprite = shield;
					}
					GameObject bow1 = GameObject.FindGameObjectWithTag ("bow");
					Destroy (bow1);
					full [i] = true;
					//break;
					return;
				}

				if (full [i] == true) {
					Debug.Log ("3");
				}
				break;
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
			hidesword.SetActive (false);
			hidecrosshair.SetActive (true);
			hidepotion.SetActive (false);
			hideapple.SetActive (false);
			hidearmour1.SetActive (false);
			hidearmour2.SetActive (false);
			hidebat.SetActive (false);
			hidebelt.SetActive (false);
			hideboots.SetActive (false);
			hidebow2.SetActive (false);
			hideclub.SetActive (false);
			hidedagger.SetActive (false);
			hidegloves.SetActive (false);
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			return damage;
		}
		//Sets damage for the sword
		else if (weaponname == "sword") {
			damage = 3;
			hidesword.SetActive (true);
			hidebow1.SetActive (false);
			hidecrosshair.SetActive (false);
			hidepotion.SetActive (false);
			hideapple.SetActive (false);
			hidearmour1.SetActive (false);
			hidearmour2.SetActive (false);
			hidebat.SetActive (false);
			hidebelt.SetActive (false);
			hideboots.SetActive (false);
			hidebow2.SetActive (false);
			hideclub.SetActive (false);
			hidedagger.SetActive (false);
			hidegloves.SetActive (false);
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			return damage;
		}
		//Sets damage for the bat
		else if (weaponname == "bat") {
			damage = 4;
			hidesword.SetActive (false);
			hidebow1.SetActive (false);
			hidecrosshair.SetActive (false);
			hidepotion.SetActive (false);
			hideapple.SetActive (false);
			hidearmour1.SetActive (false);
			hidearmour2.SetActive (false);
			hidebat.SetActive (true);
			hidebelt.SetActive (false);
			hideboots.SetActive (false);
			hidebow2.SetActive (false);
			hideclub.SetActive (false);
			hidedagger.SetActive (false);
			hidegloves.SetActive (false);
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			return damage;
		}
		//Sets damage for the bow2
		else if (weaponname == "bow2") {
			damage = 3;
			hidesword.SetActive (false);
			hidebow1.SetActive (false);
			hidecrosshair.SetActive (true);
			hidepotion.SetActive (false);
			hideapple.SetActive (false);
			hidearmour1.SetActive (false);
			hidearmour2.SetActive (false);
			hidebat.SetActive (false);
			hidebelt.SetActive (false);
			hideboots.SetActive (false);
			hidebow2.SetActive (true);
			hideclub.SetActive (false);
			hidedagger.SetActive (false);
			hidegloves.SetActive (false);
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			return damage;
		}
		//Sets damage for the club
		else if (weaponname == "club") {
			damage = 6;
			hidesword.SetActive (false);
			hidebow1.SetActive (false);
			hidecrosshair.SetActive (false);
			hidepotion.SetActive (false);
			hideapple.SetActive (false);
			hidearmour1.SetActive (false);
			hidearmour2.SetActive (false);
			hidebat.SetActive (false);
			hidebelt.SetActive (false);
			hideboots.SetActive (false);
			hidebow2.SetActive (false);
			hideclub.SetActive (true);
			hidedagger.SetActive (false);
			hidegloves.SetActive (false);
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			return damage;
		}
		//Sets damage for the dagger
		else if (weaponname == "dagger") {
			damage = 4;
			hidesword.SetActive (false);
			hidebow1.SetActive (false);
			hidecrosshair.SetActive (false);
			hidepotion.SetActive (false);
			hideapple.SetActive (false);
			hidearmour1.SetActive (false);
			hidearmour2.SetActive (false);
			hidebat.SetActive (false);
			hidebelt.SetActive (false);
			hideboots.SetActive (false);
			hidebow2.SetActive (false);
			hideclub.SetActive (false);
			hidedagger.SetActive (true);
			hidegloves.SetActive (false);
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			return damage;
		}
		//Sets damage for the mage
		else if (weaponname == "mage") {
			damage = 15;
			hidesword.SetActive (false);
			hidebow1.SetActive (false);
			hidecrosshair.SetActive (false);
			hidepotion.SetActive (false);
			hideapple.SetActive (false);
			hidearmour1.SetActive (false);
			hidearmour2.SetActive (false);
			hidebat.SetActive (false);
			hidebelt.SetActive (false);
			hideboots.SetActive (false);
			hidebow2.SetActive (false);
			hideclub.SetActive (false);
			hidedagger.SetActive (false);
			hidegloves.SetActive (false);
			hidemage.SetActive (true);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			return damage;
		}
		//Sets damage for when nothing is selected
		else
		{
			
			damage = 0;
			return damage;
		}
	}
	public int Speed(int playerspeed)
	{
		if (weaponname == "potion") {
			hidesword.SetActive (false);
			hidebow1.SetActive (false);
			hidecrosshair.SetActive (false);
			hidepotion.SetActive (true);
			hideapple.SetActive (false);
			hidearmour1.SetActive (false);
			hidearmour2.SetActive (false);
			hidebat.SetActive (false);
			hidebelt.SetActive (false);
			hideboots.SetActive (false);
			hidebow2.SetActive (false);
			hideclub.SetActive (false);
			hidedagger.SetActive (false);
			hidegloves.SetActive (false);
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				
				if(sleep==false)
				{
					playerspeed = 5;
					hidepotion.SetActive (false);
					StartCoroutine (speedcoroutine ());
				}
			}
			return playerspeed;
		}
		//Sets the speed when the potion is not used
		else {
			playerspeed = 1;
			return playerspeed;
		}
	}
	IEnumerator speedcoroutine()
	{
		sleep = true;
		Debug.Log ("6");
		yield return new WaitForSecondsRealtime (5);
		Debug.Log ("7");
		playerspeed = 1;
		sleep = false;
	}

}
