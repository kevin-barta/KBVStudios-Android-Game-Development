using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
	public GoogleAnalyticsV4 googleAnalytics;
	public GameObject Multiplayer;
	public GameObject CreateBird;
	public GameObject UpgradeBird;
	public GameObject MainMenu1;
	public GameObject PickDifficulty;
	public GameObject PickLevel;
	public GameObject Loading;
	public GameObject Settings;
	public GameObject Credits;
	public GameObject UserName;
	public Image Wing1_1;
	public Image Wing2_1;
	public Image Wing1_2;
	public Image Wing2_2;
	public Image AudioImg;
	public Image MusicImg;
	public Image XpImage;
	public Image SettingsIcon;
	public Image HeaderBackground;
	public Image ScrollArea;
	public Image Panel;
	public Text LevelText;
	public Text Username;
	public Text ErrorText;
	public Text GameCon;
	public Button NextButton;
	public InputField inputfield;
	public AudioSource Music;
	public AudioSource CreditMusic;
	public RectTransform CD;
	public Slider HueSlider;
	private bool Finished = false;
	private bool Finished1 = false;
	private int Red;
	private int Green;
	private int Blue;
	private float Timeset;
	private int Timeset1;
	private int MoveReady1 = 10;
	private float MoveTime1 = 0f;
	private string lvltime1 = "";
	private string lvltime2 = "";
	private string lvltime3 = "";
	private string lvltime4 = "";
	private string lvltime5 = "";
	private string lvltime6 = "";
	private string lvltime7 = "";
	private string iddata1 = "";

	void Awake (){
		System.GC.Collect();
		Resources.UnloadUnusedAssets();
		if(PlayerPref.GetString(38).Substring(1, 1) == "0"){
			Music.mute = true;
			CreditMusic.mute = true;
		}
		string Colour = PlayerPref.GetString (38).Substring(6);
		Red = int.Parse(Colour.Substring(0, 3));
		Green = int.Parse(Colour.Substring(3, 3));
		Blue = int.Parse(Colour.Substring(6));
		SettingsIcon.color = new Color(Red/255f, Green/255f, Blue/255f);
		Panel.color = new Color(Red/255f, Green/255f, Blue/255f, 0.5f);
		HeaderBackground.color = new Color(Red/255f, Green/255f, Blue/255f);
		ScrollArea.color = new Color(Red/255f, Green/255f, Blue/255f, 0.5f);
		if(PlayerPref.GetString(0) == ""){
			MainMenu1.SetActive(false);
			UserName.SetActive(true);
		}
		else if(PlayerPref.GetString(0) == "UNNAMED"){
			MainMenu1.SetActive(false);
			UserName.SetActive(true);
		}
	}

	void Update (){
		if(MainMenu1.activeInHierarchy == true){
			if(MoveReady1 == 10){
				MoveReady1 = 0;
				MoveTime1 = Time.time;
			}
			if(MoveReady1 == 0){
				Wing1_1.transform.localPosition = Vector3.Lerp(new Vector3(-170.1f, 9f, 0), new Vector3(-170.1f, 1.2f, 0), (Time.time - MoveTime1) * 4f);
				Wing2_1.transform.localPosition = Vector3.Lerp(new Vector3(-110.1f, 9f, 0), new Vector3(-110.1f, 1.2f, 0), (Time.time - MoveTime1) * 4f);
				Wing1_2.transform.localPosition = Vector3.Lerp(new Vector3(110.1f, 9f, 0), new Vector3(110.1f, 1.2f, 0), (Time.time - MoveTime1) * 4f);
				Wing2_2.transform.localPosition = Vector3.Lerp(new Vector3(170.1f, 9f, 0), new Vector3(170.1f, 1.2f, 0), (Time.time - MoveTime1) * 4f);
				Wing1_1.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime1) * 4f);
				Wing2_1.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime1) * 4f);
				Wing1_2.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime1) * 4f);
				Wing2_2.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime1) * 4f);
				if((Time.time - MoveTime1) * 3f >= 1){
					MoveReady1 = 10;
				}
			}
		}
		if(Credits.activeInHierarchy == true){
			CD.transform.Translate(new Vector3(0, 1, 0));
			if(CD.anchoredPosition.y > 2050){
				CD.anchoredPosition = new Vector2(CD.anchoredPosition.x, -626);
			}
		}
		if(Timeset1 == 1){
			MainMenu1.transform.position = Vector3.Lerp (MainMenu1.transform.position, new Vector3(Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			CreateBird.transform.position = Vector3.Lerp (CreateBird.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				MainMenu1.SetActive (false);
			}
		}
		else if(Timeset1 == 2){
			MainMenu1.transform.position = Vector3.Lerp (MainMenu1.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			CreateBird.transform.position = Vector3.Lerp (CreateBird.transform.position, new Vector3(-Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				CreateBird.SetActive (false);
			}
		}
		else if(Timeset1 == 3){
			MainMenu1.transform.position = Vector3.Lerp (MainMenu1.transform.position, new Vector3(-Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			Multiplayer.transform.position = Vector3.Lerp (Multiplayer.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				MainMenu1.SetActive (false);
			}
		}
		else if(Timeset1 == 4){
			MainMenu1.transform.position = Vector3.Lerp (MainMenu1.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			Multiplayer.transform.position = Vector3.Lerp (Multiplayer.transform.position, new Vector3(Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				Multiplayer.SetActive (false);
			}
		}
		else if(Timeset1 == 5){
			UpgradeBird.transform.position = Vector3.Lerp (UpgradeBird.transform.position, new Vector3(Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			PickDifficulty.transform.position = Vector3.Lerp (PickDifficulty.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				UpgradeBird.SetActive (false);
			}
		}
		else if(Timeset1 == 6){
			UpgradeBird.transform.position = Vector3.Lerp (UpgradeBird.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			PickDifficulty.transform.position = Vector3.Lerp (PickDifficulty.transform.position, new Vector3(-Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				PickDifficulty.SetActive (false);
			}
		}
		else if(Timeset1 == 7){
			PickDifficulty.transform.position = Vector3.Lerp (PickDifficulty.transform.position, new Vector3(Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			PickLevel.transform.position = Vector3.Lerp (PickLevel.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				PickDifficulty.SetActive (false);
			}
		}
		else if(Timeset1 == 8){
			PickDifficulty.transform.position = Vector3.Lerp (PickDifficulty.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			PickLevel.transform.position = Vector3.Lerp (PickLevel.transform.position, new Vector3(-Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				PickLevel.SetActive (false);
			}
		}
		else if(Timeset1 == 9){
			PickLevel.transform.position = Vector3.Lerp (PickLevel.transform.position, new Vector3(Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			Loading.transform.position = Vector3.Lerp (Loading.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				CreateBird.SetActive (false);
				Application.LoadLevel(2);
			}
		}
		else if(Timeset1 == 10){
			MainMenu1.transform.position = Vector3.Lerp (MainMenu1.transform.position, new Vector3(0, -Screen.width * 2, 0), (Time.time - Timeset)/10);
			Settings.transform.position = Vector3.Lerp (Settings.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				MainMenu1.SetActive (false);
			}
		}
		else if(Timeset1 == 11){
			MainMenu1.transform.position = Vector3.Lerp (MainMenu1.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			Settings.transform.position = Vector3.Lerp (Settings.transform.position, new Vector3(0, Screen.width * 2, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				Settings.SetActive (false);
			}
		}
		else if(Timeset1 == 12){
			Settings.transform.position = Vector3.Lerp (Settings.transform.position, new Vector3(0, -Screen.width * 2, 0), (Time.time - Timeset)/10);
			Credits.transform.position = Vector3.Lerp (Credits.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				Settings.SetActive (false);
			}
		}
		else if(Timeset1 == 13){
			Settings.transform.position = Vector3.Lerp (Settings.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			Credits.transform.position = Vector3.Lerp (Credits.transform.position, new Vector3(0, Screen.width * 2, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				Credits.SetActive (false);
			}
		}
		else if(Timeset1 == 14){
			UserName.transform.position = Vector3.Lerp (UserName.transform.position, new Vector3(0, -Screen.width * 2, 0), (Time.time - Timeset)/10);
			MainMenu1.transform.position = Vector3.Lerp (MainMenu1.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				UserName.SetActive (false);
			}
		}
		else if(Timeset1 == 15){
			UserName.transform.position = Vector3.Lerp (UserName.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			MainMenu1.transform.position = Vector3.Lerp (MainMenu1.transform.position, new Vector3(0, Screen.width * 2, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				MainMenu1.SetActive (false);
			}
		}
		else if(Timeset1 == 16){
			CreateBird.transform.position = Vector3.Lerp (CreateBird.transform.position, new Vector3(Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			UpgradeBird.transform.position = Vector3.Lerp (UpgradeBird.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				CreateBird.SetActive (false);
			}
		}
		else if(Timeset1 == 17){
			CreateBird.transform.position = Vector3.Lerp (CreateBird.transform.position, new Vector3(0, 0, 0), (Time.time - Timeset)/10);
			UpgradeBird.transform.position = Vector3.Lerp (UpgradeBird.transform.position, new Vector3(-Screen.width * 2, 0, 0), (Time.time - Timeset)/10);
			if((Time.time - Timeset)/2 > 1){
				Timeset1 = 0;
				UpgradeBird.SetActive (false);
			}
		}
	}

	public void OnClickSinglePlayer(){
		googleAnalytics.LogScreen("Single Player");
		Timeset = Time.time;
		Timeset1 = 1;
		CreateBird.transform.position = new Vector3 (-Screen.width * 2, 0, 0);
		CreateBird.SetActive (true);
		int Level = Xp.GetLevel();
		string MinMaxLevel = Xp.GetMinMaxLevel ();
		int LevelMin = int.Parse(MinMaxLevel.Substring (0, 6));
		int LevelMax = int.Parse(MinMaxLevel.Substring (6));
		int XP = Xp.GetXp();
		XP -= LevelMin;
		LevelMax -= LevelMin; 
		float filled = XP / (LevelMax * 1f);
		XpImage.fillAmount = filled;
		LevelText.text = Level.ToString();
		Username.text = PlayerPref.GetString (0);
	}

	public void OnClickSinglePlayerBack(){
		Timeset = Time.time;
		Timeset1 = 2;
		MainMenu1.SetActive (true);
	}

	public void OnClickMultiPlayer(){
		googleAnalytics.LogScreen("Multiplayer");
		Timeset = Time.time;
		Timeset1 = 3;
		Multiplayer.transform.position = new Vector3 (Screen.width * 2, 0, 0);
		Multiplayer.SetActive (true);
	}
	
	public void OnClickMultiPlayerBack(){
		Timeset = Time.time;
		Timeset1 = 4;
		MainMenu1.SetActive (true);
	}

	public void OnClickPickDifficulty(){
		googleAnalytics.LogScreen("Picking Difficulty");
		Timeset = Time.time;
		Timeset1 = 5;
		PickDifficulty.transform.position = new Vector3 (-Screen.width * 2, 0, 0);
		PickDifficulty.SetActive (true);
	}

	public void OnClickPickDifficultyBack(){
		Timeset = Time.time;
		Timeset1 = 6;
		UpgradeBird.SetActive (true);
	}

	public void OnClickPickLevel(string Difficult){
		googleAnalytics.LogScreen("Picking Level");
		string player = PlayerPref.GetString (16);
		player = Difficult + player.Substring (1);
		PlayerPref.SetString (16, player);
		Timeset = Time.time;
		Timeset1 = 7;
		PickLevel.transform.position = new Vector3 (-Screen.width * 2, 0, 0);
		PickLevel.SetActive (true);
		if(Difficult == "1"){
			GameObject.Find("PickYourRace").GetComponent<Text>().text = "Pick Your Race: Easy";
			lvltime1 = "17";
			lvltime2 = "18";
			lvltime3 = "19";
			lvltime4 = "20";
			lvltime5 = "21";
			lvltime6 = "22";
			lvltime7 = "23";
		}
		else if(Difficult == "2"){
			GameObject.Find("PickYourRace").GetComponent<Text>().text = "Pick Your Race: Hard";
			lvltime1 = "24";
			lvltime2 = "25";
			lvltime3 = "26";
			lvltime4 = "27";
			lvltime5 = "28";
			lvltime6 = "29";
			lvltime7 = "30";
		}
		else if(Difficult == "3"){
			GameObject.Find("PickYourRace").GetComponent<Text>().text = "Pick Your Race: Extreme";
			lvltime1 = "31";
			lvltime2 = "32";
			lvltime3 = "33";
			lvltime4 = "34";
			lvltime5 = "35";
			lvltime6 = "36";
			lvltime7 = "37";
		}

		lvltime1 = PlayerPref.GetString (int.Parse(lvltime1));
		string lvlplace = lvltime1.Substring (0, 3);
		lvltime1 = "[" + lvltime1.Substring(3) + "]";
		GameObject.Find("Race1Text1").GetComponent<Text>().text = lvlplace + "\n" + lvltime1;
		lvltime2 = PlayerPref.GetString (int.Parse(lvltime2));
		lvlplace = lvltime2.Substring (0, 3);
		lvltime2 = "[" + lvltime2.Substring(3) + "]";
		GameObject.Find("Race2Text1").GetComponent<Text>().text = lvlplace + "\n" + lvltime2;
		lvltime3 = PlayerPref.GetString (int.Parse(lvltime3));
		lvlplace = lvltime3.Substring (0, 3);
		lvltime3 = "[" + lvltime3.Substring(3) + "]";
		GameObject.Find("Race3Text1").GetComponent<Text>().text = lvlplace + "\n" + lvltime3;
		lvltime4 = PlayerPref.GetString (int.Parse(lvltime4));
		lvlplace = lvltime4.Substring (0, 3);
		lvltime4 = "[" + lvltime4.Substring(3) + "]";
		GameObject.Find("Race4Text1").GetComponent<Text>().text = lvlplace + "\n" + lvltime4;
		lvltime5 = PlayerPref.GetString (int.Parse(lvltime5));
		lvlplace = lvltime5.Substring (0, 3);
		lvltime5 = "[" + lvltime5.Substring(3) + "]";
		GameObject.Find("Race5Text1").GetComponent<Text>().text = lvlplace + "\n" + lvltime5;
		lvltime6 = PlayerPref.GetString (int.Parse(lvltime6));
		lvlplace = lvltime6.Substring (0, 3);
		lvltime6 = "[" + lvltime6.Substring(3) + "]";
		GameObject.Find("Race6Text1").GetComponent<Text>().text = lvlplace + "\n" + lvltime6;
		lvltime7 = PlayerPref.GetString (int.Parse(lvltime7));
		lvlplace = lvltime7.Substring (0, 3);
		lvltime7 = "[" + lvltime7.Substring(3) + "]";
		GameObject.Find("Race7Text1").GetComponent<Text>().text = lvlplace + "\n" + lvltime7;
	}
	
	public void OnClickPickLevelBack(){
		Timeset = Time.time;
		Timeset1 = 8;
		PickDifficulty.SetActive (true);
	}

	public void OnClickLoading(string Lvl){
		if(Lvl == "10000"){
			PlayerPref.SetString(39, "1");
			Lvl = "1";
		}
		string player = PlayerPref.GetString (16);
		googleAnalytics.LogScreen("Playing Lvl: " + Lvl + " Difficulty: " + player.Substring(0, 1) + " Tutorial: " + PlayerPref.GetString (39) + " Bird Name: " + PlayerPref.GetString(0) + " XP: " + Xp.GetLevel().ToString("00") + "(" + Xp.GetXp().ToString("000000") + ")" + " GameCon: " + PlayerPref.GetString(14));
		player = player.Substring (0, 1) + Lvl;
		PlayerPref.SetString (16, player);
		Timeset = Time.time;
		Timeset1 = 9;
		Loading.transform.position = new Vector3 (-Screen.width * 2, 0, 0);
		Loading.SetActive (true);
	}

	public void OnClickSettings (){
		googleAnalytics.LogScreen("Settings");
		Timeset = Time.time;
		Timeset1 = 10;
		Settings.transform.position = new Vector3 (0, Screen.width * 2, 0);
		Settings.SetActive (true);
		string SettingsData = PlayerPref.GetString (38);
		string AudioData = SettingsData.Substring (0, 1);
		string MusicData = SettingsData.Substring (1, 1);
		string HueData = SettingsData.Substring (2, 4);
		HueSlider.value = float.Parse(HueData);
		if(AudioData == "1"){
			AudioImg.sprite =  Resources.Load<Sprite> ("audioOn");
		}
		else if(AudioData == "0"){
			AudioImg.sprite =  Resources.Load<Sprite> ("audioOff");
		}
		if(MusicData == "1"){
			MusicImg.sprite =  Resources.Load<Sprite> ("musicOn");
		}
		else if(MusicData == "0"){
			MusicImg.sprite =  Resources.Load<Sprite> ("musicOff");
		}
	}

	public void OnClickSettingsBack (){
		Timeset = Time.time;
		Timeset1 = 11;
		MainMenu1.SetActive (true);
	}

	public void OnClickCredits (){
		googleAnalytics.LogScreen("Credits");
		Timeset = Time.time;
		Timeset1 = 12;
		Credits.transform.position = new Vector3 (0, Screen.width * 2, 0);
		Credits.SetActive (true);
		CD.anchoredPosition = new Vector2(CD.anchoredPosition.x, -626);
		if(PlayerPref.GetString(38).Substring(1, 1) == "1"){
			Music.Pause();
			CreditMusic.Play();
		}
	}
	
	public void OnClickCreditsBack (){
		Timeset = Time.time;
		Timeset1 = 13;
		Settings.SetActive (true);
		if(PlayerPref.GetString(38).Substring(1, 1) == "1"){
			CreditMusic.Pause();
			Music.Play();
		}
	}

	public void OnClickUsername (){
		googleAnalytics.LogScreen("Bird Name");
		Finished = false;
		Finished1 = true;
		StartCoroutine(NameCoroutine(1));
	}
	
	public void OnClickUsernameBack (){
		Timeset = Time.time;
		Timeset1 = 15;
		UserName.SetActive (true);
	}

	public void OnClickUpgradeBird(){
		googleAnalytics.LogScreen("Upgrade Bird");
		Timeset = Time.time;
		Timeset1 = 16;
		UpgradeBird.transform.position = new Vector3 (-Screen.width * 2, 0, 0);
		UpgradeBird.SetActive (true);
		BirdUpgrade ();
	}
	
	public void OnClickUpgradeBirdBack(){
		Timeset = Time.time;
		Timeset1 = 17;
		CreateBird.SetActive (true);
	}

	public void OnClickAudio (){
		string SettingsData = PlayerPref.GetString (38);
		string AudioData = SettingsData.Substring(0, 1);
		if(AudioData == "1"){
			AudioData = "0";
			AudioImg.sprite =  Resources.Load<Sprite> ("audioOff");
			googleAnalytics.LogScreen("Audio Off");
		}
		else if(AudioData == "0"){
			AudioData = "1";
			AudioImg.sprite =  Resources.Load<Sprite> ("audioOn");
			googleAnalytics.LogScreen("Audio On");
		}
		SettingsData = AudioData + SettingsData.Substring (1);
		PlayerPref.SetString (38, SettingsData);
	}

	public void OnClickMusic (){
		string SettingsData = PlayerPref.GetString (38);
		string MusicData = SettingsData.Substring(1, 1);
		if(MusicData == "1"){
			MusicData = "0";
			MusicImg.sprite =  Resources.Load<Sprite> ("musicOff");
			googleAnalytics.LogScreen("Music Off");
			Music.mute = true;
			CreditMusic.mute = true;
		}
		else if(MusicData == "0"){
			MusicData = "1";
			MusicImg.sprite =  Resources.Load<Sprite> ("musicOn");
			googleAnalytics.LogScreen("Music On");
			Music.mute = false;
			CreditMusic.mute = false;
		}
		SettingsData = SettingsData.Substring(0, 1) + MusicData + SettingsData.Substring (2);
		PlayerPref.SetString (38, SettingsData);
	}

	public void BirdUpgrade (){
		GameCon.text = PlayerPref.GetString (14);
		int BU1 = int.Parse (PlayerPref.GetString (40).Substring (0, 2));
		int BU2 = int.Parse (PlayerPref.GetString (40).Substring (2, 2));
		int BU3 = int.Parse (PlayerPref.GetString (40).Substring (4, 2));
		while(BU1 != 0){
			GameObject.Find ("Speed" + BU1.ToString()).GetComponent<Image>().color = Color.green;
			BU1 -= 1;
		}
		while(BU2 != 0){
			GameObject.Find ("Acceleration" + BU2.ToString()).GetComponent<Image>().color = Color.green;
			BU2 -= 1;
		}
		while(BU3 != 0){
			GameObject.Find ("Power" + BU3.ToString()).GetComponent<Image>().color = Color.green;
			BU3 -= 1;
		}
	}

	public void OnValueChanged (float Hue){
		string SettingsData = PlayerPref.GetString (38).Substring (0, 2);
		int Hue1 = Mathf.RoundToInt(Hue);
		if(Hue1 >= 1276){
			Red = 255;
			Green = 0;
			Blue = 1530 - Hue1;
		}
		else if(Hue1 >= 1021){
			Red = Hue1 - 1020;
			Green = 0;
			Blue = 255;
		}
		else if(Hue1 >= 766){
			Red = 0;
			Green = 1020 - Hue1;
			Blue = 255;
		}
		else if(Hue1 >= 511){
			Red = 0;
			Green = 255;
			Blue = Hue1 - 510;
		}
		else if(Hue1 >= 256){
			Red = 510 - Hue1;
			Green = 255;
			Blue = 0;
		}
		else if(Hue1 >= 0){
			Red = 255;
			Green = Hue1;
			Blue = 0;
		}
		Panel.color = new Color(Red/255f, Green/255f, Blue/255f, 0.5f);
		SettingsIcon.color = new Color(Red/255f, Green/255f, Blue/255f);
		HeaderBackground.color = new Color(Red/255f, Green/255f, Blue/255f);
		ScrollArea.color = new Color(Red/255f, Green/255f, Blue/255f, 0.5f);
		googleAnalytics.LogScreen("Colour Changed To " + "Red: " + Red + " Green: " + Green + " Blue: " + Blue);
		PlayerPref.SetString (38, SettingsData + Hue.ToString("0000") + Red.ToString("000") + Green.ToString("000") + Blue.ToString("000"));
	}

	public void OnValueChangedUpgrade (int save){
		if(int.Parse(PlayerPref.GetString(14)) >= 1){ 
			string upgrade = PlayerPref.GetString (40);
			if(save == 1){
				int upgrade1 = int.Parse(upgrade.Substring(0, 2));
				upgrade1 += 1;
				upgrade = upgrade1.ToString("00") + upgrade.Substring(2);
			}
			else if(save == 2){
				int upgrade2 = int.Parse(upgrade.Substring(2, 2));
				upgrade2 += 1;
				upgrade = upgrade.Substring(0, 2) + upgrade2.ToString("00") + upgrade.Substring(4);
			}
			else if(save == 3){
				int upgrade3 = int.Parse(upgrade.Substring(4));
				upgrade3 += 1;
				upgrade = upgrade.Substring(0, 4) + upgrade3.ToString("00");
			}
			save = int.Parse(PlayerPref.GetString (14));
			save -= 1;
			PlayerPref.SetString (14, save.ToString("00"));
			PlayerPref.SetString (40, upgrade);
			BirdUpgrade ();
		}
	}

	public void OnValueChangedName (string value){
		string uname = value;
		if(uname.Length > 12){
			uname = uname.Substring(0, 12);
			uname = System.Text.RegularExpressions.Regex.Replace(uname, @"[^a-zA-Z0-9]", "");
			uname = uname.ToUpper ();
			inputfield.text = uname;
		}
		else if(uname.Length <= 12){
			uname = System.Text.RegularExpressions.Regex.Replace(uname, @"[^a-zA-Z0-9]", "");
			uname = uname.ToUpper ();
			inputfield.text = uname;
		}
		StartCoroutine(NameCoroutine(0));
	}

	public void OnEndedName (string value){
		string uname = value;
		if(uname.Length > 12){
			uname = uname.Substring(0, 12);
			uname = System.Text.RegularExpressions.Regex.Replace(uname, @"[^a-zA-Z0-9]", "");
			uname = uname.ToUpper ();
			inputfield.text = uname;
		}
		else if(uname.Length <= 12){
			uname = System.Text.RegularExpressions.Regex.Replace(uname, @"[^a-zA-Z0-9]", "");
			uname = uname.ToUpper ();
			inputfield.text = uname;
		}
		//StartCoroutine(NameCoroutine(0));
	}

	IEnumerator NameCoroutine(int ready){
		WWWForm form = new WWWForm();
		form.AddField("userid", inputfield.text);
		form.AddField("ready", ready.ToString());
		WWW w = new WWW("http://kbvstudios.com/birdracing.php", form);
		yield return w;
		string w1 = w.text;
		if(w.text.Length >= 21){
			if(w.text.Substring(0, 21) == "Bird Name Available!@"){
				string[] iddata = w1.Substring(21).Split(',');
				iddata1 = iddata[0];
				w1 = "Bird Name Available!";
			}
		}
		if(w.error != null) {
			ErrorText.text = w.error;
			ErrorText.color = Color.red;
			NextButton.interactable = false;
			Finished = false;
		}
		else if(w1 != "Bird Name Available!"){
			ErrorText.text = w1;
			ErrorText.color = Color.red;
			NextButton.interactable = false;
			Finished = false;
		}
		else if(w1 == "Bird Name Available!"){
			ErrorText.text = w1;
			ErrorText.color = Color.green;
			NextButton.interactable = true;
			Finished = true;
		}
		if(Finished == true && Finished1 == true){
			PlayerPref.SetId(iddata1);
			PlayerPref.SetString (0, inputfield.text);
			Timeset = Time.time;
			Timeset1 = 14;
			MainMenu1.transform.position = new Vector3 (0, Screen.width * 2, 0);
			MainMenu1.SetActive (true);
		}
		Finished1 = false;
	}

	public void OnClickKbvstudios(){
		googleAnalytics.LogScreen("Kbvstudios");
		Application.OpenURL ("http://kbvstudios.com");
	}
}
