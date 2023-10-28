using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public SliderMusic volumeSlider;
	private float Music = 0;

	void Update () {
		Music = volumeSlider.GetSliderPercent();
		PlayerPrefs.SetInt ("MusicChanged", 10);
		PlayerPrefs.SetFloat ("Music", Music);
		PlayerPrefs.Save ();
	}
}
