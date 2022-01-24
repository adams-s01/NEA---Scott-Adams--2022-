/*
* Created: Sprint 8
* Last Edited: Sprint 14
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
	bool sleep2;
	IEnumerator coroutine;
	public GameObject mutebutton;
	public GameObject unmutebutton;
	public GameObject mutesoundbutton;
	public GameObject unmutesoundbutton;
	bool sound2;

	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource> ();
		other2 = other.GetComponent<Inventory_1> ();
	}

	// Update is called once per frame
	void Update () {
		if (sleep == false && sleep2 == false) {
			coroutine = backgroundcoroutine ();
			StartCoroutine (coroutine);
		}
		if (other2.sound == sound1) {
			if (sound1 != 0) {
				if (sound2 == false) {
					source.PlayOneShot (potion, 1);
				}
			}
			sound1++;
		}
		if (sleep2 == true) {
			source.Pause ();

		}
		if (sleep2 == false) {
			source.UnPause ();
			Debug.Log ("789");
		}
	}
	//Adds coin sound when collide with a coin
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "coin(Clone)" || col.gameObject.name == "coin2(Clone)" || col.gameObject.name == "coin3(Clone)") {
			if (sound2 == false) {
				source.PlayOneShot (coin, 1);
			}
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
	public void Mute()
	{
		sleep2 = true;
		unmutebutton.SetActive (true);
		mutebutton.SetActive (false);
	}
	public void Unmute()
	{
		sleep2 = false;
		mutebutton.SetActive (true);
		unmutebutton.SetActive (false);
	}
	public void MuteSound()
	{
		sound2 = true;
		unmutesoundbutton.SetActive (true);
		mutesoundbutton.SetActive (false);
	}
	public void UnmuteSound()
	{
		sound2 = false;
		mutesoundbutton.SetActive (true);
		unmutesoundbutton.SetActive (false);
	}
}
