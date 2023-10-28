using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

	public GameObject land0game;
	public GameObject land1game;
	public GameObject land2game;
	public GameObject land3game;
	public GameObject land4game;
	public GameObject land5game;
	public GameObject land6game;
	public GameObject land7game;
	public GameObject Players;

	// Use this for initialization
	void Start () {
		LoadLandGame ("0");
		float ratio = (Screen.height * (16 / 9f)) / Screen.width;
		GetComponent<Camera>().orthographicSize = ratio * 20;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Players.transform.position.x, Players.transform.position.y, -100);
	}

	public void LoadLandGame (string filename){
		string[] savedata;
		if (filename == "0") {
			savedata = GameData.data[int.Parse(filename)].Split (',');
		}
		else {
			savedata = PlayerPref.GetString (filename).Split (',');
		}
		foreach (string childdata in savedata) {
			GameObject g = null;
			int roty = 0;
			int rotz = 0;
			switch (int.Parse(childdata.Substring(0, 1))) {
			case 0:
				g = (GameObject)Instantiate (land0game);
				break;
			case 1:
				g = (GameObject)Instantiate (land1game);
				break;
			case 2:
				g = (GameObject)Instantiate (land2game);
				break;
			case 3:
				g = (GameObject)Instantiate (land3game);
				break;
			case 4:
				g = (GameObject)Instantiate (land4game);
				break;
			case 5:
				g = (GameObject)Instantiate (land5game);
				break;
			case 6:
				g = (GameObject)Instantiate (land6game);
				break;
			case 7:
				g = (GameObject)Instantiate (land7game);
				break;
			}
			if (int.Parse(childdata.Substring(0, 1)) == 0) {
				g.transform.position = new Vector3 (int.Parse (childdata.Substring (1, 2)) * 5, int.Parse (childdata.Substring (3, 2)) * 5, 1);
			}
			else {
				g.transform.position = new Vector3 (int.Parse (childdata.Substring (1, 2)) * 5, int.Parse (childdata.Substring (3, 2)) * 5, 0);
			}
			switch (int.Parse(childdata.Substring(5, 1))) {
			case 0:
				roty = 0;
				break;
			case 1:
				roty = 180;
				break;
			}
			switch (int.Parse(childdata.Substring(6, 1))) {
			case 0:
				rotz = 0;
				break;
			case 1:
				rotz = 90;
				break;
			case 2:
				rotz = 180;
				break;
			case 3:
				rotz = 270;
				break;
			}
			g.transform.eulerAngles = new Vector3 (0, roty, rotz);
			g.transform.parent = GameObject.Find ("LandHolder").transform;
		}
	}

	public void TutorialClicked (){
		GameObject.Find ("Tutorial").SetActive(false);
		GameObject.Find ("Players").GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
		GameObject.Find ("LegP1").GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
		GameObject.Find ("BodyP1").GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
		GameObject.Find ("FootP1").GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
		GameObject.Find ("HeadP1").GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
		GameObject.Find ("LegP2").GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
		GameObject.Find ("BodyP2").GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
		GameObject.Find ("FootP2").GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
		GameObject.Find ("HeadP2").GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
	}

	public void HealthBarChanged (Slider healthbar){
		if(healthbar.value == healthbar.minValue){
			print ("Right Side Wins");
		}
		else if(healthbar.value == healthbar.maxValue){
			print ("Left Side Wins");
		}
	}
}
