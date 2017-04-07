using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallGuard : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		col.gameObject.transform.position = new Vector3 (131.2f,5f,-93.4f);
	}
}
