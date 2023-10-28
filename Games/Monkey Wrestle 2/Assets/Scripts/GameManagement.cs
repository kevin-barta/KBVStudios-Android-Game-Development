using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour {

	public void Start (){
		if (SceneManager.GetActiveScene ().buildIndex == 6) {
			SceneManager.LoadScene (1);
		}
		else if (SceneManager.GetActiveScene ().buildIndex == 7) {
			Destroy(GameObject.Find ("Chess Holder"));
			if (GameObject.Find ("Music").GetComponent<AudioSource> ().bypassEffects == true) {
				GameObject.Find ("Mafia").SetActive (false);
			}
			else {
				GameObject.Find ("Ghetto").SetActive (false);
			}
			GameObject.Find ("Music").GetComponent<AudioSource> ().bypassEffects = false;
		}
		else if (SceneManager.GetActiveScene ().buildIndex == 9) {
			if (QualitySettings.GetQualityLevel () == 0) {
				GameObject.Find ("Best Quality").GetComponent<Toggle>().isOn = false;
			}
			if (GameObject.Find ("Music").GetComponent<AudioSource> ().isPlaying == false) {
				GameObject.Find ("Music Settings").GetComponent<Toggle>().isOn = false;
			}
		}
	}

	public void OnClickChangeQuality (){
		GameObject clickedToggle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
		if(clickedToggle == null || clickedToggle.GetComponent<Toggle>() == null) {
			return;
		}
		if (QualitySettings.GetQualityLevel() == 5) {
			QualitySettings.SetQualityLevel (0, true);
		}
		else {
			QualitySettings.SetQualityLevel (5, true);
		}
	}

	public void OnClickChangeMusic (){
		GameObject clickedToggle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
		if(clickedToggle == null || clickedToggle.GetComponent<Toggle>() == null) {
			return;
		}
		AudioSource music = GameObject.Find ("Music").GetComponent<AudioSource> ();
		if (music.isPlaying == true) {
			music.Pause();
		}
		else {
			music.Play();
		}
	}

	public void OnClickEnableGameObject (GameObject g){
		g.SetActive(true);
	}

	public void OnClickDisableGameObject (GameObject g){
		g.SetActive(false);
	}

	public void OnClickLoadScene (int sceneBuildIndex) {
		Time.timeScale = 1;
		SceneManager.LoadScene (sceneBuildIndex);
	}

	public void OnClickExitGame (){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
