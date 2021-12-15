/*
* Created: Sprint 10
* Last Edited: Sprint 10
* Purpose: Causes blind area to be destroyed
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blind_Coroutine : MonoBehaviour {


	public GameObject blind;


	// Use this for initialization
	void Awake () {
		if (gameObject.name != "Blind") {
			StartCoroutine (removeblindcoroutine ());
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
	//Waits for 5 seconds to remove the blind area
	IEnumerator removeblindcoroutine()
	{
		yield return new WaitForSecondsRealtime (5);
		Destroy (gameObject);
	}
}
