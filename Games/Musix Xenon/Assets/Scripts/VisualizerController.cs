using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using SVGImporter;
using UnityEngine.UI;

//In this "game", the controller uses data from the analyses is used to create some simple visuals.
public class VisualizerController : MonoBehaviour
{
	/// <summary>
	/// prefab that represents a line.
	/// </summary>
	public GameObject linePrefab;
		
	/// <summary>
	/// RythmTool.
	/// </summary>
	public RhythmTool rhythmTool;

	public Shape shape;

	public GoogleAnalyticsV4 googleAnalytics;
	public MobileImporter mp3Importer;
	public GameObject Songs;
	public GameObject HighScores;
	public GameObject OnlineDataSideBar;
	public GameObject playbox;
	public GameObject blocker;
	public SVGImage playcircle;
	public SVGImage innercircle;
	public SVGImage hand;
	public SVGImage sp;
	public SVGImage mp;
	public Image breaker;
	public Image progressbar;
	public Text progresstext;
	public Text playtext;
	public Transform holder;
	public Transform playcircle1;
	public Transform contentpanel1;
	public Transform contentpanel2;
	public Transform contentpanel3;
	public Transform contentpanel4;
	public Transform contentpanel5;
	public int songownnumber;
	public int userid;
	public int start;
	public int end;
	public bool initialized = false;
	private AudioClip song;
	private int lastFrame;
	private Analysis low;
	private Analysis mid;
	private Analysis high;
	private Analysis best;
	private Analysis best1;
	private Analysis best2;
	public int lowonset;
	public int midonset;
	public int highonset;
	public int best1onset;
	public int best2onset;
	public List<string> beatlist;

	public AudioClip a2;
	public string songtitlebrowser;
	public string songtitlename;
	public string song1;
	public List<string> song2;
	public List<int> songlistspare;
	public List<string> songlistoriginal;
	public List<string> songlistnew;
	public List<int> songplaying;
	private bool once2;

	private GameObject objref1;
	private GameObject objref2;
	private float time = -1f;
	private float timeplayselect = -1f;
	private bool disable;
	private int nextchangeindex;
	private int play;
	private int playselect;
	private int playselect1;
	private int playselect2;
	private int playselect3;
	private int TotalFrames;
	private int CurrentFrame;
	private int changeindex;
	private int tut;
	private bool checksum;
	
	void Awake (){
		googleAnalytics.LogScreen("User ID: " + PlayerPref.GetString("User"));
		googleAnalytics.LogScreen("Main Menu");
		DontDestroyOnLoad (gameObject);
		objref1 = TextBubble.BubbleSetup (GameObject.Find("Canvas").transform, -80, 50, 0, 1, "Single-Player", 17, 1);
		objref2 = TextBubble.BubbleSetup (GameObject.Find("Canvas").transform, 80, 50, 180, 1, "Multi-Player", 17, 1);
	}

	public void OnClickKbvstudios (){
		googleAnalytics.LogScreen("KBVStudios Website");
		Application.OpenURL ("http://www.kbvstudios.com/");
	}
		
	public void OnClickPlay(string mode)
	{
		if(mode == "SP"){
			playselect = 3;
			googleAnalytics.LogScreen("Single-Player Clicked");
		}
		else if(mode == "MP"){
			StartCoroutine (OnlineData());
			playselect2 = 2;
			googleAnalytics.LogScreen("Multi-Player Clicked");
		}
		Destroy (objref1);
		Destroy (objref2);
		sp.GetComponent<CanvasGroup>().blocksRaycasts = false;
		mp.GetComponent<CanvasGroup>().blocksRaycasts = false;
		sp.color = Color.clear;
		mp.color = Color.clear;
		breaker.color = Color.clear;
		timeplayselect = Time.time;
		playtext.text = "";
		playtext.gameObject.SetActive(true);
		playcircle1.gameObject.SetActive(true);
		innercircle.enabled = true;
	}

	public void OnClickBack()
	{
		sp.GetComponent<CanvasGroup>().blocksRaycasts = true;
		mp.GetComponent<CanvasGroup>().blocksRaycasts = true;
		playcircle.GetComponent<Button> ().interactable = true;
		sp.color = Color.black;
		mp.color = Color.black;
		breaker.color = Color.white;
		timeplayselect = 0;
		playselect = 0;
		playselect1 = 0;
		playselect2 = 0;
		playselect3 = 0;
		play = 0;
		playtext.text = "";
		playtext.gameObject.SetActive(false);
		playcircle1.gameObject.SetActive(false);
		innercircle.enabled = false;
	}

