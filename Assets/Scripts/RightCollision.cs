using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCollision : MonoBehaviour {
	public GameObject cube;
	public float Speed;
	void OnTriggerStay(Collider col){
		if (col.gameObject.tag == "Player") {
			cube.transform.position = new Vector3 (cube.transform.position.x - Time.deltaTime * Speed, cube.transform.position.y, cube.transform.position.z);
		}
	}

}
