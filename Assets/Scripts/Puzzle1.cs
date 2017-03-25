using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour {
	public PuzzleTile tile1;
	public PuzzleTile tile2;
	public PuzzleTile tile3;
	public PuzzleTile tile4;
	public PuzzleTile tile5;
	public PuzzleTile tile6;
	public PuzzleTile tile7;
	public PuzzleTile tile8;
	public PuzzleTile tile9;
	public PuzzleTile tile10;
	public PuzzleTile tile11;
	public PuzzleTile tile12;

	public bool puzzleSolved=false;
	public GameObject door;
	public Vector3 doorInitPos;
	public float speed;
	// Use this for initialization
	void Start(){
		doorInitPos = door.transform.position;
	}
	// Update is called once per frame
	void Update () {
		if (tile1.tileOn && !tile2.tileOn && tile3.tileOn && !tile4.tileOn && !tile5.tileOn && tile6.tileOn && !tile7.tileOn && tile8.tileOn && tile9.tileOn && !tile10.tileOn && tile11.tileOn && !tile12.tileOn) {
			puzzleSolved = true;
		}
		if (puzzleSolved) {
			if (door.transform.position.x <= doorInitPos.x + 7) {
				door.transform.position = new Vector3 (door.transform.position.x + Time.deltaTime * speed, door.transform.position.y, door.transform.position.z);
			}
		}
	}
}
