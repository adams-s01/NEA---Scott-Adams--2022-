/*
* Created: Sprint 8
* Last Edited: Sprint 14
* Purpose: Adds sound to the game
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
	int soundlevel;
	public float soundlevelfloat;
	public TextMeshProUGUI soundleveltext;

	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource> ();
		other2 = other.GetComponent<Inventory_1> ();
		soundlevel = 10;
		soundlevelfloat = (float)soundlevel / 10;
	}

	// Update is called once per frame
	void Update () {
		//Shows value of sound out of 10
		soundleveltext.text = "Sound Level: " + soundlevel + "/10";
		soundlevelfloat = (float)soundlevel / 10;
		//Plays backgroundcoroutine
		if (sleep == false && sleep2 == false) {
			coroutine = backgroundcoroutine ();
			StartCoroutine (coroutine);
		}
		//Plays potion sound
		if (other2.sound == sound1) {
			if (sound1 != 0) {
				if (sound2 == false) {
					source.PlayOneShot (potion, soundlevelfloat);
				}
			}
			sound1++;
		}
		//Pauses background sound
		if (sleep2 == true) {
			source.Pause ();

		}
		//Unpauses background sound
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
				source.PlayOneShot (coin, soundlevelfloat);
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
	//Activates when mute button pressed (mutes background)
	public void Mute()
	{
		sleep2 = true;
		unmutebutton.SetActive (true);
		mutebutton.SetActive (false);
	}
	//Activates when unmute button pressed (unmutes background)
	public void Unmute()
	{
		sleep2 = false;
		mutebutton.SetActive (true);
		unmutebutton.SetActive (false);
	}
	//Activates when mute sound button pressed (mutes sound)
	public void MuteSound()
	{
		sound2 = true;
		unmutesoundbutton.SetActive (true);
		mutesoundbutton.SetActive (false);
	}
	//Activates when unmute sound button pressed (unmutes sound)
	public void UnmuteSound()
	{
		sound2 = false;
		mutesoundbutton.SetActive (true);
		unmutesoundbutton.SetActive (false);
	}
	//Activates when + button pressed (increases volume up to 10)
	public void Plus()
	{
		if(soundlevel<10)
		{
			soundlevel++;
		}
	}
	//Activates when - button pressed (decreases volume to 0)
	public void Minus()
	{
		if(soundlevel>0)
		{
			soundlevel--;
		}
	}
}
