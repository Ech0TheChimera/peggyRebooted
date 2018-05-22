using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour {

	// References to platform, ball, and horizontal movement value
	private GameObject mainPlatform;
	public static GameObject ball;
	private Rigidbody rb;
	private float hval;
	public float platSpeed;
	public static float ballSpeed;

	// Use this for initialization
	void Start () {
		mainPlatform = GameObject.Find("mainPlatform");
		ball = GameObject.Find ("ball");
		ballSpeed = 3;
		rb = ball.GetComponent<Rigidbody>();
		hval = 0;
	}
	
	// Update is called once per frame
	void Update () {

		rb.velocity = new Vector3 (0f, -ballSpeed, 0f);

		// get horizontal val,
		// 0 if not pressing <--, -->, a or d
		// < 0 if pressing --> or d
		// > 0 if pressing <-- or a
		hval = Input.GetAxis ("Horizontal");

		// If we want to move to the right
		// and we're not at the far edge (10) minus 1/2 platform size (5/2 = 2.5)
		if (hval > 0 && getPlatformPosX() <= 7.5) {
			transform.Translate (platSpeed * 0.1f, 0f, 0f);
		}

		// If we want to move to the left
		// and we're not at the far edge (-10) plus 1/2 platform size (5/2 = 2.5)
		else if (hval < 0 && getPlatformPosX() >= -7.5) {
			transform.Translate (-platSpeed * 0.1f, 0f, 0f);
		}
	}

	// sets ball to top with random x pos between -10 and 10
	public static void teleportBall () {
		ball.transform.position = new Vector3(Random.Range(-10,10),6f,0f);
	}

	// returns x position of platform
	float getPlatformPosX () {
		return transform.position.x;
	
	}

	void OnTriggerEnter (Collider other)
	{
		teleportBall ();
		pointSys.points++;
		gameProgressionSystem.changeBallSpeed (pointSys.points);
	}
}