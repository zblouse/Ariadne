using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {
	public AudioSource AboveGround;
	public bool isUnderground;
	public AudioSource UnderGround;

	public bool playing=false;
	public bool switched;
	// Use this for initialization
	void Start () {
		switched = isUnderground;
		AboveGround.volume = .3f;
		UnderGround.volume = .2f;
	}
	
	// Update is called once per frame
	void Update () {
		if (switched != isUnderground) {
			playing = false;
			if (switched) {
				UnderGround.Stop ();
			} else {
				AboveGround.Stop ();
			}
			switched = isUnderground;
		}
		if (!playing) {
			if (isUnderground) {
				UnderGround.Play ();
				playing = true;
			} else {
				
				AboveGround.Play ();
				playing = true;
			}
		}
	}
}
