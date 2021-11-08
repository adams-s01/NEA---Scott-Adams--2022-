/*
* Created: Sprint 2
* Last Edited: Sprint 6
* Purpose: Causes an inventory to exist
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
	public Sprite ring2;
	public Sprite ring3;
	public Sprite ring4;
	public Sprite ring5;
	public Sprite ring6;
	public Sprite shield;
	public Sprite key;
	GameObject inventorycanvas;
	public Image image;
	public Image image2;
	public Image image3;
	public Image image4;
	public Image image5;
	public Image armourimage;
	public Image glovesimage;
	public Image bootsimage;
	public Image ring1image;
	public Image ring2image;
	public Image ring3image;
	public Image ring4image;
	public Image ring5image;
	public Image ring6image;
	public Image keyimage;
	public string weaponname;
	public int damage;
	public float playerspeed;
	public int armourstat;
	int armourarmourstat;
	int armourglovesstat;
	int armourbootsstat;
	int armourringstat;
	public GameObject hidebow1;
	public GameObject hidesword;
	public GameObject hidecrosshair;
	public GameObject hidepotion;
	public GameObject hideapple;
	public GameObject hidearmour1;
	public GameObject hidearmour2;
	public GameObject hidebat;
	public GameObject hidebelt;
	public GameObject hideboots;
	public GameObject hidebow2;
	public GameObject hideclub;
	public GameObject hidedagger;
	public GameObject hidegloves;
	public GameObject hidemage;
	public GameObject hidering;
	public GameObject hideshield;
	bool sleep;
	bool playerspeedtrue;
	bool playerspeedtrue2;
	int speeddouble;
	public bool playerhealth;
	public bool playerhealth2;
	public bool playerhealth3;
	public bool keytrue;
	GameObject armourcanvas;
	GameObject ringcanvas;
	int inventory1;
	int inventory2;
	int inventory3;
	int inventory4;
	int inventory5;

	// Use this for initialization
	void Start () {
		inventory = GameObject.FindGameObjectsWithTag ("image");
		inventorycanvas = GameObject.FindGameObjectWithTag ("inventory");
		armourcanvas = GameObject.FindGameObjectWithTag ("armourcanvas");
		ringcanvas = GameObject.FindGameObjectWithTag ("ringcanvas");
		//hidebow1 = GameObject.Find ("Bow11");
		//hidesword = GameObject.Find ("sword1");
		//hidecrosshair = GameObject.FindGameObjectWithTag ("crosshair");
		/*hidepotion = GameObject.Find ("potion");
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
		hideshield = GameObject.Find ("shield");*/
		armourcanvas.SetActive (false);
		ringcanvas.SetActive (false);
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
		playerspeedtrue = false;
		armourstat = 0;
		if (SceneManager.GetActiveScene ().buildIndex == 1) {
			inventory1 = 1;
			inventory2 = 4;
			inventory3 = 3;
			inventory4 = 0;
			inventory5 = 2;
		}
		if (SceneManager.GetActiveScene ().buildIndex == 2) {
			inventory1 = 2;
			inventory2 = 4;
			inventory3 = 3;
			inventory4 = 1;
			inventory5 = 0;
		}
	}
	
	// Sets damage to the damage in the function Weapon
	void Update () {
		damage=Weapon(damage);
		playerspeed = Speed (playerspeed);
		armourstat = armourarmourstat + armourglovesstat + armourbootsstat+armourringstat;
		//Doubles speed so long as its not tripled
		if (playerspeedtrue == true && playerspeedtrue2 == false) {
			speeddouble = 2;
		}
		//Triples speed
		if (playerspeedtrue2 == true) {
			speeddouble = 3;
		} else {
			speeddouble = 1;
		}

		
	}
	//Collides with the player, causes them to pick up the item if space available
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player") {
			for (int i = 0; i < inventory.Length; i++) {
				if (inventory [i].GetComponent<Image> ().sprite == null) {
					if (gameObject.name == "Bow1(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = bow;
					}
					if (gameObject.name == "sword(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = sword;
					}
					if (gameObject.name == "potion(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = potion;
					}
					if (gameObject.name == "apple(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = apple;
					}
					if (gameObject.name == "armour1(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = armour1;
					}
					if (gameObject.name == "armour2(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = armour2;
					}
					if (gameObject.name == "bat(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = bat;
					}
					if (gameObject.name == "belt(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = belt;
					}
					if (gameObject.name == "boots(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = boots;
					}
					if (gameObject.name == "bow2(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = bow2;
					}
					if (gameObject.name == "club(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = club;
					}
					if (gameObject.name == "dagger(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = dagger;
					}
					if (gameObject.name == "gloves(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = gloves;
					}
					if (gameObject.name == "mage(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = mage;
					}
					if (gameObject.name == "ring(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = ring;
					}
					if (gameObject.name == "ring2(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = ring2;
					}
					if (gameObject.name == "ring3(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = ring3;
					}
					if (gameObject.name == "ring4(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = ring4;
					}
					if (gameObject.name == "ring5(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = ring5;
					}
					if (gameObject.name == "ring6(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = ring6;
					}
					if (gameObject.name == "shield(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = shield;
					}
					if (gameObject.name == "Key_B(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = key;
					}
					GameObject bow1 = GameObject.FindGameObjectWithTag ("bow");
					Destroy (bow1);
					full [i] = true;
					//break;
					return;
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
		if (weaponname == "potion") {
			inventory [inventory1].GetComponent<Image> ().sprite = null;
		}
		if (weaponname == "armour1") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = armour1;
			armourarmourstat = 2;
		}
		if (weaponname == "armour2") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = armour2;
			armourarmourstat = 5;
		}
		if (weaponname == "belt") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = belt;
			armourglovesstat = 2;
		}
		if (weaponname == "gloves") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = gloves;
			armourglovesstat = 3;
		}
		if (weaponname == "shield") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = shield;
			armourglovesstat = 5;
		}
		if (weaponname == "boots") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = boots;
			armourbootsstat = 2;
		}
		if (weaponname == "apple") {
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			playerhealth3 = true;
		}
		if (weaponname == "ring") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 10;
		}
		if (weaponname == "ring2") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue = true;
		}
		if (weaponname == "ring3") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth = true;
		}
		if (weaponname == "ring4") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 40;
		}
		if (weaponname == "ring5") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue2 = true;
		}
		if (weaponname == "ring6") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth2 = true;
		}
		if (weaponname == "Key_B") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			keyimage.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			keytrue = true;
		}
	}
	//Acitvates when slot two clicked
	public void Inventory2()
	{
		Debug.Log ("2");
		weaponname = image2.sprite.name;
		Debug.Log (weaponname);
		if (weaponname == "potion") {
			inventory [inventory2].GetComponent<Image> ().sprite = null;
		}
		if (weaponname == "armour1") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = armour1;
			armourarmourstat = 2;
		}
		if (weaponname == "armour2") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = armour2;
			armourarmourstat = 5;
		}
		if (weaponname == "belt") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = belt;
			armourglovesstat = 2;
		}
		if (weaponname == "gloves") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = gloves;
			armourglovesstat = 3;
		}
		if (weaponname == "shield") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = shield;
			armourglovesstat = 5;
		}
		if (weaponname == "boots") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = boots;
			armourbootsstat = 2;
		}
		if (weaponname == "apple") {
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			playerhealth3 = true;
		}
		if (weaponname == "ring") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 10;
		}
		if (weaponname == "ring2") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue = true;
		}
		if (weaponname == "ring3") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth = true;
		}
		if (weaponname == "ring4") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 40;
		}
		if (weaponname == "ring5") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue2 = true;
		}
		if (weaponname == "ring6") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth2 = true;
		}
		if (weaponname == "Key_B") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			keyimage.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			keytrue = true;
		}

	}
	//Activates when slot three clicked
	public void Inventory3()
	{
		Debug.Log ("3");
		weaponname = image3.sprite.name;
		Debug.Log (weaponname);
		if (weaponname == "potion") {
			inventory [inventory3].GetComponent<Image> ().sprite = null;
		}
		if (weaponname == "armour1") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = armour1;
			armourarmourstat = 2;
		}
		if (weaponname == "armour2") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = armour2;
			armourarmourstat = 5;
		}
		if (weaponname == "belt") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = belt;
			armourglovesstat = 2;
		}
		if (weaponname == "gloves") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = gloves;
			armourglovesstat = 3;
		}
		if (weaponname == "shield") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = shield;
			armourglovesstat = 5;
		}
		if (weaponname == "boots") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = boots;
			armourbootsstat = 2;
		}
		if (weaponname == "apple") {
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			playerhealth3 = true;
		}
		if (weaponname == "ring") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 10;
		}
		if (weaponname == "ring2") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue = true;
		}
		if (weaponname == "ring3") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth = true;
		}
		if (weaponname == "ring4") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 40;
		}
		if (weaponname == "ring5") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue2 = true;
		}
		if (weaponname == "ring6") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth2 = true;
		}
		if (weaponname == "Key_B") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			keyimage.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			keytrue = true;
		}
	}
	//Activates when slot four clicked
	public void Inventory4()
	{
		Debug.Log ("4");
		weaponname = image4.sprite.name;
		Debug.Log (weaponname);
		if (weaponname == "potion") {
			inventory [inventory4].GetComponent<Image> ().sprite = null;
		}
		if (weaponname == "armour1") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = armour1;
			armourarmourstat = 2;
		}
		if (weaponname == "armour2") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = armour2;
			armourarmourstat = 5;
		}
		if (weaponname == "belt") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = belt;
			armourglovesstat = 2;
		}
		if (weaponname == "gloves") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = gloves;
			armourglovesstat = 3;
		}
		if (weaponname == "shield") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = shield;
			armourglovesstat = 5;
		}
		if (weaponname == "boots") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = boots;
			armourbootsstat = 2;
		}
		if (weaponname == "apple") {
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			playerhealth3 = true;
		}
		if (weaponname == "ring") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 10;
		}
		if (weaponname == "ring2") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue = true;
		}
		if (weaponname == "ring3") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth = true;
		}
		if (weaponname == "ring4") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 40;
		}
		if (weaponname == "ring5") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue2 = true;
		}
		if (weaponname == "ring6") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth2 = true;
		}
		if (weaponname == "Key_B") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			keyimage.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			keytrue = true;
		}
	}
	//Activated when slot five clicked
	public void Inventory5()
	{
		Debug.Log ("5");
		weaponname = image5.sprite.name;
		Debug.Log (weaponname);
		if (weaponname == "potion") {
			inventory [inventory5].GetComponent<Image> ().sprite = null;
		}
		if (weaponname == "armour1") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = armour1;
			armourarmourstat = 2;
		}
		if (weaponname == "armour2") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = armour2;
			armourarmourstat = 5;
		}
		if (weaponname == "belt") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = belt;
			armourglovesstat = 2;
		}
		if (weaponname == "gloves") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = gloves;
			armourglovesstat = 3;
		}
		if (weaponname == "shield") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = shield;
			armourglovesstat = 5;
		}
		if (weaponname == "boots") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = boots;
			armourbootsstat = 2;
		}
		if (weaponname == "apple") {
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			playerhealth3 = true;
		}
		if (weaponname == "ring") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 10;
		}
		if (weaponname == "ring2") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue = true;
		}
		if (weaponname == "ring3") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth = true;
		}
		if (weaponname == "ring4") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 40;
		}
		if (weaponname == "ring5") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue2 = true;
		}
		if (weaponname == "ring6") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth2 = true;
		}
		if (weaponname == "Key_B") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			keyimage.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			keytrue = true;
		}
	}
	//Activates canvas showing armour
	public void InventoryArmour()
	{
		armourcanvas.SetActive (true);
	}
	//Deactivates canvas showing armour
	public void InventoryArmourExit()
	{
		armourcanvas.SetActive (false);
	}
	//Activates canvas showing rings
	public void InventoryRing()
	{
		ringcanvas.SetActive (true);
	}
	//Deactivates canvas showing armour
	public void InventoryRingExit()
	{
		ringcanvas.SetActive (false);
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
	//Causes speed increase from potion
	public float Speed(float playerspeed)
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
					playerspeed = Random.Range (0f, 5f) * speeddouble;
					Debug.Log (playerspeed);
					StartCoroutine (speedcoroutine ());

				}
			}
			return playerspeed;
		}
		//Sets the speed when the potion is not used
		else {
			playerspeed = 1 * speeddouble;
			return playerspeed;
		}
	}
	//Resets speed after 5 seconds
	IEnumerator speedcoroutine()
	{
		sleep = true;
		yield return new WaitForSecondsRealtime (5);
		playerspeed = 1 * speeddouble;
		weaponname = null;
		hidepotion.SetActive (false);
		sleep = false;
	}

}
