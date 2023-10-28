using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoText : MonoBehaviour {
	public Text textui;
	private float time;
	private float olength;
	private float flength;
	private float olengthtemp;
	private float flengthtemp;

	public void UpdateInfoText(string inputtext, float opaquelength, float fadelength){
		textui.color = new Color(textui.color.r, textui.color.b, textui.color.g, 1);
		textui.text = inputtext;
		if (olength == 0) {
			olength = opaquelength;
			flength = fadelength;
			StartCoroutine (Wait ());
		}
		else{
			olengthtemp = opaquelength;
			flengthtemp = fadelength;
		}
	}

	void Update () {
		if(olengthtemp != 0){
			time = 0;
			olength = olengthtemp;
			flength = flengthtemp;
			olengthtemp = 0;
			flengthtemp = 0;
			textui.color = new Color(textui.color.r, textui.color.b, textui.color.g, 1);
			StartCoroutine(Wait ());
		}
		else if(time != 0 && ((time - Time.time) / flength) <= 0){
			textui.text = "";
			time = 0;
			olength = 0;
			flength = 0;
		}
		else if(time != 0){
			textui.color = Color.Lerp (new Color(textui.color.r, textui.color.b, textui.color.g, 1), new Color(textui.color.r, textui.color.b, textui.color.g, 0), 1 - ((time - Time.time) / flength));
		}
	}

	IEnumerator Wait(){
		for (int i = 0; i < (olength / 0.1f); i++) {
			if(olengthtemp != 0){
				i = 0;
				olength = olengthtemp;
				flength = flengthtemp;
				olengthtemp = 0;
				flengthtemp = 0;
			}
			yield return new WaitForSeconds (0.1f);
		}
		time = Time.time + flength;
	}
}
