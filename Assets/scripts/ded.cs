using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ded : MonoBehaviour {
	// References to sounds
	public AudioSource MissSound;
	public AudioSource MissSound2;
	public AudioSource MissSound3;
	public AudioSource MissSound4;
	public AudioSource MissSound5;
	// Use this for initialization
	void Start () {
		MissSound = GetComponent<AudioSource> ();
		MissSound2 = GameObject.Find("Canvas").GetComponent<AudioSource> ();
		MissSound3 = GameObject.Find("Text").GetComponent<AudioSource> ();
		MissSound4 = GameObject.Find("Sun").GetComponent<AudioSource> ();
		MissSound5 = GameObject.Find("special").GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.name == "ball") {
			if (pointSys.getPoints () - 1 <= 0)
			pointSys.decrement ();
			platformController.teleportBall ();
			float r = Random.Range(0,10);
			if (r <= 2)
				MissSound.Play ();
			else if (r <= 4)
				MissSound2.Play ();
			else if (r <= 6)
				MissSound3.Play ();
			else if (r <= 8)
				MissSound4.Play ();
			else
				MissSound5.Play ();
		} else {
			platformController.teleportBomb ();
		}

		gameProgressionSystem.changeBallSpeed (pointSys.getPoints ());
	}
}
