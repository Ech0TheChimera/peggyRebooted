using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour {

	// References to platform, ball, and horizontal movement value
	public static GameObject mainPlatform;
	public static GameObject ball;
	public static GameObject bombOmb;
	private Rigidbody rb;
	private Rigidbody rb2;
	private float hval;
	public float platSpeed;
	public static float ballSpeed;
	public static float bombOmbSpeed;

	// Use this for initialization
	void Start () {
		mainPlatform = GameObject.Find ("mainPlatform");
		ball = GameObject.Find ("ball");
		bombOmb = GameObject.Find ("bombOmb");
		ballSpeed = 3;
		bombOmbSpeed = 2;
		rb = ball.GetComponent<Rigidbody>();
		rb2 = bombOmb.GetComponent<Rigidbody>();
		hval = 0;
	}

	// Update is called once per frame
	void Update () {

		rb.velocity = new Vector3 (0f, -ballSpeed, 0f);
		rb2.velocity = new Vector3(0f, -bombOmbSpeed, 0f);
		// get horizontal val,
		// 0 if not pressing <--, -->, a or d
		// < 0 if pressing --> or d
		// > 0 if pressing <-- or a
		hval = Input.GetAxis ("Horizontal");

		// If we want to move to the right
		// and we're not at the far edge (10) minus 1/2 platform size (5/2 = 2.5)
		if (hval > 0 && getPlatformPosX() <= 10 - (0.5 * mainPlatform.transform.localScale.x)) {
			moveRight ((int)platSpeed);
		}

		// If we want to move to the left
		// and we're not at the far edge (-10) plus 1/2 platform size (5/2 = 2.5)
		else if (hval < 0 && getPlatformPosX() >= -10 + (0.5 * mainPlatform.transform.localScale.x)) {
			moveLeft ((int)platSpeed);
		}
	}

	// sets ball to top with random x pos between -10 and 10
	public static void teleportBall () {
		ball.transform.position = new Vector3(Random.Range(-10,10),6f,0f);
	}

	// sets ball to top with random x pos between -10 and 10
	public static void teleportBomb () {
		bombOmb.transform.position = new Vector3(Random.Range(-10,10),30f,0f);
	}

	// returns x position of platform
	float getPlatformPosX () {
		return transform.position.x;
	}


	public static void moveRight(int speed) {
		if (speed < 0)
			speed *= -1;
		mainPlatform.transform.Translate (speed * 0.1f, 0f, 0f);
	}

	public static void moveLeft(int speed) {
		if (speed < 0)
			speed *= -1;
		mainPlatform.transform.Translate (-speed * 0.1f, 0f, 0f);
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "ball") {
			teleportBall ();
			pointSys.increment ();
			gameProgressionSystem.changeBallSpeed (pointSys.getPoints ());
			soundController.ballHit ();
		} else {
			teleportBomb ();
			transform.localScale += new Vector3(-0.25f * transform.localScale.x, 0, 0);
			pointSys.reset ();
			gameProgressionSystem.changeBallSpeed (pointSys.getPoints ());
			soundController.bombHit ();
		}
	}
}
