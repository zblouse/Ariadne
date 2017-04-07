using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutSceneControl : MonoBehaviour {
	public Text CutSceneText;
	private int stateNum=0;
	public GameObject descisionButtons;
	public GameObject mainButtons;
	// Use this for initialization
	void Start () {
		descisionButtons.SetActive (false);
		mainButtons.SetActive (false);
		CutSceneText.text = "Every year, in exchange for not being slaughered by the people of Crete,\n the people of Athens would send a ship full of teenagers to Crete\n to be sent into the Labyrinth to feed the Minotaur.";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			stateNum++;
		}
		if (stateNum == 1) {
			CutSceneText.text = "Until one year a brave youth named Theseus volunteered to go on the ship.\n He wanted to try to kill the Minotaur.When the ship arrived on Crete,\n you, the princess Ariadne, discovered his plan and wanted to help stop the slaughter.";
		} else if (stateNum == 2) {
			CutSceneText.text = "The Labyrinth had been designed so no one could find their way out.\nBut you devised a way for Theseus to find his way back out, you call it a Klew.\nYou give it to him the night before he is to go into the Labyrinth.";
		} else if (stateNum == 3) {
			CutSceneText.text = "But being the forgetful person he is, Theseus forgot the Klew,\nthe one thing that could get him out of the Labyrith after he defeated the Minotaur.\nWill you go in and find him and get him safely out?";
			descisionButtons.SetActive (true);
		}
	}
	public void StayOut(){
		descisionButtons.SetActive (false);
		CutSceneText.text="You stay out of the Labyrinth, Theseus is never heard from again.\nYou sit silently and watch new people being led into the Labyrinth every year.";
		mainButtons.SetActive (true);
	}
}
