/*
* Created: Sprint 2
* Last Edited: Sprint 6
* Purpose: Causes a shop to exist
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

	public GameObject shopmenu;
	GameObject item1;
	GameObject item2;
	GameObject item3;
	GameObject item4;
	GameObject item5;
	GameObject item6;
	GameObject item7;
	GameObject item8;
	GameObject item9;
	GameObject item10;
	GameObject item11;
	GameObject item12;
	GameObject item13;
	GameObject item14;
	GameObject item15;
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
	public int gold;
	public TextMeshProUGUI goldtext;
	ColorBlock unusablecolour;
	ColorBlock usablecolour;
	float playerx;
	float playery;
	GameObject player;
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
	public GameObject other;
	private Player_Movement other2;


	//Initialises shopmenu and hides the shop menu canvas
	void Start () {
		shopmenu = GameObject.FindGameObjectWithTag ("shopmenu");
		item1 = GameObject.FindGameObjectWithTag ("item1");
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
		shopmenu.SetActive (false);
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
		gold = 10;
		unusablecolour = item1button.colors;
		usablecolour = item1button.colors;
		unusablecolour.highlightedColor = new Color32 (204, 0, 0, 255);
		unusablecolour.normalColor = new Color32 (255, 0, 0, 255);
		unusablecolour.pressedColor = new Color32 (255, 73, 73, 255);
		usablecolour.highlightedColor = new Color32 (0, 204, 0, 255);
		usablecolour.normalColor = new Color32 (0, 255, 0, 255);
		usablecolour.pressedColor = new Color32 (73, 255, 73, 255);
		player = GameObject.FindGameObjectWithTag ("Player");
		other2 = other.GetComponent<Player_Movement> ();
	}
	
	// Sets text for amount of gold
	void Update () {
		gold += other2.gold;
		goldtext.text = "Gold: " + gold.ToString ();
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
		//Makes button green
		if (gold >= 25) {
			item15button.colors = usablecolour;
		}
		//Makes button red
		if (gold < 25) {
			item15button.colors = unusablecolour;
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

}
