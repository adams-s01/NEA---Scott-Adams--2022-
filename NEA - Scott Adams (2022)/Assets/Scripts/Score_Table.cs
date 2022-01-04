/*
* Created: Sprint 12
* Last Edited: Sprint 12
* Purpose: Read and writes to CSV file
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System;

public class Score_Table : MonoBehaviour {

	public GameObject other;
	Escape_Door other2;
	string filepath;

	// Use this for initialization
	void Start () {
		other2 = other.GetComponent<Escape_Door> ();
		filepath = getpath ();
	}
	
	// Update is called once per frame
	void Update () {
		if (other2.endstatscanvas.activeSelf == true) {
			
			StreamWriter writer = new StreamWriter (filepath, true);
			writer.WriteLine ("Name," + Time.fixedTime.ToString ("0.00"));
			writer.Close ();
			Debug.Log ("2345");
		}

	}
	private string getpath()
	{
		return Application.dataPath + "ScoreTable.csv";
	}
}
