using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Settings : MonoBehaviour {

	private Ray ray;
	private RaycastHit hit;

	// Use this for initialization
	void Start () {
	System.GC.Collect();
	Resources.UnloadUnusedAssets();
		PlayerPrefs.SetInt("VisitSettings", 10);
		PlayerPrefs.Save();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit)){
				if(hit.transform.name == "How To Play"){
					if (GoogleAnalytics.instance)
						GoogleAnalytics.instance.LogScreen("Howtoplay");
					PlayerPrefs.SetInt("HowToPlay", 10);
					PlayerPrefs.Save();
					Application.LoadLevel(8);
				}
				if(hit.transform.name == "Achievements"){
					if (GoogleAnalytics.instance)
						GoogleAnalytics.instance.LogScreen("Achievements");
					Social.ShowAchievementsUI();

				}
				if(hit.transform.name == "SignOut"){
					if (GoogleAnalytics.instance)
						GoogleAnalytics.instance.LogScreen("SignOut");
					GCM.ShowToast ("Signed Out");
					((PlayGamesPlatform)Social.Active).SignOut();
				}
				if(hit.transform.name == "Back"){
					Application.LoadLevel(9);
				}
				if(hit.transform.name == "Visit"){
					if (GoogleAnalytics.instance)
						GoogleAnalytics.instance.LogScreen("Kbvstudios");
					Application.OpenURL("http://www.kbvstudios.com/");
				}
			}
		}
	}
}
