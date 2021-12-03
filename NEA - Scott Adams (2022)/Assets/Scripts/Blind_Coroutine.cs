using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blind_Coroutine : MonoBehaviour {

	public GameObject other;
	Enemy_Movement other2;
	public GameObject blind;
	GameObject blindarea;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		other2 = other.GetComponent<Enemy_Movement> ();
		if (other2.sleep1 == true) {
			StartCoroutine (removeblindcoroutine ());
		}
	}
	//Waits for 5 seconds to remove the blind area
	IEnumerator removeblindcoroutine()
	{
		other2.sleep1 = false;
		blindarea = Instantiate (blind, new Vector2 (other2.enemyx, other2.enemyy), Quaternion.identity);
		Debug.Log ("start of call");
		yield return new WaitForSecondsRealtime (5);
		Debug.Log ("after call");
		Destroy (blindarea);
		other2.sleep1 = true;
	}
}
