using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class pointSys : MonoBehaviour {

	private static int points;
	private static Text text;


	// Use this for initialization
	void Start () {
		points = 0;
		text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (points < 0) {
			points = 0;
		}
	}

	public static int getPoints() {
		return points;
	}

	public static void increment() {
		display(++points);
	}

	public static void decrement() {
		display(--points);
	}

	public static void reset() {
		points = 0;
		display(points);
	}

	private static void display(int p) {
		text.text = "Points: " + p;
	}
}
