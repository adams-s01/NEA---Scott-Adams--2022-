/*
* Created: Sprint 1
* Last Edited: Sprint 8
* Purpose: Cause the player to move
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Player_Movement : MonoBehaviour {

	Rigidbody2D rb;
	GameObject leg1;
	GameObject leg;
	GameObject vase;
	GameObject vase2;
	GameObject vase3;
	GameObject keyvase;
	public Image speedbar;
	public GameObject bow;
	public GameObject potion;
	public GameObject weakpotion;
	public GameObject key;
	bool resting;
	float speed;
	Enemy_Movement other2;
	int playerdamage1;
	public int playerhealth;
	bool sleep;
	Transform player;
	int damage;
	int playerdamage;
	public GameObject other;
	private Inventory_1 other3;
	bool ringhealth;
	bool ringhealth2;
	public int lives;
	public int gold;
	public TextMeshProUGUI healthtext;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		leg1 = GameObject.FindGameObjectWithTag ("leg1");
		leg = GameObject.FindGameObjectWithTag ("leg");
		vase = GameObject.FindGameObjectWithTag ("vase");
		vase2 = GameObject.FindGameObjectWithTag ("vase2");
		keyvase = GameObject.FindGameObjectWithTag ("keyvase");
		resting = false;
		speed = 1;
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
		other3 = other.GetComponent<Inventory_1> ();
		lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		//Moves right
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate (Vector3.right * speed * Time.deltaTime * 3);
			if(leg1.transform.eulerAngles.y==0)
				{
				leg1.transform.localEulerAngles = new Vector3 (0, 180, 0);
				leg.transform.localEulerAngles = new Vector3 (0, 180, 0);
				}
		}
		//Moves left
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime * 3);
			if(leg1.transform.eulerAngles.y==180)
				{
				leg1.transform.localEulerAngles = new Vector3 (0, 0, 0);
				leg.transform.localEulerAngles = new Vector3 (0, 0, 0);
				}
		}
		//Jumps
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			rb.AddForce (new Vector2 (0, 2) * 2, ForceMode2D.Impulse);

		}
		//Sprint
		if (Input.GetKey (KeyCode.LeftShift)&&resting==false) {
			speed = 8;
			speedbar.transform.localScale -= new Vector3 (0.002f, 0, 0);
			if (speedbar.transform.localScale.x <= 0) {
				StartCoroutine (restingcoroutine ());
			}
			
		}
		//Stops sprint
		if (Input.GetKey (KeyCode.LeftShift) == false) {
			speed = other3.playerspeed;
		}
		//Damages player, once every second
		if (sleep == false) {
			
			Damage(playerdamage);
		}
		//Resets player when they die
		if (playerhealth <= 0) {
			player.SetPositionAndRotation (new Vector2 (-8, -2), Quaternion.identity);
			playerhealth = 10;
			lives--;
		}
		//Adds 20 health from first ring
		if (other3.playerhealth == true&&ringhealth==false) {
			playerhealth += 20;
			ringhealth = true;
		}
		//Adds 50 health from second ring
		if (other3.playerhealth2 == true&&ringhealth2==false) {
			playerhealth += 50;
			ringhealth2 = true;
		}
		//Adds 10 health from eating apple
		if (other3.playerhealth3 == true) {
			playerhealth += 10;
			other3.playerhealth3 = false;
		}
		//If all lives lost, go to start screen
		if (lives == 0) {
			SceneManager.LoadScene (0);
		}
		//Shows health
		healthtext.text = "Health: " + playerhealth.ToString ();

	}
	//Causes the palyer to not be able to sprint for 10 seconds
	IEnumerator restingcoroutine()
	{
		resting=true;
		speed = 1;
		speedbar.transform.localScale = new Vector3(0,0,0);
		yield return new WaitForSecondsRealtime(10);
		resting=false;
		speedbar.transform.localScale = new Vector3(1,1,1);
	}
	//Allows player to break the vase and get an item from it when in contact
	public void OnCollisionStay2D(Collision2D col)
	{
		//Bow vase
		if(Input.GetKeyDown(KeyCode.Mouse0)&&col.gameObject.tag=="vase")
		{
			Destroy (vase);
			Instantiate (bow, new Vector2 (vase.transform.position.x, vase.transform.position.y), Quaternion.identity);
		}
		//Potion vase
		if(Input.GetKeyDown(KeyCode.Mouse0)&&col.gameObject.tag=="vase2")
		{
			string vasename = col.gameObject.name;
			vase2 = GameObject.Find (vasename);
			Destroy (vase2);
			Instantiate (potion, new Vector2 (vase2.transform.position.x, vase2.transform.position.y), Quaternion.identity);
		}
		//Potion vase
		if(Input.GetKeyDown(KeyCode.Mouse0)&&col.gameObject.tag=="vase3")
		{
			string vasename = col.gameObject.name;
			vase3 = GameObject.Find (vasename);
			Destroy (vase3);
			Instantiate (weakpotion, new Vector2 (vase3.transform.position.x, vase3.transform.position.y), Quaternion.identity);
		}
		//Key vase
		if(Input.GetKeyDown(KeyCode.Mouse0)&&col.gameObject.tag=="keyvase")
		{
			Destroy (keyvase);
			Instantiate (key, new Vector2 (keyvase.transform.position.x, keyvase.transform.position.y), Quaternion.identity);
		}
		//Coin1
		if (col.gameObject.name == "coin(Clone)") {
			gold = 2;
			Destroy (col.gameObject);
		}
		//Coin2
		if (col.gameObject.name == "coin2(Clone)") {
			gold = 4;
			Destroy (col.gameObject);
		}
		//Coin3
		if (col.gameObject.name == "coin3(Clone)") {
			gold = 3;
			Destroy (col.gameObject);
		}
		if (col.gameObject.name != "coin(Clone)" && col.gameObject.name != "coin2(Clone)" && col.gameObject.name != "coin3(Clone)") {
			gold = 0;
		}
	}
	//Causes the player to be damaged once every second, by the amount of damage from the Enemy_Movement
	IEnumerator damagecoroutine(int playerdamage)
	{
		sleep = true;
		playerhealth -= playerdamage;
		//Debug.Log (playerhealth);
		//Debug.Log (playerdamage);
		yield return new WaitForSecondsRealtime (1);
		sleep = false;
	}
	//Damages player, only once at a time
	public void Damage(int playerdamage)
	{
		if (sleep == false) {
			StartCoroutine (damagecoroutine (playerdamage));
		}
	}

}
