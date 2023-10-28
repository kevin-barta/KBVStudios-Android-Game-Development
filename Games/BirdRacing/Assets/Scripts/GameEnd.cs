using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using GoogleMobileAds.Api;

public class GameEnd : MonoBehaviour {
	public GameObject PanelBoard;
	public GameObject PanelXp;
	public GameObject LevelUp;
	public Text TextTime;
	public Text TextRank;
	public Text LevelText;
	public Text LvlUpText;
	public Image VideoAdImage;
	public Image XpImage;
	public Image NextImage;
	public Button ViedoAdButton;
	public Button NextButton;
	public UnitySampleAssets.Utility.Ranking _Ranking;
	public bool TestMode = false;
	private bool AdRequested = false;
	private bool Next2;
	private bool Next4;
	private int XP = 1;
	private int XP2 = 0;
	private int XP4 = 0;
	private int XP5 = 0;
	private int Level1Old = 0;
	private int Level2Old = 0;
	private InterstitialAd interstitial;

	void Awake() {
		interstitial = new InterstitialAd("ca-app-pub-8870763355959902/1488455478");
		if (Advertisement.isSupported) {
			Advertisement.Initialize ("65895", TestMode);
		}
		else {
			Debug.Log("Platform not supported");
		}
	}

	void Update (){
		if(_Ranking.LapBird8Tracker == 5 && AdRequested == false){
			AdRequested = true;
			AdFullscreen ();
		}
		if (interstitial.IsLoaded() && AdRequested == true) {
			interstitial.Show();
		}
		if(Next2 == true){
			if(XP >= XP2){
				XP2 += 1;
				Xp.SetXp (1);
				int Level1 = Xp.GetLevel();
				if(Level1 > Level1Old){
					Level1Old = Level1;
					int l1 = int.Parse (PlayerPref.GetString(14));
					l1 += 1;
					PlayerPref.SetString(14, l1.ToString("00"));
					LevelUp.SetActive(true);
					LvlUpText.text = l1.ToString("00");
				}
				string MinMaxLevel1 = Xp.GetMinMaxLevel ();
				int LevelMin1 = int.Parse(MinMaxLevel1.Substring (0, 6));
				int LevelMax1 = int.Parse(MinMaxLevel1.Substring (6));
				int XP1 = Xp.GetXp();
				XP1 -= LevelMin1;
				LevelMax1 -= LevelMin1; 
				float filled1 = XP1 / (LevelMax1 * 1f);
				XpImage.fillAmount = filled1;
				LevelText.text = Level1.ToString();
				StartCoroutine(Next3());
			}
			else if(XP < XP2){
				if(Next4 == false){
					NextButton.interactable = true;
					NextImage.color = new Color(NextImage.color.r, NextImage.color.g, NextImage.color.b, 1);
					Next2 = false;
					StartCoroutine(UploadXp());
				}
			}
		}
		if(Next4 == true){
			if(XP5 >= XP4){
				XP4 += 1;
				Xp.SetXp (1);
				int Level2 = Xp.GetLevel();
				if(Level2 > Level2Old){
					Level2Old = Level2;
					int l2 = int.Parse (PlayerPref.GetString(14));
					l2 += 1;
					PlayerPref.SetString(14, l2.ToString("00"));
					LevelUp.SetActive(true);
					LvlUpText.text = l2.ToString("00");
				}
				string MinMaxLevel2 = Xp.GetMinMaxLevel ();
				int LevelMin2 = int.Parse(MinMaxLevel2.Substring (0, 6));
				int LevelMax2 = int.Parse(MinMaxLevel2.Substring (6));
				int XP2 = Xp.GetXp();
				XP2 -= LevelMin2;
				LevelMax2 -= LevelMin2; 
				float filled2 = XP2 / (LevelMax2 * 1f);
				XpImage.fillAmount = filled2;
				LevelText.text = Level2.ToString();
				StartCoroutine(Next5());
			}
			else if(XP5 < XP4){
				NextButton.interactable = true;
				NextImage.color = new Color(NextImage.color.r, NextImage.color.g, NextImage.color.b, 1);
				Next4 = false;
				StartCoroutine(UploadXp());
			}
		}
	}
		
	void AdFullscreen (){
		AdRequest request = new AdRequest.Builder().Build();
		interstitial.LoadAd(request);
	}

	public void Next1 (){
		PanelBoard.transform.localScale = new Vector3(0, 0, 0);
		PanelXp.transform.localScale = new Vector3(1, 1, 1);
		int Level = Xp.GetLevel();
		string MinMaxLevel = Xp.GetMinMaxLevel ();
		int LevelMin = int.Parse(MinMaxLevel.Substring (0, 6));
		int LevelMax = int.Parse(MinMaxLevel.Substring (6));
		int XP3 = Xp.GetXp();
		XP3 -= LevelMin;
		LevelMax -= LevelMin; 
		float filled = XP3 / (LevelMax * 1f);
		XpImage.fillAmount = filled;
		LevelText.text = Level.ToString();
		if(TextRank.text == "1st"){
			XP = 200;
		}
		else if(TextRank.text == "2nd"){
			XP = 175;
		}
		else if(TextRank.text == "3rd"){
			XP = 150;
		}
		else if(TextRank.text == "4th"){
			XP = 130;
		}
		else if(TextRank.text == "5th"){
			XP = 120;
		}
		else if(TextRank.text == "6th"){
			XP = 110;
		}
		else if(TextRank.text == "7th"){
			XP = 105;
		}
		else if(TextRank.text == "8th"){
			XP = 100;
		}
		Next2 = true;
		Level1Old = Xp.GetLevel();
		LvlUpText.text = PlayerPref.GetString (14);
	}

