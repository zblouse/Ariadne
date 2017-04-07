using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutSceneMenu : MonoBehaviour {

	public void LoadScene(int scene){
		Debug.Log ("Loading Scene");
		SceneManager.LoadScene (scene);
	}
}
