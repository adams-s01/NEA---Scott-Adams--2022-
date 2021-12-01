/*
* Created: Sprint 8
* Last Edited: Sprint 9
* Purpose: Shows which sections have been visited
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map_Boundaries : MonoBehaviour {

	public GameObject startzone;
	public GameObject spikes;
	public GameObject firstdown;
	public GameObject across;
	public GameObject upperroom;
	public GameObject partialdown;
	public GameObject connectingroom;
	public GameObject hallway;
	public GameObject spawnerroom;
	public GameObject hallwaypumpkin;
	public GameObject seconddown;
	public GameObject shop;
	public GameObject thirdhallway;
	public GameObject keyroom;
	public GameObject secondconnectingroom;
	public GameObject up;
	public GameObject slope;
	public GameObject escaperoom;
	public GameObject startzone2;
	public GameObject acrosstoup2;
	public GameObject firstup2;
	public GameObject acrosstop2;
	public GameObject topspawner2;
	public GameObject topshop2;
	public GameObject down2;
	public GameObject acrossfromdown2;
	public GameObject emptyroom2;
	public GameObject acrosstodownshop2;
	public GameObject downshop2;
	public GameObject thallway2;
	public GameObject seconddown2;
	public GameObject hallwaytokeyroom2;
	public GameObject keyroom2;
	public GameObject keyroomgap2;
	public GameObject downspawner2;
	public GameObject secondup2;
	public GameObject secondemptyroom2;
	public GameObject hallwaytoescaperoom2;
	public GameObject escaperoom2;

	// Use this for initialization
	void Start () {
		if (SceneManager.GetActiveScene ().buildIndex == 2) {
			startzone.SetActive (false);
			spikes.SetActive (false);
			firstdown.SetActive (false);
			across.SetActive (false);
			upperroom.SetActive (false);
			partialdown.SetActive (false);
			connectingroom.SetActive (false);
			hallway.SetActive (false);
			spawnerroom.SetActive (false);
			hallwaypumpkin.SetActive (false);
			seconddown.SetActive (false);
			shop.SetActive (false);
			thirdhallway.SetActive (false);
			keyroom.SetActive (false);
			secondconnectingroom.SetActive (false);
			up.SetActive (false);
			slope.SetActive (false);
			escaperoom.SetActive (false);
		}
		if (SceneManager.GetActiveScene ().buildIndex == 3) {
			startzone2.SetActive (false);
			acrosstoup2.SetActive (false);
			firstup2.SetActive (false);
			acrosstop2.SetActive (false);
			topspawner2.SetActive (false);
			topshop2.SetActive (false);
			down2.SetActive (false);
			acrossfromdown2.SetActive (false);
			emptyroom2.SetActive (false);
			acrosstodownshop2.SetActive (false);
			downshop2.SetActive (false);
			thallway2.SetActive (false);
			seconddown2.SetActive (false);
			hallwaytokeyroom2.SetActive (false);
			keyroom2.SetActive (false);
			keyroomgap2.SetActive (false);
			downspawner2.SetActive (false);
			secondup2.SetActive (false);
			secondemptyroom2.SetActive (false);
			hallwaytoescaperoom2.SetActive (false);
			escaperoom2.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Determines whether passed through barrier, sets that part of map active
	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Startzoneboundary") {
			startzone.SetActive (true);
		}
		if (col.gameObject.name == "Spikesboundary") {
			spikes.SetActive (true);
		}
		if (col.gameObject.name == "Firstdownboundary") {
			firstdown.SetActive (true);
		}
		if (col.gameObject.name == "Acrossboundary") {
			across.SetActive (true);
		}
		if (col.gameObject.name == "Upperroomboundary") {
			upperroom.SetActive (true);
		}
		if (col.gameObject.name == "Partialroomboundary") {
			partialdown.SetActive (true);
		}
		if (col.gameObject.name == "Connectingroomboundary") {
			connectingroom.SetActive (true);
		}
		if (col.gameObject.name == "Hallwayboundary") {
			hallway.SetActive (true);
		}
		if (col.gameObject.name == "Spawnerroomboundary") {
			spawnerroom.SetActive (true);
		}
		if (col.gameObject.name == "Hallwaypumpkinboundary") {
			hallwaypumpkin.SetActive (true);
		}
		if (col.gameObject.name == "Seconddownboundary") {
			seconddown.SetActive (true);
		}
		if (col.gameObject.name == "Shopboundary") {
			shop.SetActive (true);
		}
		if (col.gameObject.name == "Thirdhallwayboundary") {
			thirdhallway.SetActive (true);
		}
		if (col.gameObject.name == "Keyroomboundary") {
			keyroom.SetActive (true);
		}
		if (col.gameObject.name == "Secondconnectingroomboundary") {
			secondconnectingroom.SetActive (true);
		}
		if (col.gameObject.name == "Upboundary") {
			up.SetActive (true);
		}
		if (col.gameObject.name == "Slopeboundary") {
			slope.SetActive (true);
		}
		if (col.gameObject.name == "Escaperoomboundary") {
			escaperoom.SetActive (true);
		}
		if (col.gameObject.name == "Startzone2boundary") {
			startzone2.SetActive (true);
		}
		if (col.gameObject.name == "Acrosstoup2boundary") {
			acrosstoup2.SetActive (true);
		}
		if (col.gameObject.name == "Firstup2boundary") {
			firstup2.SetActive (true);
		}
		if (col.gameObject.name == "Acrosstop2boundary") {
			acrosstop2.SetActive (true);
		}
		if (col.gameObject.name == "Topspawner2boundary") {
			topspawner2.SetActive (true);
		}
		if (col.gameObject.name == "Topshop2boundary") {
			topshop2.SetActive (true);
		}
		if (col.gameObject.name == "Down2boundary") {
			down2.SetActive (true);
		}
		if (col.gameObject.name == "Acrossfromdown2boundary") {
			acrossfromdown2.SetActive (true);
		}
		if (col.gameObject.name == "Emptyroom2boundary") {
			emptyroom2.SetActive (true);
		}
		if (col.gameObject.name == "Acrosstodownshop2boundary") {
			acrosstodownshop2.SetActive (true);
		}
		if (col.gameObject.name == "Downshop2boundary") {
			downshop2.SetActive (true);
		}
		if (col.gameObject.name == "Thallway2boundary") {
			thallway2.SetActive (true);
		}
		if (col.gameObject.name == "Seconddown2boundary") {
			seconddown2.SetActive (true);
		}
		if (col.gameObject.name == "Hallwaytokeyroom2boundary") {
			hallwaytokeyroom2.SetActive (true);
		}
		if (col.gameObject.name == "Keyroom2boundary") {
			keyroom2.SetActive (true);
		}
		if (col.gameObject.name == "Keyroomgap2boundary") {
			keyroomgap2.SetActive (true);
		}
		if (col.gameObject.name == "Downspawner2boundary") {
			downspawner2.SetActive (true);
		}
		if (col.gameObject.name == "Secondup2boundary") {
			secondup2.SetActive (true);
		}
		if (col.gameObject.name == "Secondemptyroom2boundary") {
			secondemptyroom2.SetActive (true);
		}
		if (col.gameObject.name == "Hallwaytoescapedoor2boundary") {
			hallwaytoescaperoom2.SetActive (true);
		}
		if (col.gameObject.name == "Escaperoom2boundary") {
			escaperoom2.SetActive (true);
		}
	}
}
