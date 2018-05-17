using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameProgressionSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void changeBallSpeed (int points) {
		if (points < 1) {
			platformController.ballSpeed = 2.5f;
		} else if (points < 2) {
			platformController.ballSpeed = 3;
		} else if (points < 3) {
			platformController.ballSpeed = 4;
		} else if (points < 5) {
			platformController.ballSpeed = 5;
		} else if (points < 10) {
			platformController.ballSpeed = 7;
		} else if (points < 20) {
			platformController.ballSpeed = 10;
		} else if (points < 30) {
			platformController.ballSpeed = 15;
		} else if (points < 50) {
			platformController.ballSpeed = 20;
		} else if (points < 75) {
			platformController.ballSpeed = 25;
		} else if (points < 100) {
			platformController.ballSpeed = 30;
		} else if (points < 150) {
			platformController.ballSpeed = 50;
		}
	}
}
