/*
* Created: Sprint 4
* Last Edited: Sprint 13
* Purpose: Creates a spawner to create more enemies
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_Spawner : MonoBehaviour {

	GameObject spawner;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public List<GameObject> enemyspawned;
	public bool[] spawnerfull;
	int i;



	// Use this for initialization
	void Start () {
		spawner = GameObject.FindGameObjectWithTag ("spawner");
		enemyspawned=new List<GameObject>();

		//Determines location to spawn skeletons for tutorial
		if (SceneManager.GetActiveScene ().buildIndex == 1) {
			//for (int i = 0; i < 3; i++) {
			enemyspawned.Add (Instantiate (enemy1, new Vector2 (90.1f, 2.8f), Quaternion.identity));
			spawnerfull [0] = true;
			enemyspawned.Add (Instantiate (enemy2, new Vector2 (90.1f, 2.8f), Quaternion.identity));
			spawnerfull [1] = true;
			enemyspawned.Add (Instantiate (enemy3, new Vector2 (90.1f, 2.8f), Quaternion.identity));
			spawnerfull [2] = true;
			//}
			InvokeRepeating ("Spawner1",3,5);
		}
		//Determines location to spawn skeletons for level 1
		if (SceneManager.GetActiveScene ().buildIndex == 2) {
			//for (int i = 0; i < 3; i++) {
			enemyspawned.Add (Instantiate (enemy1, new Vector2 (10.91f, -27.54f), Quaternion.identity));
			spawnerfull [0] = true;
			enemyspawned.Add (Instantiate (enemy2, new Vector2 (10.91f, -27.54f), Quaternion.identity));
			spawnerfull [1] = true;
			enemyspawned.Add (Instantiate (enemy3, new Vector2 (10.91f, -27.54f), Quaternion.identity));
			spawnerfull [2] = true;
			//}
			InvokeRepeating ("Spawner2",3,5);
		}
		//Determines location to spawn skeletons for level 2
		if (SceneManager.GetActiveScene ().buildIndex == 3) {
			if (gameObject.name == "Spawnerdoor") {
				//for (int i = 0; i < 3; i++) {
				enemyspawned.Add (Instantiate (enemy1, new Vector2 (-16.55f, 7.45f), Quaternion.identity));
				spawnerfull [0] = true;
				enemyspawned.Add (Instantiate (enemy2, new Vector2 (-16.55f, 7.45f), Quaternion.identity));
				spawnerfull [1] = true;
				enemyspawned.Add (Instantiate (enemy3, new Vector2 (-16.55f, 7.45f), Quaternion.identity));
				spawnerfull [2] = true;
				//}
			}
			if (gameObject.name == "Spawnerdoor2") {
				//for (int i = 0; i < 3; i++) {
				enemyspawned.Add (Instantiate (enemy1, new Vector2 (16.93f, -17.81f), Quaternion.identity));
				spawnerfull [0] = true;
				enemyspawned.Add (Instantiate (enemy2, new Vector2 (16.93f, -17.81f), Quaternion.identity));
				spawnerfull [1] = true;
				enemyspawned.Add (Instantiate (enemy3, new Vector2 (16.93f, -17.81f), Quaternion.identity));
				spawnerfull [2] = true;
				//}
			}
			InvokeRepeating ("Spawner3",3,5);
		}
		//Determines location to spawn skeletons for level 3
		if (SceneManager.GetActiveScene ().buildIndex == 4) {
			if (gameObject.name == "Spawnerdoor") {
				//for (int i = 0; i < 3; i++) {
				enemyspawned.Add (Instantiate (enemy1, new Vector2 (19.2f, -5.07f), Quaternion.identity));
				spawnerfull [0] = true;
				enemyspawned.Add (Instantiate (enemy2, new Vector2 (19.2f, -5.07f), Quaternion.identity));
				spawnerfull [1] = true;
				enemyspawned.Add (Instantiate (enemy3, new Vector2 (19.2f, -5.07f), Quaternion.identity));
				spawnerfull [2] = true;
				//}
				InvokeRepeating ("Spawner4",3,5);
			}
		}
	}

	// Update is called once per frame
	void Update () {
		//Spawns new enemy when old one destroyed



			
			
		//}
		//Checks if old enemy is destroyed
		if (enemyspawned [0] == null) {
			spawnerfull [0] = false;
			//spawnerfull [1] = true;
			//spawnerfull [2] = true;
			Debug.Log ("I0:False");

		}
		else if (enemyspawned [1] == null) {
			//spawnerfull [0] = true;
			spawnerfull [1] = false;
			//spawnerfull [2] = true;
			Debug.Log ("I1:False");
		}
		else if (enemyspawned [2] == null) {
			//spawnerfull [0] = true;
			//spawnerfull [1] = true;
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
	void Spawner1()
	{



		//Spawns at location in tutorial
		if (spawnerfull [2] == false) {
			enemyspawned.Insert (2, (Instantiate (enemy3, new Vector2 (90.1f, 2.8f), Quaternion.identity)));
			spawnerfull [2] = true;
			Debug.Log ("I2:True");
		}
		if (spawnerfull [1] == false) {
			enemyspawned.Insert (1, (Instantiate (enemy2, new Vector2 (90.1f, 2.8f), Quaternion.identity)));
			spawnerfull [1] = true;
			Debug.Log ("I1:True");
		}
		if (spawnerfull [0] == false) {
			enemyspawned.Insert (0, (Instantiate (enemy1, new Vector2 (90.1f, 2.8f), Quaternion.identity)));
			spawnerfull [0] = true;
			Debug.Log ("I0:True");
		}
		
	}
	void Spawner2()
	{


		//Spawns at location in level 1
		if (spawnerfull [2] == false) {
			enemyspawned.Insert (2, (Instantiate (enemy3, new Vector2 (10.91f, -27.54f), Quaternion.identity)));
			spawnerfull [2] = true;
			Debug.Log ("I2:True");
		}
		if (spawnerfull [1] == false) {
			enemyspawned.Insert (1, (Instantiate (enemy2, new Vector2 (10.91f, -27.54f), Quaternion.identity)));
			spawnerfull [1] = true;
			Debug.Log ("I1:True");
		}
		if (spawnerfull [0] == false) {
			enemyspawned.Insert (0, (Instantiate (enemy1, new Vector2 (10.91f, -27.54f), Quaternion.identity)));
			spawnerfull [0] = true;
			Debug.Log ("I0:True");
		}
		
	}
	void Spawner3()
	{



		//Spawns at location in level 2
		//For skeleton spawner
		if (gameObject.name == "Spawnerdoor") {
			if (spawnerfull [2] == false) {
				enemyspawned.Insert (2, (Instantiate (enemy3, new Vector2 (-16.55f, 7.45f), Quaternion.identity)));
				spawnerfull [2] = true;
				Debug.Log ("I2:True");
			}
			if (spawnerfull [1] == false) {
				enemyspawned.Insert (1, (Instantiate (enemy2, new Vector2 (-16.55f, 7.45f), Quaternion.identity)));
				spawnerfull [1] = true;
				Debug.Log ("I1:True");
			}
			if (spawnerfull [0] == false) {
				enemyspawned.Insert (0, (Instantiate (enemy1, new Vector2 (-16.55f, 7.45f), Quaternion.identity)));
				spawnerfull [0] = true;
				Debug.Log ("I0:True");
			}
		}
		//For slime spawner
		if (gameObject.name == "Spawnerdoor2") {
			if (spawnerfull [2] == false) {
				enemyspawned.Insert (2, (Instantiate (enemy3, new Vector2 (16.93f, -17.81f), Quaternion.identity)));
				spawnerfull [2] = true;
				Debug.Log ("I2:True");
			}
			if (spawnerfull [1] == false) {
				enemyspawned.Insert (1, (Instantiate (enemy2, new Vector2 (16.93f, -17.81f), Quaternion.identity)));
				spawnerfull [1] = true;
				Debug.Log ("I1:True");
			}
			if (spawnerfull [0] == false) {
				enemyspawned.Insert (0, (Instantiate (enemy1, new Vector2 (16.93f, -17.81f), Quaternion.identity)));
				spawnerfull [0] = true;
				Debug.Log ("I0:True");
			}
		}
	}
	void Spawner4()
	{
		

		//Spawns at location in level 3
		//if (gameObject.name == "Spawnerdoor") {
		Debug.Log ("0" + enemyspawned [0]);
		Debug.Log ("1" + enemyspawned [1]);
		Debug.Log ("2" + enemyspawned [2]);
		if (spawnerfull [1] == false/*enemyspawned [1] == null*/) {
			enemyspawned.Insert (1, (Instantiate (enemy2, new Vector2 (19.2f, -5.07f), Quaternion.identity)));

			spawnerfull [1] = true;
			spawnerfull [2] = true;
			Debug.Log ("I1:True");
		}
		if (spawnerfull [0] == false/*enemyspawned [0] == null*/) {
			enemyspawned.Insert (0, (Instantiate (enemy1, new Vector2 (19.2f, -5.07f), Quaternion.identity)));
			spawnerfull [0] = true;
			spawnerfull [1] = true;
			spawnerfull [2] = true;
			Debug.Log ("I0:True");
		}
		if (spawnerfull [2] == false/*enemyspawned [2] == null*/) {
			enemyspawned.Insert (2, (Instantiate (enemy3, new Vector2 (19.2f, -5.07f), Quaternion.identity)));
			spawnerfull [2] = true;
			Debug.Log ("I2:True");
		}
		//}
	}
}
