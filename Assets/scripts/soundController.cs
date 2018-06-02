using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundController : MonoBehaviour {
	// References to sounds
	private static List<AudioSource> ballMissSounds;
	private static List<AudioSource> ballHitSounds;
	private static List<AudioSource> bombHitSounds;

	// Use this for initialization
	void Start () {
		ballHitSounds = new List<AudioSource> ();
		ballMissSounds = new List<AudioSource> ();
		bombHitSounds = new List<AudioSource> ();
		foreach (AudioSource s in GameObject.Find("ballMissSounds").GetComponents<AudioSource>()) {
			ballMissSounds.Add(s);
		}
		foreach (AudioSource s in GameObject.Find("ballHitSounds").GetComponents<AudioSource>()) {
			ballHitSounds.Add(s);
		}
		foreach (AudioSource s in GameObject.Find("bombHitSounds").GetComponents<AudioSource>()) {
			bombHitSounds.Add(s);
		}
	}

	// Update is called once per frame
	void Update () {

	}

	public static void ballMiss() {
		int r = Random.Range(0,ballMissSounds.Count);
		ballMissSounds[r].Play ();
	}

	public static void ballHit() {
		int r = Random.Range(0,ballHitSounds.Count);
		ballHitSounds[r].Play ();
	}

	public static void bombHit() {
		int r = Random.Range(0,bombHitSounds.Count);
		bombHitSounds[r].Play ();
	}
}
