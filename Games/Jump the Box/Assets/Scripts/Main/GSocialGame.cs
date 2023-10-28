using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class GSocialGame : MonoBehaviour {

	public const string ViewYourAchievements = "CgkI08Sz7toDEAIQAQ";
	public const string ViewTheLeaderboard = "CgkI08Sz7toDEAIQCg";
	public const string Get10Points = "CgkI08Sz7toDEAIQAg";
	public const string Get20Points = "CgkI08Sz7toDEAIQAw";
	public const string Get50Points = "CgkI08Sz7toDEAIQBA";
	public const string Get100Points = "CgkI08Sz7toDEAIQBQ";
	public const string Play50Games = "CgkI08Sz7toDEAIQBg";
	public const string Play100Games = "CgkI08Sz7toDEAIQBw";
	public const string Play500Games = "CgkI08Sz7toDEAIQCA";
	public const string Play1000Games = "CgkI08Sz7toDEAIQCQ";
	private Ray ray;
	private RaycastHit hit;
	public GameObject Achievement;
	public  GameObject Leaderboard;
	int Achievement1 = 0;
	int Leaderboard1 = 0;

	void Start () {
		if (Social.localUser.authenticated) {
		}
		else{
			PlayGamesPlatform.Activate();
			Social.localUser.Authenticate ((bool success) => {
			});
		}
		if (Social.localUser.authenticated){
			int Highscore2 = PlayerPrefs.GetInt("Highscore1");
			Social.ReportScore(Highscore2, "CgkI08Sz7toDEAIQAA", (bool success) => {
			});
		}
		if(PlayerPrefs.GetInt("ViewYourAchievements") == 10){
			if (Social.localUser.authenticated){
				Social.ReportProgress(ViewYourAchievements, 100.0f, (bool success) => {
				});
			}
		}
		if(PlayerPrefs.GetInt("ViewTheLeaderboard") == 10){
			if (Social.localUser.authenticated){
				Social.ReportProgress(ViewTheLeaderboard, 100.0f, (bool success) => {
				});
			}
		}
		if(PlayerPrefs.GetInt("Get10Points") == 10){
			if (Social.localUser.authenticated){
				Social.ReportProgress(Get10Points, 100.0f, (bool success) => {
				});
			}
		}
		if(PlayerPrefs.GetInt("Get20Points") == 10){
			if (Social.localUser.authenticated){
				Social.ReportProgress(Get20Points, 100.0f, (bool success) => {
				});
			}
		}
		if(PlayerPrefs.GetInt("Get50Points") == 10){
			if (Social.localUser.authenticated){
				Social.ReportProgress(Get50Points, 100.0f, (bool success) => {
				});
			}
		}
		if(PlayerPrefs.GetInt("Get100Points") == 10){
			if (Social.localUser.authenticated){
				Social.ReportProgress(Get100Points, 100.0f, (bool success) => {
				});
			}
		}
		if(PlayerPrefs.GetInt("PlayGame") == 10){
			if (Social.localUser.authenticated){
				((PlayGamesPlatform) Social.Active).IncrementAchievement(
					"CgkI08Sz7toDEAIQBg", 1, (bool success) => {
				});
			}
		}
		if(PlayerPrefs.GetInt("PlayGame") == 10){
			if (Social.localUser.authenticated){
				((PlayGamesPlatform) Social.Active).IncrementAchievement(
					"CgkI08Sz7toDEAIQBw", 1, (bool success) => {
				});
			}
		}
		if(PlayerPrefs.GetInt("PlayGame") == 10){
			if (Social.localUser.authenticated){
				((PlayGamesPlatform) Social.Active).IncrementAchievement(
					"CgkI08Sz7toDEAIQCA", 1, (bool success) => {
				});
			}
		}
		if(PlayerPrefs.GetInt("PlayGame") == 10){
			if (Social.localUser.authenticated){
				((PlayGamesPlatform) Social.Active).IncrementAchievement(
					"CgkI08Sz7toDEAIQCQ", 1, (bool success) => {
				});
				PlayerPrefs.SetInt("PlayGame", 0);
				PlayerPrefs.Save();
			}
		}
	}

	void Update (){
			if(Input.GetMouseButtonDown(0)){
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if(Physics.Raycast(ray, out hit)){
					if(hit.transform.name == "Achievements"){
						Achievement.transform.localScale += new Vector3(0.2F,0.2F,0);
						Achievement1 = 10;
					}
					if(hit.transform.name == "Leaderboard"){
						Leaderboard.transform.localScale += new Vector3(0.2F,0.2F,0);
						Leaderboard1 = 10;
					}
				}
			}
			if(Input.GetMouseButtonUp(0)){
				if(Achievement1 == 10){
					Achievement.transform.localScale -= new Vector3(0.2F,0.2F,0);
					Achievement1 = 0;
				}
				if(Leaderboard1 == 10){
					Leaderboard.transform.localScale -= new Vector3(0.2F,0.2F,0);
					Leaderboard1 = 0;
				}
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if(Physics.Raycast(ray, out hit)){
				if(hit.transform.name == "Achievements"){
					if (Social.localUser.authenticated){
						PlayerPrefs.SetInt("ViewYourAchievements", 10);
						PlayerPrefs.Save();
						Application.LoadLevel(0);
						Social.ShowAchievementsUI();
					}
				}
				if(hit.transform.name == "Leaderboard"){
					if (Social.localUser.authenticated){
						PlayerPrefs.SetInt("ViewTheLeaderboard", 10);
						PlayerPrefs.Save();
						Application.LoadLevel(0);
						((PlayGamesPlatform) Social.Active).ShowLeaderboardUI("CgkI08Sz7toDEAIQAA");
					}
				}
			}
		}
	}
}