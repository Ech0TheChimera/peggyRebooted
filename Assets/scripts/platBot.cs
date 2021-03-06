﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platBot : MonoBehaviour {
	private GameObject plat;
	private GameObject ball;
	private GameObject omb;
	private float hb;
	private float hp;
	private float ho;
	private float vo;
	float d,d2,d3;
	float moveAmt;
	int pspeed;

	// Use this for initialization
	void Start () {
		plat = GameObject.Find("mainPlatform");
		ball = GameObject.Find ("ball");
		omb = GameObject.Find ("bombOmb");
		pspeed = 5;
	}

	// Update is called once per frame
	void Update () {
		hb = ball.transform.position.x;
		hp = plat.transform.position.x;
		ho = omb.transform.position.x;
		vo = omb.transform.position.y;
		d = hb - hp;
		d2 = ho - hp;
		d3 = vo + 4.1f;
		moveAmt = 2.5f + 0.03f * pointSys.getPoints ();

		if (d2 < 3 && d2 > -3 && d3 < moveAmt && d3 > -1) {
			if (d2 < 0)
				platformController.moveRight (pspeed);
			else
				platformController.moveLeft (pspeed);
		} else if ((d3 < 2.5 && d3 > -1) && ((d2 > 3 && d2 < 7) || (d2 < -3 && d2 > -7))) {
			; // Do nothing
		} else {
			// If we're close enough to catch the ball
			// OR the ball is too far to catch, do nothing
			if ((d < (0.5 * plat.transform.localScale.x) && d > -(0.5 * plat.transform.localScale.x)) || (d > 15 && pointSys.getPoints () > 300)) {
				;
			} else if (d > 0) {
				platformController.moveRight (pspeed);
			} else if (d < 0) {
				platformController.moveLeft (pspeed);
			}
		}
	}
}
