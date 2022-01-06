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
using TMPro;
using UnityEngine.SceneManagement;

public class Score_Table : MonoBehaviour {

	public GameObject other;
	Escape_Door other2;
	string filepath;
	bool once;
	public TextMeshProUGUI first;
	public TextMeshProUGUI second;
	public TextMeshProUGUI third;
	public TextMeshProUGUI fourth;
	public TextMeshProUGUI five;

	// Use this for initialization
	void Start () {
		if (SceneManager.GetActiveScene ().buildIndex != 0) {
			other2 = other.GetComponent<Escape_Door> ();
		}
		filepath = getpath ();
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().buildIndex != 0) {
			//If the endstats canvas is active, open CSV
			if (other2.endstatscanvas.activeSelf == true && once == false) {
				//Writes name and time to the CSV file
				once = true;
				StreamWriter writer = new StreamWriter (filepath, true);
				writer.WriteLine ("Name," + Time.fixedTime.ToString ("0.00"));
				writer.Close ();
				Debug.Log ("2345");
			}
		}
		if (SceneManager.GetActiveScene ().buildIndex == 0) {
			StreamReader reader = new StreamReader (filepath);

		}
	}
	//Finds location of the file
	private string getpath()
	{
		return Application.dataPath + "ScoreTable.csv";
	}
}
