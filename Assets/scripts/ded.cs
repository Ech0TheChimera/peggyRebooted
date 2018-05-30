using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ded : MonoBehaviour {
	// References to sounds
	public AudioSource MissSound;
	// Use this for initialization
	void Start () {
		MissSound = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.name == "ball") {
			if (--pointSys.points <= 0)
			pointSys.points = 0;
			platformController.teleportBall ();
			MissSound.Play ();
		} else {
			platformController.teleportBomb ();
		}

		gameProgressionSystem.changeBallSpeed (pointSys.points);
	}
}
