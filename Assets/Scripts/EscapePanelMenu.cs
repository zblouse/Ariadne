using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscapePanelMenu : MonoBehaviour {
	public bool menuActive=false;
	public GameObject escapeMenu;
	public GameObject Player;
	public GameObject Puzzle1Door;
	public GameObject GemDoor;
	public GameObject box;
	private GemBox GemBoxInit;
	private GemBoxTrigger GemBoxTriggerInit;
	private GemInventory inventory;
	// Use this for initialization
	void Start () {
		escapeMenu.SetActive (false);
		inventory = Player.GetComponent<GemInventory> ();
		GemBoxInit = box.GetComponent<GemBox> ();
		GemBoxTriggerInit = box.GetComponentInChildren <GemBoxTrigger> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			menuActive = !menuActive;
			escapeMenu.SetActive (menuActive);
		}
	}
	public void QuitGame(){
		Application.Quit ();
	}
	public void LoadLevel(int sceneNum){
		
		SceneManager.LoadScene (sceneNum);
	}
	public void SaveGame(){
		Debug.Log ("Escape Save");
		GameControl.control.PlayerPositionX = Player.transform.position.x;
		GameControl.control.PlayerPositionY = Player.transform.position.y;
		GameControl.control.PlayerPositionZ = Player.transform.position.z;
		GameControl.control.Puzzle1DoorX = Puzzle1Door.transform.position.x;
		GameControl.control.GemDoorZ = GemDoor.transform.position.z;
		GameControl.control.PlayerGem1 = inventory.HasGem1;
		GameControl.control.PlayerGem2 = inventory.HasGem2;
		GameControl.control.PlayerGem3 = inventory.HasGem3;
		GameControl.control.PlayerGem4 = inventory.HasGem4;
		GameControl.control.PlayerGem5 = inventory.HasGem5;
		GameControl.control.BoxGem1 = GemBoxInit.Gem1;
		GameControl.control.BoxGem2 = GemBoxInit.Gem2;
		GameControl.control.BoxGem3 = GemBoxInit.Gem3;
		GameControl.control.BoxGem4 = GemBoxInit.Gem4;
		GameControl.control.BoxGem5 = GemBoxInit.Gem5;

		GameControl.control.save ();
	}

}
