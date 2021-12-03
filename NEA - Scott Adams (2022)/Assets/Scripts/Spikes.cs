/*
* Created: Sprint 6
* Last Edited: Sprint 9
* Purpose: To make the spikes work
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

	GameObject spike;
	public int playerdamage;
	bool sleep;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		spike = GameObject.FindGameObjectWithTag ("spikes");
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.tag == "spikes2") {
			SpikeMovement ();
		}
	}
	//Damages player when they land on the spikes
	void OnCollisionStay2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player"&&gameObject.tag=="spikes"||gameObject.tag=="spikes2") {
			playerdamage = 1;
			col.gameObject.SendMessage ("Damage", playerdamage);
		}
	}
	//Calls coroutine for spike to move
	public void SpikeMovement()
	{
		if (sleep == false) {
			StartCoroutine (spikecoroutine ());
		}
	}
	//Coroutine for causing bats to move
	IEnumerator spikecoroutine()
	{
		sleep = true;
		rb.AddForce (new Vector2 (0, -1) * 2, ForceMode2D.Impulse);
		yield return new WaitForSecondsRealtime (4);
		rb.velocity = Vector2.zero;
		rb.AddForce (new Vector2 (0, 1) * 2, ForceMode2D.Impulse);
		yield return new WaitForSecondsRealtime (4);
		rb.velocity = Vector2.zero;
		sleep = false;
	}
}
