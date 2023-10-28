using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class ColourButton : MonoBehaviour {

	private int Active = 0;
	private int SetActive = 10;
	private int Part = 0;
	private string Part1 = "";
	public Image buybackground;
	public Text buytext;

	public void Start (){
		if(transform.parent.gameObject.name == "BodiesMenu"){
			Part = 1;
		}
		else if(transform.parent.gameObject.name == "WingsMenu"){
			Part = 3;
		}
		else if(transform.parent.gameObject.name == "ClawsMenu"){
			Part = 6;
		}
		else if(transform.parent.gameObject.name == "EyesMenu"){
			Part = 8;
		}
		else if(transform.parent.gameObject.name == "BeaksMenu"){
			Part = 10;
		}
		else if(transform.parent.gameObject.name == "AccessoriesMenu"){
			Part = 12;
		}
		Part1 = PlayerPref.GetString (Part);
		Part1 = "ColourButton" + Part1;
		if(Part1 == gameObject.name){
			SetActive = 0;
			Active = 10;
			buytext.GetComponent<Text>().text = "ACTIVE";
		}
	}

	public void BuyItem (){
		if(SetActive == 10){
			SetActive = 0;
			Active = 10;
			buytext.GetComponent<Text>().text = "ACTIVE";
			if(transform.parent.gameObject.name == "BodiesMenu"){
				Part = 1;
			}
			else if(transform.parent.gameObject.name == "WingsMenu"){
				Part = 3;
			}
			else if(transform.parent.gameObject.name == "ClawsMenu"){
				Part = 6;
			}
			else if(transform.parent.gameObject.name == "EyesMenu"){
				Part = 8;
			}
			else if(transform.parent.gameObject.name == "BeaksMenu"){
				Part = 10;
			}
			else if(transform.parent.gameObject.name == "AccessoriesMenu"){
				Part = 12;
			}
			Part1 = PlayerPref.GetString (Part);
			Part1 = "ColourButton" + Part1;
			foreach(GameObject Obj in GameObject.FindGameObjectsWithTag(gameObject.tag)){
				if(Obj.name == Part1){
					Obj.SendMessage("Deactivate");
				}
			}
		}
	}

	public void Deactivate (){
		Active = 0;
		SetActive = 10;
		buytext.GetComponent<Text>().text = "SET ACTIVE";
	}
}