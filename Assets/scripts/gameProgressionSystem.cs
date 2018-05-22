using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameProgressionSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void changeBallSpeed (int points) {
		platformController.ballSpeed =  3 + (points * 0.1f);
	}
}
