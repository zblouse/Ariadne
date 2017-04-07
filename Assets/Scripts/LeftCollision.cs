using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCollision : MonoBehaviour {
	public GameObject cube;
	public float speed;
	void OnTriggerStay(Collider col){
		if (col.tag == "Player") {
			cube.transform.position = new Vector3 (cube.transform.position.x + Time.deltaTime * speed, cube.transform.position.y, cube.transform.position.z);
		}
		}
}