	public void OnClickPlaySelect()
	{
		if (playselect == 1) {
			googleAnalytics.LogScreen("Story Music Browser");
			Songs.SetActive (true);
			blocker.SetActive (false);
			Songs.GetComponent<RectTransform> ().sizeDelta = new Vector2 (425, 421);
			Songs.transform.localPosition = new Vector3 (0, -20, 0);
			contentpanel1.transform.localPosition = new Vector3 (0, 0, 0);
		}
		else if (playselect == 2) {
			googleAnalytics.LogScreen("All Music Browser");
			GameObject.Find ("All Music").transform.localScale = new Vector3 (1, 0, 0);
			GameObject.Find ("Browser").transform.localScale = new Vector3 (0, 0, 0);
			mp3Importer.OpenBrowser();
			blocker.SetActive (false);
			GameObject.Find ("All Music").GetComponent<RectTransform> ().sizeDelta = new Vector2 (425, 421);
			GameObject.Find ("All Music").transform.localPosition = new Vector3 (0, -20, 0);
			contentpanel2.transform.localPosition = new Vector3 (0, 0, 0);
		}
		else if (playselect == 3) {
			googleAnalytics.LogScreen("Directory Browser");
			GameObject.Find ("Browser").transform.localScale = new Vector3 (1, 0, 0);
			GameObject.Find ("All Music").transform.localScale = new Vector3 (0, 0, 0);
			mp3Importer.OpenBrowser();
			blocker.SetActive (false);
			GameObject.Find ("Browser").GetComponent<RectTransform> ().sizeDelta = new Vector2 (425, 421);
			GameObject.Find ("Browser").transform.localPosition = new Vector3 (0, -20, 0);
			contentpanel3.transform.localPosition = new Vector3 (0, 0, 0);
		}
		else if (playselect2 == 1) {
			googleAnalytics.LogScreen("Online Music Browser");
			GameObject.Find ("OnlineData").transform.localScale = new Vector3 (1, 1, 1);
			GameObject.Find ("Browser").transform.localScale = new Vector3 (0, 0, 0);
			GameObject.Find ("All Music").transform.localScale = new Vector3 (0, 0, 0);
			GameObject.Find ("MusicSelection").transform.localScale = new Vector3(1, 1, 1);
			OnlineDataSideBar.SetActive (true);
			blocker.SetActive (true);
			contentpanel4.transform.localPosition = new Vector3 (0, 0, 0);
		}
		else if (playselect2 == 2) {
			googleAnalytics.LogScreen("High Scores Browser");
			GameObject.Find ("OnlineData").transform.localScale = new Vector3 (1, 1, 1);
			GameObject.Find ("Browser").transform.localScale = new Vector3 (0, 0, 0);
			GameObject.Find ("All Music").transform.localScale = new Vector3 (0, 0, 0);
			GameObject.Find ("MusicSelection").transform.localScale = new Vector3(0, 0, 0);
			HighScores.SetActive (true);
			blocker.SetActive (false);
			contentpanel5.transform.localPosition = new Vector3 (0, 0, 0);
		}
		play = 1;
		time = Time.time;
		innercircle.GetComponent<Button> ().interactable = false;
		playselect = 0;
		playselect1 = 0;
		playselect2 = 0;
		playselect3 = 0;
	}

	public void OnClickMultiplayerSelect(int selection){
		OnlineDataSideBar.SetActive (false);
		if(selection == 1){
			Songs.SetActive (true);
			Songs.GetComponent<RectTransform> ().sizeDelta = new Vector2 (212.5f, 391);
			Songs.transform.localPosition = new Vector3 (106, -35, 0);
			contentpanel1.transform.localPosition = new Vector3 (0, 0, 0);
		}
		else if(selection == 2){
			GameObject.Find ("All Music").transform.localScale = new Vector3 (1, 0, 0);
			GameObject.Find ("Browser").transform.localScale = new Vector3 (0, 0, 0);
			mp3Importer.OpenBrowser();
			GameObject.Find ("All Music").GetComponent<RectTransform> ().sizeDelta = new Vector2 (212.5f, 391);
			GameObject.Find ("All Music").transform.localPosition = new Vector3 (106, -35, 0);
			contentpanel2.transform.localPosition = new Vector3 (0, 0, 0);
		}
		else if(selection == 3){
			GameObject.Find ("Browser").transform.localScale = new Vector3 (1, 0, 0);
			GameObject.Find ("All Music").transform.localScale = new Vector3 (0, 0, 0);
			mp3Importer.OpenBrowser();
			GameObject.Find ("Browser").GetComponent<RectTransform> ().sizeDelta = new Vector2 (212.5f, 391);
			GameObject.Find ("Browser").transform.localPosition = new Vector3 (106, -35, 0);
			contentpanel3.transform.localPosition = new Vector3 (0, 0, 0);
		}
		else if(selection == 4){
			OnlineDataSideBar.SetActive (true);
			Songs.SetActive (false);
			GameObject.Find ("Browser").transform.localScale = new Vector3 (0, 0, 0);
			GameObject.Find ("All Music").transform.localScale = new Vector3 (0, 0, 0);
		}
	}

