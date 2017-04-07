using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	public GameObject Player;
	// Use this for initialization
	void Start () {
		this.transform.position = Player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = Player.transform.position;
	}
}