	public void Next (){
		string lvl = PlayerPref.GetString (16);
		string difficulty = lvl.Substring (0, 1);
		lvl = lvl.Substring (1);
		if(difficulty == "1"){
			if(lvl == "1"){
				lvl = PlayerPref.GetString (17);
				difficulty = "17";
			}
			else if(lvl == "2"){
				lvl = PlayerPref.GetString (18);
				difficulty = "18";
			}
			else if(lvl == "3"){
				lvl = PlayerPref.GetString (19);
				difficulty = "19";
			}
			else if(lvl == "4"){
				lvl = PlayerPref.GetString (20);
				difficulty = "20";
			}
			else if(lvl == "5"){
				lvl = PlayerPref.GetString (21);
				difficulty = "21";
			}
			else if(lvl == "6"){
				lvl = PlayerPref.GetString (22);
				difficulty = "22";
			}
			else if(lvl == "7"){
				lvl = PlayerPref.GetString (23);
				difficulty = "23";
			}
		}
		else if(difficulty == "2"){
			if(lvl == "1"){
				lvl = PlayerPref.GetString (24);
				difficulty = "24";
			}
			else if(lvl == "2"){
				lvl = PlayerPref.GetString (25);
				difficulty = "25";
			}
			else if(lvl == "3"){
				lvl = PlayerPref.GetString (26);
				difficulty = "26";
			}
			else if(lvl == "4"){
				lvl = PlayerPref.GetString (27);
				difficulty = "27";
			}
			else if(lvl == "5"){
				lvl = PlayerPref.GetString (28);
				difficulty = "28";
			}
			else if(lvl == "6"){
				lvl = PlayerPref.GetString (29);
				difficulty = "29";
			}
			else if(lvl == "7"){
				lvl = PlayerPref.GetString (30);
				difficulty = "30";
			}
		}
		if(difficulty == "3"){
			if(lvl == "1"){
				lvl = PlayerPref.GetString (31);
				difficulty = "31";
			}
			else if(lvl == "2"){
				lvl = PlayerPref.GetString (32);
				difficulty = "32";
			}
			else if(lvl == "3"){
				lvl = PlayerPref.GetString (33);
				difficulty = "33";
			}
			else if(lvl == "4"){
				lvl = PlayerPref.GetString (34);
				difficulty = "34";
			}
			else if(lvl == "5"){
				lvl = PlayerPref.GetString (35);
				difficulty = "35";
			}
			else if(lvl == "6"){
				lvl = PlayerPref.GetString (36);
				difficulty = "36";
			}
			else if(lvl == "7"){
				lvl = PlayerPref.GetString (37);
				difficulty = "37";
			}
		}
		int oldposition = 8;
		int oldtime = 95999;
		if(lvl.Substring(0, 1) != "N"){
			oldposition = int.Parse(lvl.Substring (0, 1));
			oldtime = int.Parse(lvl.Substring (3).Replace(":", ""));
		}
		int birdposition = gameObject.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird8;
		int birdtime = int.Parse(TextTime.text.Replace(":", ""));
		if(birdposition < oldposition){
			string data1 = PlayerPref.GetString(int.Parse(difficulty)).Substring(3);
			PlayerPref.SetString(int.Parse(difficulty), TextRank.text + data1);
		}
		if(birdtime < oldtime){
			string data2 = PlayerPref.GetString(int.Parse(difficulty)).Substring(0, 3);
			PlayerPref.SetString(int.Parse(difficulty), data2 + TextTime.text);
		}
		Application.LoadLevel (1);
	}

	public void VideoAd (){
		VideoAdImage.color = new Color (VideoAdImage.color.r, VideoAdImage.color.g, VideoAdImage.color.b, 0.5f);
		ViedoAdButton.interactable = false;
		string zone = null;
		ShowOptions options = new ShowOptions ();
		options.resultCallback = AdCallbackhandler;
		if(Advertisement.IsReady(zone)){
			Advertisement.Show(null, options);
		}
	}

	public void AdCallbackhandler (ShowResult result){
		switch(result) {
			case ShowResult.Finished:
			XP5 = XP * 3;
			Next4 = true;
			Level2Old = Xp.GetLevel();
			NextButton.interactable = false;
			NextImage.color = new Color(NextImage.color.r, NextImage.color.g, NextImage.color.b, 0.5f);
			break;
		}
	}

	IEnumerator UploadXp (){
		WWWForm form = new WWWForm();
		form.AddField("userid", PlayerPref.GetString(0));
		form.AddField("xp", Xp.GetXp().ToString("000000"));
		WWW w = new WWW("http://kbvstudios.com/birdracingupdate.php", form);
		yield return w;
	}

	IEnumerator Next3(){
		yield return new WaitForSeconds(0.02f);
		yield break;
	}

	IEnumerator Next5(){
		yield return new WaitForSeconds(0.01f);
		yield break;
	}
}