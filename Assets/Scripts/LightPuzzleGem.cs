using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzleGem : MonoBehaviour {
	public bool GemOn=false;
	public Material onMaterial;
	public Material offMaterial;
	public GameObject door;
	private Renderer rend;
	public float speed;
	private bool soundPlayed=false;
	public AudioSource doorMusic;
	void Start(){
		rend = gameObject.GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GemOn) {
			rend.material = onMaterial;
			if (door.transform.position.z <= -96.98 + 7) {
				if (!soundPlayed) {
					doorMusic.Play ();
					soundPlayed = true;
				}
				door.transform.position = new Vector3 (door.transform.position.x, door.transform.position.y,door.transform.position.z + Time.deltaTime * speed);
			}
		} else {
			rend.material = offMaterial;
		}
	}
}
