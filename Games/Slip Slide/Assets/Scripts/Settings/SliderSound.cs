using UnityEngine;
using System.Collections;

[RequireComponent (typeof (BoxCollider))]
public class SliderSound : MonoBehaviour {

	public Transform knob;
	public TextMesh textMesh;
	public string sliderName;

	public int[] valueRange;
	public int decimalPlaces;
	public float initialSliderPercent;

	private Vector3 targetPos;
	private float sliderPercent;
	private float sliderDisplayValue;
	private float sliderLength;
	
	void Start () {
		if(PlayerPrefs.GetInt("SoundChanged") == 10){
			sliderPercent = PlayerPrefs.GetFloat("Sound");
		}
		else {
			sliderPercent = initialSliderPercent;
		}
		sliderLength = GetComponent<BoxCollider>().size.x-.4f;
		targetPos = knob.position + Vector3.right * (sliderLength/-2 + sliderLength * sliderPercent);
		knob.position = targetPos; 
	}

	void Update () {
		knob.position = Vector3.Lerp(knob.position,targetPos,Time.deltaTime * 7);

		sliderPercent = Mathf.Clamp01((knob.localPosition.x + sliderLength/2) / sliderLength);
		sliderDisplayValue = Mathf.Lerp(valueRange[0],valueRange[1],sliderPercent);

		textMesh.text = sliderName + ": " + sliderDisplayValue.ToString("F" + decimalPlaces);
	}

	void OnTouchStay(Vector3 point) {
		targetPos = new Vector3(point.x,targetPos.y,targetPos.z);
	}

	public float GetSliderPercent() {
		return sliderPercent;
	}
}
