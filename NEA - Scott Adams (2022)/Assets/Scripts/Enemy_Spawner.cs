﻿/*
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
	public bool spawnerfalse;

	// Use this for initialization
	void Start () {
		spawner = GameObject.FindGameObjectWithTag ("spawner");
		enemyspawned=new List<GameObject>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(spawnerfull[0]==false||spawnerfull[1]==false||spawnerfull[2]==false)
		{
			enemyspawned.Add(Instantiate(enemy,new Vector2(90.1f,2.8f),Quaternion.identity));
			spawnerfull [i] = true;
			i++;
			if (i == 3) {
				i = 0;
			}
		}
		Full (spawnerfalse);
	}
	public void Full(bool spawnerfalse)
	{
		spawnerfull [0] = spawnerfalse;
	}
}
