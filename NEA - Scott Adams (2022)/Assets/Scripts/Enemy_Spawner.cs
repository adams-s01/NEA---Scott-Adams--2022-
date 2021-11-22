/*
* Created: Sprint 4
* Last Edited: Sprint 6
* Purpose: Creates a spawner to create more enemies
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_Spawner : MonoBehaviour {

	GameObject spawner;
	public GameObject enemy;
	public List<GameObject> enemyspawned;
	public bool[] spawnerfull;
	int i;



	// Use this for initialization
	void Start () {
		spawner = GameObject.FindGameObjectWithTag ("spawner");
		enemyspawned=new List<GameObject>();
		//Determines location to spawn skeletons for tutorial
		if (SceneManager.GetActiveScene ().buildIndex == 1) {
			for (int i = 0; i < 3; i++) {
				enemyspawned.Add (Instantiate (enemy, new Vector2 (90.1f, 2.8f), Quaternion.identity));
				spawnerfull [i] = true;
			}
		}
		//Determines location to spawn skeletons for level 1
		if (SceneManager.GetActiveScene ().buildIndex == 2) {
			for (int i = 0; i < 3; i++) {
				enemyspawned.Add (Instantiate (enemy, new Vector2 (10.91f, -27.54f), Quaternion.identity));
				spawnerfull [i] = true;
			}
		}
	}

	// Update is called once per frame
	void Update () {
		//Spawns new enemy when old one destroyed
		//Spawns at location in tutorial
		if (SceneManager.GetActiveScene ().buildIndex == 1) {
			if (spawnerfull [2] == false) {
				enemyspawned.Insert (2, (Instantiate (enemy, new Vector2 (90.1f, 2.8f), Quaternion.identity)));
				spawnerfull [2] = true;
				Debug.Log ("I2:True");
			}
			if (spawnerfull [1] == false) {
				enemyspawned.Insert (1, (Instantiate (enemy, new Vector2 (90.1f, 2.8f), Quaternion.identity)));
				spawnerfull [1] = true;
				Debug.Log ("I1:True");
			}
			if (spawnerfull [0] == false) {
				enemyspawned.Insert (0, (Instantiate (enemy, new Vector2 (90.1f, 2.8f), Quaternion.identity)));
				spawnerfull [0] = true;
				Debug.Log ("I0:True");
			}
		}
		//Spawns at location in level 1
		if(SceneManager.GetActiveScene ().buildIndex == 2) {
			if (spawnerfull [2] == false) {
				enemyspawned.Insert (2, (Instantiate (enemy, new Vector2 (10.91f, -27.54f), Quaternion.identity)));
				spawnerfull [2] = true;
				Debug.Log ("I2:True");
			}
			if (spawnerfull [1] == false) {
				enemyspawned.Insert (1, (Instantiate (enemy, new Vector2 (10.91f, -27.54f), Quaternion.identity)));
				spawnerfull [1] = true;
				Debug.Log ("I1:True");
			}
			if (spawnerfull [0] == false) {
				enemyspawned.Insert (0, (Instantiate (enemy, new Vector2 (10.91f, -27.54f), Quaternion.identity)));
				spawnerfull [0] = true;
				Debug.Log ("I0:True");
			}
		}
			
			
		//}
		//Checks if old enemy is destroyed
		if (enemyspawned [0] == null) {
			spawnerfull [0] = false;
			Debug.Log ("I0:False");

		}
		else if (enemyspawned [1] == null) {
			spawnerfull [1] = false;
			Debug.Log ("I1:False");
		}
		else if (enemyspawned [2] == null) {
			spawnerfull [2] = false;
			Debug.Log ("I2:False");
		}
		//Removes excess enemies
		if (enemyspawned.Count >= 4) {
			for (int i = 3; i < enemyspawned.Count; i++) {
				Destroy (enemyspawned [i]);
				enemyspawned [i] = null;
			}
		}
	}
}
