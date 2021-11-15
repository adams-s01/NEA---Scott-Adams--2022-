using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blindpotion : MonoBehaviour {

	GameObject blindcanvas;

	// Use this for initialization
	void Start () {
		blindcanvas = GameObject.FindGameObjectWithTag ("blindcanvas");
		blindcanvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag=="Player")
		{
			blindcanvas.SetActive(true);
		}
	}
}
