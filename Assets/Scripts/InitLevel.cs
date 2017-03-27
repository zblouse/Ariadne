using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitLevel : MonoBehaviour {
	public GameObject Player;
	public GameObject Puzzle1Door;
	public GameObject GemDoor;
	public GameObject PuzzleScripts;
	private GemInventory PlayerInventory;
	private Puzzle1 puzzle1;
	public GameObject box;
	private GemBox gemBoxInit;
	private GemBoxTrigger gemBoxTriggerInit;
	private int GemCount=0;
	// Use this for initialization
	void Awake () {
		Debug.Log ("I initialized");
		puzzle1 = PuzzleScripts.GetComponent<Puzzle1> ();
		PlayerInventory = Player.GetComponent<GemInventory> ();
		gemBoxInit = box.GetComponent<GemBox> ();
		gemBoxTriggerInit = box.GetComponentInChildren<GemBoxTrigger> ();

		Player.transform.position = new Vector3(GameControl.control.PlayerPositionX,GameControl.control.PlayerPositionY,GameControl.control.PlayerPositionZ);
		Puzzle1Door.transform.position = new Vector3 (GameControl.control.Puzzle1DoorX,Puzzle1Door.transform.position.y,Puzzle1Door.transform.position.z);
		GemDoor.transform.position = new Vector3 (GemDoor.transform.position.x,GemDoor.transform.position.y,GameControl.control.GemDoorZ);
		PlayerInventory.HasGem1 = GameControl.control.PlayerGem1;
		PlayerInventory.HasGem2 = GameControl.control.PlayerGem2;
		PlayerInventory.HasGem3 = GameControl.control.PlayerGem3;
		PlayerInventory.HasGem4 = GameControl.control.PlayerGem4;
		PlayerInventory.HasGem5 = GameControl.control.PlayerGem5;
		gemBoxInit.Gem1 = GameControl.control.BoxGem1;
		gemBoxInit.Gem2 = GameControl.control.BoxGem2;
		gemBoxInit.Gem3 = GameControl.control.BoxGem3;
		gemBoxInit.Gem4 = GameControl.control.BoxGem4;
		gemBoxInit.Gem5 = GameControl.control.BoxGem5;
		if (gemBoxInit.Gem1) {
			gemBoxTriggerInit.gem1.SetActive (true);
			GemCount++;
		}
		if (gemBoxInit.Gem2) {
			gemBoxTriggerInit.gem2.SetActive (true);
			GemCount++;
		}
		if (gemBoxInit.Gem3) {
			gemBoxTriggerInit.gem3.SetActive (true);
			GemCount++;
		}
		if (gemBoxInit.Gem4) {
			gemBoxTriggerInit.gem4.SetActive (true);
			GemCount++;
		}
		if (gemBoxInit.Gem5) {
			gemBoxTriggerInit.gem5.SetActive (true);
			GemCount++;
		}
		gemBoxTriggerInit.gemTotal = GemCount;


	}
	

}
