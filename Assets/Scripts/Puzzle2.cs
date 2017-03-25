using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider col){
		Destroy (gameObject);
	}
}