	public void OnClickPlayBox (){
		play = 3;
		time = Time.time;
	}

	public void OnClickFileSelected(AudioClip clip)
	{
		song = clip;
		GetComponent<AudioSource> ().clip = clip;
		GetComponent<AudioSource> ().Play ();
		if (song.name == "Akiam Dance") {
			songownnumber = 1;
		} 
		else if (song.name == "Slow Pipes") {
			songownnumber = 2;
		} 
		else if (song.name == "The Tunnel") {
			songownnumber = 3;
		} 
		else if (song.name == "At The Other End On The Party") {
			songownnumber = 4;
		} 
		else if (song.name == "Irelands Coast Travelog Edition") {
			songownnumber = 5;
		}
		else if (song.name == "The Old Song") {
			songownnumber = 6;
		}
		else if (song.name == "Hello") {
			songownnumber = 7;
		}
		else if (song.name == "Sea Star") {
			songownnumber = 8;
		}
		else if (song.name == "Laser Millenium") {
			songownnumber = 9;
		}
		else if (song.name == "Disco Century") {
			songownnumber = 10;
		}
		else if (song.name == "Zombies Also Love To Play The Fool") {
			songownnumber = 11;
		}
		else if (song.name == "No Joke Is All That Counts") {
			songownnumber = 12;
		}
		else if (song.name == "Night Adventure") {
			songownnumber = 13;
		}
		else if (song.name == "Runner") {
			songownnumber = 14;
		}
		else if (song.name == "Chocolate Addiction") {
			songownnumber = 15;
		}
		googleAnalytics.LogScreen(song.name);
		if (song1 != "") {
			GetComponent<AudioSource> ().clip = song;
			GetComponent<AudioSource> ().Play ();
			rhythmTool.NewSong (song);
			best = rhythmTool.AddAnalysis(start, end, "Best");
			checksum = true;
		}
		else {
			start = 0;
			if(songownnumber == 7){
				end = 15;
			}
			else if(songownnumber == 5){
				end = 20;
			}
			else if(songownnumber == 3){
				end = 30;
			}
			else if(songownnumber == 1 || songownnumber == 10){
				end = 50;
			}
			else if(songownnumber == 4 || songownnumber == 6 || songownnumber == 8 || songownnumber == 15){
				end = 2;
			}
			else {
				end = 7;
			}
			rhythmTool.NewSong (song);
			best = rhythmTool.AddAnalysis(start, end, "Best");
			SceneManager.LoadScene (2);
		}
	}

	void FileSelected(string path)
	{
		if (song1 != "") {
			song = mp3Importer.ImportFile(path);
			googleAnalytics.LogScreen(song.name);
			GetComponent<AudioSource> ().clip = song;
			GetComponent<AudioSource> ().Play();
			rhythmTool.NewSong(song);
			best = rhythmTool.AddAnalysis(start, end, "Best");
			checksum = true;
		}
		else {
			song = mp3Importer.ImportFile(path);
			googleAnalytics.LogScreen(song.name);
			rhythmTool.NewSong(song);
			start = 0;
			end = 0;
			best1 = rhythmTool.AddAnalysis (0, 50, "Best1");
			best2 = rhythmTool.AddAnalysis (0, 100, "Best2");
			SceneManager.LoadScene (2);
		}
	}

	void Game ()
	{
		Application.runInBackground = true;
		
		rhythmTool = GetComponent<RhythmTool>();
	}
	
	void OnReadyToPlay()
	{
		if (SceneManager.GetActiveScene ().buildIndex == 2 && (rhythmTool.TotalFrames - rhythmTool.LastFrame) == 1) {
			if (GameObject.Find ("LoadingText") != null) {
				GameObject.Find ("LoadingText").SetActive (false);
			}
			shape = GameObject.Find ("Shape").GetComponent<Shape> ();
			progressbar = GameObject.Find ("Progress Bar").GetComponent<Image> ();
			progresstext = GameObject.Find ("Progress Text").GetComponent<Text> ();
			shape.Change ();
			//Start playing and analyzing the song.
			GetComponent<AudioSource> ().volume = 1;
			rhythmTool.Play ();
		
			//Game related initializatoin.
			//get the data from the analyzer.
			low = rhythmTool.Low;
			mid = rhythmTool.Mid;
			high = rhythmTool.High;
			lastFrame = 0;
			tut = 0;
			TotalFrames = rhythmTool.TotalFrames - 1;
			CurrentFrame = 0;
			if(end == 0){
				if (AmountOfOnsets (low, 1) == true) {
					best = low;
					start = 0;
					end = 20;
				}
				else if (AmountOfOnsets (best1, 2) == true) {
					best = best1;
					start = 0;
					end = 50;
				}
				else if (AmountOfOnsets (best2, 3) == true) {
					best = best2;
					start = 0;
					end = 100;
				}
				else if (AmountOfOnsets (mid, 4) == true) {
					best = mid;
					start = 30;
					end = 350;
				}
				else if (AmountOfOnsets (high, 5) == true) {
					best = high;
					start = 350;
					end = 700;
				}
				else{
					if (lowonset >= best1onset && lowonset >= best2onset && lowonset >= midonset && lowonset >= highonset) {
						best = low;
						start = 0;
						end = 20;
					}
					else if (best1onset >= best2onset && best1onset >= midonset && best1onset >= highonset) {
						best = best1;
						start = 0;
						end = 50;
					}
					else if (best2onset >= midonset && best2onset >= highonset) {
						best = best2;
						start = 0;
						end = 100;
					}
					else if (midonset >= highonset) {
						best = mid;
						start = 30;
						end = 350;
					}
					else{
						best = high;
						start = 350;
						end = 700;
					}
				}
			}
			songplaying.Clear ();
			foreach(int f in best.onsetIndices) {
				if (best.GetOnset(f) > 10.3f) {
					songplaying.Add (f);
				}
			}
			initialized = true;
		}
	}

