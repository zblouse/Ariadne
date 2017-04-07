using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour {
	public MusicController controller;

	
	void OnTriggerEnter(Collider col){
		controller.isUnderground = !controller.isUnderground;
	}
}
