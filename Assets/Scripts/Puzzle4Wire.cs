using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle4Wire : MonoBehaviour {
	public GameObject Piece1;
	private Renderer rend1;
	public GameObject Piece2;
	private Renderer rend2;
	public GameObject Piece3;
	private Renderer rend3;
	public GameObject Piece4;
	private Renderer rend4;
	public GameObject Piece5;
	private Renderer rend5;
	public int tileNum;
	private Puzzle4Tile thisTile;
	public Puzzle4 puzzle;

	public Material onMaterial;
	public Material offMaterial;
	// Use this for initialization
	void Start () {
		thisTile = gameObject.GetComponent<Puzzle4Tile> ();
		rend1 = Piece1.GetComponent<Renderer> ();
		rend2 = Piece2.GetComponent<Renderer> ();
		rend3 = Piece3.GetComponent<Renderer> ();
		if (tileNum == 4 || tileNum ==5 ||tileNum==9) {
			rend4 = Piece4.GetComponent<Renderer> ();
			rend5 = Piece5.GetComponent<Renderer> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (tileNum == 1) {
			if (puzzle.Tile1.tileOn) {
				rend1.material = onMaterial;
				rend2.material = onMaterial;
				rend3.material = onMaterial;
			} else {
				rend1.material = offMaterial;
				rend2.material = offMaterial;
				rend3.material = offMaterial;
			}
		}else if (tileNum == 2) {
			if (puzzle.Tile2.tileOn) {
				rend1.material = onMaterial;
				rend2.material = onMaterial;
				rend3.material = onMaterial;
			} else {
				rend1.material = offMaterial;
				rend2.material = offMaterial;
				rend3.material = offMaterial;
			}
		}else if (tileNum == 3) {
			if (puzzle.Tile3.tileOn) {
				rend1.material = onMaterial;
				rend2.material = onMaterial;
				rend3.material = onMaterial;
			} else {
				rend1.material = offMaterial;
				rend2.material = offMaterial;
				rend3.material = offMaterial;
			}
		}else if (tileNum == 4) {
			if (puzzle.Tile3.tileOn && !thisTile.tileOn) {
				rend1.material = onMaterial;
				rend2.material = onMaterial;
				rend3.material = onMaterial;
				rend4.material = onMaterial;
				rend5.material = onMaterial;
			} else {
				rend1.material = offMaterial;
				rend2.material = offMaterial;
				rend3.material = offMaterial;
				rend4.material = offMaterial;
				rend5.material = offMaterial;
			}

		}else if (tileNum == 5) {
			if (puzzle.Tile1.tileOn && thisTile.tileOn) {
				rend1.material = onMaterial;
				rend2.material = onMaterial;
				rend3.material = onMaterial;
				rend4.material = onMaterial;
				rend5.material = onMaterial;
			} else {
				rend1.material = offMaterial;
				rend2.material = offMaterial;
				rend3.material = offMaterial;
				rend4.material = offMaterial;
				rend5.material = offMaterial;
			}

		}else if (tileNum == 6) {
			if (puzzle.Tile3.tileOn && !puzzle.Tile4.tileOn && thisTile.tileOn) {
				rend1.material = onMaterial;
				rend2.material = onMaterial;
				rend3.material = onMaterial;
			} else {
				rend1.material = offMaterial;
				rend2.material = offMaterial;
				rend3.material = offMaterial;
			}

		}else if (tileNum == 7) {
			if (puzzle.Tile3.tileOn && !puzzle.Tile4.tileOn && puzzle.Tile1.tileOn && puzzle.Tile5.tileOn && !thisTile.tileOn) {
				rend1.material = onMaterial;
				rend2.material = onMaterial;
				rend3.material = onMaterial;
			} else {
				rend1.material = offMaterial;
				rend2.material = offMaterial;
				rend3.material = offMaterial;
			}

		}else if (tileNum == 8) {
			if (puzzle.Tile1.tileOn && puzzle.Tile5.tileOn && thisTile.tileOn) {
				rend1.material = onMaterial;
				rend2.material = onMaterial;
				rend3.material = onMaterial;
			} else {
				rend1.material = offMaterial;
				rend2.material = offMaterial;
				rend3.material = offMaterial;
			}

		}else if (tileNum == 9) {
			if (puzzle.Tile1.tileOn && puzzle.Tile3.tileOn && !puzzle.Tile4.tileOn  && puzzle.Tile5.tileOn  && puzzle.Tile6.tileOn && !puzzle.Tile7.tileOn&& puzzle.Tile8.tileOn && thisTile.tileOn ) {
				rend1.material = onMaterial;
				rend2.material = onMaterial;
				rend3.material = onMaterial;
				rend4.material = onMaterial;
				rend5.material = onMaterial;
			} else {
				rend1.material = offMaterial;
				rend2.material = offMaterial;
				rend3.material = offMaterial;
				rend4.material = offMaterial;
				rend5.material = offMaterial;
			}

		}
	}

}
