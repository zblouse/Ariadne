using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	public void QuitGame(){
		Application.Quit ();
	}
	public void LoadLevel(int sceneNum){
		SceneManager.LoadScene (sceneNum);
	}
}
