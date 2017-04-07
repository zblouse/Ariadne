using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosingCutSceneControl : MonoBehaviour {

	public Text CutSceneText;
	private int stateNum=0;
	public GameObject mainButtons;
	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		mainButtons.SetActive (false);
		CutSceneText.text = "You walk into the blackness. You hear something moving around.";
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			stateNum++;
		}
		if (stateNum == 1) {
			CutSceneText.text = "It bumps into you. You realize it's Theseus. You finally found him!";
		} else if (stateNum == 2) {
			CutSceneText.text = "He tells you he defeated the Minotaur, but couldn't find his way back out.\nYou lead him out of the Labyrinth.";
		} else if (stateNum == 3) {
			CutSceneText.text = "Game Over";
			mainButtons.SetActive (true);
		}
	}

}
