using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle4Tile : MonoBehaviour {
	public bool tileOn=false;
	public Material onMaterial;
	public Material offMaterial;
	private Renderer rend;
	void Start(){
		rend = gameObject.GetComponent<Renderer> ();
	}
	// Update is called once per frame
	void OnTriggerEnter(Collider collider){
		if (collider.tag == "PushBlock") {
			tileOn = true;
			rend.material = onMaterial;
		}
	}
	void OnTriggerExit(Collider Collider){
		if (Collider.tag == "PushBlock") {
			tileOn = false;
			rend.material = offMaterial;
		}
	}


}
