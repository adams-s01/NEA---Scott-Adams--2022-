/*
* Created: Sprint 7
* Last Edited: Sprint 7
* Purpose: Causes player to be blinded for a certain amount of time
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blindpotion : MonoBehaviour {

	public GameObject blindcanvas;
	bool sleep;

	// Use this for initialization
	void Start () {
		//blindcanvas = GameObject.FindGameObjectWithTag ("blindcanvas");
		blindcanvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Effects player when in blindness area
	void OnTriggerStay2D(Collider2D col)
	{
		if(col.gameObject.tag=="Player")
		{
			if (sleep == false) {
				blindcanvas.SetActive (true);
				StartCoroutine (blindcoroutine ());
			}
		}
	}
	//Keeps blindness for 10 seconds
	IEnumerator blindcoroutine()
	{
		sleep = true;
		yield return new WaitForSecondsRealtime (10);
		blindcanvas.SetActive (false);
		sleep=false;
	}
}
