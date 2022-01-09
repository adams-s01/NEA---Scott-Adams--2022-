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
	public TextMeshProUGUI fifth;
	public String[] array;
	public int count;
	bool twice;
	int i;
	string read;
	public GameObject scoreboard;
	public GameObject menu;
	public GameObject other3;
	Name other4;
	public GameObject other5;
	End_Stats other6;

	// Use this for initialization
	void Start () {
		if (SceneManager.GetActiveScene ().buildIndex != 0) {
			other2 = other.GetComponent<Escape_Door> ();
			other4 = other3.GetComponent<Name> ();
			other6 = other5.GetComponent<End_Stats> ();
		}
		filepath = getpath ();
		if (SceneManager.GetActiveScene ().buildIndex == 0) {
			scoreboard.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().buildIndex != 0) {
			//If the endstats canvas is active, open CSV
			if (other6.sendscore == true && once == false) {
				//Writes name and time to the CSV file
				once = true;
				StreamWriter writer = new StreamWriter (filepath, true);
				writer.WriteLine (Time.fixedTime.ToString ("00.00") + "," + other4.name);
				writer.Close ();
				Debug.Log ("2345");
			}
		}
		//For the score page showing the top five
		if (SceneManager.GetActiveScene ().buildIndex == 0) {
			StreamReader reader = new StreamReader (filepath);
			//Counts how many items in file
			if (twice == false) {
				twice = true;
				do {
					count++;
				} while(reader.ReadLine () != null);
			}
			array = new String[count-1];
			i = 0;
			//Adds items into an array
			while (!reader.EndOfStream) {
				//Debug.Log (reader.ReadLine ());
				array [i] = reader.ReadLine ();
				i++;
			}
			reader.Close ();
			//Organises array in order of shortest time to longest
			Array.Sort (array);
			//Shows the top five times
			first.text = "1: " + array [0];
			second.text = "2: " + array [1];
			third.text = "3: " + array [2];
			fourth.text = "4: " + array [3];
			fifth.text = "5: " + array [4];
		}
	}
	//Finds location of the file
	private string getpath()
	{
		return Application.dataPath + "ScoreTable.csv";
	}
	public void ExitButton()
	{
		scoreboard.SetActive (false);
		menu.SetActive (true);
	}
}
