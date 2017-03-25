using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTile : MonoBehaviour {
	public bool tileOn=false;
	public Material onMaterial;
	public Material offMaterial;
	public Renderer rend;
	void Start(){
		rend = gameObject.GetComponent<Renderer> ();
	}
	// Update is called once per frame
	void OnTriggerEnter(Collider collider){
		if (tileOn) {
			tileOn = false;
			rend.material = offMaterial;
		} else {
			tileOn = true;
			rend.material = onMaterial;
		}
	}
}