	bool AmountOfOnsets(Analysis b, int saveonset){
		int onset = 0;
		for (int i = 0; i < b.onsets.Count; i++) {
			if (b.onsets [i] > 10.3f) {
				onset++;
			}
		}
		if(saveonset == 1){
			lowonset = onset;
		}
		else if(saveonset == 2){
			best1onset = onset;
		}
		else if(saveonset == 3){
			best2onset = onset;
		}
		else if(saveonset == 4){
			midonset = onset;
		}
		else if(saveonset == 5){
			highonset = onset;
		}
		if (onset >= (rhythmTool.TotalFrames / 60)) {
			return true;
		}
		else {
			return false;
		}
	}

	// Update is called once per frame
	void Update ()
	{
		if (SceneManager.GetActiveScene().buildIndex == 1) {
			if(checksum == true && rhythmTool.AnalysisDone){
				checksum = false;
				SongIdentify (song1);
				if (songlistnew.Count > 0) {
					SceneManager.LoadScene (2);
				}
				else {
					TextBubble.BubbleSetup (GameObject.Find("Canvas").transform, 0, 107, 0, 1.3f, "Error, Song Mismatch!", 17, 1);
				}
			}
			if(songtitlebrowser != "" && HighScores.activeSelf == true){
				songtitlename = songtitlebrowser;
				StartCoroutine (OnlineData (userid, false));
				songtitlebrowser = "";
			}
			else if(songtitlebrowser != ""){
				songtitlename = songtitlebrowser;
				StartCoroutine (OnlineData (songtitlebrowser));
				songtitlebrowser = "";
			}
			if(timeplayselect <= Time.time && playselect == 1){
				playselect1 = 1;
				playselect = 0;
				time = Time.time;
				playtext.text = "";
				innercircle.GetComponent<Button> ().interactable = false;
				hand.enabled = false;
			}
			else if(timeplayselect <= Time.time && playselect == 2){
				playselect1 = 2;
				playselect = 0;
				time = Time.time;
				playtext.text = "";
				innercircle.GetComponent<Button> ().interactable = false;
				hand.enabled = false;
			}
			else if(timeplayselect <= Time.time && playselect == 3){
				playselect1 = 3;
				playselect = 0;
				time = Time.time;
				playtext.text = "";
				innercircle.GetComponent<Button> ().interactable = false;
				hand.enabled = false;
			}
			else if(timeplayselect <= Time.time && playselect2 == 1){
				playselect3 = 1;
				playselect2 = 0;
				time = Time.time;
				playtext.text = "";
				innercircle.GetComponent<Button> ().interactable = false;
				hand.enabled = false;
			}
			else if(timeplayselect <= Time.time && playselect2 == 2){
				playselect3 = 2;
				playselect2 = 0;
				time = Time.time;
				playtext.text = "";
				innercircle.GetComponent<Button> ().interactable = false;
				hand.enabled = false;
			}
			if (playcircle.color.a <= 0 && play == 1) {
				play = 2;
				time = Time.time;
				playcircle.GetComponent<Button> ().interactable = false;
			}
			else if (holder.localPosition.y == 0 && play == 2) {
				play = 0;
			}
			else if (holder.localPosition.y == -470 && play == 3) {
				play = 4;
				timeplayselect = 0;
				playselect = 0;
				playselect1 = 0;
				playselect2 = 0;
				playselect3 = 0;
				playtext.text = "";
				song1 = "";
				songtitlename = "";
				time = Time.time;
				innercircle.enabled = false;
				hand.enabled = false;
				playtext.gameObject.SetActive(false);
				playcircle1.gameObject.SetActive(false);
				GameObject.Find ("Browser").transform.localScale = new Vector3(0, 0, 0);
				GameObject.Find ("All Music").transform.localScale = new Vector3(0, 0, 0);
				GameObject.Find ("OnlineData").transform.localScale = new Vector3 (0, 0, 0);
				Songs.SetActive (false);
				OnlineDataSideBar.SetActive (false);
				HighScores.SetActive (false);
				sp.GetComponent<CanvasGroup>().blocksRaycasts = true;
				mp.GetComponent<CanvasGroup>().blocksRaycasts = true;
				playcircle.GetComponent<Button> ().interactable = true;
				sp.color = Color.black;
				mp.color = Color.black;
				breaker.color = Color.white;
			}
			else if (playcircle.color.a >= 1 && play == 4) {
				play = 0;
			}
			if(playselect1 == 1){
				if ((Time.time - time) * 2 >= 1) {
					timeplayselect = Time.time + 3;
					playtext.text = "USER MUSIC (IN ORDER)";
					playselect = 2;
					playselect1 = 0;
					innercircle.GetComponent<Button> ().interactable = true;
					hand.enabled = true;
					StartCoroutine (HandBlink ());
				}
				else {
					playcircle1.localEulerAngles = Vector3.Lerp (new Vector3 (0, 0, 0), new Vector3 (0, 0, 45), (Time.time - time) * 2);
					hand.transform.localEulerAngles = Vector3.Lerp (new Vector3 (0, 0, 0), new Vector3 (0, 0, -45), (Time.time - time) * 2);
					hand.rectTransform.anchoredPosition = new Vector2 (0,-14);
				}
			}
			else if(playselect1 == 2){
				if((Time.time - time) * 2 >= 1){
					timeplayselect = Time.time + 3;
					playtext.text = "USER MUSIC (DIRECTORY)";
					playselect = 3;
					playselect1 = 0;
					innercircle.GetComponent<Button> ().interactable = true;
					hand.enabled = true;
					StartCoroutine (HandBlink ());
				}
				else{
					playcircle1.transform.localEulerAngles = Vector3.Lerp(new Vector3 (0, 0, 45), new Vector3 (0, 0, 90), (Time.time - time) * 2);
					hand.transform.localEulerAngles = Vector3.Lerp (new Vector3 (0, 0, -45), new Vector3 (0, 0, -90), (Time.time - time) * 2);
					hand.rectTransform.anchoredPosition = new Vector2 (-10,-10);
				}
			}
			else if(playselect1 == 3){
				if ((Time.time - time) * 2 >= 1) {
					timeplayselect = Time.time + 3;
					playtext.text = "STORY MUSIC (DEFAULT)";
					playselect = 1;
					playselect1 = 0;
					innercircle.GetComponent<Button> ().interactable = true;
					hand.enabled = true;
					StartCoroutine (HandBlink ());
				}
				else {
					playcircle1.transform.localEulerAngles = Vector3.Lerp (new Vector3 (0, 0, 90), new Vector3 (0, 0, 0), (Time.time - time) * 2);
					hand.transform.localEulerAngles = Vector3.Lerp (new Vector3 (0, 0, -90), new Vector3 (0, 0, 0), (Time.time - time) * 2);
					hand.rectTransform.anchoredPosition = new Vector2 (10,-10);
				}
			}
			else if(playselect3 == 1){
				if ((Time.time - time) * 2 >= 1) {
					timeplayselect = Time.time + 3;
					playtext.text = "MULTIPLAYER SCORES";
					playselect2 = 2;
					playselect3 = 0;
					innercircle.GetComponent<Button> ().interactable = true;
					hand.enabled = true;
					StartCoroutine (HandBlink ());
				}
				else {
					playcircle1.localEulerAngles = Vector3.Lerp (new Vector3 (0, 0, 22.5f), new Vector3 (0, 0, 67.5f), (Time.time - time) * 2);
					hand.transform.localEulerAngles = Vector3.Lerp (new Vector3 (0, 0, -22.5f), new Vector3 (0, 0, -67.5f), (Time.time - time) * 2);
					hand.rectTransform.anchoredPosition = new Vector2 (-5,-13);
				}
			}
			else if(playselect3 == 2){
				if((Time.time - time) * 2 >= 1){
					timeplayselect = Time.time + 3;
					playtext.text = "MULTIPLAYER SELECTION";
					playselect2 = 1;
					playselect3 = 0;
					innercircle.GetComponent<Button> ().interactable = true;
					hand.enabled = true;
					StartCoroutine (HandBlink ());
				}
				else{
					playcircle1.transform.localEulerAngles = Vector3.Lerp(new Vector3 (0, 0, 67.5f), new Vector3 (0, 0, 22.5f), (Time.time - time) * 2);
					hand.transform.localEulerAngles = Vector3.Lerp (new Vector3 (0, 0, -67.5f), new Vector3 (0, 0, -22.5f), (Time.time - time) * 2);
					hand.rectTransform.anchoredPosition = new Vector2 (5,-13);
				}
			}
			if (play == 1) {
				playcircle.color = new Color (playcircle.color.r, playcircle.color.g, playcircle.color.b, 1 - ((Time.time - time) * 2));
				innercircle.color = new Color (innercircle.color.r, innercircle.color.g, innercircle.color.b, 1 - ((Time.time - time) * 2));
				hand.color = new Color (hand.color.r, hand.color.g, hand.color.b, 1 - ((Time.time - time) * 2));
				playtext.color = new Color (playtext.color.r, playtext.color.g, playtext.color.b, 1 - ((Time.time - time) * 2));
			}
			else if (play == 2) {
				holder.localPosition = Vector3.Lerp (new Vector3 (0, -470, 0), new Vector3 (0, 0, 0), (Time.time - time));
			}
			else if (play == 3) {
				holder.localPosition = Vector3.Lerp (new Vector3 (0, 0, 0), new Vector3 (0, -470, 0), (Time.time - time));
			}
			else if (play == 4) {
				playcircle.color = new Color (playcircle.color.r, playcircle.color.g, playcircle.color.b, (Time.time - time) * 2);
				innercircle.color = new Color (innercircle.color.r, innercircle.color.g, innercircle.color.b, (Time.time - time) * 2);
				hand.color = new Color (hand.color.r, hand.color.g, hand.color.b, (Time.time - time) * 2);
				playtext.color = new Color (playtext.color.r, playtext.color.g, playtext.color.b, (Time.time - time) * 2);
				sp.color = new Color (0, 0, 0, (Time.time - time) * 2);
				mp.color = new Color (0, 0, 0, (Time.time - time) * 2);
				breaker.color = new Color (0, 0, 0, (Time.time - time) * 2);
			}
		}
	
		//If not initialized for some reason (no song loaded), don't do anything.
		if (!initialized) {
			if (SceneManager.GetActiveScene().buildIndex == 2) {
				OnReadyToPlay ();
			}
			return;
		}

		if (TotalFrames <= CurrentFrame) {
			if(shape.finished == false){
				GameObject.Find ("EndDisplayBackground").transform.localScale = new Vector3 (1, 1, 1);
				if (songtitlename == "") {
					StartCoroutine(User ());
					song1 = SongIdentify (songlistoriginal, start, end);
					GameObject.Find ("UploadHolder").transform.localScale = new Vector3 (1, 1, 1);
				}
				else {
					StartCoroutine (OnlineData(userid, true));
					GameObject.Find ("ScoreHolder").transform.localScale = new Vector3 (1, 1, 1);
				}
				shape.finished = true;
			}
		}

		if(SceneManager.GetActiveScene().buildIndex == 3){
			System.GC.Collect();
			Resources.UnloadUnusedAssets();
			SceneManager.LoadScene (1);
		}

		if(rhythmTool.CurrentFrame != 0){
			CurrentFrame = rhythmTool.CurrentFrame;
			progressbar.fillAmount = CurrentFrame / (TotalFrames * 1f);
			progresstext.text = Mathf.FloorToInt((CurrentFrame / (TotalFrames * 1f)) * 100f) + "%";
		}
		
		//Game logic
		//create some lines to represent some of the analyzed data.
		for (int i = lastFrame+1; i<rhythmTool.CurrentFrame+30; i++) {
			if (i > rhythmTool.TotalFrames - 1)
				break;
			if(disable == false && rhythmTool.CurrentFrame+30 >= rhythmTool.NextChangeIndex(rhythmTool.CurrentFrame) && rhythmTool.NextChangeIndex(rhythmTool.CurrentFrame) > rhythmTool.CurrentFrame){
				disable = true;
				changeindex = rhythmTool.NextChangeIndex (rhythmTool.CurrentFrame);
			}
			if (rhythmTool.CurrentFrame >= changeindex && disable == true) {
				shape.Change ();
				disable = false;
			}
			if (disable == false) {
				//if (best.GetOnset (i) > 10.3f) {
				//	shape.AddPoint(0);
				//}
				for (int f = 0; f < songplaying.Count; f++){
					if (songplaying[f] < rhythmTool.CurrentFrame) {
						songplaying.RemoveAt(0);
						f--;
					}
					else if (songplaying[f] <= i) {
						if (songownnumber == 1 && tut < 5) {
							tut++;
							shape.AddPoint ((i - songplaying [f]) / 30f, true, tut);
						}
						else {
							shape.AddPoint ((i - songplaying [f]) / 30f, true, 0);
						}
						songplaying.RemoveAt(0);
						f--;
					}
					else {
						f = songplaying.Count;
					}
				}
				if (Time.time >= time) {
					//lines.Add (CreateLine (i, Color.blue, 100));
					//time = Time.time + (60f / rhythmTool.BPM);
				}

				if (mid.GetOnset (i) > .3f) {
					//lines.Add (CreateLine (i, Color.green, mid.GetOnset(i) * .7f));
				}

				if (high.GetOnset (i) > .1f) {
					//lines.Add (CreateLine (i, Color.yellow, high.GetOnset(i)));
				}
			}
			lastFrame = i;
		}
	}

