using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class pointSys : MonoBehaviour {

	private GameObject mainPlatform;
	public static int points;
	Text text;


	// Use this for initialization
	void Start () {
		mainPlatform = GameObject.Find("mainPlatform");
		points = 0;
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Points: " + points;
	}
}
