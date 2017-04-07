using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTile : MonoBehaviour {
	public bool tileOn=false;
	public Material onMaterial;
	public Material offMaterial;
	public Renderer rend;
	public AudioSource triggerSound;
	void Start(){
		rend = gameObject.GetComponent<Renderer> ();
	}
	// Update is called once per frame
	void OnTriggerEnter(Collider collider){
		
			triggerSound.Play ();

		
		if (tileOn) {
			tileOn = false;
			rend.material = offMaterial;
		} else {
			tileOn = true;
			rend.material = onMaterial;
		}
	}
}
