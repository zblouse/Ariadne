using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemBoxTrigger : MonoBehaviour {

	public GemBox gemBox;
	public GameObject player;
	private GemInventory playerGems;
	public Text bottomScreenText;
	public bool interacting=false;
	private bool triggered=false;
	private bool displayedText=false;
	public int gemTotal=0;
	public GameObject gem1;
	public GameObject gem2;
	public GameObject gem3;
	public GameObject gem4;
	public GameObject gem5;
	void OnTriggerEnter(Collider col){
		bottomScreenText.text="Press X to Interact";
		triggered = true;
	}
	void OnTriggerExit(Collider col){
		bottomScreenText.text = "";
		triggered = false;
		displayedText = false;
	}
	void Update(){
		if (gemBox.Gem1) {
			gem1.SetActive (true);
		}
		if (gemBox.Gem2) {
			gem2.SetActive (true);
		}
		if (gemBox.Gem3) {
			gem3.SetActive (true);
		}
		if (gemBox.Gem4) {
			gem4.SetActive (true);
		}
		if (gemBox.Gem5) {
			gem5.SetActive (true);
		}
		if (triggered) {
			if (Input.GetKeyDown (KeyCode.X)) {
				interacting = true;
			}
		} else {
			interacting = false;
		}
		if (interacting) {
			int gemCount=0;
			if (playerGems.HasGem1) {
				gemCount++;
				gemBox.Gem1 = true;
				playerGems.HasGem1 = false;
				gem1.SetActive (true);
				gemTotal++;

			}
			if (playerGems.HasGem2) {
				gemCount++;
				gemTotal++;
				gemBox.Gem2 = true;
				gem2.SetActive (true);
				playerGems.HasGem2 = false;
			}
			if (playerGems.HasGem3) {
				gemCount++;
				gemTotal++;
				gem3.SetActive (true);
				gemBox.Gem3 = true;
				playerGems.HasGem3 = false;
			}
			if (playerGems.HasGem4) {
				gemCount++;
				gemTotal++;
				gemBox.Gem4 = true;
				gem4.SetActive (true);
				playerGems.HasGem4 = false;
			}
			if (playerGems.HasGem5) {
				gemCount++;
				gemTotal++;
				gem5.SetActive (true);
				gemBox.Gem5 = true;
				playerGems.HasGem5 = false;
			}

			if (!displayedText) {
				if (gemCount == 1) {
					bottomScreenText.text = "You put your gem into an empty hole";
					displayedText = true;
				} else if (gemCount > 0) {
					bottomScreenText.text = "You put your " + gemCount + " gems into empty holes";
					displayedText = true;
				} else if(gemTotal==0){
					bottomScreenText.text = "It looks like there are five holes";
					displayedText = true;
				} else if(gemTotal==1){
					bottomScreenText.text = "It looks like there are four empty holes";
					displayedText = true;
				} else if(gemTotal==2){
					bottomScreenText.text = "It looks like there are three empty holes";
					displayedText = true;
				} else if(gemTotal==3){
					bottomScreenText.text = "It looks like there are two empty holes";
					displayedText = true;
				} else if(gemTotal==4){
					bottomScreenText.text = "It looks like there is one empty hole";
					displayedText = true;
				} else if(gemTotal==5){
					bottomScreenText.text = "All holes have been filled";
					displayedText = true;
				}
			}
		}
	}
	void Start(){
		playerGems = player.GetComponent<GemInventory> ();
		gem1.SetActive (false);
		gem2.SetActive (false);
		gem3.SetActive (false);
		gem4.SetActive (false);
		gem5.SetActive (false);
	}
}
