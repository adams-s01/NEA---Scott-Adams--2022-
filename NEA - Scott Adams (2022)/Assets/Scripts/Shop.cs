/*
* Created: Sprint 2
* Last Edited: Sprint 11
* Purpose: Causes a shop to exist
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour {

	public GameObject shopmenu;
	public GameObject shopmenu2;
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject item4;
	public GameObject item5;
	public GameObject item6;
	public GameObject item7;
	public GameObject item8;
	public GameObject item9;
	public GameObject item10;
	public GameObject item11;
	public GameObject item12;
	public GameObject item13;
	public GameObject item14;
	public GameObject item15;
	public GameObject item16;
	public GameObject item17;
	public GameObject item18;
	public GameObject item19;
	public GameObject item20;
	public GameObject item21;
	public GameObject item22;
	public GameObject item23;
	public GameObject item24;
	public GameObject item25;
	public GameObject item26;
	public GameObject item27;
	public GameObject item28;
	public GameObject item29;
	public GameObject item30;
	public Button item1button;
	public Button item2button;
	public Button item3button;
	public Button item4button;
	public Button item5button;
	public Button item6button;
	public Button item7button;
	public Button item8button;
	public Button item9button;
	public Button item10button;
	public Button item11button;
	public Button item12button;
	public Button item13button;
	public Button item14button;
	public Button item15button;
	public Button item16button;
	public Button item17button;
	public Button item18button;
	public Button item19button;
	public Button item20button;
	public Button item21button;
	public Button item22button;
	public Button item23button;
	public Button item24button;
	public Button item25button;
	public Button item26button;
	public Button item27button;
	public Button item28button;
	public Button item29button;
	public Button item30button;
	public int gold;
	public TextMeshProUGUI goldtext;
	public TextMeshProUGUI goldtext2;
	ColorBlock unusablecolour;
	ColorBlock usablecolour;
	float playerx;
	float playery;
	public GameObject player;
	public GameObject sword;
	public GameObject apple;
	public GameObject armour1;
	public GameObject boots;
	public GameObject club;
	public GameObject mage;
	public GameObject bat;
	public GameObject shield;
	public GameObject belt;
	public GameObject gloves;
	public GameObject belt1;
	public GameObject bow;
	public GameObject armour2;
	public GameObject ring;
	public GameObject potion;
	public GameObject dagger;
	public GameObject ring3;
	public GameObject warhammer;
	public GameObject mountainsword;
	public GameObject greyarmour;
	public GameObject boots2;
	public GameObject wand;
	public GameObject greygloves;
	public GameObject greyboots;
	public GameObject bow3;
	public GameObject axe;
	public GameObject ring4;
	public GameObject darkgloves;
	public GameObject darkarmour;
	public GameObject darkboots;
	public GameObject cheese;
	public GameObject other;
	private Player_Movement other2;


	//Initialises shopmenu and hides the shop menu canvas
	void Start () {
		//shopmenu2 = GameObject.FindGameObjectWithTag ("shopmenu2");
		/*item1 = GameObject.FindGameObjectWithTag ("item1");
		item2 = GameObject.FindGameObjectWithTag ("item2");
		item3 = GameObject.FindGameObjectWithTag ("item3");
		item4 = GameObject.FindGameObjectWithTag ("item4");
		item5 = GameObject.FindGameObjectWithTag ("item5");
		item6 = GameObject.FindGameObjectWithTag ("item6");
		item7 = GameObject.FindGameObjectWithTag ("item7");
		item8 = GameObject.FindGameObjectWithTag ("item8");
		item9 = GameObject.FindGameObjectWithTag ("item9");
		item10 = GameObject.FindGameObjectWithTag ("item10");
		item11 = GameObject.FindGameObjectWithTag ("item11");
		item12 = GameObject.FindGameObjectWithTag ("item12");
		item13 = GameObject.FindGameObjectWithTag ("item13");
		item14 = GameObject.FindGameObjectWithTag ("item14");
		item15 = GameObject.FindGameObjectWithTag ("item15");
		item16 = GameObject.FindGameObjectWithTag ("item16");
		item17 = GameObject.FindGameObjectWithTag ("item17");
		item18 = GameObject.FindGameObjectWithTag ("item18");
		item19 = GameObject.FindGameObjectWithTag ("item19");
		item20 = GameObject.FindGameObjectWithTag ("item20");
		item21 = GameObject.FindGameObjectWithTag ("item21");
		item22 = GameObject.FindGameObjectWithTag ("item22");
		item23 = GameObject.FindGameObjectWithTag ("item23");
		item24 = GameObject.FindGameObjectWithTag ("item24");
		item25 = GameObject.FindGameObjectWithTag ("item25");
		item26 = GameObject.FindGameObjectWithTag ("item26");
		item27 = GameObject.FindGameObjectWithTag ("item27");
		item28 = GameObject.FindGameObjectWithTag ("item28");
		item29 = GameObject.FindGameObjectWithTag ("item29");
		item30 = GameObject.FindGameObjectWithTag ("item30");*/
		shopmenu.SetActive (false);
		shopmenu2.SetActive (false);
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		if (SceneManager.GetActiveScene ().buildIndex == 2) {
			gold = 1000;
		}
		if (SceneManager.GetActiveScene ().buildIndex == 3 || SceneManager.GetActiveScene ().buildIndex == 4) {
			gold = PlayerPrefs.GetInt ("gold");
		}
		unusablecolour = item1button.colors;
		usablecolour = item1button.colors;
		unusablecolour.highlightedColor = new Color32 (204, 0, 0, 255);
		unusablecolour.normalColor = new Color32 (255, 0, 0, 255);
		unusablecolour.pressedColor = new Color32 (255, 73, 73, 255);
		usablecolour.highlightedColor = new Color32 (0, 204, 0, 255);
		usablecolour.normalColor = new Color32 (0, 255, 0, 255);
		usablecolour.pressedColor = new Color32 (73, 255, 73, 255);
		//player = GameObject.FindGameObjectWithTag ("Player");
		other2 = other.GetComponent<Player_Movement> ();
	}
	
	// Sets text for amount of gold
	void Update () {
		gold += other2.gold;
		goldtext.text = "Gold: " + gold.ToString ();
		goldtext2.text = "Gold: " + gold.ToString ();
		Debug.Log (gold);
		/*if (gold >= 10) {
			item1button.colors = usablecolour;
		}
		if (gold < 10) {
			item1button.colors = unusablecolour;
		}*/
		
	}
	//Collides with player and makes shop menu visible
	public void OnTriggerStay2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			shopmenu.SetActive (true);
		}
	}
			
	//Button to make shop menu disappear
	public void Exit()
	{
		shopmenu.SetActive (false);
		shopmenu2.SetActive (false);
	}
	//Button to move to next shop menu
	public void Shopmenu2()
	{
		shopmenu2.SetActive (true);
		shopmenu.SetActive (false);
	}
	//Button to move to previous shop menu
	public void Shopmenu()
	{
		shopmenu.SetActive (true);
		shopmenu2.SetActive (false);
	}
	//Button to make item 1 stats appear
	public void Item1()
	{
		item1.SetActive (true);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Mokes button green
		if (gold >= 10) {
			item1button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 10) {
			item1button.colors = unusablecolour;
		}
	}
	//Button to make item 2 stats appear
	public void Item2()
	{
		item1.SetActive (false);
		item2.SetActive (true);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 15) {
			item2button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 15) {
			item2button.colors = unusablecolour;
		}
	}
	//Button to make item 3 stats appear
	public void Item3()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (true);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 20) {
			item3button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 20) {
			item3button.colors = unusablecolour;
		}
	}
	//Button to make item 4 stats appear
	public void Item4()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (true);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 15) {
			item4button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 15) {
			item4button.colors = unusablecolour;
		}
	}
	//Button to make item 5 stats appear
	public void Item5()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (true);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 20) {
			item5button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 20) {
			item5button.colors = unusablecolour;
		}
	}
	//Button to make item 6 stats appear
	public void Item6()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (true);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 100) {
			item6button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 100) {
			item6button.colors = unusablecolour;
		}
	}
	//Button to make item 7 stats appear
	public void Item7()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (true);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 30) {
			item7button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 30) {
			item7button.colors = unusablecolour;
		}
	}
	//Button to make item 8 stats appear
	public void Item8()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (true);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 30) {
			item8button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 30) {
			item8button.colors = unusablecolour;
		}
	}
	//Button to make item 9 stats appear
	public void Item9()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (true);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 15) {
			item9button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 15) {
			item9button.colors = unusablecolour;
		}
	}
	//Button to make item 10 stats appear
	public void Item10()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (true);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 25) {
			item10button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 25) {
			item10button.colors = unusablecolour;
		}
	}
	//Button to make item 11 stats appear
	public void Item11()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (true);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 25) {
			item11button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 25) {
			item11button.colors = unusablecolour;
		}
	}
	//Button to make item 12 stats appear
	public void Item12()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (true);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 50) {
			item12button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 50) {
			item12button.colors = unusablecolour;
		}
	}
	//Button to make item 13 stats appear
	public void Item13()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (true);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 15) {
			item13button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 15) {
			item13button.colors = unusablecolour;
		}
	}
	//Button to make item 14 stats appear
	public void Item14()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (true);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 20) {
			item14button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 20) {
			item14button.colors = unusablecolour;
		}
	}
	//Button to make item 15 stats appear
	public void Item15()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (true);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 25) {
			item15button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 25) {
			item15button.colors = unusablecolour;
		}
	}
	//Button to make item 16 stats appear
	public void Item16()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (true);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 40) {
			item16button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 40) {
			item16button.colors = unusablecolour;
		}
	}
	//Button to make item 17 stats appear
	public void Item17()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (true);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 35) {
			item17button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 35) {
			item17button.colors = unusablecolour;
		}
	}
	//Button to make item 18 stats appear
	public void Item18()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (true);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 30) {
			item18button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 30) {
			item18button.colors = unusablecolour;
		}
	}
	//Button to make item 19 stats appear
	public void Item19()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (true);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 65) {
			item19button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 65) {
			item19button.colors = unusablecolour;
		}
	}
	//Button to make item 20 stats appear
	public void Item20()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (true);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 35) {
			item20button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 35) {
			item20button.colors = unusablecolour;
		}
	}
	//Button to make item 21 stats appear
	public void Item21()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (true);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 50) {
			item21button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 50) {
			item21button.colors = unusablecolour;
		}
	}
	//Button to make item 22 stats appear
	public void Item22()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (true);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 50) {
			item22button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 50) {
			item22button.colors = unusablecolour;
		}
	}
	//Button to make item 23 stats appear
	public void Item23()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (true);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 45) {
			item23button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 45) {
			item23button.colors = unusablecolour;
		}
	}
	//Button to make item 24 stats appear
	public void Item24()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (true);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 35) {
			item24button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 35) {
			item24button.colors = unusablecolour;
		}
	}
	//Button to make item 25 stats appear
	public void Item25()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (true);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 40) {
			item25button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 40) {
			item25button.colors = unusablecolour;
		}
	}
	//Button to make item 26 stats appear
	public void Item26()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (true);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 75) {
			item26button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 75) {
			item26button.colors = unusablecolour;
		}
	}
	//Button to make item 27 stats appear
	public void Item27()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (true);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 70) {
			item27button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 70) {
			item27button.colors = unusablecolour;
		}
	}
	//Button to make item 28 stats appear
	public void Item28()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (true);
		item29.SetActive (false);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 90) {
			item28button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 90) {
			item28button.colors = unusablecolour;
		}
	}
	//Button to make item 29 stats appear
	public void Item29()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (true);
		item30.SetActive (false);
		//Makes button green
		if (gold >= 75) {
			item29button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 75) {
			item29button.colors = unusablecolour;
		}
	}
	//Button to make item 30 stats appear
	public void Item30()
	{
		item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);
		item10.SetActive (false);
		item11.SetActive (false);
		item12.SetActive (false);
		item13.SetActive (false);
		item14.SetActive (false);
		item15.SetActive (false);
		item16.SetActive (false);
		item17.SetActive (false);
		item18.SetActive (false);
		item19.SetActive (false);
		item20.SetActive (false);
		item21.SetActive (false);
		item22.SetActive (false);
		item23.SetActive (false);
		item24.SetActive (false);
		item25.SetActive (false);
		item26.SetActive (false);
		item27.SetActive (false);
		item28.SetActive (false);
		item29.SetActive (false);
		item30.SetActive (true);
		//Makes button green
		if (gold >= 35) {
			item30button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 35) {
			item30button.colors = unusablecolour;
		}
	}
	//Activates Button 1
	public void Button1()
	{
		//Button 1 only works when gold is 10 or over, creates image of item
		if(gold>=10)
		{
			gold -= 10;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (sword, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 2
	public void Button2()
	{
		//Button 2 only works when gold is 15 or over, creates image of item
		if(gold>=15)
		{
			gold -= 15;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (apple, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 3
	public void Button3()
	{
		//Button 3 only works when gold is 20 or over, creates image of item
		if(gold>=20)
		{
			gold -= 20;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (armour1, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 4
	public void Button4()
	{
		//Button 4 only works when gold is 15 or over, creates image of item
		if(gold>=15)
		{
			gold -= 15;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (boots, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 5
	public void Button5()
	{
		//Button 5 only works when gold is 20 or over, creates image of item
		if(gold>=20)
		{
			gold -= 20;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (club, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 6
	public void Button6()
	{
		//Button 6 only works when gold is 100 or over, creates image of item
		if(gold>=100)
		{
			gold -= 100;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (mage, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 7
	public void Button7()
	{
		//Button 7 only works when gold is 30 or over, creates image of item
		if(gold>=30)
		{
			gold -= 30;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (bat, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 8
	public void Button8()
	{
		//Button 8 only works when gold is 30 or over, creates image of item
		if(gold>=30)
		{
			gold -= 30;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (shield, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 9
	public void Button9()
	{
		//Button 9 only works when gold is 15 or over, creates image of item
		if(gold>=15)
		{
			gold -= 15;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (belt1, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 10
	public void Button10()
	{
		//Button 10 only works when gold is 25 or over, creates image of item
		if(gold>=25)
		{
			gold -= 25;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (gloves, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 11
	public void Button11()
	{
		//Button 11 only works when gold is 25 or over, creates image of item
		if(gold>=25)
		{
			gold -= 25;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (bow, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 12
	public void Button12()
	{
		//Button 12 only works when gold is 50 or over, creates image of item
		if(gold>=50)
		{
			gold -= 50;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (armour2, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 13
	public void Button13()
	{
		//Button 13 only works when gold is 15 or over, creates image of item
		if(gold>=15)
		{
			gold -= 15;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (ring, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 14
	public void Button14()
	{
		//Button 14 only works when gold is 20 or over, creates image of item
		if(gold>=20)
		{
			gold -= 20;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (potion, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 15
	public void Button15()
	{
		//Button 15 only works when gold is 25 or over, creates image of item
		if(gold>=25)
		{
			gold -= 25;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (dagger, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 16
	public void Button16()
	{
		//Button 16 only works when gold is 40 or over, creates image of item
		if(gold>=40)
		{
			gold -= 40;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (ring3, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 17
	public void Button17()
	{
		//Button 17 only works when gold is 35 or over, creates image of item
		if(gold>=35)
		{
			gold -= 35;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (warhammer, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 18
	public void Button18()
	{
		//Button 18 only works when gold is 30 or over, creates image of item
		if(gold>=30)
		{
			gold -= 30;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (mountainsword, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 19
	public void Button19()
	{
		//Button 19 only works when gold is 65 or over, creates image of item
		if(gold>=65)
		{
			gold -= 65;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (greyarmour, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 20
	public void Button20()
	{
		//Button 20 only works when gold is 35 or over, creates image of item
		if(gold>=35)
		{
			gold -= 35;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (boots2, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 21
	public void Button21()
	{
		//Button 21 only works when gold is 50 or over, creates image of item
		if(gold>=50)
		{
			gold -= 50;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (wand, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 22
	public void Button22()
	{
		//Button 22 only works when gold is 50 or over, creates image of item
		if(gold>=50)
		{
			gold -= 50;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (greygloves, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 23
	public void Button23()
	{
		//Button 23 only works when gold is 45 or over, creates image of item
		if(gold>=45)
		{
			gold -= 45;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (greyboots, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 24
	public void Button24()
	{
		//Button 24 only works when gold is 35 or over, creates image of item
		if(gold>=35)
		{
			gold -= 35;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (bow3, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 25
	public void Button25()
	{
		//Button 25 only works when gold is 40 or over, creates image of item
		if(gold>=40)
		{
			gold -= 40;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (axe, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 26
	public void Button26()
	{
		//Button 26 only works when gold is 75 or over, creates image of item
		if(gold>=75)
		{
			gold -= 75;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (ring4, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 27
	public void Button27()
	{
		//Button 27 only works when gold is 70 or over, creates image of item
		if(gold>=70)
		{
			gold -= 70;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (darkgloves, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 28
	public void Button28()
	{
		//Button 28 only works when gold is 90 or over, creates image of item
		if(gold>=90)
		{
			gold -= 90;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (darkarmour, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 29
	public void Button29()
	{
		//Button 29 only works when gold is 75 or over, creates image of item
		if(gold>=75)
		{
			gold -= 75;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (darkboots, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}
	//Activates Button 30
	public void Button30()
	{
		//Button 30 only works when gold is 35 or over, creates image of item
		if(gold>=35)
		{
			gold -= 35;
			playerx = player.transform.position.x;
			playery = player.transform.position.y;
			Instantiate (cheese, new Vector2 (playerx, playery), Quaternion.identity);
		}
	}

}
