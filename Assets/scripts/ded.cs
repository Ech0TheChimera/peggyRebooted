﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ded : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.name == "ball") {
			if ((pointSys.getPoints () - 1) >= 0)
				pointSys.decrement ();
			platformController.teleportBall ();
			soundController.ballMiss ();
		} else {
			platformController.teleportBomb ();
		}

		gameProgressionSystem.changeBallSpeed (pointSys.getPoints ());
	}
}
