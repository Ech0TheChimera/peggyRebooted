using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platBot : MonoBehaviour {
	private GameObject plat;
	private GameObject ball;
	private float hb;
	private float hp;
	float d;

	// Use this for initialization
	void Start () {
		plat = GameObject.Find("mainPlatform");
		ball = GameObject.Find ("ball");
	}

	// Update is called once per frame
	void Update () {
		hb = ball.transform.position.x;
		hp = plat.transform.position.x;
		d = hb - hp;
		// If we're close enough to catch the ball
		// OR the ball is too far to catch, do nothing
		if ((d < 2.5 && d > -2.5) || (d > 15 && pointSys.points > 300)) {
			;
		}
		else if (d > 0) {
			plat.transform.Translate (5 * 0.1f, 0f, 0f);
		}
		else if (d < 0) {
			plat.transform.Translate (-5 * 0.1f, 0f, 0f);
		}
	}
}
