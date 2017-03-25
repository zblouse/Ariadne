using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemBox : MonoBehaviour {
	public bool Gem1 = false;
	public bool Gem2 = false;
	public bool Gem3 = false;
	public bool Gem4 = false;
	public bool Gem5 = false;
	public float DoorSpeed;
	public GameObject door;
	public bool CompletedPuzzle = false;
	private bool DoorMoving=false;
	private Vector3 initDoorPos;
	// Use this for initialization
	void Start () {
		initDoorPos = door.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Gem1 && Gem2 && Gem3 && Gem4 && Gem5){
			CompletedPuzzle = true;
		}
		if (CompletedPuzzle && door.transform.position.z < initDoorPos.z + 7) {
			door.transform.position = new Vector3 (door.transform.position.x,door.transform.position.y,door.transform.position.z+DoorSpeed*Time.deltaTime);
		}
	}
}
