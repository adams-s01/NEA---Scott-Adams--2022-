/*
* Created: Sprint 2
* Last Edited: Sprint 2
* Purpose: Causes an inventory to exist
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public GameObject[] inventory;
	public bool[] full;

	// Use this for initialization
	void Start () {
		full=new bool[4];
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
