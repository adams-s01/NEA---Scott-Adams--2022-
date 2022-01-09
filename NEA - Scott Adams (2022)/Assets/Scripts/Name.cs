/*
* Created: Sprint 12
* Last Edited: Sprint 12
* Purpose: Allows player to enter a name
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Name : MonoBehaviour {

	public string name;
	public TextMeshProUGUI nametext;
	public GameObject namecanvas;
	public GameObject endstatscanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		nametext.text = "Name: " + name;
	}
	//Button to add letter Q
	public void Q()
	{
		name = name + "Q";
	}
	//Button to add letter W
	public void W()
	{
		name = name + "W";
	}
	//Button to add letter E
	public void E()
	{
		name = name + "E";
	}
	//Button to add letter R
	public void R()
	{
		name = name + "R";
	}
	//Button to add letter T
	public void T()
	{
		name = name + "T";
	}
	//Button to add letter Y
	public void Y()
	{
		name = name + "Y";
	}
	//Button to add letter U
	public void U()
	{
		name = name + "U";
	}
	//Button to add letter I
	public void I()
	{
		name = name + "I";
	}
	//Button to add letter O
	public void O()
	{
		name = name + "O";
	}
	//Button to add letter P
	public void P()
	{
		name = name + "P";
	}
	//Button to add letter A
	public void A()
	{
		name = name + "A";
	}
	//Button to add letter S
	public void S()
	{
		name = name + "S";
	}
	//Button to add letter D
	public void D()
	{
		name = name + "D";
	}
	//Button to add letter F
	public void F()
	{
		name = name + "F";
	}
	//Button to add letter G
	public void G()
	{
		name = name + "G";
	}
	//Button to add letter H
	public void H()
	{
		name = name + "H";
	}
	//Button to add letter J
	public void J()
	{
		name = name + "J";
	}
	//Button to add letter K
	public void K()
	{
		name = name + "K";
	}
	//Button to add letter L
	public void L()
	{
		name = name + "L";
	}
	//Button to add letter Z
	public void Z()
	{
		name = name + "Z";
	}
	//Button to add letter X
	public void X()
	{
		name = name + "X";
	}
	//Button to add letter C
	public void C()
	{
		name = name + "C";
	}
	//Button to add letter V
	public void V()
	{
		name = name + "V";
	}
	//Button to add letter B
	public void B()
	{
		name = name + "B";
	}
	//Button to add letter N
	public void N()
	{
		name = name + "N";
	}
	//Button to add letter M
	public void M()
	{
		name = name + "M";
	}
	//Button to exit to the end stats canvas
	public void Exit()
	{
		endstatscanvas.SetActive (true);
		namecanvas.SetActive (false);
	}
}
