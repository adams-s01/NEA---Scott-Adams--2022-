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
	public GameObject other;
	Blind_Coroutine other2;

	// Use this for initialization
	void Start () {
		//blindcanvas = GameObject.FindGameObjectWithTag ("blindcanvas");
		blindcanvas.SetActive (false);
		other = GameObject.;
		other2 = other.GetComponent<Blind_Coroutine> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (other2.makeblind == true) {
			blindcanvas.SetActive (true);
			StartCoroutine (blindcoroutine ());
		}
	}
	IEnumerator blindcoroutine()
	{
		sleep = true;
		yield return new WaitForSecondsRealtime (10);
		blindcanvas.SetActive (false);
		sleep=false;
	}
}
