using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour {
	private GameObject mainPlatform;
	private float hval;
	private GameObject ball;
	// Use this for initialization
	void Start () {
		mainPlatform = GameObject.Find("mainPlatform");
		ball = GameObject.Find ("ball");
		hval = 0;
		teleportBall ();
	}
	
	// Update is called once per frame
	void Update () {
		hval = Input.GetAxis ("Horizontal");
		if (hval > 0) {
			transform.Translate (0.1f, 0f, 0f);
		}
		else if (hval < 0) {
			transform.Translate (-0.1f, 0f, 0f);
		}
		teleportBall ();
	}

	void teleportBall () {
		ball.transform.position = new Vector3(Random.Range(-10,10),6f,0f);
	}
}
