using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3MirrorScript : MonoBehaviour {
	public GameObject Mirror;
	public GameObject Puzzles;
	private LightBeam beam;
	private Vector3 Rotation;
	public AudioSource triggerSound;
	// Use this for initialization
	void Start () {
		Rotation = new Vector3 (0, 30, 0);
		beam = Puzzles.GetComponent<LightBeam> ();
	}
	
	void OnTriggerEnter(Collider col){
		triggerSound.Play ();
		Mirror.transform.Rotate (Rotation);
		beam.MirrorsChanged = true;
	}
}
