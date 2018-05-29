using System.Collections;
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
			if (--pointSys.points <= 0)
			pointSys.points = 0;
			platformController.teleportBall ();
		} else {
			platformController.teleportBomb ();
		}

		gameProgressionSystem.changeBallSpeed (pointSys.points);
	}
}
