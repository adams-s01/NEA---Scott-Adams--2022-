/*
* Created: Sprint 8
* Last Edited: Sprint 8
* Purpose: Adds sound to the game
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour {

	public AudioClip coin;
	public AudioClip background;
	private AudioSource source;
	bool sleep;

	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (sleep == false) {
			StartCoroutine (backgroundcoroutine ());
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "coin(Clone)" || col.gameObject.name == "coin2(Clone)" || col.gameObject.name == "coin3(Clone)") {
			source.PlayOneShot (coin, 1);
		}
	}
	IEnumerator backgroundcoroutine()
	{
		sleep = true;
		source.PlayOneShot (background, 0.5f);
		yield return new WaitForSecondsRealtime (60);
		sleep = false;
	}
}
