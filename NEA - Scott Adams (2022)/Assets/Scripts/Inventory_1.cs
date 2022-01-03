/*
* Created: Sprint 2
* Last Edited: Sprint 11
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
	public Sprite warhammer;
	public Sprite mountainsword;
	public Sprite greyarmour;
	public Sprite boots2;
	public Sprite wand;
	public Sprite greygloves;
	public Sprite greyboots;
	public Sprite bow3;
	public Sprite axe;
	public Sprite darkgloves;
	public Sprite darkarmour;
	public Sprite darkboots;
	public Sprite cheese;
	public Sprite key;
	public Sprite potiondoubledamage;
	public Sprite potionweak;
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
	public GameObject hidewarhammer;
	public GameObject hidemountainsword;
	public GameObject hidegreyarmour;
	public GameObject hideboots2;
	public GameObject hidewand;
	public GameObject hidegreygloves;
	public GameObject hidegreyboots;
	public GameObject hidebow3;
	public GameObject hideaxe;
	public GameObject hidedarkgloves;
	public GameObject hidedarkarmour;
	public GameObject hidedarkboots;
	public GameObject hidecheese;
	public GameObject hidepotiondouble;
	public GameObject hidepotionweak;
	bool sleep;
	bool playerspeedtrue;
	bool playerspeedtrue2;
	int speeddouble;
	int doubledamage;
	public bool playerhealth;
	public bool playerhealth2;
	public bool playerhealth3;
	public bool playerhealth4;
	public bool keytrue;
	public GameObject armourcanvas;
	public GameObject ringcanvas;
	int inventory1;
	int inventory2;
	int inventory3;
	int inventory4;
	int inventory5;
	GameObject player;
	float playerx;
	float playery;
	public GameObject weak;
	private GameObject weakwall;
	public int sound;
	Sprite weaponholder;
	public string ring1true;
	public string ring2true;
	public string ring3true;
	public string ring4true;
	public string ring5true;
	public string ring6true;


	// Use this for initialization
	void Start () {
		inventory = GameObject.FindGameObjectsWithTag ("image");
		inventorycanvas = GameObject.FindGameObjectWithTag ("inventory");
		player = GameObject.FindGameObjectWithTag ("Player");
		//armourcanvas = GameObject.FindGameObjectWithTag ("armourcanvas");
		//ringcanvas = GameObject.FindGameObjectWithTag ("ringcanvas");
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
		hidepotiondouble.SetActive (false);
		hidepotionweak.SetActive (false);
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
		if (SceneManager.GetActiveScene ().buildIndex != 1) {
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
		}

		sleep = false;
		playerspeedtrue = false;
		armourstat = 0;
		doubledamage = 1;

		//Sets which part of list for tutorial link to which inventory slot
		if (SceneManager.GetActiveScene ().buildIndex == 1) {
			inventory1 = 1;
			inventory2 = 4;
			inventory3 = 3;
			inventory4 = 0;
			inventory5 = 2;
		}
		//Sets which part of list for level 1 link to which inventory slot
		if (SceneManager.GetActiveScene ().buildIndex == 2) {
			inventory1 = 2;
			inventory2 = 4;
			inventory3 = 3;
			inventory4 = 1;
			inventory5 = 0;
		}
		//Sets which part of list for level 2 link to which inventory slot and transfers items from level 1
		if (SceneManager.GetActiveScene ().buildIndex == 3) {
			inventory1 = 2;
			inventory2 = 4;
			inventory3 = 3;
			inventory4 = 1;
			inventory5 = 0;
			if (PlayerPrefs.GetString ("inventory1") == "Bow1") {
				weaponholder = bow;
			}
			if (PlayerPrefs.GetString ("inventory1") == "sword") {
				weaponholder = sword;
			}
			if (PlayerPrefs.GetString ("inventory1") == "potion") {
				weaponholder = potion;
			}
			if (PlayerPrefs.GetString ("inventory1") == "apple") {
				weaponholder = apple;
			}
			if (PlayerPrefs.GetString ("inventory1") == "armour1") {
				weaponholder = armour1;
			}
			if (PlayerPrefs.GetString ("inventory1") == "armour2") {
				weaponholder = armour2;
			}
			if (PlayerPrefs.GetString ("inventory1") == "bat") {
				weaponholder = bat;
			}
			if (PlayerPrefs.GetString ("inventory1") == "belt") {
				weaponholder = belt;
			}
			if (PlayerPrefs.GetString ("inventory1") == "boots") {
				weaponholder = boots;
			}
			if (PlayerPrefs.GetString ("inventory1") == "bow2") {
				weaponholder = bow2;
			}
			if (PlayerPrefs.GetString ("inventory1") == "club") {
				weaponholder = club;
			}
			if (PlayerPrefs.GetString ("inventory1") == "dagger") {
				weaponholder = dagger;
			}
			if (PlayerPrefs.GetString ("inventory1") == "gloves") {
				weaponholder = gloves;
			}
			if (PlayerPrefs.GetString ("inventory1") == "mage") {
				weaponholder = mage;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring") {
				weaponholder = ring;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring2") {
				weaponholder = ring2;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring3") {
				weaponholder = ring3;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring4") {
				weaponholder = ring4;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring5") {
				weaponholder = ring5;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring6") {
				weaponholder = ring6;
			}
			if (PlayerPrefs.GetString ("inventory1") == "shield") {
				weaponholder = shield;
			}
			if (PlayerPrefs.GetString ("inventory1") == "warhammer") {
				weaponholder = warhammer;
			}
			if (PlayerPrefs.GetString ("inventory1") == "mountainsword") {
				weaponholder = mountainsword;
			}
			if (PlayerPrefs.GetString ("inventory1") == "greyarmour") {
				weaponholder = greyarmour;
			}
			if (PlayerPrefs.GetString ("inventory1") == "boots2") {
				weaponholder = boots2;
			}
			if (PlayerPrefs.GetString ("inventory1") == "wand") {
				weaponholder = wand;
			}
			if (PlayerPrefs.GetString ("inventory1") == "greygloves") {
				weaponholder = greygloves;
			}
			if (PlayerPrefs.GetString ("inventory1") == "greyboots") {
				weaponholder = greyboots;
			}
			if (PlayerPrefs.GetString ("inventory1") == "bow3") {
				weaponholder = bow3;
			}
			if (PlayerPrefs.GetString ("inventory1") == "axe") {
				weaponholder = axe;
			}
			if (PlayerPrefs.GetString ("inventory1") == "darkgloves") {
				weaponholder = darkgloves;
			}
			if (PlayerPrefs.GetString ("inventory1") == "darkarmour") {
				weaponholder = darkarmour;
			}
			if (PlayerPrefs.GetString ("inventory1") == "darkboots") {
				weaponholder = darkboots;
			}
			if (PlayerPrefs.GetString ("inventory1") == "cheese") {
				weaponholder = cheese;
			}
			if (PlayerPrefs.GetString ("inventory1") == "Key_B") {
				weaponholder = key;
			}
			if (PlayerPrefs.GetString ("inventory1") == "potiondoubledamage") {
				weaponholder = potiondoubledamage;
			}
			if (PlayerPrefs.GetString ("inventory1") == "potionweak") {
				weaponholder = potionweak;
			}
			if (PlayerPrefs.GetString ("inventory1") == null) {
				weaponholder = null;
			}
			inventory [inventory1].GetComponent<Image> ().sprite = weaponholder;
			if (PlayerPrefs.GetString ("inventory2") == "Bow1") {
				weaponholder = bow;
			}
			if (PlayerPrefs.GetString ("inventory2") == "sword") {
				weaponholder = sword;
			}
			if (PlayerPrefs.GetString ("inventory2") == "potion") {
				weaponholder = potion;
			}
			if (PlayerPrefs.GetString ("inventory2") == "apple") {
				weaponholder = apple;
			}
			if (PlayerPrefs.GetString ("inventory2") == "armour1") {
				weaponholder = armour1;
			}
			if (PlayerPrefs.GetString ("inventory2") == "armour2") {
				weaponholder = armour2;
			}
			if (PlayerPrefs.GetString ("inventory2") == "bat") {
				weaponholder = bat;
			}
			if (PlayerPrefs.GetString ("inventory2") == "belt") {
				weaponholder = belt;
			}
			if (PlayerPrefs.GetString ("inventory2") == "boots") {
				weaponholder = boots;
			}
			if (PlayerPrefs.GetString ("inventory2") == "bow2") {
				weaponholder = bow2;
			}
			if (PlayerPrefs.GetString ("inventory2") == "club") {
				weaponholder = club;
			}
			if (PlayerPrefs.GetString ("inventory2") == "dagger") {
				weaponholder = dagger;
			}
			if (PlayerPrefs.GetString ("inventory2") == "gloves") {
				weaponholder = gloves;
			}
			if (PlayerPrefs.GetString ("inventory2") == "mage") {
				weaponholder = mage;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring") {
				weaponholder = ring;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring2") {
				weaponholder = ring2;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring3") {
				weaponholder = ring3;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring4") {
				weaponholder = ring4;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring5") {
				weaponholder = ring5;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring6") {
				weaponholder = ring6;
			}
			if (PlayerPrefs.GetString ("inventory2") == "shield") {
				weaponholder = shield;
			}
			if (PlayerPrefs.GetString ("inventory2") == "warhammer") {
				weaponholder = warhammer;
			}
			if (PlayerPrefs.GetString ("inventory2") == "mountainsword") {
				weaponholder = mountainsword;
			}
			if (PlayerPrefs.GetString ("inventory2") == "greyarmour") {
				weaponholder = greyarmour;
			}
			if (PlayerPrefs.GetString ("inventory2") == "boots2") {
				weaponholder = boots2;
			}
			if (PlayerPrefs.GetString ("inventory2") == "wand") {
				weaponholder = wand;
			}
			if (PlayerPrefs.GetString ("inventory2") == "greygloves") {
				weaponholder = greygloves;
			}
			if (PlayerPrefs.GetString ("inventory2") == "greyboots") {
				weaponholder = greyboots;
			}
			if (PlayerPrefs.GetString ("inventory2") == "bow3") {
				weaponholder = bow3;
			}
			if (PlayerPrefs.GetString ("inventory2") == "axe") {
				weaponholder = axe;
			}
			if (PlayerPrefs.GetString ("inventory2") == "darkgloves") {
				weaponholder = darkgloves;
			}
			if (PlayerPrefs.GetString ("inventory2") == "darkarmour") {
				weaponholder = darkarmour;
			}
			if (PlayerPrefs.GetString ("inventory2") == "darkboots") {
				weaponholder = darkboots;
			}
			if (PlayerPrefs.GetString ("inventory2") == "cheese") {
				weaponholder = cheese;
			}
			if (PlayerPrefs.GetString ("inventory2") == "Key_B") {
				weaponholder = key;
			}
			if (PlayerPrefs.GetString ("inventory2") == "potiondoubledamage") {
				weaponholder = potiondoubledamage;
			}
			if (PlayerPrefs.GetString ("inventory2") == "potionweak") {
				weaponholder = potionweak;
			}
			if (PlayerPrefs.GetString ("inventory2") == null) {
				weaponholder = null;
			}
			inventory [inventory2].GetComponent<Image> ().sprite = weaponholder;
			if (PlayerPrefs.GetString ("inventory3") == "Bow1") {
				weaponholder = bow;
			}
			if (PlayerPrefs.GetString ("inventory3") == "sword") {
				weaponholder = sword;
			}
			if (PlayerPrefs.GetString ("inventory3") == "potion") {
				weaponholder = potion;
			}
			if (PlayerPrefs.GetString ("inventory3") == "apple") {
				weaponholder = apple;
			}
			if (PlayerPrefs.GetString ("inventory3") == "armour1") {
				weaponholder = armour1;
			}
			if (PlayerPrefs.GetString ("inventory3") == "armour2") {
				weaponholder = armour2;
			}
			if (PlayerPrefs.GetString ("inventory3") == "bat") {
				weaponholder = bat;
			}
			if (PlayerPrefs.GetString ("inventory3") == "belt") {
				weaponholder = belt;
			}
			if (PlayerPrefs.GetString ("inventory3") == "boots") {
				weaponholder = boots;
			}
			if (PlayerPrefs.GetString ("inventory3") == "bow2") {
				weaponholder = bow2;
			}
			if (PlayerPrefs.GetString ("inventory3") == "club") {
				weaponholder = club;
			}
			if (PlayerPrefs.GetString ("inventory3") == "dagger") {
				weaponholder = dagger;
			}
			if (PlayerPrefs.GetString ("inventory3") == "gloves") {
				weaponholder = gloves;
			}
			if (PlayerPrefs.GetString ("inventory3") == "mage") {
				weaponholder = mage;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring") {
				weaponholder = ring;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring2") {
				weaponholder = ring2;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring3") {
				weaponholder = ring3;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring4") {
				weaponholder = ring4;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring5") {
				weaponholder = ring5;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring6") {
				weaponholder = ring6;
			}
			if (PlayerPrefs.GetString ("inventory3") == "shield") {
				weaponholder = shield;
			}
			if (PlayerPrefs.GetString ("inventory3") == "warhammer") {
				weaponholder = warhammer;
			}
			if (PlayerPrefs.GetString ("inventory3") == "mountainsword") {
				weaponholder = mountainsword;
			}
			if (PlayerPrefs.GetString ("inventory3") == "greyarmour") {
				weaponholder = greyarmour;
			}
			if (PlayerPrefs.GetString ("inventory3") == "boots2") {
				weaponholder = boots2;
			}
			if (PlayerPrefs.GetString ("inventory3") == "wand") {
				weaponholder = wand;
			}
			if (PlayerPrefs.GetString ("inventory3") == "greygloves") {
				weaponholder = greygloves;
			}
			if (PlayerPrefs.GetString ("inventory3") == "greyboots") {
				weaponholder = greyboots;
			}
			if (PlayerPrefs.GetString ("inventory3") == "bow3") {
				weaponholder = bow3;
			}
			if (PlayerPrefs.GetString ("inventory3") == "axe") {
				weaponholder = axe;
			}
			if (PlayerPrefs.GetString ("inventory3") == "darkgloves") {
				weaponholder = darkgloves;
			}
			if (PlayerPrefs.GetString ("inventory3") == "darkarmour") {
				weaponholder = darkarmour;
			}
			if (PlayerPrefs.GetString ("inventory3") == "darkboots") {
				weaponholder = darkboots;
			}
			if (PlayerPrefs.GetString ("inventory3") == "cheese") {
				weaponholder = cheese;
			}
			if (PlayerPrefs.GetString ("inventory3") == "Key_B") {
				weaponholder = key;
			}
			if (PlayerPrefs.GetString ("inventory3") == "potiondoubledamage") {
				weaponholder = potiondoubledamage;
			}
			if (PlayerPrefs.GetString ("inventory3") == "potionweak") {
				weaponholder = potionweak;
			}
			if (PlayerPrefs.GetString ("inventory3") == null) {
				weaponholder = null;
			}
			inventory [inventory3].GetComponent<Image> ().sprite = weaponholder;
			if (PlayerPrefs.GetString ("inventory4") == "Bow1") {
				weaponholder = bow;
			}
			if (PlayerPrefs.GetString ("inventory4") == "sword") {
				weaponholder = sword;
			}
			if (PlayerPrefs.GetString ("inventory4") == "potion") {
				weaponholder = potion;
			}
			if (PlayerPrefs.GetString ("inventory4") == "apple") {
				weaponholder = apple;
			}
			if (PlayerPrefs.GetString ("inventory4") == "armour1") {
				weaponholder = armour1;
			}
			if (PlayerPrefs.GetString ("inventory4") == "armour2") {
				weaponholder = armour2;
			}
			if (PlayerPrefs.GetString ("inventory4") == "bat") {
				weaponholder = bat;
			}
			if (PlayerPrefs.GetString ("inventory4") == "belt") {
				weaponholder = belt;
			}
			if (PlayerPrefs.GetString ("inventory4") == "boots") {
				weaponholder = boots;
			}
			if (PlayerPrefs.GetString ("inventory4") == "bow2") {
				weaponholder = bow2;
			}
			if (PlayerPrefs.GetString ("inventory4") == "club") {
				weaponholder = club;
			}
			if (PlayerPrefs.GetString ("inventory4") == "dagger") {
				weaponholder = dagger;
			}
			if (PlayerPrefs.GetString ("inventory4") == "gloves") {
				weaponholder = gloves;
			}
			if (PlayerPrefs.GetString ("inventory4") == "mage") {
				weaponholder = mage;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring") {
				weaponholder = ring;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring2") {
				weaponholder = ring2;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring3") {
				weaponholder = ring3;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring4") {
				weaponholder = ring4;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring5") {
				weaponholder = ring5;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring6") {
				weaponholder = ring6;
			}
			if (PlayerPrefs.GetString ("inventory4") == "shield") {
				weaponholder = shield;
			}
			if (PlayerPrefs.GetString ("inventory4") == "warhammer") {
				weaponholder = warhammer;
			}
			if (PlayerPrefs.GetString ("inventory4") == "mountainsword") {
				weaponholder = mountainsword;
			}
			if (PlayerPrefs.GetString ("inventory4") == "greyarmour") {
				weaponholder = greyarmour;
			}
			if (PlayerPrefs.GetString ("inventory4") == "boots2") {
				weaponholder = boots2;
			}
			if (PlayerPrefs.GetString ("inventory4") == "wand") {
				weaponholder = wand;
			}
			if (PlayerPrefs.GetString ("inventory4") == "greygloves") {
				weaponholder = greygloves;
			}
			if (PlayerPrefs.GetString ("inventory4") == "greyboots") {
				weaponholder = greyboots;
			}
			if (PlayerPrefs.GetString ("inventory4") == "bow3") {
				weaponholder = bow3;
			}
			if (PlayerPrefs.GetString ("inventory4") == "axe") {
				weaponholder = axe;
			}
			if (PlayerPrefs.GetString ("inventory4") == "darkgloves") {
				weaponholder = darkgloves;
			}
			if (PlayerPrefs.GetString ("inventory4") == "darkarmour") {
				weaponholder = darkarmour;
			}
			if (PlayerPrefs.GetString ("inventory4") == "darkboots") {
				weaponholder = darkboots;
			}
			if (PlayerPrefs.GetString ("inventory4") == "cheese") {
				weaponholder = cheese;
			}
			if (PlayerPrefs.GetString ("inventory4") == "Key_B") {
				weaponholder = key;
			}
			if (PlayerPrefs.GetString ("inventory4") == "potiondoubledamage") {
				weaponholder = potiondoubledamage;
			}
			if (PlayerPrefs.GetString ("inventory4") == "potionweak") {
				weaponholder = potionweak;
			}
			if (PlayerPrefs.GetString ("inventory4") == null) {
				weaponholder = null;
			}
			inventory [inventory4].GetComponent<Image> ().sprite = weaponholder;
			if (PlayerPrefs.GetString ("inventory5") == "Bow1") {
				weaponholder = bow;
			}
			if (PlayerPrefs.GetString ("inventory5") == "sword") {
				weaponholder = sword;
			}
			if (PlayerPrefs.GetString ("inventory5") == "potion") {
				weaponholder = potion;
			}
			if (PlayerPrefs.GetString ("inventory5") == "apple") {
				weaponholder = apple;
			}
			if (PlayerPrefs.GetString ("inventory5") == "armour1") {
				weaponholder = armour1;
			}
			if (PlayerPrefs.GetString ("inventory5") == "armour2") {
				weaponholder = armour2;
			}
			if (PlayerPrefs.GetString ("inventory5") == "bat") {
				weaponholder = bat;
			}
			if (PlayerPrefs.GetString ("inventory5") == "belt") {
				weaponholder = belt;
			}
			if (PlayerPrefs.GetString ("inventory5") == "boots") {
				weaponholder = boots;
			}
			if (PlayerPrefs.GetString ("inventory5") == "bow2") {
				weaponholder = bow2;
			}
			if (PlayerPrefs.GetString ("inventory5") == "club") {
				weaponholder = club;
			}
			if (PlayerPrefs.GetString ("inventory5") == "dagger") {
				weaponholder = dagger;
			}
			if (PlayerPrefs.GetString ("inventory5") == "gloves") {
				weaponholder = gloves;
			}
			if (PlayerPrefs.GetString ("inventory5") == "mage") {
				weaponholder = mage;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring") {
				weaponholder = ring;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring2") {
				weaponholder = ring2;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring3") {
				weaponholder = ring3;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring4") {
				weaponholder = ring4;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring5") {
				weaponholder = ring5;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring6") {
				weaponholder = ring6;
			}
			if (PlayerPrefs.GetString ("inventory5") == "shield") {
				weaponholder = shield;
			}
			if (PlayerPrefs.GetString ("inventory5") == "warhammer") {
				weaponholder = warhammer;
			}
			if (PlayerPrefs.GetString ("inventory5") == "mountainsword") {
				weaponholder = mountainsword;
			}
			if (PlayerPrefs.GetString ("inventory5") == "greyarmour") {
				weaponholder = greyarmour;
			}
			if (PlayerPrefs.GetString ("inventory5") == "boots2") {
				weaponholder = boots2;
			}
			if (PlayerPrefs.GetString ("inventory5") == "wand") {
				weaponholder = wand;
			}
			if (PlayerPrefs.GetString ("inventory5") == "greygloves") {
				weaponholder = greygloves;
			}
			if (PlayerPrefs.GetString ("inventory5") == "greyboots") {
				weaponholder = greyboots;
			}
			if (PlayerPrefs.GetString ("inventory5") == "bow3") {
				weaponholder = bow3;
			}
			if (PlayerPrefs.GetString ("inventory5") == "axe") {
				weaponholder = axe;
			}
			if (PlayerPrefs.GetString ("inventory5") == "darkgloves") {
				weaponholder = darkgloves;
			}
			if (PlayerPrefs.GetString ("inventory5") == "darkarmour") {
				weaponholder = darkarmour;
			}
			if (PlayerPrefs.GetString ("inventory5") == "darkboots") {
				weaponholder = darkboots;
			}
			if (PlayerPrefs.GetString ("inventory5") == "cheese") {
				weaponholder = cheese;
			}
			if (PlayerPrefs.GetString ("inventory5") == "Key_B") {
				weaponholder = key;
			}
			if (PlayerPrefs.GetString ("inventory5") == "potiondoubledamage") {
				weaponholder = potiondoubledamage;
			}
			if (PlayerPrefs.GetString ("inventory5") == "potionweak") {
				weaponholder = potionweak;
			}
			if (PlayerPrefs.GetString ("inventory5") == null) {
				weaponholder = null;
			}
			inventory [inventory5].GetComponent<Image> ().sprite = weaponholder;
			if (PlayerPrefs.GetString ("armourimage") == null) {
				weaponholder = null;
			}
			if (PlayerPrefs.GetString ("armourimage") == "armour1") {
				armourimage.GetComponent<Image> ().sprite = armour1;
				armourarmourstat = 2;
			}
			if (PlayerPrefs.GetString ("armourimage") == "armour2") {
				armourimage.GetComponent<Image> ().sprite = armour2;
				armourarmourstat = 5;
			}
			if (PlayerPrefs.GetString ("armourimage") == "greyarmour") {
				armourimage.GetComponent<Image> ().sprite = greyarmour;
				armourarmourstat = 7;
			}
			if (PlayerPrefs.GetString ("armourimage") == "darkarmour") {
				armourimage.GetComponent<Image> ().sprite = darkarmour;
				armourarmourstat = 10;
			}
			if (PlayerPrefs.GetString ("glovesimage") == "belt") {
				glovesimage.GetComponent<Image> ().sprite = belt;
				armourglovesstat = 2;
			}
			if (PlayerPrefs.GetString ("glovesimage") == "gloves") {
				glovesimage.GetComponent<Image> ().sprite = gloves;
				armourglovesstat = 3;
			}
			if (PlayerPrefs.GetString ("glovesimage") == "greygloves") {
				glovesimage.GetComponent<Image> ().sprite = greygloves;
				armourglovesstat = 5;
			}
			if (PlayerPrefs.GetString ("glovesimage") == "darkgloves") {
				glovesimage.GetComponent<Image> ().sprite = darkgloves;
				armourglovesstat = 7;
			}
			if (PlayerPrefs.GetString ("glovesimage") == "shield") {
				glovesimage.GetComponent<Image> ().sprite = shield;
				armourglovesstat = 5;
			}
			if (PlayerPrefs.GetString ("bootsimage") == "boots") {
				bootsimage.GetComponent<Image> ().sprite = boots;
				armourbootsstat = 2;
			}
			if (PlayerPrefs.GetString ("bootsimage") == "boots2") {
				bootsimage.GetComponent<Image> ().sprite = boots2;
				armourbootsstat = 4;
			}
			if (PlayerPrefs.GetString ("bootsimage") == "greyboots") {
				bootsimage.GetComponent<Image> ().sprite = greyboots;
				armourbootsstat = 6;
			}
			if (PlayerPrefs.GetString ("bootsimage") == "darkboots") {
				bootsimage.GetComponent<Image> ().sprite = darkboots;
				armourbootsstat = 9;
			}
			if (PlayerPrefs.GetString ("ring1") == "true") {
				ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				armourringstat += 10;
			}
			if (PlayerPrefs.GetString ("ring2") == "true") {
				ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				playerspeedtrue = true;
			}
			if (PlayerPrefs.GetString ("ring3") == "true") {
				ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				playerhealth = true;
			}
			if (PlayerPrefs.GetString ("ring4") == "true") {
				ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				armourringstat += 40;
			}
			if (PlayerPrefs.GetString ("ring5") == "true") {
				ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				playerspeedtrue2 = true;
			}
			if (PlayerPrefs.GetString ("ring6") == "true") {
				ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				playerhealth2 = true;
			}
			Debug.Log(PlayerPrefs.GetString("inventory1"));
			Debug.Log(PlayerPrefs.GetString("inventory2"));
			Debug.Log(PlayerPrefs.GetString("inventory3"));
			Debug.Log(PlayerPrefs.GetString("inventory4"));
			Debug.Log(PlayerPrefs.GetString("inventory5"));
		}
		//Sets which part of list for level 3 link to which inventory slot and transfers items from level 2
		if (SceneManager.GetActiveScene ().buildIndex == 4) {
			inventory1 = 2;
			inventory2 = 4;
			inventory3 = 3;
			inventory4 = 1;
			inventory5 = 0;
			if (PlayerPrefs.GetString ("inventory1") == "Bow1") {
				weaponholder = bow;
			}
			if (PlayerPrefs.GetString ("inventory1") == "sword") {
				weaponholder = sword;
			}
			if (PlayerPrefs.GetString ("inventory1") == "potion") {
				weaponholder = potion;
			}
			if (PlayerPrefs.GetString ("inventory1") == "apple") {
				weaponholder = apple;
			}
			if (PlayerPrefs.GetString ("inventory1") == "armour1") {
				weaponholder = armour1;
			}
			if (PlayerPrefs.GetString ("inventory1") == "armour2") {
				weaponholder = armour2;
			}
			if (PlayerPrefs.GetString ("inventory1") == "bat") {
				weaponholder = bat;
			}
			if (PlayerPrefs.GetString ("inventory1") == "belt") {
				weaponholder = belt;
			}
			if (PlayerPrefs.GetString ("inventory1") == "boots") {
				weaponholder = boots;
			}
			if (PlayerPrefs.GetString ("inventory1") == "bow2") {
				weaponholder = bow2;
			}
			if (PlayerPrefs.GetString ("inventory1") == "club") {
				weaponholder = club;
			}
			if (PlayerPrefs.GetString ("inventory1") == "dagger") {
				weaponholder = dagger;
			}
			if (PlayerPrefs.GetString ("inventory1") == "gloves") {
				weaponholder = gloves;
			}
			if (PlayerPrefs.GetString ("inventory1") == "mage") {
				weaponholder = mage;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring") {
				weaponholder = ring;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring2") {
				weaponholder = ring2;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring3") {
				weaponholder = ring3;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring4") {
				weaponholder = ring4;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring5") {
				weaponholder = ring5;
			}
			if (PlayerPrefs.GetString ("inventory1") == "ring6") {
				weaponholder = ring6;
			}
			if (PlayerPrefs.GetString ("inventory1") == "shield") {
				weaponholder = shield;
			}
			if (PlayerPrefs.GetString ("inventory1") == "warhammer") {
				weaponholder = warhammer;
			}
			if (PlayerPrefs.GetString ("inventory1") == "mountainsword") {
				weaponholder = mountainsword;
			}
			if (PlayerPrefs.GetString ("inventory1") == "greyarmour") {
				weaponholder = greyarmour;
			}
			if (PlayerPrefs.GetString ("inventory1") == "boots2") {
				weaponholder = boots2;
			}
			if (PlayerPrefs.GetString ("inventory1") == "wand") {
				weaponholder = wand;
			}
			if (PlayerPrefs.GetString ("inventory1") == "greygloves") {
				weaponholder = greygloves;
			}
			if (PlayerPrefs.GetString ("inventory1") == "greyboots") {
				weaponholder = greyboots;
			}
			if (PlayerPrefs.GetString ("inventory1") == "bow3") {
				weaponholder = bow3;
			}
			if (PlayerPrefs.GetString ("inventory1") == "axe") {
				weaponholder = axe;
			}
			if (PlayerPrefs.GetString ("inventory1") == "darkgloves") {
				weaponholder = darkgloves;
			}
			if (PlayerPrefs.GetString ("inventory1") == "darkarmour") {
				weaponholder = darkarmour;
			}
			if (PlayerPrefs.GetString ("inventory1") == "darkboots") {
				weaponholder = darkboots;
			}
			if (PlayerPrefs.GetString ("inventory1") == "cheese") {
				weaponholder = cheese;
			}
			if (PlayerPrefs.GetString ("inventory1") == "Key_B") {
				weaponholder = key;
			}
			if (PlayerPrefs.GetString ("inventory1") == "potiondoubledamage") {
				weaponholder = potiondoubledamage;
			}
			if (PlayerPrefs.GetString ("inventory1") == "potionweak") {
				weaponholder = potionweak;
			}
			if (PlayerPrefs.GetString ("inventory1") == null) {
				weaponholder = null;
			}
			inventory [inventory1].GetComponent<Image> ().sprite = weaponholder;
			if (PlayerPrefs.GetString ("inventory2") == "Bow1") {
				weaponholder = bow;
			}
			if (PlayerPrefs.GetString ("inventory2") == "sword") {
				weaponholder = sword;
			}
			if (PlayerPrefs.GetString ("inventory2") == "potion") {
				weaponholder = potion;
			}
			if (PlayerPrefs.GetString ("inventory2") == "apple") {
				weaponholder = apple;
			}
			if (PlayerPrefs.GetString ("inventory2") == "armour1") {
				weaponholder = armour1;
			}
			if (PlayerPrefs.GetString ("inventory2") == "armour2") {
				weaponholder = armour2;
			}
			if (PlayerPrefs.GetString ("inventory2") == "bat") {
				weaponholder = bat;
			}
			if (PlayerPrefs.GetString ("inventory2") == "belt") {
				weaponholder = belt;
			}
			if (PlayerPrefs.GetString ("inventory2") == "boots") {
				weaponholder = boots;
			}
			if (PlayerPrefs.GetString ("inventory2") == "bow2") {
				weaponholder = bow2;
			}
			if (PlayerPrefs.GetString ("inventory2") == "club") {
				weaponholder = club;
			}
			if (PlayerPrefs.GetString ("inventory2") == "dagger") {
				weaponholder = dagger;
			}
			if (PlayerPrefs.GetString ("inventory2") == "gloves") {
				weaponholder = gloves;
			}
			if (PlayerPrefs.GetString ("inventory2") == "mage") {
				weaponholder = mage;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring") {
				weaponholder = ring;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring2") {
				weaponholder = ring2;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring3") {
				weaponholder = ring3;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring4") {
				weaponholder = ring4;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring5") {
				weaponholder = ring5;
			}
			if (PlayerPrefs.GetString ("inventory2") == "ring6") {
				weaponholder = ring6;
			}
			if (PlayerPrefs.GetString ("inventory2") == "shield") {
				weaponholder = shield;
			}
			if (PlayerPrefs.GetString ("inventory2") == "warhammer") {
				weaponholder = warhammer;
			}
			if (PlayerPrefs.GetString ("inventory2") == "mountainsword") {
				weaponholder = mountainsword;
			}
			if (PlayerPrefs.GetString ("inventory2") == "greyarmour") {
				weaponholder = greyarmour;
			}
			if (PlayerPrefs.GetString ("inventory2") == "boots2") {
				weaponholder = boots2;
			}
			if (PlayerPrefs.GetString ("inventory2") == "wand") {
				weaponholder = wand;
			}
			if (PlayerPrefs.GetString ("inventory2") == "greygloves") {
				weaponholder = greygloves;
			}
			if (PlayerPrefs.GetString ("inventory2") == "greyboots") {
				weaponholder = greyboots;
			}
			if (PlayerPrefs.GetString ("inventory2") == "bow3") {
				weaponholder = bow3;
			}
			if (PlayerPrefs.GetString ("inventory2") == "axe") {
				weaponholder = axe;
			}
			if (PlayerPrefs.GetString ("inventory2") == "darkgloves") {
				weaponholder = darkgloves;
			}
			if (PlayerPrefs.GetString ("inventory2") == "darkarmour") {
				weaponholder = darkarmour;
			}
			if (PlayerPrefs.GetString ("inventory2") == "darkboots") {
				weaponholder = darkboots;
			}
			if (PlayerPrefs.GetString ("inventory2") == "cheese") {
				weaponholder = cheese;
			}
			if (PlayerPrefs.GetString ("inventory2") == "Key_B") {
				weaponholder = key;
			}
			if (PlayerPrefs.GetString ("inventory2") == "potiondoubledamage") {
				weaponholder = potiondoubledamage;
			}
			if (PlayerPrefs.GetString ("inventory2") == "potionweak") {
				weaponholder = potionweak;
			}
			if (PlayerPrefs.GetString ("inventory2") == null) {
				weaponholder = null;
			}
			inventory [inventory2].GetComponent<Image> ().sprite = weaponholder;
			if (PlayerPrefs.GetString ("inventory3") == "Bow1") {
				weaponholder = bow;
			}
			if (PlayerPrefs.GetString ("inventory3") == "sword") {
				weaponholder = sword;
			}
			if (PlayerPrefs.GetString ("inventory3") == "potion") {
				weaponholder = potion;
			}
			if (PlayerPrefs.GetString ("inventory3") == "apple") {
				weaponholder = apple;
			}
			if (PlayerPrefs.GetString ("inventory3") == "armour1") {
				weaponholder = armour1;
			}
			if (PlayerPrefs.GetString ("inventory3") == "armour2") {
				weaponholder = armour2;
			}
			if (PlayerPrefs.GetString ("inventory3") == "bat") {
				weaponholder = bat;
			}
			if (PlayerPrefs.GetString ("inventory3") == "belt") {
				weaponholder = belt;
			}
			if (PlayerPrefs.GetString ("inventory3") == "boots") {
				weaponholder = boots;
			}
			if (PlayerPrefs.GetString ("inventory3") == "bow2") {
				weaponholder = bow2;
			}
			if (PlayerPrefs.GetString ("inventory3") == "club") {
				weaponholder = club;
			}
			if (PlayerPrefs.GetString ("inventory3") == "dagger") {
				weaponholder = dagger;
			}
			if (PlayerPrefs.GetString ("inventory3") == "gloves") {
				weaponholder = gloves;
			}
			if (PlayerPrefs.GetString ("inventory3") == "mage") {
				weaponholder = mage;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring") {
				weaponholder = ring;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring2") {
				weaponholder = ring2;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring3") {
				weaponholder = ring3;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring4") {
				weaponholder = ring4;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring5") {
				weaponholder = ring5;
			}
			if (PlayerPrefs.GetString ("inventory3") == "ring6") {
				weaponholder = ring6;
			}
			if (PlayerPrefs.GetString ("inventory3") == "shield") {
				weaponholder = shield;
			}
			if (PlayerPrefs.GetString ("inventory3") == "warhammer") {
				weaponholder = warhammer;
			}
			if (PlayerPrefs.GetString ("inventory3") == "mountainsword") {
				weaponholder = mountainsword;
			}
			if (PlayerPrefs.GetString ("inventory3") == "greyarmour") {
				weaponholder = greyarmour;
			}
			if (PlayerPrefs.GetString ("inventory3") == "boots2") {
				weaponholder = boots2;
			}
			if (PlayerPrefs.GetString ("inventory3") == "wand") {
				weaponholder = wand;
			}
			if (PlayerPrefs.GetString ("inventory3") == "greygloves") {
				weaponholder = greygloves;
			}
			if (PlayerPrefs.GetString ("inventory3") == "greyboots") {
				weaponholder = greyboots;
			}
			if (PlayerPrefs.GetString ("inventory3") == "bow3") {
				weaponholder = bow3;
			}
			if (PlayerPrefs.GetString ("inventory3") == "axe") {
				weaponholder = axe;
			}
			if (PlayerPrefs.GetString ("inventory3") == "darkgloves") {
				weaponholder = darkgloves;
			}
			if (PlayerPrefs.GetString ("inventory3") == "darkarmour") {
				weaponholder = darkarmour;
			}
			if (PlayerPrefs.GetString ("inventory3") == "darkboots") {
				weaponholder = darkboots;
			}
			if (PlayerPrefs.GetString ("inventory3") == "cheese") {
				weaponholder = cheese;
			}
			if (PlayerPrefs.GetString ("inventory3") == "Key_B") {
				weaponholder = key;
			}
			if (PlayerPrefs.GetString ("inventory3") == "potiondoubledamage") {
				weaponholder = potiondoubledamage;
			}
			if (PlayerPrefs.GetString ("inventory3") == "potionweak") {
				weaponholder = potionweak;
			}
			if (PlayerPrefs.GetString ("inventory3") == null) {
				weaponholder = null;
			}
			inventory [inventory3].GetComponent<Image> ().sprite = weaponholder;
			if (PlayerPrefs.GetString ("inventory4") == "Bow1") {
				weaponholder = bow;
			}
			if (PlayerPrefs.GetString ("inventory4") == "sword") {
				weaponholder = sword;
			}
			if (PlayerPrefs.GetString ("inventory4") == "potion") {
				weaponholder = potion;
			}
			if (PlayerPrefs.GetString ("inventory4") == "apple") {
				weaponholder = apple;
			}
			if (PlayerPrefs.GetString ("inventory4") == "armour1") {
				weaponholder = armour1;
			}
			if (PlayerPrefs.GetString ("inventory4") == "armour2") {
				weaponholder = armour2;
			}
			if (PlayerPrefs.GetString ("inventory4") == "bat") {
				weaponholder = bat;
			}
			if (PlayerPrefs.GetString ("inventory4") == "belt") {
				weaponholder = belt;
			}
			if (PlayerPrefs.GetString ("inventory4") == "boots") {
				weaponholder = boots;
			}
			if (PlayerPrefs.GetString ("inventory4") == "bow2") {
				weaponholder = bow2;
			}
			if (PlayerPrefs.GetString ("inventory4") == "club") {
				weaponholder = club;
			}
			if (PlayerPrefs.GetString ("inventory4") == "dagger") {
				weaponholder = dagger;
			}
			if (PlayerPrefs.GetString ("inventory4") == "gloves") {
				weaponholder = gloves;
			}
			if (PlayerPrefs.GetString ("inventory4") == "mage") {
				weaponholder = mage;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring") {
				weaponholder = ring;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring2") {
				weaponholder = ring2;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring3") {
				weaponholder = ring3;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring4") {
				weaponholder = ring4;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring5") {
				weaponholder = ring5;
			}
			if (PlayerPrefs.GetString ("inventory4") == "ring6") {
				weaponholder = ring6;
			}
			if (PlayerPrefs.GetString ("inventory4") == "shield") {
				weaponholder = shield;
			}
			if (PlayerPrefs.GetString ("inventory4") == "warhammer") {
				weaponholder = warhammer;
			}
			if (PlayerPrefs.GetString ("inventory4") == "mountainsword") {
				weaponholder = mountainsword;
			}
			if (PlayerPrefs.GetString ("inventory4") == "greyarmour") {
				weaponholder = greyarmour;
			}
			if (PlayerPrefs.GetString ("inventory4") == "boots2") {
				weaponholder = boots2;
			}
			if (PlayerPrefs.GetString ("inventory4") == "wand") {
				weaponholder = wand;
			}
			if (PlayerPrefs.GetString ("inventory4") == "greygloves") {
				weaponholder = greygloves;
			}
			if (PlayerPrefs.GetString ("inventory4") == "greyboots") {
				weaponholder = greyboots;
			}
			if (PlayerPrefs.GetString ("inventory4") == "bow3") {
				weaponholder = bow3;
			}
			if (PlayerPrefs.GetString ("inventory4") == "axe") {
				weaponholder = axe;
			}
			if (PlayerPrefs.GetString ("inventory4") == "darkgloves") {
				weaponholder = darkgloves;
			}
			if (PlayerPrefs.GetString ("inventory4") == "darkarmour") {
				weaponholder = darkarmour;
			}
			if (PlayerPrefs.GetString ("inventory4") == "darkboots") {
				weaponholder = darkboots;
			}
			if (PlayerPrefs.GetString ("inventory4") == "cheese") {
				weaponholder = cheese;
			}
			if (PlayerPrefs.GetString ("inventory4") == "Key_B") {
				weaponholder = key;
			}
			if (PlayerPrefs.GetString ("inventory4") == "potiondoubledamage") {
				weaponholder = potiondoubledamage;
			}
			if (PlayerPrefs.GetString ("inventory4") == "potionweak") {
				weaponholder = potionweak;
			}
			if (PlayerPrefs.GetString ("inventory4") == null) {
				weaponholder = null;
			}
			inventory [inventory4].GetComponent<Image> ().sprite = weaponholder;
			if (PlayerPrefs.GetString ("inventory5") == "Bow1") {
				weaponholder = bow;
			}
			if (PlayerPrefs.GetString ("inventory5") == "sword") {
				weaponholder = sword;
			}
			if (PlayerPrefs.GetString ("inventory5") == "potion") {
				weaponholder = potion;
			}
			if (PlayerPrefs.GetString ("inventory5") == "apple") {
				weaponholder = apple;
			}
			if (PlayerPrefs.GetString ("inventory5") == "armour1") {
				weaponholder = armour1;
			}
			if (PlayerPrefs.GetString ("inventory5") == "armour2") {
				weaponholder = armour2;
			}
			if (PlayerPrefs.GetString ("inventory5") == "bat") {
				weaponholder = bat;
			}
			if (PlayerPrefs.GetString ("inventory5") == "belt") {
				weaponholder = belt;
			}
			if (PlayerPrefs.GetString ("inventory5") == "boots") {
				weaponholder = boots;
			}
			if (PlayerPrefs.GetString ("inventory5") == "bow2") {
				weaponholder = bow2;
			}
			if (PlayerPrefs.GetString ("inventory5") == "club") {
				weaponholder = club;
			}
			if (PlayerPrefs.GetString ("inventory5") == "dagger") {
				weaponholder = dagger;
			}
			if (PlayerPrefs.GetString ("inventory5") == "gloves") {
				weaponholder = gloves;
			}
			if (PlayerPrefs.GetString ("inventory5") == "mage") {
				weaponholder = mage;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring") {
				weaponholder = ring;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring2") {
				weaponholder = ring2;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring3") {
				weaponholder = ring3;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring4") {
				weaponholder = ring4;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring5") {
				weaponholder = ring5;
			}
			if (PlayerPrefs.GetString ("inventory5") == "ring6") {
				weaponholder = ring6;
			}
			if (PlayerPrefs.GetString ("inventory5") == "shield") {
				weaponholder = shield;
			}
			if (PlayerPrefs.GetString ("inventory5") == "warhammer") {
				weaponholder = warhammer;
			}
			if (PlayerPrefs.GetString ("inventory5") == "mountainsword") {
				weaponholder = mountainsword;
			}
			if (PlayerPrefs.GetString ("inventory5") == "greyarmour") {
				weaponholder = greyarmour;
			}
			if (PlayerPrefs.GetString ("inventory5") == "boots2") {
				weaponholder = boots2;
			}
			if (PlayerPrefs.GetString ("inventory5") == "wand") {
				weaponholder = wand;
			}
			if (PlayerPrefs.GetString ("inventory5") == "greygloves") {
				weaponholder = greygloves;
			}
			if (PlayerPrefs.GetString ("inventory5") == "greyboots") {
				weaponholder = greyboots;
			}
			if (PlayerPrefs.GetString ("inventory5") == "bow3") {
				weaponholder = bow3;
			}
			if (PlayerPrefs.GetString ("inventory5") == "axe") {
				weaponholder = axe;
			}
			if (PlayerPrefs.GetString ("inventory5") == "darkgloves") {
				weaponholder = darkgloves;
			}
			if (PlayerPrefs.GetString ("inventory5") == "darkarmour") {
				weaponholder = darkarmour;
			}
			if (PlayerPrefs.GetString ("inventory5") == "darkboots") {
				weaponholder = darkboots;
			}
			if (PlayerPrefs.GetString ("inventory5") == "cheese") {
				weaponholder = cheese;
			}
			if (PlayerPrefs.GetString ("inventory5") == "Key_B") {
				weaponholder = key;
			}
			if (PlayerPrefs.GetString ("inventory5") == "potiondoubledamage") {
				weaponholder = potiondoubledamage;
			}
			if (PlayerPrefs.GetString ("inventory5") == "potionweak") {
				weaponholder = potionweak;
			}
			if (PlayerPrefs.GetString ("inventory5") == null) {
				weaponholder = null;
			}
			inventory [inventory5].GetComponent<Image> ().sprite = weaponholder;
			if (PlayerPrefs.GetString ("armourimage") == null) {
				weaponholder = null;
			}
			if (PlayerPrefs.GetString ("armourimage") == "armour1") {
				armourimage.GetComponent<Image> ().sprite = armour1;
				armourarmourstat = 2;
			}
			if (PlayerPrefs.GetString ("armourimage") == "armour2") {
				armourimage.GetComponent<Image> ().sprite = armour2;
				armourarmourstat = 5;
			}
			if (PlayerPrefs.GetString ("armourimage") == "greyarmour") {
				armourimage.GetComponent<Image> ().sprite = greyarmour;
				armourarmourstat = 7;
			}
			if (PlayerPrefs.GetString ("armourimage") == "darkarmour") {
				armourimage.GetComponent<Image> ().sprite = darkarmour;
				armourarmourstat = 10;
			}
			if (PlayerPrefs.GetString ("glovesimage") == "belt") {
				glovesimage.GetComponent<Image> ().sprite = belt;
				armourglovesstat = 2;
			}
			if (PlayerPrefs.GetString ("glovesimage") == "gloves") {
				glovesimage.GetComponent<Image> ().sprite = gloves;
				armourglovesstat = 3;
			}
			if (PlayerPrefs.GetString ("glovesimage") == "greygloves") {
				glovesimage.GetComponent<Image> ().sprite = greygloves;
				armourglovesstat = 5;
			}
			if (PlayerPrefs.GetString ("glovesimage") == "darkgloves") {
				glovesimage.GetComponent<Image> ().sprite = darkgloves;
				armourglovesstat = 7;
			}
			if (PlayerPrefs.GetString ("glovesimage") == "shield") {
				glovesimage.GetComponent<Image> ().sprite = shield;
				armourglovesstat = 5;
			}
			if (PlayerPrefs.GetString ("bootsimage") == "boots") {
				bootsimage.GetComponent<Image> ().sprite = boots;
				armourbootsstat = 2;
			}
			if (PlayerPrefs.GetString ("bootsimage") == "boots2") {
				bootsimage.GetComponent<Image> ().sprite = boots2;
				armourbootsstat = 4;
			}
			if (PlayerPrefs.GetString ("bootsimage") == "greyboots") {
				bootsimage.GetComponent<Image> ().sprite = greyboots;
				armourbootsstat = 6;
			}
			if (PlayerPrefs.GetString ("bootsimage") == "darkboots") {
				bootsimage.GetComponent<Image> ().sprite = darkboots;
				armourbootsstat = 9;
			}
			if (PlayerPrefs.GetString ("ring1") == "true") {
				ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				armourringstat += 10;
			}
			if (PlayerPrefs.GetString ("ring2") == "true") {
				ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				playerspeedtrue = true;
			}
			if (PlayerPrefs.GetString ("ring3") == "true") {
				ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				playerhealth = true;
			}
			if (PlayerPrefs.GetString ("ring4") == "true") {
				ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				armourringstat += 40;
			}
			if (PlayerPrefs.GetString ("ring5") == "true") {
				ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				playerspeedtrue2 = true;
			}
			if (PlayerPrefs.GetString ("ring6") == "true") {
				ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
				playerhealth2 = true;
			}
			Debug.Log(PlayerPrefs.GetString("inventory1"));
			Debug.Log(PlayerPrefs.GetString("inventory2"));
			Debug.Log(PlayerPrefs.GetString("inventory3"));
			Debug.Log(PlayerPrefs.GetString("inventory4"));
			Debug.Log(PlayerPrefs.GetString("inventory5"));
		}
		ring1true = "false";
		ring2true = "false";
		ring3true = "false";
		ring4true = "false";
		ring5true = "false";
		ring6true = "false";
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
					if (gameObject.name == "warhammer(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = warhammer;
					}
					if (gameObject.name == "mountainsword(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = mountainsword;
					}
					if (gameObject.name == "greyarmour(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = greyarmour;
					}
					if (gameObject.name == "boots2(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = boots2;
					}
					if (gameObject.name == "wand(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = wand;
					}
					if (gameObject.name == "greygloves(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = greygloves;
					}
					if (gameObject.name == "greyboots(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = greyboots;
					}
					if (gameObject.name == "bow3(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = bow3;
					}
					if (gameObject.name == "axe(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = axe;
					}
					if (gameObject.name == "darkgloves(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = darkgloves;
					}
					if (gameObject.name == "darkarmour(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = darkarmour;
					}
					if (gameObject.name == "darkboots(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = darkboots;
					}
					if (gameObject.name == "cheese(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = cheese;
					}
					if (gameObject.name == "Key_B(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = key;
					}
					if (gameObject.name == "potiondoubledamage(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = potiondoubledamage;
					}
					if (gameObject.name == "potionweak(Clone)") {
						inventory [i + 0].GetComponent<Image> ().sprite = potionweak;
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
		if (weaponname == "greyarmour") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = greyarmour;
			armourarmourstat = 7;
		}
		if (weaponname == "darkarmour") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = darkarmour;
			armourarmourstat = 10;
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
		if (weaponname == "greygloves") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = greygloves;
			armourglovesstat = 5;
		}
		if (weaponname == "darkgloves") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = darkgloves;
			armourglovesstat = 7;
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
		if (weaponname == "boots2") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = boots2;
			armourbootsstat = 4;
		}
		if (weaponname == "greyboots") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = greyboots;
			armourbootsstat = 6;
		}
		if (weaponname == "darkboots") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = darkboots;
			armourbootsstat = 9;
		}
		if (weaponname == "apple") {
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			playerhealth3 = true;
		}
		if (weaponname == "cheese") {
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			playerhealth4 = true;
		}
		if (weaponname == "ring") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 10;
			ring1true = "true";
		}
		if (weaponname == "ring2") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue = true;
			ring2true = "true";
		}
		if (weaponname == "ring3") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth = true;
			ring3true = "true";
		}
		if (weaponname == "ring4") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 40;
			ring4true = "true";
		}
		if (weaponname == "ring5") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue2 = true;
			ring5true = "true";
		}
		if (weaponname == "ring6") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth2 = true;
			ring6true = "true";
		}
		if (weaponname == "Key_B") {
			weaponname = null;
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			keyimage.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			keytrue = true;
		}
		if (weaponname == "potiondoubledamage") {
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			doubledamage = 2;
			StartCoroutine (coroutine ());
		}
		if (weaponname == "potionweak") {
			inventory [inventory1].GetComponent<Image> ().sprite = null;
			playerx = player.transform.position.x;
			playery = player.transform.position.y + 2.5f;
			StartCoroutine (weakcoroutine ());
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
		if (weaponname == "greyarmour") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = greyarmour;
			armourarmourstat = 7;
		}
		if (weaponname == "darkarmour") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = darkarmour;
			armourarmourstat = 10;
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
		if (weaponname == "greygloves") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = greygloves;
			armourglovesstat = 5;
		}
		if (weaponname == "darkgloves") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = darkgloves;
			armourglovesstat = 7;
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
		if (weaponname == "boots2") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = boots2;
			armourbootsstat = 4;
		}
		if (weaponname == "greyboots") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = greyboots;
			armourbootsstat = 6;
		}
		if (weaponname == "darkboots") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = darkboots;
			armourbootsstat = 9;
		}
		if (weaponname == "apple") {
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			playerhealth3 = true;
		}
		if (weaponname == "cheese") {
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			playerhealth4 = true;
		}
		if (weaponname == "ring") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 10;
			ring1true = "true";
		}
		if (weaponname == "ring2") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue = true;
			ring2true = "true";
		}
		if (weaponname == "ring3") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth = true;
			ring3true = "true";
		}
		if (weaponname == "ring4") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 40;
			ring4true = "true";
		}
		if (weaponname == "ring5") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue2 = true;
			ring5true = "true";
		}
		if (weaponname == "ring6") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth2 = true;
			ring6true = "true";
		}
		if (weaponname == "Key_B") {
			weaponname = null;
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			keyimage.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			keytrue = true;
		}
		if (weaponname == "potiondoubledamage") {
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			doubledamage = 2;
			StartCoroutine (coroutine ());
		}
		if (weaponname == "potionweak") {
			inventory [inventory2].GetComponent<Image> ().sprite = null;
			playerx = player.transform.position.x;
			playery = player.transform.position.y + 2.5f;
			StartCoroutine (weakcoroutine ());
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
		if (weaponname == "greyarmour") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = greyarmour;
			armourarmourstat = 7;
		}
		if (weaponname == "darkarmour") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = darkarmour;
			armourarmourstat = 10;
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
		if (weaponname == "greygloves") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = greygloves;
			armourglovesstat = 5;
		}
		if (weaponname == "darkgloves") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = darkgloves;
			armourglovesstat = 7;
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
		if (weaponname == "boots2") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = boots2;
			armourbootsstat = 4;
		}
		if (weaponname == "greyboots") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = greyboots;
			armourbootsstat = 6;
		}
		if (weaponname == "darkboots") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = darkboots;
			armourbootsstat = 9;
		}
		if (weaponname == "apple") {
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			playerhealth3 = true;
		}
		if (weaponname == "cheese") {
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			playerhealth4 = true;
		}
		if (weaponname == "ring") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 10;
			ring1true = "true";
		}
		if (weaponname == "ring2") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue = true;
			ring2true = "true";
		}
		if (weaponname == "ring3") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth = true;
			ring3true = "true";
		}
		if (weaponname == "ring4") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 40;
			ring4true = "true";
		}
		if (weaponname == "ring5") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue2 = true;
			ring5true = "true";
		}
		if (weaponname == "ring6") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth2 = true;
			ring6true = "true";
		}
		if (weaponname == "Key_B") {
			weaponname = null;
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			keyimage.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			keytrue = true;
		}
		if (weaponname == "potiondoubledamage") {
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			doubledamage = 2;
			StartCoroutine (coroutine ());
		}
		if (weaponname == "potionweak") {
			inventory [inventory3].GetComponent<Image> ().sprite = null;
			playerx = player.transform.position.x;
			playery = player.transform.position.y + 2.5f;
			StartCoroutine (weakcoroutine ());
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
		if (weaponname == "greyarmour") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = greyarmour;
			armourarmourstat = 7;
		}
		if (weaponname == "darkarmour") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = darkarmour;
			armourarmourstat = 10;
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
		if (weaponname == "greygloves") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = greygloves;
			armourglovesstat = 5;
		}
		if (weaponname == "darkgloves") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = darkgloves;
			armourglovesstat = 7;
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
		if (weaponname == "boots2") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = boots2;
			armourbootsstat = 4;
		}
		if (weaponname == "greyboots") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = greyboots;
			armourbootsstat = 6;
		}
		if (weaponname == "darkboots") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = darkboots;
			armourbootsstat = 9;
		}
		if (weaponname == "apple") {
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			playerhealth3 = true;
		}
		if (weaponname == "cheese") {
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			playerhealth4 = true;
		}
		if (weaponname == "ring") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 10;
			ring1true = "true";
		}
		if (weaponname == "ring2") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue = true;
			ring2true = "true";
		}
		if (weaponname == "ring3") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth = true;
			ring3true = "true";
		}
		if (weaponname == "ring4") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 40;
			ring4true = "true";
		}
		if (weaponname == "ring5") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue2 = true;
			ring5true = "true";
		}
		if (weaponname == "ring6") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth2 = true;
			ring6true = "true";
		}
		if (weaponname == "Key_B") {
			weaponname = null;
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			keyimage.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			keytrue = true;
		}
		if (weaponname == "potiondoubledamage") {
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			doubledamage = 2;
			StartCoroutine (coroutine ());
		}
		if (weaponname == "potionweak") {
			inventory [inventory4].GetComponent<Image> ().sprite = null;
			playerx = player.transform.position.x;
			playery = player.transform.position.y + 2.5f;
			StartCoroutine (weakcoroutine ());
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
		if (weaponname == "greyarmour") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = greyarmour;
			armourarmourstat = 7;
		}
		if (weaponname == "darkarmour") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			armourimage.GetComponent<Image> ().sprite = darkarmour;
			armourarmourstat = 10;
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
		if (weaponname == "greygloves") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = greygloves;
			armourglovesstat = 5;
		}
		if (weaponname == "darkgloves") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			glovesimage.GetComponent<Image> ().sprite = darkgloves;
			armourglovesstat = 7;
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
		if (weaponname == "boots2") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = boots2;
			armourbootsstat = 4;
		}
		if (weaponname == "greyboots") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = greyboots;
			armourbootsstat = 6;
		}
		if (weaponname == "darkboots") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			bootsimage.GetComponent<Image> ().sprite = darkboots;
			armourbootsstat = 9;
		}
		if (weaponname == "apple") {
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			playerhealth3 = true;
		}
		if (weaponname == "cheese") {
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			playerhealth4 = true;
		}
		if (weaponname == "ring") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring1image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 10;
			ring1true = "true";
		}
		if (weaponname == "ring2") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring2image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue = true;
			ring2true = "true";
		}
		if (weaponname == "ring3") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring3image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth = true;
			ring3true = "true";
		}
		if (weaponname == "ring4") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring4image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			armourringstat += 40;
			ring4true = "true";
		}
		if (weaponname == "ring5") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring5image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerspeedtrue2 = true;
			ring5true = "true";
		}
		if (weaponname == "ring6") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			ring6image.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			playerhealth2 = true;
			ring6true = "true";
		}
		if (weaponname == "Key_B") {
			weaponname = null;
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			keyimage.GetComponent<Image> ().color = new Color32 (130, 98, 56, 255);
			keytrue = true;
		}
		if (weaponname == "potiondoubledamage") {
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			doubledamage = 2;
			StartCoroutine (coroutine ());
		}
		if (weaponname == "potionweak") {
			inventory [inventory5].GetComponent<Image> ().sprite = null;
			playerx = player.transform.position.x;
			playery = player.transform.position.y + 2.5f;
			StartCoroutine (weakcoroutine ());
		}
	}
	//Activates when X for slot 1 pressed
	public void Remove1()
	{
		inventory[inventory1].GetComponent<Image>().sprite=null;
	}
	//Activates when X for slot 2 pressed
	public void Remove2()
	{
		inventory[inventory2].GetComponent<Image>().sprite=null;
	}
	//Activates when X for slot 3 pressed
	public void Remove3()
	{
		inventory[inventory3].GetComponent<Image>().sprite=null;
	}
	//Activates when X for slot 4 pressed
	public void Remove4()
	{
		inventory[inventory4].GetComponent<Image>().sprite=null;
	}
	//Activates when X for slot 5 pressed
	public void Remove5()
	{
		inventory[inventory5].GetComponent<Image>().sprite=null;
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
			
			damage = 2 * doubledamage;
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
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the sword
		else if (weaponname == "sword") {
			damage = 3 * doubledamage;
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
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the bat
		else if (weaponname == "bat") {
			damage = 4 * doubledamage;
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
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the bow2
		else if (weaponname == "bow2") {
			damage = 3 * doubledamage;
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
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the bow3
		else if (weaponname == "bow3") {
			damage = 4 * doubledamage;
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
			hidebow2.SetActive (false);
			hideclub.SetActive (false);
			hidedagger.SetActive (false);
			hidegloves.SetActive (false);
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (true);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the club
		else if (weaponname == "club") {
			damage = 6 * doubledamage;
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
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the dagger
		else if (weaponname == "dagger") {
			damage = 4 * doubledamage;
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
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the mage
		else if (weaponname == "mage") {
			damage = 15 * doubledamage;
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
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the warhammer
		else if (weaponname == "warhammer") {
			damage = 5 * doubledamage;
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
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (true);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the mountainsword
		else if (weaponname == "mountainsword") {
			damage = 4 * doubledamage;
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
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (true);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the wand
		else if (weaponname == "wand") {
			damage = 10 * doubledamage;
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
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (true);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (false);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
			return damage;
		}
		//Sets damage for the axe
		else if (weaponname == "axe") {
			damage = 7 * doubledamage;
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
			hidemage.SetActive (false);
			hidering.SetActive (false);
			hideshield.SetActive (false);
			hidepotiondouble.SetActive (false);
			hidewarhammer.SetActive (false);
			hidemountainsword.SetActive (false);
			hidegreyarmour.SetActive (false);
			hideboots2.SetActive (false);
			hidewand.SetActive (false);
			hidegreygloves.SetActive (false);
			hidegreyboots.SetActive (false);
			hidebow3.SetActive (false);
			hideaxe.SetActive (true);
			hidedarkgloves.SetActive (false);
			hidedarkarmour.SetActive (false);
			hidedarkboots.SetActive (false);
			hidecheese.SetActive (false);
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
			hidepotiondouble.SetActive (false);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				
				if(sleep==false)
				{
					playerspeed = Random.Range (0f, 5f) * speeddouble;
					sound++;
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
	//Waits for 10 seconds for double damage potion
	IEnumerator coroutine()
	{
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
		hidemage.SetActive (false);
		hidering.SetActive (false);
		hideshield.SetActive (false);
		hidepotiondouble.SetActive (true);
		yield return new WaitForSecondsRealtime (10);
		doubledamage = 1;
	}
	//Destroys weakness area of effect after 5 seconds
	IEnumerator weakcoroutine()
	{
		weakwall = Instantiate (weak, new Vector2 (playerx, playery), Quaternion.identity);
		yield return new WaitForSecondsRealtime (5);
		Destroy (weakwall);
	}
}
