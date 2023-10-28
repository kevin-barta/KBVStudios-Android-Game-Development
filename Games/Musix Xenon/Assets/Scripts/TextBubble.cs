using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SVGImporter;

public class TextBubble : MonoBehaviour {
	public SVGImage imageui;
	public Text textui;
	public float wait = -1;
	private float time;

	void Update () {
		GetComponent<SVGImage>().color = GameObject.Find("Controller").GetComponent<Gradient> ().colorrel;
		if(wait <= Time.time && wait != 0){
			wait = 0;
			time = Time.time;
		}
		else if(time != 0 && (Time.time - time) <= 1){
			imageui.color = new Color(imageui.color.r, imageui.color.g, imageui.color.b, 1f - (Time.time - time));
			textui.color = new Color(textui.color.r, textui.color.g, textui.color.b, 1f - (Time.time - time));
		}
		else if(time != 0){
			Destroy(gameObject);
		}
	}

	public static GameObject BubbleSetup(Transform rect, float posx, float posy, int rot, float sizerelative, string text, int textsize, float opaquetime){
		GameObject objectref = (GameObject)Instantiate (Resources.Load("TextBackground"));
		objectref.transform.SetParent (rect);
		objectref.transform.localPosition = new Vector3(posx, posy);
		objectref.transform.localEulerAngles = new Vector3 (0, rot);
		objectref.transform.localScale = new Vector3 (1, 1, 1);
		objectref.GetComponent<RectTransform> ().sizeDelta = new Vector2 (100 * sizerelative, 68 * sizerelative);
		objectref.GetComponent<TextBubble> ().textui.transform.localEulerAngles = new Vector3 (0, rot);
		objectref.GetComponent<TextBubble> ().textui.text = text;
		objectref.GetComponent<TextBubble> ().textui.fontSize = textsize;
		objectref.GetComponent<TextBubble> ().wait = Time.time + opaquetime;
		return objectref;
	}
}
