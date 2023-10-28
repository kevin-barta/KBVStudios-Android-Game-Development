using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Achievements : MonoBehaviour {

	public const string JustPlainHorrible = "CgkI5v-PufwaEAIQAw";
	public const string GoodStart = "CgkI5v-PufwaEAIQAg";
	public const string GettingThere = "CgkI5v-PufwaEAIQBA";
	public const string KeepTrying = "CgkI5v-PufwaEAIQBQ";
	public const string VisitSettings = "CgkI5v-PufwaEAIQBg";


	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("JustPlainHorrible") == 10){
		if (Social.localUser.authenticated){
			Social.ReportProgress(JustPlainHorrible, 100.0f, (bool success) => {
				if (success){
					Debug.Log("You've successfully logged in");
					}
				else{
					Debug.Log("Login failed for some reason");
				    }
			    });
		    }
		}
		if(PlayerPrefs.GetInt("GoodStart") == 10){
			if (Social.localUser.authenticated){
				Social.ReportProgress(GoodStart, 100.0f, (bool success) => {
					if (success){
						Debug.Log("You've successfully logged in");
					}
					else{
						Debug.Log("Login failed for some reason");
					}
				});
			}
		}
		if(PlayerPrefs.GetInt("GettingThere") == 10){
			if (Social.localUser.authenticated){
				Social.ReportProgress(GettingThere, 100.0f, (bool success) => {
					if (success){
						Debug.Log("You've successfully logged in");
					}
					else{
						Debug.Log("Login failed for some reason");
					}
				});
			}
		}
		if(PlayerPrefs.GetInt("KeepTrying") == 10){
			if (Social.localUser.authenticated){
				Social.ReportProgress(KeepTrying, 100.0f, (bool success) => {
					if (success){
						Debug.Log("You've successfully logged in");
					}
					else{
						Debug.Log("Login failed for some reason");
					}
				});
			}
		}
		if(PlayerPrefs.GetInt("VisitSettings") == 10){
			if (Social.localUser.authenticated){
				Social.ReportProgress(VisitSettings, 100.0f, (bool success) => {
					if (success){
						Debug.Log("You've successfully logged in");
					}
					else{
						Debug.Log("Login failed for some reason");
					}
				});
			}
		}
	}
}
