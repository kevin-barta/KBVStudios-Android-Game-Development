using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class GooglePlayServices : MonoBehaviour {

	//public GUISkin skin;
	public const string achievement = "CgkI5v-PufwaEAIQAw";

	void Start () {
		// Activate the Google Play Games platform
		PlayGamesPlatform.Activate();

		Social.localUser.Authenticate((bool success) =>
		                              {
			if (success)
			{
				Debug.Log("You've successfully logged in");
			}
			else
			{
				Debug.Log("Login failed for some reason");
			}
		});

		//Social.localUser.Authenticate((bool success) => {
			// handle success or failure
		//});
	}
	/*public void OnGUI (){

		GUI.skin = skin;
		skin.button.fixedWidth = Screen.width - 25;
		skin.textField.fixedWidth = Screen.width - 25;
		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
		
		GUILayout.BeginVertical("box");
		
		GUILayout.Space(20);


		//Achievement
		if (GUILayout.Button("Unlock Achievement"))
		{
			if (Social.localUser.authenticated)
			{
				Social.ReportProgress(achievement, 100.0f, (bool success) =>
				                      {
					if (success)
					{
						Debug.Log("You've successfully logged in");
					}
					else
					{
						Debug.Log("Login failed for some reason");
					}
				});
			}
		}
		//Sign Out
		if (GUILayout.Button("Sign Out"))
		{
			((PlayGamesPlatform)Social.Active).SignOut();
		}
		
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}*/
}
