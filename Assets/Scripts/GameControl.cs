using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public static GameControl control;

	public float PlayerPositionX;
	public float PlayerPositionY;
	public float PlayerPositionZ;

	public float Puzzle1DoorX;
	public float GemDoorZ;
	public float LightDoorZ;
	public float ElectricDoorX;

	public bool PlayerGem1;
	public bool PlayerGem2;
	public bool PlayerGem3;
	public bool PlayerGem4;
	public bool PlayerGem5;

	public bool BoxGem1;
	public bool BoxGem2;
	public bool BoxGem3;
	public bool BoxGem4;
	public bool BoxGem5;

	public bool isUnderground;


	// Use this for initialization
	void Awake () {

		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
			if (File.Exists (Application.persistentDataPath + "/playerDat.dat")) {
				load ();

			} else {
				PlayerPositionX = -68.59f;
				PlayerPositionY = 8f;
				PlayerPositionZ = 0.61f;
				Puzzle1DoorX = 20.21f;
				GemDoorZ = -7.37f;
				LightDoorZ = -96.98f;
				ElectricDoorX = 472.95f;
				PlayerGem1 = false;
				PlayerGem2 = false;
				PlayerGem3 = false;
				PlayerGem4 = false;
				PlayerGem5 = false;

				BoxGem1 = false;
				BoxGem2 = false;
				BoxGem3 = false;
				BoxGem4 = false;
				BoxGem5 = false;

				isUnderground = true;
					

			}

		} else if (control != this) {
			Destroy (gameObject);
		}

	}
	void OnDestroy(){
		save ();
	}

	public void save(){
		
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath+ "/playerDat.dat");
		PlayerData data = new PlayerData ();
		data.PlayerPositionX = control.PlayerPositionX;
		data.PlayerPositionY = control.PlayerPositionY;
		data.PlayerPositionZ = control.PlayerPositionZ;
		data.Puzzle1DoorX = control.Puzzle1DoorX;
		data.GemDoorZ = control.GemDoorZ;
		data.LightDoorZ = control.LightDoorZ;
		data.ElectricDoorX = control.ElectricDoorX;
		data.PlayerGem1 = control.PlayerGem1;
		data.PlayerGem2 = control.PlayerGem2;
		data.PlayerGem3 = control.PlayerGem3;
		data.PlayerGem4 = control.PlayerGem4;
		data.PlayerGem5 = control.PlayerGem5;
		data.BoxGem1 = control.BoxGem1;
		data.BoxGem2 = control.BoxGem2;
		data.BoxGem3 = control.BoxGem3;
		data.BoxGem4 = control.BoxGem4;
		data.BoxGem5 = control.BoxGem5;
		data.isUnderground = control.isUnderground;

		bf.Serialize (file, data);
		file.Close();

	}

	public void load(){
		if (File.Exists (Application.persistentDataPath + "/playerDat.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath+ "/playerDat.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			file.Close ();
			control.PlayerPositionX = data.PlayerPositionX;
			control.PlayerPositionY = data.PlayerPositionY;
			control.PlayerPositionZ = data.PlayerPositionZ;
			control.Puzzle1DoorX = data.Puzzle1DoorX;
			control.GemDoorZ = data.GemDoorZ;
			control.LightDoorZ = data.LightDoorZ;
			control.ElectricDoorX = data.ElectricDoorX;
			control.PlayerGem1 = data.PlayerGem1;
			control.PlayerGem2 = data.PlayerGem2;
			control.PlayerGem3 = data.PlayerGem3;
			control.PlayerGem4 = data.PlayerGem4;
			control.PlayerGem5 = data.PlayerGem5;
			control.BoxGem1 = data.BoxGem1;
			control.BoxGem2 = data.BoxGem2;
			control.BoxGem3 = data.BoxGem3;
			control.BoxGem4 = data.BoxGem4;
			control.BoxGem5 = data.BoxGem5;
			control.isUnderground = data.isUnderground;

		}
	}
	public void NewSaveFile(){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath+ "/playerDat.dat");
		PlayerData data = new PlayerData ();
		data.PlayerPositionX = -68.59f;
		data.PlayerPositionY = 8f;
		data.PlayerPositionZ = 0.61f;
		data.Puzzle1DoorX = 20.21f;
		data.GemDoorZ = -7.37f;
		data.LightDoorZ = -96.98f;
		data.ElectricDoorX = 472.95f;
		data.PlayerGem1 = false;
		data.PlayerGem2 = false;
		data.PlayerGem3 = false;
		data.PlayerGem4 = false;
		data.PlayerGem5 = false;
		data.BoxGem1 = false;
		data.BoxGem2 = false;
		data.BoxGem3 = false;
		data.BoxGem4 = false;
		data.BoxGem5 = false;
		data.isUnderground = true;


		control.PlayerPositionX = -68.59f;
		control.PlayerPositionY = 8f;
		control.PlayerPositionZ = 0.61f;
		control.Puzzle1DoorX = 20.21f;
		control.GemDoorZ = -7.37f;
		control.LightDoorZ = -96.98f;
		control.ElectricDoorX = 472.95f;
		control.PlayerGem1 = false;
		control.PlayerGem2 = false;
		control.PlayerGem3 = false;
		control.PlayerGem4 = false;
		control.PlayerGem5 = false;
		control.BoxGem1 = false;
		control.BoxGem2 = false;
		control.BoxGem3 = false;
		control.BoxGem4 = false;
		control.BoxGem5 = false;
		control.isUnderground = true;


		bf.Serialize (file, data);
		file.Close();
		SceneManager.LoadScene (1);
	}
}
[Serializable]
class PlayerData{
	public float PlayerPositionX;
	public float PlayerPositionY;
	public float PlayerPositionZ;
	public float Puzzle1DoorX;
	public float GemDoorZ;
	public float LightDoorZ;
	public float ElectricDoorX;
	public bool PlayerGem1;
	public bool PlayerGem2;
	public bool PlayerGem3;
	public bool PlayerGem4;
	public bool PlayerGem5;
	public bool BoxGem1;
	public bool BoxGem2;
	public bool BoxGem3;
	public bool BoxGem4;
	public bool BoxGem5;
	public bool isUnderground;
}

