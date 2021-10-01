/*
* Created: Sprint 2
* Last Edited: Sprint 2
* Purpose: Causes a shop to exist
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour {

	GameObject shopmenu;
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

	int gold;
	public TextMeshProUGUI goldtext;

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
	}
	
	// Update is called once per frame
	void Update () {
		goldtext.text = "Gold: " + gold.ToString ();
		
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
	}

}
