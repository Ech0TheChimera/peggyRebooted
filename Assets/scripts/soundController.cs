using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundController : MonoBehaviour {
	// References to sounds
	private static ArrayList<AudioSource> sounds;
	// Use this for initialization
	void Start () {
		sounds = new ArrayList<AudioSource>(GetComponents<AudioSource>());
		foreach (AudioSource s in sounds)
			print(s);
	}

	// Update is called once per frame
	void Update () {

	}
	public static void ballMiss() {
		float r = Random.Range(0,10);
		if (r <= 2)
			sounds[3].Play ();
		else if (r <= 4)
			sounds[4].Play ();
		else if (r <= 6)
			sounds[5].Play ();
		else if (r <= 8)
			sounds[6].Play ();
		else
			sounds[7].Play ();
	}
}