	public string SongIdentify(List<string> songlist, int fstart, int fend){
		songlistspare.Clear ();
		songlist.Clear ();
		if (rhythmTool.LastFrame == rhythmTool.TotalFrames - 1) {
			for (int i = 0; i < rhythmTool.TotalFrames; i++) {
				if (best.GetOnset (i) > 10.3f) {
					songlistspare.Add (i);
				}
			}
			for (int i = 0; i < songlistspare.Count; i++) {
				if (i == 0) {
					songlist.Add (songlistspare [0] + ",");
				}
				else if (i == (songlistspare.Count - 1)){
					songlist.Add ((songlistspare [i] - songlistspare [i - 1]).ToString());
				}
				else {
					songlist.Add ((songlistspare [i] - songlistspare [i - 1]) + ",");
				}
			}
		}
		return string.Join("", songlist.ToArray());
	}

	public List<string> SongIdentify (string songlist){
		songlistoriginal.Clear ();
		foreach(string s in songlist.Split(',')){
			songlistoriginal.Add(s);
		}
		songlistspare.Clear ();
		songlistnew.Clear ();
		if (rhythmTool.LastFrame == rhythmTool.TotalFrames - 1) {
			for (int i = 0; i < rhythmTool.TotalFrames; i++) {
				if (best.GetOnset (i) > 10.3f) {
					songlistspare.Add (i);
				}
			}
			for (int i = 0; i < songlistspare.Count; i++) {
				if (i == 0) {
					songlistnew.Add (songlistspare [0].ToString());
				}
				else {
					songlistnew.Add ((songlistspare [i] - songlistspare [i - 1]).ToString());
				}
			}
		}
		songlistspare.Clear ();
		foreach(string s in songlistoriginal){
			for (int c = 0; c < songlistnew.Count; c++) {
				if (songlistnew [c] == s) {
					songlistspare.Add (c);
					songlistnew[c] = "";
					c = songlistnew.Count;
				}
			}
		}
		float percent = songlistspare.Count / (songlistoriginal.Count * 1f);
		songlistnew.Clear ();
		if (percent >= 0.90f) {
			foreach (int i in songlistspare) {
				songlistnew.Add (i.ToString());
			}
		}
		return songlistnew;
	}

