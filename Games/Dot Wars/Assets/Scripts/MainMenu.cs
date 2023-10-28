using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SVGImporter;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public byte Version = 1;
	public PhotonView photonview;
	public string MatchID;
	public Text Errortext;
	private PhotonPlayer join1;
	private PhotonPlayer join2;
	private PhotonPlayer join3;
	private PhotonPlayer join4;
	private bool ConnectInUpdate = true;
	private bool ConnectedMaster = false;

	public RectTransform Matches;
	public RectTransform Players;
	public RectTransform StoreHolder;
	public RectTransform BuyHolder;
	public RectTransform UpgradeHolder;
	public RectTransform SceneHolder;
	public Button PlayBack;
	public Button PlayersBack;
	public Button StoreBack;
	public Button BuyBack;
	public Button UpgradeBack;
	public Button SceneBack;
	public Button PlayersStart;
	public Button Buy;
	public Button Buy1;
	public Button Buy2;
	public Button Buy3;
	public Button Buy4;
	public Button Buy5;
	public Button Upgrade;
	public Button Speed;
	public Button Shots;
	public Button Scene;
	public Button SceneDefault;
	public Button Scene1;
	public Button Scene2;
	public Button Scene3;
	public Button Scene4;
	public SVGImage Play;
	public SVGImage Store;
	public SVGImage Automatch;
	public SVGImage AutomatchDouble;
	public SVGImage CreateMatch;
	public SVGImage CreateMatchDouble;
	public SVGImage JoinMatch;
	public SVGImage JoinMatchDouble;
	public Text StoreInfoText;
	public Text AutomatchText;
	public Text CreateMatchText;
	public Text JoinMatchText;
	public Text CreateMatchAgainText;
	public Text PlayersText;
	public InputField JoinMatchInput;
	//private GoogleAnalyticsV4 googleAnalytics;
	private int playorder;
	private int playclicked;
	private int storeclicked;
	private int starttimeleft;
	private float time;
	private float time1;
	private float storetime;
	private float storeitemstime;

	public virtual void Start()
	{
		//googleAnalytics = GameObject.Find ("GAv4").GetComponent<GoogleAnalyticsV4>();
		//googleAnalytics.LogScreen ("Main");
		PhotonNetwork.autoJoinLobby = false;
		PhotonNetwork.Disconnect ();
		System.GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	void Update (){
		if(storeclicked == 1){
			if ((Time.time - time) * 1.5f <= 1) {
				Play.transform.localPosition = Vector3.Lerp (new Vector3 (0, 0, 0), new Vector3 (500, 0, 0), (Time.time - time) * 1.5f);
				Store.transform.localPosition = Vector3.Lerp (new Vector3 (0, -100, 0), new Vector3 (500, -100, 0), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				storeclicked = 0;
				StoreBack.interactable = true;
				Buy.interactable = true;
				Scene.interactable = true;
				Upgrade.interactable = true;
			}
			else{
				if(time1 == 0){
					time1 = Time.time;
				}
				StoreHolder.offsetMin = Vector2.Lerp (new Vector2 (-500, 30), new Vector2 (0, 30), (Time.time - time1) * 1.5f);
				StoreHolder.offsetMax = Vector2.Lerp (new Vector2 (-500, -125), new Vector2 (0, -125), (Time.time - time1) * 1.5f);
			}
		}
		else if(storeclicked == 2){
			if((Time.time - time) * 1.5f <= 1){
				StoreHolder.offsetMin = Vector2.Lerp (new Vector2 (0, 30), new Vector2 (-500, 30), (Time.time - time) * 1.5f);
				StoreHolder.offsetMax = Vector2.Lerp (new Vector2 (0, -125), new Vector2 (-500, -125), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				storeclicked = 0;
				Play.GetComponent<Button> ().interactable = true;
				Store.GetComponent<Button> ().interactable = true;
			}
			else {
				if(time1 == 0){
					time1 = Time.time;
				}
				Play.transform.localPosition = Vector3.Lerp (new Vector3 (500, 0, 0), new Vector3 (0, 0, 0), (Time.time - time1) * 1.5f);
				Store.transform.localPosition = Vector3.Lerp (new Vector3 (500, -100, 0), new Vector3 (0, -100, 0), (Time.time - time1) * 1.5f);
			}
		}
		else if(storeclicked == 3){
			if ((Time.time - time) * 1.5f <= 1) {
				StoreHolder.offsetMin = Vector2.Lerp (new Vector2 (0, 30), new Vector2 (500, 30), (Time.time - time) * 1.5f);
				StoreHolder.offsetMax = Vector2.Lerp (new Vector2 (0, -125), new Vector2 (500, -125), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				storeclicked = 0;
				BuyBack.interactable = true;
				Buy1.interactable = true;
				Buy2.interactable = true;
				Buy3.interactable = true;
				Buy4.interactable = true;
				Buy5.interactable = true;
			}
			else{
				if(time1 == 0){
					time1 = Time.time;
				}
				BuyHolder.offsetMin = Vector2.Lerp (new Vector2 (-500, 30), new Vector2 (0, 30), (Time.time - time1) * 1.5f);
				BuyHolder.offsetMax = Vector2.Lerp (new Vector2 (-500, -125), new Vector2 (0, -125), (Time.time - time1) * 1.5f);
			}
		}
		else if(storeclicked == 4){
			if((Time.time - time) * 1.5f <= 1){
				BuyHolder.offsetMin = Vector2.Lerp (new Vector2 (0, 30), new Vector2 (-500, 30), (Time.time - time) * 1.5f);
				BuyHolder.offsetMax = Vector2.Lerp (new Vector2 (0, -125), new Vector2 (-500, -125), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				storeclicked = 0;
				StoreBack.interactable = true;
				Buy.interactable = true;
				Scene.interactable = true;
				Upgrade.interactable = true;
			}
			else {
				if(time1 == 0){
					time1 = Time.time;
				}
				StoreHolder.offsetMin = Vector2.Lerp (new Vector2 (500, 30), new Vector2 (0, 30), (Time.time - time1) * 1.5f);
				StoreHolder.offsetMax = Vector2.Lerp (new Vector2 (500, -125), new Vector2 (0, -125), (Time.time - time1) * 1.5f);
			}
		}
		else if(storeclicked == 5){
			if ((Time.time - time) * 1.5f <= 1) {
				StoreHolder.offsetMin = Vector2.Lerp (new Vector2 (0, 30), new Vector2 (500, 30), (Time.time - time) * 1.5f);
				StoreHolder.offsetMax = Vector2.Lerp (new Vector2 (0, -125), new Vector2 (500, -125), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				storeclicked = 0;
				UpgradeBack.interactable = true;
				Speed.interactable = true;
				Shots.interactable = true;
			}
			else{
				if(time1 == 0){
					time1 = Time.time;
				}
				UpgradeHolder.offsetMin = Vector2.Lerp (new Vector2 (-500, 30), new Vector2 (0, 30), (Time.time - time1) * 1.5f);
				UpgradeHolder.offsetMax = Vector2.Lerp (new Vector2 (-500, -125), new Vector2 (0, -125), (Time.time - time1) * 1.5f);
			}
		}
		else if(storeclicked == 6){
			if((Time.time - time) * 1.5f <= 1){
				UpgradeHolder.offsetMin = Vector2.Lerp (new Vector2 (0, 30), new Vector2 (-500, 30), (Time.time - time) * 1.5f);
				UpgradeHolder.offsetMax = Vector2.Lerp (new Vector2 (0, -125), new Vector2 (-500, -125), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				storeclicked = 0;
				StoreBack.interactable = true;
				Buy.interactable = true;
				Scene.interactable = true;
				Upgrade.interactable = true;
			}
			else {
				if(time1 == 0){
					time1 = Time.time;
				}
				StoreHolder.offsetMin = Vector2.Lerp (new Vector2 (500, 30), new Vector2 (0, 30), (Time.time - time1) * 1.5f);
				StoreHolder.offsetMax = Vector2.Lerp (new Vector2 (500, -125), new Vector2 (0, -125), (Time.time - time1) * 1.5f);
			}
		}
		else if(storeclicked == 7){
			if ((Time.time - time) * 1.5f <= 1) {
				StoreHolder.offsetMin = Vector2.Lerp (new Vector2 (0, 30), new Vector2 (500, 30), (Time.time - time) * 1.5f);
				StoreHolder.offsetMax = Vector2.Lerp (new Vector2 (0, -125), new Vector2 (500, -125), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				storeclicked = 0;
				SceneBack.interactable = true;
				SceneDefault.interactable = true;
				Scene1.interactable = true;
				Scene2.interactable = true;
				Scene3.interactable = true;
				Scene4.interactable = true;
			}
			else{
				if(time1 == 0){
					time1 = Time.time;
				}
				SceneHolder.offsetMin = Vector2.Lerp (new Vector2 (-500, 30), new Vector2 (0, 30), (Time.time - time1) * 1.5f);
				SceneHolder.offsetMax = Vector2.Lerp (new Vector2 (-500, -125), new Vector2 (0, -125), (Time.time - time1) * 1.5f);
			}
		}
		else if(storeclicked == 8){
			if((Time.time - time) * 1.5f <= 1){
				SceneHolder.offsetMin = Vector2.Lerp (new Vector2 (0, 30), new Vector2 (-500, 30), (Time.time - time) * 1.5f);
				SceneHolder.offsetMax = Vector2.Lerp (new Vector2 (0, -125), new Vector2 (-500, -125), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				storeclicked = 0;
				StoreBack.interactable = true;
				Buy.interactable = true;
				Scene.interactable = true;
				Upgrade.interactable = true;
			}
			else {
				if(time1 == 0){
					time1 = Time.time;
				}
				StoreHolder.offsetMin = Vector2.Lerp (new Vector2 (500, 30), new Vector2 (0, 30), (Time.time - time1) * 1.5f);
				StoreHolder.offsetMax = Vector2.Lerp (new Vector2 (500, -125), new Vector2 (0, -125), (Time.time - time1) * 1.5f);
			}
		}
		if(playclicked == 1){
			if ((Time.time - time) * 1.5f <= 1) {
				Play.transform.localPosition = Vector3.Lerp (new Vector3(0, 0, 0), new Vector3 (-500, 0, 0), (Time.time - time) * 1.5f);
				Store.transform.localPosition = Vector3.Lerp (new Vector3(0, -100, 0), new Vector3 (-500, -100, 0), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				playclicked = 0;
				Automatch.GetComponent<Button> ().interactable = true;
				CreateMatch.GetComponent<Button> ().interactable = true;
				JoinMatch.GetComponent<Button> ().interactable = true;
				PlayBack.interactable = true;
			}
			else{
				if(time1 == 0){
					time1 = Time.time;
				}
				Matches.transform.localPosition = Vector3.Lerp (new Vector3(500, 0, 0), new Vector3(0, 0, 0), (Time.time - time1) * 1.5f);
			}
		}
		else if(playclicked == 2){
			if((Time.time - time) * 1.5f <= 1){
				Matches.transform.localPosition = Vector3.Lerp (new Vector3(0, 0, 0), new Vector3(500, 0, 0), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				playclicked = 0;
				Play.GetComponent<Button> ().interactable = true;
				Store.GetComponent<Button> ().interactable = true;
			}
			else {
				if(time1 == 0){
					time1 = Time.time;
				}
				Play.transform.localPosition = Vector3.Lerp (new Vector3 (-500, 0, 0), new Vector3 (0, 0, 0), (Time.time - time1) * 1.5f);
				Store.transform.localPosition = Vector3.Lerp (new Vector3 (-500, -100, 0), new Vector3 (0, -100, 0), (Time.time - time1) * 1.5f);
			}
		}
		else if(playclicked == 3){
			if(playorder == 0 || playorder == 1){
				//googleAnalytics.LogScreen ("Auto-Match");
				if (ConnectInUpdate && !PhotonNetwork.connected){
					ConnectInUpdate = false;
					PhotonNetwork.ConnectUsingSettings(Version.ToString());
				}
				else if(PhotonNetwork.connected && ConnectedMaster == true){
					OnConnectedToMaster ();
				}
			}
			else if (Time.time - time >= 1) {
				playclicked = 0;
				if (playorder == 3 || playorder == 5) {
					playorder = 0;
				}
				else {
					playorder = 1;
				}
				Automatch.GetComponent<Button> ().interactable = true;
				CreateMatch.GetComponent<Button> ().interactable = true;
				JoinMatch.GetComponent<Button> ().interactable = true;
				PlayBack.interactable = true;
			}
			else{
				if (playorder == 3 || playorder == 4) {
					Automatch.transform.localPosition = Vector3.Lerp (new Vector3(-85, -35, 0), new Vector3 (0, 50, 0), Time.time - time);
				}
				else if(playorder == 2 || playorder == 5){
					Automatch.transform.localPosition = Vector3.Lerp (new Vector3(85, -35, 0), new Vector3 (0, 50, 0), Time.time - time);
				}
				Automatch.rectTransform.sizeDelta = Vector2.Lerp (new Vector2 (85, 85), new Vector2(115, 115), Time.time - time);
				AutomatchDouble.rectTransform.sizeDelta = Vector2.Lerp (new Vector2 (90, 90), new Vector2(120, 120), Time.time - time);
				AutomatchText.fontSize = 19 + Mathf.RoundToInt((Time.time - time) * 11);
				if (playorder == 2 || playorder == 3) {
					CreateMatch.rectTransform.sizeDelta = Vector2.Lerp (new Vector2 (115, 115), new Vector2 (85, 85),Time.time - time);
					CreateMatchDouble.rectTransform.sizeDelta = Vector2.Lerp (new Vector2 (120, 120), new Vector2 (90, 90), Time.time - time);
					CreateMatchText.fontSize = 30 - Mathf.RoundToInt ((Time.time - time) * 11);
					if (playorder == 2) {
						CreateMatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (85, -35, 0), Time.time - time);
					}
					else{
						CreateMatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (-85, -35, 0), Time.time - time);
					}
				}
				else if (playorder == 4 || playorder == 5) {
					JoinMatch.rectTransform.sizeDelta = Vector2.Lerp (new Vector2 (115, 115), new Vector2 (85, 85), Time.time - time);
					JoinMatchDouble.rectTransform.sizeDelta = Vector2.Lerp (new Vector2 (120, 120), new Vector2 (90, 90), Time.time - time);
					JoinMatchText.fontSize = 30 - Mathf.RoundToInt ((Time.time - time) * 11);
					if (playorder == 4){
						JoinMatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (-85, -35, 0), Time.time - time);
					}
					else {
						JoinMatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (85, -35, 0), Time.time - time);
					}
				}
			}
		}
		else if(playclicked == 4){
			if (playorder == 2 || playorder == 3) {
				//googleAnalytics.LogScreen ("Create-Match");
				if (ConnectInUpdate && !PhotonNetwork.connected){
					CreateMatchAgainText.enabled = false;
					ConnectInUpdate = false;
					PhotonNetwork.ConnectUsingSettings(Version.ToString());
				}
				else if(PhotonNetwork.connected && ConnectedMaster == true){
					CreateMatchAgainText.enabled = false;
					OnConnectedToMaster ();
				}
			}
			else if (Time.time - time >= 1) {
				playclicked = 0;
				if (playorder == 1 || playorder == 5) {
					playorder = 2;
				}
				else {
					playorder = 3;
				}
				Automatch.GetComponent<Button> ().interactable = true;
				CreateMatch.GetComponent<Button> ().interactable = true;
				JoinMatch.GetComponent<Button> ().interactable = true;
				PlayBack.interactable = true;
			}
			else{
				if (playorder == 0 || playorder == 5) {
					CreateMatch.transform.localPosition = Vector3.Lerp (new Vector3(-85, -35, 0), new Vector3 (0, 50, 0), Time.time - time);
				}
				else if(playorder == 1 || playorder == 4){
					CreateMatch.transform.localPosition = Vector3.Lerp (new Vector3(85, -35, 0), new Vector3 (0, 50, 0), Time.time - time);
				}
				CreateMatch.rectTransform.sizeDelta = Vector2.Lerp (new Vector2 (85, 85), new Vector2(115, 115), Time.time - time);
				CreateMatchDouble.rectTransform.sizeDelta = Vector2.Lerp (new Vector2 (90, 90), new Vector2(120, 120), Time.time - time);
				CreateMatchText.fontSize = 19 + Mathf.RoundToInt((Time.time - time) * 11);
				if (playorder == 0 || playorder == 1) {
					Automatch.rectTransform.sizeDelta = Vector2.Lerp (new Vector2(115, 115), new Vector2 (85, 85), Time.time - time);
					AutomatchDouble.rectTransform.sizeDelta = Vector2.Lerp (new Vector2 (120, 120), new Vector2 (90, 90), Time.time - time);
					AutomatchText.fontSize = 30 - Mathf.RoundToInt ((Time.time - time) * 11);
					if (playorder == 0) {
						Automatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (-85, -35, 0), Time.time - time);
					}
					else {
						Automatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (85, -35, 0), Time.time - time);
					}
				}
				else if (playorder == 4 || playorder == 5) {
					JoinMatch.rectTransform.sizeDelta = Vector2.Lerp (new Vector2(115, 115), new Vector2 (85, 85), Time.time - time);
					JoinMatchDouble.rectTransform.sizeDelta = Vector2.Lerp (new Vector2 (120, 120), new Vector2 (90, 90), Time.time - time);
					JoinMatchText.fontSize = 30 - Mathf.RoundToInt ((Time.time - time) * 11);
					if (playorder == 4) {
						JoinMatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (85, -35, 0), Time.time - time);
					}
					else {
						JoinMatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (-85, -35, 0), Time.time - time);
					}
				}
			}
		}
		else if(playclicked == 5){
			if(playorder == 4 || playorder == 5){
				if (JoinMatchInput.text.Length != 6) {
					playclicked = 0;
					Automatch.GetComponent<Button> ().interactable = true;
					CreateMatch.GetComponent<Button> ().interactable = true;
					JoinMatch.GetComponent<Button> ().interactable = true;
					PlayBack.interactable = true;
					Errortext.text = "Enter your 6 digit Match ID!";
				}
				else if (ConnectInUpdate && !PhotonNetwork.connected){
					//googleAnalytics.LogScreen ("Join-Match");
					ConnectInUpdate = false;
					PhotonNetwork.ConnectUsingSettings (Version.ToString ());
				}
				else if(PhotonNetwork.connected && ConnectedMaster == true){
					//googleAnalytics.LogScreen ("Join-Match");
					OnConnectedToMaster ();
				}
			}
			else if (Time.time - time >= 1) {
				playclicked = 0;
				if (playorder == 1 || playorder == 3) {
					playorder = 4;
				}
				else {
					playorder = 5;
				}
				Automatch.GetComponent<Button> ().interactable = true;
				CreateMatch.GetComponent<Button> ().interactable = true;
				JoinMatch.GetComponent<Button> ().interactable = true;
				PlayBack.interactable = true;
			}
			else{
				if (playorder == 1 || playorder == 2) {
					JoinMatch.transform.localPosition = Vector3.Lerp (new Vector3(-85, -35, 0), new Vector3 (0, 50, 0), Time.time - time);
				}
				else if(playorder == 0 || playorder == 3){
					JoinMatch.transform.localPosition = Vector3.Lerp (new Vector3(85, -35, 0), new Vector3 (0, 50, 0), Time.time - time);
				}
				JoinMatch.rectTransform.sizeDelta = Vector2.Lerp (new Vector2(85, 85), new Vector2(115, 115), Time.time - time);
				JoinMatchDouble.rectTransform.sizeDelta = Vector2.Lerp (new Vector2(90, 90), new Vector2(120, 120), Time.time - time);
				JoinMatchText.fontSize = 19 + Mathf.RoundToInt((Time.time - time) * 11);
				if (playorder == 0 || playorder == 1) {
					Automatch.rectTransform.sizeDelta = Vector2.Lerp (new Vector2(115, 115), new Vector2(85, 85), Time.time - time);
					AutomatchDouble.rectTransform.sizeDelta = Vector2.Lerp (new Vector2(120, 120), new Vector2(90, 90), Time.time - time);
					AutomatchText.fontSize = 30 - Mathf.RoundToInt((Time.time - time) * 11);
					if (playorder == 0) {
						Automatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (85, -35, 0), Time.time - time);
					}
					else{
						Automatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (-85, -35, 0), Time.time - time);
					}
				}
				else if (playorder == 2 || playorder == 3) {
					CreateMatch.rectTransform.sizeDelta = Vector2.Lerp (new Vector2(115, 115), new Vector2(85, 85), Time.time - time);
					CreateMatchDouble.rectTransform.sizeDelta = Vector2.Lerp (new Vector2(120, 120), new Vector2(90, 90), Time.time - time);
					CreateMatchText.fontSize = 30 - Mathf.RoundToInt((Time.time - time) * 11);
					if (playorder == 2){
						CreateMatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (-85, -35, 0), Time.time - time);
					}
					else {
						CreateMatch.transform.localPosition = Vector3.Lerp (new Vector3(0, 50, 0), new Vector3 (85, -35, 0), Time.time - time);
					}
				}
			}
		}
		else if(playclicked == 6){
			if ((Time.time - time) * 1.5f <= 1) {
				Matches.transform.localPosition = Vector3.Lerp (new Vector3(0, 0, 0), new Vector3 (-500, 0, 0), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				playclicked = 0;
				PlayersStart.GetComponent<Button> ().interactable = true;
				PlayersBack.GetComponent<Button> ().interactable = true;
			}
			else{
				if(time1 == 0){
					time1 = Time.time;
				}
				Players.transform.localPosition = Vector3.Lerp (new Vector3(500, 0, 0), new Vector3(0, 0, 0), (Time.time - time1) * 1.5f);
			}
		}
		else if(playclicked == 7){
			if((Time.time - time) * 1.5f <= 1){
				Players.transform.localPosition = Vector3.Lerp (new Vector3(0, 0, 0), new Vector3(500, 0, 0), (Time.time - time) * 1.5f);
			}
			else if(time1 != 0 && (Time.time - time1) * 1.5f >= 1){
				playclicked = 0;
				Automatch.GetComponent<Button> ().interactable = true;
				CreateMatch.GetComponent<Button> ().interactable = true;
				JoinMatch.GetComponent<Button> ().interactable = true;
				PlayBack.interactable = true;
			}
			else {
				if(time1 == 0){
					time1 = Time.time;
				}
				Matches.transform.localPosition = Vector3.Lerp (new Vector3 (-500, 0, 0), new Vector3 (0, 0, 0), (Time.time - time1) * 1.5f);
			}
		}
	}

	public void OnClickKbvstudios(){
		//googleAnalytics.LogScreen ("KBVStudios");
		Application.OpenURL("http://kbvstudios.com");
	}

	public void OnClickPlay(int playnumber){
		if (playnumber == 1) {
			if(PlayerPref.GetString("Tutorial") == ""){
				SceneManager.LoadScene (2);
				//googleAnalytics.LogScreen ("Tutorial-Play");
			}
			else{
				time = Time.time;
				playclicked = 1;
				time1 = 0;
				Play.GetComponent<Button> ().interactable = false;
				Store.GetComponent<Button> ().interactable = false;
				//googleAnalytics.LogScreen ("Clicked Play");
			}
		}
		else if (playnumber == 2) {
			time = Time.time;
			playclicked = 2;
			time1 = 0;
			Automatch.GetComponent<Button> ().interactable = false;
			CreateMatch.GetComponent<Button> ().interactable = false;
			JoinMatch.GetComponent<Button> ().interactable = false;
			PlayBack.interactable = false;
			//googleAnalytics.LogScreen ("Main");
		}
		else if (playnumber == 3) {
			playclicked = 3;
			time = Time.time;
			Automatch.GetComponent<Button> ().interactable = false;
			CreateMatch.GetComponent<Button> ().interactable = false;
			JoinMatch.GetComponent<Button> ().interactable = false;
			CreateMatchAgainText.enabled = false;
			JoinMatchInput.gameObject.SetActive (false);
			PlayBack.interactable = false;
			Automatch.transform.SetAsLastSibling ();
			Errortext.text = "";
			Errortext.rectTransform.anchoredPosition = new Vector2 (0, 150);
		}
		else if (playnumber == 4) {
			playclicked = 4;
			time = Time.time;
			Automatch.GetComponent<Button> ().interactable = false;
			CreateMatch.GetComponent<Button> ().interactable = false;
			JoinMatch.GetComponent<Button> ().interactable = false;
			CreateMatchAgainText.enabled = true;
			JoinMatchInput.gameObject.SetActive (false);
			PlayBack.interactable = false;
			CreateMatch.transform.SetAsLastSibling ();
			Errortext.text = "";
			Errortext.rectTransform.anchoredPosition = new Vector2 (0, 200);
		}
		else if (playnumber == 5) {
			playclicked = 5;
			time = Time.time;
			Automatch.GetComponent<Button> ().interactable = false;
			CreateMatch.GetComponent<Button> ().interactable = false;
			JoinMatch.GetComponent<Button> ().interactable = false;
			CreateMatchAgainText.enabled = false;
			JoinMatchInput.gameObject.SetActive (true);
			PlayBack.interactable = false;
			JoinMatch.transform.SetAsLastSibling ();
			Errortext.text = "";
			Errortext.rectTransform.anchoredPosition = new Vector2 (0, 200);
		}
		else if (playnumber == 7) {
			time = Time.time;
			playclicked = 7;
			time1 = 0;
			PlayersStart.GetComponent<Button> ().interactable = false;
			PlayersBack.GetComponent<Button> ().interactable = false;
			PlayersText.gameObject.SetActive (false);
			Errortext.text = "";
			PhotonNetwork.LeaveRoom ();
			PhotonNetwork.Disconnect ();
		}
	}

	public void OnClickStore(int storenumber){
		if (storenumber == 1) {
			time = Time.time;
			storeclicked = 1;
			time1 = 0;
			Play.GetComponent<Button> ().interactable = false;
			Store.GetComponent<Button> ().interactable = false;
			StoreHolder.GetComponent<StoreData> ().ReadyToGetStoreData (0, 0);
			storetime = Time.time;
		}
		else if (storenumber == 2) {
			time = Time.time;
			storeclicked = 2;
			time1 = 0;
			StoreBack.interactable = false;
			Buy.interactable = false;
			Scene.interactable = false;
			Upgrade.interactable = false;
			//googleAnalytics.LogTiming (new TimingHitBuilder().SetTimingName("Store Visited Total Time").SetTimingInterval(System.Convert.ToInt64(Time.time - storetime)));
			//googleAnalytics.LogScreen ("Main");
		}
		else if (storenumber == 3) {
			time = Time.time;
			storeclicked = 3;
			time1 = 0;
			StoreBack.interactable = false;
			Buy.interactable = false;
			Scene.interactable = false;
			Upgrade.interactable = false;
			StoreHolder.GetComponent<StoreData> ().ReadyToGetStoreData (1, 0);
			storeitemstime = Time.time;
		}
		else if (storenumber == 4) {
			time = Time.time;
			storeclicked = 4;
			time1 = 0;
			BuyBack.interactable = false;
			Buy1.interactable = false;
			Buy2.interactable = false;
			Buy3.interactable = false;
			Buy4.interactable = false;
			Buy5.interactable = false;
			StoreInfoText.text = "";
			StoreHolder.GetComponent<StoreData> ().ReadyToGetStoreData (0, 0);
			//googleAnalytics.LogTiming (new TimingHitBuilder().SetTimingName("Buy Coins Screen Time").SetTimingInterval(System.Convert.ToInt64(Time.time - storeitemstime)));
		}
		else if (storenumber == 5) {
			time = Time.time;
			storeclicked = 5;
			time1 = 0;
			StoreBack.interactable = false;
			Buy.interactable = false;
			Scene.interactable = false;
			Upgrade.interactable = false;
			StoreHolder.GetComponent<StoreData> ().ReadyToGetStoreData (2, 0);
			storeitemstime = Time.time;
		}
		else if (storenumber == 6) {
			time = Time.time;
			storeclicked = 6;
			time1 = 0;
			UpgradeBack.interactable = false;
			Speed.interactable = false;
			Shots.interactable = false;
			StoreInfoText.text = "";
			StoreHolder.GetComponent<StoreData> ().ReadyToGetStoreData (0, 0);
			//googleAnalytics.LogTiming (new TimingHitBuilder().SetTimingName("Upgrade Dot Screen Time").SetTimingInterval(System.Convert.ToInt64(Time.time - storeitemstime)));
		}
		else if (storenumber == 7) {
			time = Time.time;
			storeclicked = 7;
			time1 = 0;
			StoreBack.interactable = false;
			Buy.interactable = false;
			Scene.interactable = false;
			Upgrade.interactable = false;
			StoreHolder.GetComponent<StoreData> ().ReadyToGetStoreData (3, 0);
			storeitemstime = Time.time;
		}
		else if (storenumber == 8) {
			time = Time.time;
			storeclicked = 8;
			time1 = 0;
			SceneBack.interactable = false;
			SceneDefault.interactable = false;
			Scene1.interactable = false;
			Scene2.interactable = false;
			Scene3.interactable = false;
			Scene4.interactable = false;
			StoreInfoText.text = "";
			StoreHolder.GetComponent<StoreData> ().ReadyToGetStoreData (0, 0);
			//googleAnalytics.LogTiming (new TimingHitBuilder().SetTimingName("Scene Change Screen Time").SetTimingInterval(System.Convert.ToInt64(Time.time - storeitemstime)));
		}
	}

	public virtual void OnConnectedToMaster(){
		ConnectedMaster = true;
		PhotonNetwork.sendRate = 10;
		PhotonNetwork.sendRateOnSerialize = 10;
		if (playclicked == 3) {
			PhotonNetwork.JoinRandomRoom ();
		}
		else if (playclicked == 4) {
			bool created = false;
			int n = 0;
			while(created == false){
				n = Random.Range (0, 1000000);
				created = PhotonNetwork.CreateRoom (n.ToString("000000"), new RoomOptions () { maxPlayers = 4, isVisible = false, }, null);
			}
		}
		else if (playclicked == 5) {
			PhotonNetwork.JoinRoom (JoinMatchInput.text);
		}
		playclicked = 0;
	}

	public virtual void OnFailedToConnectToPhoton (){
		Errortext.text = "Connection error, Please check your connection and try connecting again!";
		if (playclicked != 0) {
			Automatch.GetComponent<Button> ().interactable = true;
			CreateMatch.GetComponent<Button> ().interactable = true;
			JoinMatch.GetComponent<Button> ().interactable = true;
			PlayBack.interactable = true;
			playclicked = 0;
		}
	}

	public virtual void OnDisconnectedFromPhoton (){
		MatchID = "";
		ConnectedMaster = false;
		ConnectInUpdate = true;
		StopAllCoroutines ();
	}

	public void OnJoinedRoom(){
		storeitemstime = Time.time;
		PhotonNetwork.playerName = "";
		MatchID = PhotonNetwork.room.name;
		time = Time.time;
		playclicked = 6;
		time1 = 0;
		Automatch.GetComponent<Button> ().interactable = false;
		CreateMatch.GetComponent<Button> ().interactable = false;
		JoinMatch.GetComponent<Button> ().interactable = false;
		PlayBack.interactable = false;
		if (PhotonNetwork.isMasterClient && MatchID.Length != 6) {
			PlayersStart.gameObject.SetActive(true);
			StartCoroutine(OnTimeToStartGame ());
		}
		else if(PhotonNetwork.isMasterClient && MatchID.Length == 6){
			PlayersStart.gameObject.SetActive(true);
			PlayersText.gameObject.SetActive (true);
			PlayersText.text = PhotonNetwork.room.playerCount + "/4 Players Connected!\n\nMATCH ID: " + MatchID;
		}
		else if(MatchID.Length == 6){
			PlayersStart.gameObject.SetActive(false);
			PlayersText.gameObject.SetActive (true);
			PlayersText.text = PhotonNetwork.room.playerCount + "/4 Players Connected!\n\nMATCH ID: " + MatchID;
		}
		else{
			PlayersStart.gameObject.SetActive(false);
		}
	}

	public void OnStartGame(){
		SetPlayerNames ();
	}

	public void OnPhotonPlayerConnected(){
		if (PhotonNetwork.room.playerCount == 4) {
			SetPlayerNames ();
		}
		else if(MatchID.Length == 6){
			photonview.RPC ("PlayerCount", PhotonTargets.All, PhotonNetwork.room.playerCount);
		}
	}

	public void OnPhotonPlayerDisconnected(){
		if(MatchID.Length == 6){
			if (PhotonNetwork.isMasterClient == true) {
				PlayersStart.gameObject.SetActive (true);
			}
			photonview.RPC ("PlayerCount", PhotonTargets.All, PhotonNetwork.room.playerCount);
		}
		else if (PhotonNetwork.isMasterClient == true) {
			PlayersStart.gameObject.SetActive(true);
			StopAllCoroutines ();
			StartCoroutine(OnTimeToStartGame ());
		}
	}

	public void SetPlayerNames(){
		if (PhotonNetwork.isMasterClient) {
			PhotonNetwork.room.open = false;
			bool p1picked = false;
			bool p2picked = false;
			bool p3picked = false;
			bool p4picked = false;
			foreach (PhotonPlayer pp in PhotonNetwork.otherPlayers) {
				int r = Random.Range (1, 5);
				for (int i = 0; i < 4; i++) {
					if (r == 5) {
						r = 1;
					}
					if (r == 1 && p1picked == false) {
						p1picked = true;
						i = 5;
						photonview.RPC ("StartGame", pp, "Player1");
					}
					else if (r == 2 && p2picked == false) {
						p2picked = true;
						i = 5;
						photonview.RPC ("StartGame", pp, "Player2");
					}
					else if (r == 3 && p3picked == false) {
						p3picked = true;
						i = 5;
						photonview.RPC ("StartGame", pp, "Player3");
					}
					else if (r == 4 && p4picked == false) {
						p4picked = true;
						i = 5;
						photonview.RPC ("StartGame", pp, "Player4");
					}
					r++;
				}
			}
			int r1 = Random.Range (1, 5);
			for (int i1 = 0; i1 < 4; i1++) {
				if (r1 == 5) {
					r1 = 1;
				}
				if (r1 == 1 && p1picked == false) {
					p1picked = true;
					i1 = 5;
					photonview.RPC ("StartGame", PhotonNetwork.player, "Player1");
				}
				else if (r1 == 2 && p2picked == false) {
					p2picked = true;
					i1 = 5;
					photonview.RPC ("StartGame", PhotonNetwork.player, "Player2");
				}
				else if (r1 == 3 && p3picked == false) {
					p3picked = true;
					i1 = 5;
					photonview.RPC ("StartGame", PhotonNetwork.player, "Player3");
				}
				else if (r1 == 4 && p4picked == false) {
					p4picked = true;
					i1 = 5;
					photonview.RPC ("StartGame", PhotonNetwork.player, "Player4");
				}
				r1++;
			}
		}
	}

	public IEnumerator OnTimeToStartGame(){
		int tempstarttimeleft = starttimeleft;
		for(int i = 30; i > 0; i--){
			if (PhotonNetwork.isMasterClient){
				if (tempstarttimeleft == starttimeleft && starttimeleft != 0) {
					tempstarttimeleft++;
					i = starttimeleft;
				}
				photonview.RPC ("GetTimeLeft", PhotonTargets.All, i);
			}
			yield return new WaitForSeconds (1);
		}
		SetPlayerNames ();
	}

	[PunRPC]
	void StartGame (string ppname) {
		//googleAnalytics.LogTiming (new TimingHitBuilder().SetTimingName("Joined To Start Game Time").SetTimingInterval(System.Convert.ToInt64(Time.time - storeitemstime)));
		PhotonNetwork.playerName = ppname;
		PlayersStart.gameObject.SetActive (false);
		PlayersBack.gameObject.SetActive (false);
		PlayersText.gameObject.SetActive (true);
		PlayersText.text = "STARTING MATCH!\n\nLoading... Please Wait!";
		PhotonNetwork.automaticallySyncScene = false;
		PhotonNetwork.LoadLevel (2);
	}

	[PunRPC]
	void GetTimeLeft (int timeleft) {
		starttimeleft = timeleft;
		PlayersText.gameObject.SetActive (true);
		PlayersText.text = "Waiting For Players!\n\nSTARTING MATCH\nIN " + timeleft + " SECONDS!";
	}

	[PunRPC]
	void PlayerCount (int pcount) {
		PlayersText.gameObject.SetActive (true);
		PlayersText.text = pcount + "/4 Players Connected!\n\nMATCH ID: " + MatchID;
	}

	public virtual void OnPhotonRandomJoinFailed(object[] codeAndMsg){
		//googleAnalytics.LogScreen("Random Room Join Failed (Error Code: " + codeAndMsg.ToString() + ")");
		if (int.Parse(codeAndMsg [0].ToString()) == 32757) {
			Errortext.text = "Max users have been reached, Please report to devolpers@kbvstudios.com!";
		}
		else if (int.Parse(codeAndMsg [0].ToString()) == 32758) {
			Errortext.text = "Match closed, Creating a match!";
			PhotonNetwork.CreateRoom (null, new RoomOptions () { maxPlayers = 4 }, null);
		}
		else if (int.Parse(codeAndMsg [0].ToString()) == 32760) {
			Errortext.text = "Match full, Creating a match!";
			PhotonNetwork.CreateRoom (null, new RoomOptions () { maxPlayers = 4 }, null);
		}
		else if (int.Parse(codeAndMsg [0].ToString()) == 32764) {
			Errortext.text = "Match closed, Creating a match!";
			PhotonNetwork.CreateRoom (null, new RoomOptions () { maxPlayers = 4 }, null);
		}
		else if (int.Parse(codeAndMsg [0].ToString()) == 32765) {
			Errortext.text = "Match full, Creating a match!";
			PhotonNetwork.CreateRoom (null, new RoomOptions () { maxPlayers = 4 }, null);
		}
		else if (int.Parse(codeAndMsg [0].ToString()) != 0) {
			Automatch.GetComponent<Button> ().interactable = true;
			CreateMatch.GetComponent<Button> ().interactable = true;
			JoinMatch.GetComponent<Button> ().interactable = true;
			PlayBack.interactable = true;
			if (int.Parse(codeAndMsg [0].ToString()) == 32753) {
				Errortext.text = "Authentication ticket expired, Please reconnect!";
			}
			else {
				Errortext.text = "Connection error, Please check your connection and try connecting again!";
			}
		}
	}

	public virtual void OnPhotonJoinRoomFailed(object[] codeAndMsg){
		//googleAnalytics.LogScreen("Join Room Failed (Error Code: " + codeAndMsg.ToString() + ")");
		if (int.Parse(codeAndMsg [0].ToString()) != 0) {
			Automatch.GetComponent<Button> ().interactable = true;
			CreateMatch.GetComponent<Button> ().interactable = true;
			JoinMatch.GetComponent<Button> ().interactable = true;
			PlayBack.interactable = true;
			if(int.Parse(codeAndMsg [0].ToString()) == 32753){
				Errortext.text = "Authentication ticket expired, Please reconnect!";
			}
			else if (int.Parse(codeAndMsg [0].ToString()) == 32757) {
				Errortext.text = "Max users have been reached, Please report to devolpers@kbvstudios.com!";
			}
			else if (int.Parse(codeAndMsg [0].ToString()) == 32758) {
				Errortext.text = "Match ID does not exist, Check your Match ID!";
			}
			else if (int.Parse(codeAndMsg [0].ToString()) == 32764) {
				Errortext.text = "Match closed, Join another match!";
			}
			else if (int.Parse(codeAndMsg [0].ToString()) == 32765) {
				Errortext.text = "Match full, Join another match!";
			}
			else{
				Errortext.text = "Connection error, Please check your connection and try connecting again!";
			}
		}
	}

	public virtual void OnPhotonCreateRoomFailed(object[] codeAndMsg){
		//googleAnalytics.LogScreen("Create Room Failed (Error Code: " + codeAndMsg.ToString() + ")");
		if (int.Parse(codeAndMsg [0].ToString()) != 0) {
			Automatch.GetComponent<Button> ().interactable = true;
			CreateMatch.GetComponent<Button> ().interactable = true;
			JoinMatch.GetComponent<Button> ().interactable = true;
			PlayBack.interactable = true;
			if(int.Parse(codeAndMsg [0].ToString()) == 32753){
				Errortext.text = "Authentication ticket expired, Please reconnect!";
			}
			else if (int.Parse(codeAndMsg [0].ToString()) == 32757) {
				Errortext.text = "Max users have been reached, Please report to devolpers@kbvstudios.com!";
			}
			else if (int.Parse(codeAndMsg [0].ToString()) == 32766) {
				Errortext.text = "Match ID exists, Creating another match!";
				PhotonNetwork.CreateRoom (null, new RoomOptions () { maxPlayers = 4 }, null);
			}
			else{
				Errortext.text = "Connection error, Please check your connection and try connecting again!";
			}
		}
	}

	public virtual void OnPhotonMaxCccuReached(){
		//googleAnalytics.LogScreen("Max CCU Has Been Reached");
		Errortext.text = "Max users have been reached, Please report to devolpers@kbvstudios.com!";
	}
}
