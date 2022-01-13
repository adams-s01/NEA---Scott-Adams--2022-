/*
* Created: Sprint 7
* Last Edited: Sprint 13
* Purpose: Causes player to be blinded for a certain amount of time
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blindpotion : MonoBehaviour {

	public GameObject blindcanvas;
	bool sleep;
	public GameObject other;
	Enemy_Movement other2;
	Blind_Coroutine other3;

	// Use this for initialization
	void Start () {
		//blindcanvas = GameObject.FindGameObjectWithTag ("blindcanvas");
		blindcanvas.SetActive (false);
		other2 = other.GetComponent<Enemy_Movement> ();


	}
	
	// Update is called once per frame
	void Update () {
		other3 = other2.blindinstantiated.GetComponent<Blind_Coroutine> ();
		if (other3.makeblind == true) {
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
