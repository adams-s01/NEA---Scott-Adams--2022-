/*
* Created: Sprint 8
* Last Edited: Sprint 8
* Purpose: Shows which sections have been visited
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

	// Use this for initialization
	void Start () {
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

	}
}
