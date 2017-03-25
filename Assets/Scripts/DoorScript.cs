using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorScript : MonoBehaviour {
	public Text BottomScreen;
	// Use this for initialization
	void OnTriggerEnter(Collider col){
		BottomScreen.text="The Door Appears to be Locked";
	}
	void OnTriggerExit(Collider col){
		BottomScreen.text = "";
	}
}
