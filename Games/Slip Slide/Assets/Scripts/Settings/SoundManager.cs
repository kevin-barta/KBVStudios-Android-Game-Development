using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public SliderSound volumeSlider;
	private float Sound = 0;

	void Update () {
		Sound = volumeSlider.GetSliderPercent();
		PlayerPrefs.SetInt ("SoundChanged", 10);
		PlayerPrefs.SetFloat ("Sound", Sound);
		PlayerPrefs.Save ();
	}
}
