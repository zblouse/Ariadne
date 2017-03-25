using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Chest : MonoBehaviour {
	public bool ChestOpened=false;
	public int GemNum;
	private bool alreadyDone = false;
	public GameObject player;
	public GemInventory inventory;
	public Text bottomText;
	public GameObject Gem;
	private float gemTime=0;
	public float GemSpeed;
	private Vector3 initGemPosition;
	private AnimationScript animScript;
	private bool counting=true;
	// Use this for initialization
	void Start(){
		inventory = player.GetComponent<GemInventory> ();
		initGemPosition = Gem.transform.position;
		animScript = Gem.GetComponentInChildren<AnimationScript> ();
		animScript.isFloating = false;
		animScript.isRotating = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (ChestOpened && !alreadyDone) {
			if (GemNum == 1) {
				inventory.HasGem1 = true;
				bottomText.text = "You Got A Blue Gem";
			} else if (GemNum == 2) {
				inventory.HasGem2 = true;
				bottomText.text = "You Got A Green Gem";
			} else if (GemNum == 3) {
				inventory.HasGem3 = true;
				bottomText.text = "You Got An Orange Gem";
			} else if (GemNum == 4) {
				inventory.HasGem4 = true;
				bottomText.text = "You Got A Red Gem";
			} else if (GemNum == 5) {
				inventory.HasGem5 = true;
				bottomText.text = "You Got A Yellow Gem";
			}
			alreadyDone = true;
		}
		Debug.Log (gemTime);
		if (alreadyDone && counting) {
			gemTime += Time.deltaTime;
		
			if (alreadyDone && gemTime < 5 && gemTime > 1) {
				if (Gem.transform.position.y < initGemPosition.y + 1.5) {
					Gem.transform.position = new Vector3 (Gem.transform.position.x, Gem.transform.position.y + GemSpeed * Time.deltaTime, Gem.transform.position.z);
				} else {
					animScript.isRotating = true;
				}

			}
			if (gemTime >= 5) {
				Destroy (Gem);
				bottomText.text = "";
				counting = false;
			}
		}
	}
}