	IEnumerator Load () {
		if(SceneManager.GetActiveScene().buildIndex == 3){
			System.GC.Collect();
			Resources.UnloadUnusedAssets();
			yield return new WaitForSeconds (1);
			SceneManager.LoadScene (1);
		}
	}

	IEnumerator HandBlink (){
		yield return new WaitForSeconds (0.15f);
		hand.enabled = false;
		yield return new WaitForSeconds (0.1f);
		hand.enabled = true;
		yield return new WaitForSeconds (0.15f);
		hand.enabled = false;
		yield return new WaitForSeconds (0.1f);
		hand.enabled = true;
		yield return new WaitForSeconds (0.15f);
		hand.enabled = false;
		yield return new WaitForSeconds (0.1f);
		hand.enabled = true;
	}

	IEnumerator User(){
		if (PlayerPref.GetString ("User") != "") {
			userid = int.Parse(PlayerPref.GetString ("User"));
		}
		else{
			WWW w1 = new WWW("http://kbvstudios.com/musixxenon/musixxenonid.php");
			yield return w1;
			if (w1.error == null) {
				int id = 0;
				if (int.TryParse (w1.text, out id) == true) {
					userid = id;
					PlayerPref.SetString ("User", id.ToString ("000000000"));
				}
				else {
					userid = 0;
				}
			}
		}
	}

