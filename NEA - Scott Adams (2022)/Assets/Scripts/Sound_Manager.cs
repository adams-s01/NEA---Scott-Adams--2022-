﻿/*
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
	public AudioClip potion;
	private AudioSource source;
	bool sleep;
	public GameObject other;
	Inventory_1 other2;
	int sound1;

	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource> ();
		other2 = other.GetComponent<Inventory_1> ();
	}

	// Update is called once per frame
	void Update () {
		if (sleep == false) {
			StartCoroutine (backgroundcoroutine ());
		}
		if (other2.sound == sound1) {
			if (sound1 != 0) {
				source.PlayOneShot (potion, 1);
			}
			sound1++;
		}
	}
	//Adds coin sound when collide with a coin
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "coin(Clone)" || col.gameObject.name == "coin2(Clone)" || col.gameObject.name == "coin3(Clone)") {
			source.PlayOneShot (coin, 1);
		}
	}
	//Loops background music everytime it ends
	IEnumerator backgroundcoroutine()
	{
		sleep = true;
		source.PlayOneShot (background, 0.5f);
		yield return new WaitForSecondsRealtime (60);
		sleep = false;
	}
}
