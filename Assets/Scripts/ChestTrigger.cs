using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChestTrigger : MonoBehaviour {
	public Text bottomText;
	private bool triggered;
	public Chest thisChest;
	public GameObject Top;
	Animator chestAnim;
	// Use this for initialization
	void Start(){
		chestAnim = Top.GetComponent<Animator> ();
	}
	void OnTriggerEnter(Collider col){
		
		if (!thisChest.ChestOpened) {
			bottomText.text="Press X to Open Chest";
			triggered = true;
		}
			
	}
	void OnTriggerExit(Collider col){
		triggered = false;
		bottomText.text="";
	}
	
	// Update is called once per frame
	void Update () {
		if (triggered) {
			if (Input.GetKeyDown (KeyCode.X)) {
				chestAnim.SetBool ("OpenChest",true);
				thisChest.ChestOpened = true;
				bottomText.text = "";
			}
		}
	}
}