	IEnumerator OnlineData(){
		WWW w2 = new WWW("http://kbvstudios.com/musixxenon/musixxenonsongs.php");
		yield return w2;
		if (w2.error == null) {
			string text = "";
			if (w2.text != "") {
				text = w2.text.Substring (1);
			}
			string[] data = text.Split (',');
			Browser songtitle = GameObject.Find ("OnlineData").GetComponent<Browser> ();
			songtitle.files.Clear ();
			songtitle.contentPanel.anchoredPosition = new Vector2 (0, 0);
			songtitle.files.Add ("Akiam Dance (Snabisch)");
			songtitle.files.Add ("Slow Pipes (RawGameStudios)");
			songtitle.files.Add ("The Tunnel (Snabisch)");
			songtitle.files.Add ("At The Other End On The Party (Snabisch)");
			songtitle.files.Add ("Irelands Coast Travelog Edition (Matthew Pablo)");
			songtitle.files.Add ("The Old Song (Snabisch)");
			songtitle.files.Add ("Hello (OMFG)");
			songtitle.files.Add ("Sea Star (Snabisch)");
			songtitle.files.Add ("Laser Millenium (Neocrey)");
			songtitle.files.Add ("Disco Century (Neocrey)");
			songtitle.files.Add ("Zombies Also Love To Play The Fool (Alexandr Zhelanov)");
			songtitle.files.Add ("No Joke Is All That Counts (Snabisch)");
			songtitle.files.Add ("Night Adventure (Alexandr Zhelanov)");
			songtitle.files.Add ("Runner (Alexandr Zhelanov)");
			songtitle.files.Add ("Chocolate Addiction (Snabisch)");
			foreach (string s in data) {
				if (s != "") {
					songtitle.files.Add (s);
				}
			}
			songtitle.files.Sort (15, songtitle.files.Count - 15, null);
			if (songtitle.files.Count != 0) {
				songtitle.nosongsfound.transform.localScale = new Vector3 (0, 0, 0);
			}
		}
		else {
			TextBubble.BubbleSetup (GameObject.Find("Canvas").transform, 0, 50, 0, 1.3f, "Error, Network Connection", 17, 1);
		}
	}

