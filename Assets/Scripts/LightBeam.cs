using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LightBeam : MonoBehaviour {
	public Vector3 StartingPoint;
	public Vector3 StartingDirection;
	private Vector3 Midpoint;
	public GameObject LightPrefab;
	private Quaternion newRotation;
	public GameObject LightGem;
	private LightPuzzleGem gem;
	private Stack beams;
	public bool MirrorsChanged=true;
	// Use this for initialization
	void Start () {
		StartingDirection = new Vector3 (-1,0,0);
		StartingPoint=new Vector3(448,15,-81.98f);
		beams = new Stack ();
		gem = LightGem.GetComponent<LightPuzzleGem> ();
		Debug.Log ("new Rotation: "+newRotation);
	}
	
	// Update is called once per frame
	void Update () {
		if (MirrorsChanged) {
			gem.GemOn = false;
			while (beams.Count != 0) {
				GameObject oldBeam =(GameObject) beams.Pop ();
				DestroyImmediate (oldBeam);
			}
			StartingDirection = new Vector3 (-1,0,0);
			StartingPoint=new Vector3(448,15,-81.98f);
			RaycastHit hit;
			if (Physics.Raycast (StartingPoint, StartingDirection, out hit, 100f)) {
				
					Debug.Log ("Hit Point: " + hit.point + " Distance: " + hit.distance);

					float x1 = StartingPoint.x;
					float z1 = StartingPoint.z;
					float x2 = hit.point.x;
					float z2 = hit.point.z;
					Midpoint = new Vector3 ((x1 / 2) + (x2 / 2), StartingPoint.y, (z1 / 2) + (z2 / 2));
					newRotation = Quaternion.FromToRotation (Vector3.up, hit.point - StartingPoint);
					GameObject NewBeam = Instantiate (LightPrefab, Midpoint, newRotation);
					NewBeam.transform.localScale = new Vector3 (.5f, hit.distance / 2, .5f);
					StartingPoint = hit.point;
					StartingDirection = Vector3.Reflect (StartingDirection,hit.normal);
					beams.Push (NewBeam);

				while (hit.collider.transform.tag != "Wall" && hit.collider.transform.tag !="Gem") {
					
					Debug.Log (hit.collider.transform.tag);

					Debug.Log("Hit Point: "+hit.point+" Distance: "+hit.distance);
					if (Physics.Raycast (StartingPoint, StartingDirection, out hit, 100f)) {
						
							x1 = StartingPoint.x;
							z1 = StartingPoint.z;
							x2 = hit.point.x;
							z2 = hit.point.z;
							Midpoint = new Vector3 ((x1 / 2) + (x2 / 2), StartingPoint.y, (z1 / 2) + (z2 / 2));
							newRotation = Quaternion.FromToRotation (Vector3.up, hit.point - StartingPoint);
							NewBeam = Instantiate (LightPrefab, Midpoint, newRotation);
							NewBeam.transform.localScale = new Vector3 (.5f, hit.distance / 2, .5f);
							StartingPoint = hit.point;
							StartingDirection = Vector3.Reflect (StartingDirection,hit.normal);
							beams.Push (NewBeam);

					}
				}
				if (hit.collider.transform.tag == "Gem") {
					gem.GemOn = true;
				}
			}

			MirrorsChanged = false;
		}

	}
}
