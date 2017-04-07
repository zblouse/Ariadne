using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle4 : MonoBehaviour {


	public Puzzle4Tile Tile1;
	public Puzzle4Tile Tile2;
	public Puzzle4Tile Tile3;
	public Puzzle4Tile Tile4;
	public Puzzle4Tile Tile5;
	public Puzzle4Tile Tile6;
	public Puzzle4Tile Tile7;
	public Puzzle4Tile Tile8;
	public Puzzle4Tile Tile9;

	public GameObject door;
	public float speed;

	public bool puzzleSolved = false;

	private bool soundPlayed=false;
	public AudioSource doorMusic;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Tile1.tileOn && Tile3.tileOn && !Tile4.tileOn && !Tile7.tileOn && Tile8.tileOn && Tile9.tileOn && Tile6.tileOn) {
			puzzleSolved = true;
		}
		if (puzzleSolved) {
			if (door.transform.position.x >= 472.95 - 7) {
				if (!soundPlayed) {
					doorMusic.Play ();
					soundPlayed = true;
				}
				door.transform.position = new Vector3 (door.transform.position.x-  Time.deltaTime * speed, door.transform.position.y, door.transform.position.z);
			}
		}
	}
}
