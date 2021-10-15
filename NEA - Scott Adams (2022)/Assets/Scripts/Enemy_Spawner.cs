/*
* Created: Sprint 4
* Last Edited: Sprint 4
* Purpose: Creates a spawner to create more enemies
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		for (int i = 0; i < 3; i++) {
			enemyspawned.Add(Instantiate(enemy,new Vector2(90.1f,2.8f),Quaternion.identity));
			spawnerfull [i] = true;
		}
		
	}

	// Update is called once per frame
	void Update () {
		if (spawnerfull[2]==false) {
			enemyspawned.Insert (2, (Instantiate (enemy, new Vector2 (90.1f, 2.8f), Quaternion.identity)));
			spawnerfull [2] = true;
			Debug.Log ("I2:True");
		}
		if (spawnerfull[1]==false) {
			enemyspawned.Insert (1, (Instantiate (enemy, new Vector2 (90.1f, 2.8f), Quaternion.identity)));
			spawnerfull [1] = true;
			Debug.Log ("I1:True");
		}
		if (spawnerfull[0]==false) {
			enemyspawned.Insert (0, (Instantiate (enemy, new Vector2 (90.1f, 2.8f), Quaternion.identity)));
			spawnerfull [0] = true;
			Debug.Log ("I0:True");
		}	
			
			
		//}
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
		if (enemyspawned.Count >= 4) {
			for (int i = 3; i < enemyspawned.Count; i++) {
				Destroy (enemyspawned [i]);
				enemyspawned [i] = null;
			}
		}
	}
}