	IEnumerator OnlineData(int id, bool postscore){
		if (PlayerPref.GetString ("User") != "" && int.Parse(PlayerPref.GetString ("User")) != 0) {
			id = int.Parse(PlayerPref.GetString ("User"));
		}
		else{
			WWW w1 = new WWW("http://kbvstudios.com/musixxenon/musixxenonid.php");
			yield return w1;
			id = 0;
			if (int.TryParse (w1.text, out id) == true) {
				PlayerPref.SetString ("User", id.ToString("000000000"));
			}
		}
		if (postscore == true) {
			WWWForm form = new WWWForm ();
			form.AddField ("UserID", id);
			form.AddField ("SongTitle", songtitlename);
			form.AddField ("Score", int.Parse (shape.GetPoint ()));
			WWW w2 = new WWW ("http://kbvstudios.com/musixxenon/musixxenonupload.php", form);
			yield return w2;
		}
		WWWForm form1 = new WWWForm();
		form1.AddField("UserID", id);
		form1.AddField("SongTitle", songtitlename);
		WWW w3 = new WWW("http://kbvstudios.com/musixxenon/musixxenonsongs.php", form1);
		yield return w3;
		if (w3.error == null) {
			string[] s = new string[11];
			s = w3.text.Split (',');
			if (s [0] != "") {
				GameObject.Find ("Score1").GetComponent<Text> ().text = s [0];
			}
			if (s [1] != "") {
				GameObject.Find ("Score2").GetComponent<Text> ().text = s [1];
			}
			if (s [2] != "") {
				GameObject.Find ("Score3").GetComponent<Text> ().text = s [2];
			}
			if (s [3] != "") {
				GameObject.Find ("Score4").GetComponent<Text> ().text = s [3];
			}
			if (s [4] != "") {
				GameObject.Find ("Score5").GetComponent<Text> ().text = s [4];
			}
			if (s [5] != "") {
				GameObject.Find ("Score6").GetComponent<Text> ().text = s [5];
			}
			if (s [6] != "") {
				GameObject.Find ("Score7").GetComponent<Text> ().text = s [6];
			}
			if (s [7] != "") {
				GameObject.Find ("Score8").GetComponent<Text> ().text = s [7];
			}
			if (s [8] != "") {
				GameObject.Find ("Score9").GetComponent<Text> ().text = s [8];
			}
			if (s [9] != "") {
				GameObject.Find ("Score10").GetComponent<Text> ().text = s [9];
			}
			if (s [10] != "") {
				GameObject.Find ("ScoreOwn").GetComponent<Text> ().text = s [10];
			}
		}
		else if(postscore == true) {
			TextBubble.BubbleSetup (GameObject.Find("EndDisplay").transform, 0, 285, 0, 1.3f, "Error, Network Connection", 17, 1);
		}
		else{
			TextBubble.BubbleSetup (GameObject.Find("Canvas").transform, 0, 107, 180, 1.3f, "Error, Network Connection", 17, 1);
		}
	}

	IEnumerator OnlineData(string SongTitle){
		WWWForm form = new WWWForm();
		form.AddField("SongTitle", SongTitle);
		WWW w2 = new WWW("http://kbvstudios.com/musixxenon/musixxenonsongs.php", form);
		yield return w2;
		if (w2.error == null) {
			string[] ssplit = w2.text.Split (',');
			start = int.Parse (ssplit[0]);
			end = int.Parse (ssplit[1]);
			song1 = w2.text.Substring (ssplit [0].Length + ssplit [1].Length + 2);
			blocker.SetActive (false);
		}
		else {
			TextBubble.BubbleSetup (GameObject.Find("Canvas").transform, 0, 107, 180, 1.3f, "Error, Network Connection", 17, 1);
		}
	}
}