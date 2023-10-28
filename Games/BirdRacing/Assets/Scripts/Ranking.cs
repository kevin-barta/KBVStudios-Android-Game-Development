using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace UnitySampleAssets.Utility
{
	public class Ranking : MonoBehaviour {

	private GameObject PlayerAI;
	private string BirdAI;
	private int PUPBirdAI;
	private int RankBirdAI;
	public int AIWait1 = 0;
	public int AIWait2 = 0;
	public int AIWait3 = 0;
	public int AIWait4 = 0;
	public int AIWait5 = 0;
	public int AIWait6 = 0;
	public int AIWait7 = 0;
	public WaypointCircuit circuit;
	public Color PrefColour;
	public Color PrefColour1;
	public Color PrefColour2;
	public AudioSource SoundSource;
	public AudioSource MusicSource;
	public AudioClip Chirp;
	public SpriteRenderer Oil1;
	public SpriteRenderer Oil2;
	public SpriteRenderer Oil3;
	public SpriteRenderer Oil4;
	public SpriteRenderer Oil5;
	public SpriteRenderer Oil6;
	public SpriteRenderer Oil7;
	public SpriteRenderer Oil8;
	public SpriteRenderer OilScreen1;
	public SpriteRenderer PUP11;
	public SpriteRenderer PUP12;
	public SpriteRenderer PUP21;
	public SpriteRenderer PUP22;
	public SpriteRenderer PUP31;
	public SpriteRenderer PUP32;
	public SpriteRenderer PUP41;
	public SpriteRenderer PUP42;
	public SpriteRenderer PUP51;
	public SpriteRenderer PUP52;
	public SpriteRenderer PUP61;
	public SpriteRenderer PUP62;
	public SpriteRenderer PUP71;
	public SpriteRenderer PUP72;
	public SpriteRenderer PUP81;
	public SpriteRenderer PUP82;
	public GameObject PUPBird;
	public GameObject MainCamera;
	public GameObject Fireworks;
	public GameObject MiniMapCamera;
	public GameObject PanelBoard;
	public GameObject PanelGame;
	public GameObject PauseButtonColoured;
	public GameObject PauseButton;
	public GameObject PauseButtonColoured1;
	public GameObject PauseButton1;
	public GameObject PauseClick;
	public GameObject Player1;
	public GameObject Player2;
	public GameObject Player3;
	public GameObject Player4;
	public GameObject Player5;
	public GameObject Player6;
	public GameObject Player7;
	public GameObject Player8;
	private GameObject Item1;
	private GameObject Item2;
	private GameObject Item3;
	private GameObject Item4;
	private GameObject Item5;
	private GameObject Item6;
	private GameObject Item7;
	private GameObject Item8;
	private GameObject Board1;
	private GameObject Board2;
	private GameObject Board3;
	private GameObject Board4;
	private GameObject Board5;
	private GameObject Board6;
	private GameObject Board7;
	private GameObject Board8;
	private GameObject Place1;
	private GameObject Place2;
	private GameObject Place3;
	private GameObject Place4;
	private GameObject Place5;
	private GameObject Place6;
	private GameObject Place7;
	private GameObject Place8;
	public Text Place;
	public Text PlaceColoured;
	public Text Lap;
	public Text LapColoured;
	public Text LapComplete;
	public Text LapCompleteColoured;
	public Text timecounter;
	public Text timecounter1;
	public Text DoubleEarn;
	public string Name1 = "BLUE JAY";
	public string Name2 = "CARDINAL";
	public string Name3 = "DOVE";
	public string Name4 = "SPARROW";
	public string Name5 = "GOLD FINCH";
	public string Name6 = "ROBIN";
	public string Name7 = "WOODPECKER";
	public string Name8 = "UNNAMED";
	public float Bird1 = -50;
	public float Bird2 = -100;
	public float Bird3 = -150;
	public float Bird4 = -200;
	public float Bird5 = -250;
	public float Bird6 = -300;
	public float Bird7 = -350;
	public float Bird8 = -400;
	public int RankBird1 = 1;
	public int RankBird2 = 1;
	public int RankBird3 = 1;
	public int RankBird4 = 1;
	public int RankBird5 = 1;
	public int RankBird6 = 1;
	public int RankBird7 = 1;
	public int RankBird8 = 1;
	public int LapBird1 = 1;
	public int LapBird2 = 1;
	public int LapBird3 = 1;
	public int LapBird4 = 1;
	public int LapBird5 = 1;
	public int LapBird6 = 1;
	public int LapBird7 = 1;
	public int LapBird8 = 1;
	public int LapBird1Tracker = 2;
	public int LapBird2Tracker = 2;
	public int LapBird3Tracker = 2;
	public int LapBird4Tracker = 2;
	public int LapBird5Tracker = 2;
	public int LapBird6Tracker = 2;
	public int LapBird7Tracker = 2;
	public int LapBird8Tracker = 2;
	public int PUPBird1 = 0;
	public int PUPBird2 = 0;
	public int PUPBird3 = 0;
	public int PUPBird4 = 0;
	public int PUPBird5 = 0;
	public int PUPBird6 = 0;
	public int PUPBird7 = 0;
	public int PUPBird8 = 0;
	public int Red = 0;
	public int Green = 0;
	public int Blue = 0;
	public bool RankUpdateReady = true;
	public bool doublecolour = true;
	public bool started = false;
	public bool Chirping = false;
	public bool AIWait = false;
	public float time0;
	public float time1;
	public float timestarted;
	public float timeconvert;
	public float Length;
	public int minutes;
	public int seconds;
	public int milliseconds;
	public bool paused;

		void Start () {
			Name8 = PlayerPref.GetString (0);
			string Colour = PlayerPref.GetString (38).Substring(6);
			Red = int.Parse(Colour.Substring(0, 3));
			Green = int.Parse(Colour.Substring(3, 3));
			Blue = int.Parse(Colour.Substring(6));
			PrefColour = new Color(Red/255f, Green/255f, Blue/255f);
			PrefColour1 = new Color (PrefColour.r / 2, PrefColour.g / 2, PrefColour.b / 2);
			PrefColour2 = new Color(PrefColour.r, PrefColour.g, PrefColour.b, 0.5f);
			timecounter1.color = PrefColour;
			LapCompleteColoured.color = PrefColour;
			LapColoured.color = PrefColour;
			PlaceColoured.color = PrefColour;
			PauseButtonColoured1.GetComponent<Image>().color = PrefColour;
			GameObject.Find ("MiniMapPlayerInside8").GetComponent<SpriteRenderer> ().color = PrefColour;
			GameObject.Find ("NextColoured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("NextColoured1").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("CountdownColoured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("PauseButtonColoured").GetComponent<Image> ().color = PrefColour;
			GameObject.Find ("HeaderBackground").GetComponent<Image> ().color = PrefColour;
			GameObject.Find ("PanelXpBackground").GetComponent<Image> ().color = PrefColour;
			GameObject.Find ("PanelPlace1").GetComponent<Image> ().color = PrefColour2;
			GameObject.Find ("PanelPlace2").GetComponent<Image> ().color = PrefColour2;
			GameObject.Find ("PanelPlace3").GetComponent<Image> ().color = PrefColour2;
			GameObject.Find ("PanelPlace4").GetComponent<Image> ().color = PrefColour2;
			GameObject.Find ("PanelPlace5").GetComponent<Image> ().color = PrefColour2;
			GameObject.Find ("PanelPlace6").GetComponent<Image> ().color = PrefColour2;
			GameObject.Find ("PanelPlace7").GetComponent<Image> ().color = PrefColour2;
			GameObject.Find ("PanelPlace8").GetComponent<Image> ().color = PrefColour2;
			GameObject.Find ("Next2Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Back2Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Time1Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Name1Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Place1Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Time2Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Name2Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Place2Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Time3Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Name3Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Place3Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Time4Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Name4Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Place4Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Time5Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Name5Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Place5Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Time6Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Name6Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Place6Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Time7Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Name7Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Place7Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Time8Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Name8Coloured").GetComponent<Text> ().color = PrefColour;
			GameObject.Find ("Place8Coloured").GetComponent<Text> ().color = PrefColour;
			StartCoroutine(Waittillstart());
		}

		void Update () {
			if(paused == false){
				if(started == true){
					timeconvert = Time.time - timestarted;
					minutes = (int)timeconvert / 60;
					seconds = minutes * 60;
					seconds = (int)timeconvert - seconds;
					milliseconds = minutes * 60;
					milliseconds = milliseconds + seconds;
					milliseconds = milliseconds * 100;
					timeconvert = timeconvert * 100;
					milliseconds = (int)timeconvert - milliseconds;
					if(minutes > 9){
						started = false;
						minutes = 9;
						seconds = 59;
						milliseconds = 99;
					}
					if(LapBird8Tracker != 5){
						timecounter.text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
						timecounter1.text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					}
				}
				if(PUPBird1 != 0 && AIWait1 == 0){
					AIWait1 = 5;
					StartCoroutine(AIWaiting1());
				}
				if(PUPBird2 != 0 && AIWait2 == 0){
					AIWait2 = 5;
					StartCoroutine(AIWaiting2());
				}
				if(PUPBird3 != 0 && AIWait3 == 0){
					AIWait3 = 5;
					StartCoroutine(AIWaiting3());
				}
				if(PUPBird4 != 0 && AIWait4 == 0){
					AIWait4 = 5;
					StartCoroutine(AIWaiting4());
				}
				if(PUPBird5 != 0 && AIWait5 == 0){
					AIWait5 = 5;
					StartCoroutine(AIWaiting5());
				}
				if(PUPBird6 != 0 && AIWait6 == 0){
					AIWait6 = 5;
					StartCoroutine(AIWaiting6());
				}
				if(PUPBird7 != 0 && AIWait7 == 0){
					AIWait7 = 5;
					StartCoroutine(AIWaiting7());
				}
				if(PUPBird1 != 0 && AIWait == false && AIWait1 == 10){
					AIWait = true;
					PlayerAI = Player1;
					BirdAI = "Bird1";
					PUPBirdAI = PUPBird1;
					RankBirdAI = RankBird1;
					PUPBird1 = 0;
					AIWait1 = 0;
					AIBird();
				}
				else if(PUPBird2 != 0 && AIWait == false && AIWait2 == 10){
					AIWait = true;
					PlayerAI = Player2;
					BirdAI = "Bird2";
					PUPBirdAI = PUPBird2;
					RankBirdAI = RankBird2;
					PUPBird2 = 0;
					AIWait2 = 0;
					AIBird();
				}
				else if(PUPBird3 != 0 && AIWait == false && AIWait3 == 10){
					AIWait = true;
					PlayerAI = Player3;
					BirdAI = "Bird3";
					PUPBirdAI = PUPBird3;
					RankBirdAI = RankBird3;
					PUPBird3 = 0;
					AIWait3 = 0;
					AIBird();
				}
				else if(PUPBird4 != 0 && AIWait == false && AIWait4 == 10){
					AIWait = true;
					PlayerAI = Player4;
					BirdAI = "Bird4";
					PUPBirdAI = PUPBird4;
					RankBirdAI = RankBird4;
					PUPBird4 = 0;
					AIWait4 = 0;
					AIBird();
				}
				else if(PUPBird5 != 0 && AIWait == false && AIWait5 == 10){
					AIWait = true;
					PlayerAI = Player5;
					BirdAI = "Bird5";
					PUPBirdAI = PUPBird5;
					RankBirdAI = RankBird5;
					PUPBird5 = 0;
					AIWait5 = 0;
					AIBird();
				}
				else if(PUPBird6 != 0 && AIWait == false && AIWait6 == 10){
					AIWait = true;
					PlayerAI = Player6;
					BirdAI = "Bird6";
					PUPBirdAI = PUPBird6;
					RankBirdAI = RankBird6;
					PUPBird6 = 0;
					AIWait6 = 0;
					AIBird();
				}
				else if(PUPBird7 != 0 && AIWait == false && AIWait7 == 10){
					AIWait = true;
					PlayerAI = Player7;
					BirdAI = "Bird7";
					PUPBirdAI = PUPBird7;
					RankBirdAI = RankBird7;
					PUPBird7 = 0;
					AIWait7 = 0;
					AIBird();
				}
				if(Input.GetKeyDown(KeyCode.Space) || Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Began){
					if(PUPBird8 == 0 && Chirping == false){
						if(PlayerPref.GetString(38).Substring(0, 1) == "1"){
							Chirping = true;
							GetComponent<AudioSource>().PlayOneShot(Chirp);
							StartCoroutine(WaitChirping());
						}
					}
					else if(PUPBird8 == 1){
						PUPBird8 = 0;
						PUP82.sprite = null;
						GameObject PUPBirdPoop = (GameObject) Instantiate(PUPBird, Player8.transform.position, Player8.transform.rotation);
						PUPBirdPoop.tag = "PUP_BirdPoop";
						PUPBirdPoop.GetComponent<PUPBird>().BirdCreate = "Bird8";
						PUPBirdPoop.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdPoop");
						PUPBirdPoop.GetComponent<SpriteRenderer>().color = new Color(0.4f, 0.26f, 0.13f);
					}
					else if(PUPBird8 == 2){
						PUPBird8 = 1;
						PUP81.sprite = null;
						GameObject PUPBirdPoop = (GameObject) Instantiate(PUPBird, Player8.transform.position, Player8.transform.rotation);
						PUPBirdPoop.tag = "PUP_BirdPoop";
						PUPBirdPoop.GetComponent<PUPBird>().BirdCreate = "Bird8";
						PUPBirdPoop.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdPoop");
						PUPBirdPoop.GetComponent<SpriteRenderer>().color = new Color(0.4f, 0.26f, 0.13f);
					}
					else if(PUPBird8 == 3){
						PUPBird8 = 0;
						PUP82.sprite = null;
						Player8.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
					}
					else if(PUPBird8 == 4){
						PUPBird8 = 3;
						PUP81.sprite = null;
						Player8.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
					}
					else if(PUPBird8 == 5){
						PUPBird8 = 0;
						PUP82.sprite = null;
						GameObject PUPBirdEggRed = (GameObject) Instantiate(PUPBird, Player8.transform.position, Player8.transform.rotation);
						PUPBirdEggRed.tag = "PUP_BirdEggRed";
						PUPBirdEggRed.GetComponent<PUPBird>().BirdCreate = "Bird8";
						PUPBirdEggRed.GetComponent<PUPBird>().Rank = RankBird8;
						PUPBirdEggRed.GetComponent<PUPBird>().BirdPos = Player8;
						PUPBirdEggRed.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						PUPBirdEggRed.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
					}
					else if(PUPBird8 == 6){
						PUPBird8 = 5;
						PUP81.sprite = null;
						GameObject PUPBirdEggRed = (GameObject) Instantiate(PUPBird, Player8.transform.position, Player8.transform.rotation);
						PUPBirdEggRed.tag = "PUP_BirdEggRed";
						PUPBirdEggRed.GetComponent<PUPBird>().BirdCreate = "Bird8";
						PUPBirdEggRed.GetComponent<PUPBird>().Rank = RankBird8;
						PUPBirdEggRed.GetComponent<PUPBird>().BirdPos = Player8;
						PUPBirdEggRed.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						PUPBirdEggRed.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
					}
					else if(PUPBird8 == 7){
						PUPBird8 = 0;
						PUP82.sprite = null;
						GameObject PUPBirdEggBlue = (GameObject) Instantiate(PUPBird, Player8.transform.position, Player8.transform.rotation);
						PUPBirdEggBlue.tag = "PUP_BirdEggBlue";
						PUPBirdEggBlue.GetComponent<PUPBird>().BirdCreate = "Bird8";
						PUPBirdEggBlue.GetComponent<PUPBird>().Rank = RankBird8;
						PUPBirdEggBlue.GetComponent<PUPBird>().BirdPos = Player8;
						PUPBirdEggBlue.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						PUPBirdEggBlue.GetComponent<SpriteRenderer>().color = new Color(0, 0.5f, 1);
					}
					else if(PUPBird8 == 8){
						PUPBird8 = 0;
						PUP82.sprite = null;
						GameObject PUPRottenEgg = (GameObject) Instantiate(PUPBird, Player8.transform.position, Player8.transform.rotation);
						PUPRottenEgg.tag = "PUP_RottenEgg";
						PUPRottenEgg.GetComponent<PUPBird>().BirdCreate = "Bird8";
						PUPRottenEgg.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						PUPRottenEgg.GetComponent<SpriteRenderer>().color = new Color(0, 0.25f, 0);
					}
					else if(PUPBird8 == 9){
						PUPBird8 = 0;
						PUP82.sprite = null;
						Player8.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 2;
					}
					else if(PUPBird8 == 10){
						PUPBird8 = 0;
						PUP82.sprite = null;
						Oil1.GetComponent<SpriteRenderer>().enabled = true;
						Oil2.GetComponent<SpriteRenderer>().enabled = true;
						Oil3.GetComponent<SpriteRenderer>().enabled = true;
						Oil4.GetComponent<SpriteRenderer>().enabled = true;
						Oil5.GetComponent<SpriteRenderer>().enabled = true;
						Oil6.GetComponent<SpriteRenderer>().enabled = true;
						Oil7.GetComponent<SpriteRenderer>().enabled = true;
						StartCoroutine(OilRemove());
					}
					else if(PUPBird8 == 11){
						PUPBird8 = 0;
						PUP82.sprite = null;
						Player8.GetComponent<UnitySampleAssets.Utility.WaypointProgressTracker>().progressDistance = Bird8 + 2000;
						Player8.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 3;
					}
				}
				RankBird1 = 1;
				RankBird2 = 1;
				RankBird3 = 1;
				RankBird4 = 1;
				RankBird5 = 1;
				RankBird6 = 1;
				RankBird7 = 1;
				RankBird8 = 1;
				if (Bird1 < Bird2) {
					RankBird1 = RankBird1 + 1;
				}
				if (Bird1 < Bird3) {
					RankBird1 = RankBird1 + 1;
				}
				if (Bird1 < Bird4) {
					RankBird1 = RankBird1 + 1;
				}
				if (Bird1 < Bird5) {
					RankBird1 = RankBird1 + 1;
				}
				if (Bird1 < Bird6) {
					RankBird1 = RankBird1 + 1;
				}
				if (Bird1 < Bird7) {
					RankBird1 = RankBird1 + 1;
				}
				if (Bird1 < Bird8) {
					RankBird1 = RankBird1 + 1;
				}
				if (Bird2 < Bird1) {
					RankBird2 = RankBird2 + 1;
				}
				if (Bird2 < Bird3) {
					RankBird2 = RankBird2 + 1;
				}
				if (Bird2 < Bird4) {
					RankBird2 = RankBird2 + 1;
				}
				if (Bird2 < Bird5) {
					RankBird2 = RankBird2 + 1;
				}
				if (Bird2 < Bird6) {
					RankBird2 = RankBird2 + 1;
				}
				if (Bird2 < Bird7) {
					RankBird2 = RankBird2 + 1;
				}
				if (Bird2 < Bird8) {
					RankBird2 = RankBird2 + 1;
				}
				if (Bird3 < Bird1) {
					RankBird3 = RankBird3 + 1;
				}
				if (Bird3 < Bird2) {
					RankBird3 = RankBird3 + 1;
				}
				if (Bird3 < Bird4) {
					RankBird3 = RankBird3 + 1;
				}
				if (Bird3 < Bird5) {
					RankBird3 = RankBird3 + 1;
				}
				if (Bird3 < Bird6) {
					RankBird3 = RankBird3 + 1;
				}
				if (Bird3 < Bird7) {
					RankBird3 = RankBird3 + 1;
				}
				if (Bird3 < Bird8) {
					RankBird3 = RankBird3 + 1;
				}
				if (Bird4 < Bird1) {
					RankBird4 = RankBird4 + 1;
				}
				if (Bird4 < Bird2) {
					RankBird4 = RankBird4 + 1;
				}
				if (Bird4 < Bird3) {
					RankBird4 = RankBird4 + 1;
				}
				if (Bird4 < Bird5) {
					RankBird4 = RankBird4 + 1;
				}
				if (Bird4 < Bird6) {
					RankBird4 = RankBird4 + 1;
				}
				if (Bird4 < Bird7) {
					RankBird4 = RankBird4 + 1;
				}
				if (Bird4 < Bird8) {
					RankBird4 = RankBird4 + 1;
				}
				if (Bird5 < Bird1) {
					RankBird5 = RankBird5 + 1;
				}
				if (Bird5 < Bird2) {
					RankBird5 = RankBird5 + 1;
				}
				if (Bird5 < Bird3) {
					RankBird5 = RankBird5 + 1;
				}
				if (Bird5 < Bird4) {
					RankBird5 = RankBird5 + 1;
				}
				if (Bird5 < Bird6) {
					RankBird5 = RankBird5 + 1;
				}
				if (Bird5 < Bird7) {
					RankBird5 = RankBird5 + 1;
				}
				if (Bird5 < Bird8) {
					RankBird5 = RankBird5 + 1;
				}
				if (Bird6 < Bird1) {
					RankBird6 = RankBird6 + 1;
				}
				if (Bird6 < Bird2) {
					RankBird6 = RankBird6 + 1;
				}
				if (Bird6 < Bird3) {
					RankBird6 = RankBird6 + 1;
				}
				if (Bird6 < Bird4) {
					RankBird6 = RankBird6 + 1;
				}
				if (Bird6 < Bird5) {
					RankBird6 = RankBird6 + 1;
				}
				if (Bird6 < Bird7) {
					RankBird6 = RankBird6 + 1;
				}
				if (Bird6 < Bird8) {
					RankBird6 = RankBird6 + 1;
				}
				if (Bird7 < Bird1) {
					RankBird7 = RankBird7 + 1;
				}
				if (Bird7 < Bird2) {
					RankBird7 = RankBird7 + 1;
				}
				if (Bird7 < Bird3) {
					RankBird7 = RankBird7 + 1;
				}
				if (Bird7 < Bird4) {
					RankBird7 = RankBird7 + 1;
				}
				if (Bird7 < Bird5) {
					RankBird7 = RankBird7 + 1;
				}
				if (Bird7 < Bird6) {
					RankBird7 = RankBird7 + 1;
				}
				if (Bird7 < Bird8) {
					RankBird7 = RankBird7 + 1;
				}
				if (Bird8 < Bird1) {
					RankBird8 = RankBird8 + 1;
				}
				if (Bird8 < Bird2) {
					RankBird8 = RankBird8 + 1;
				}
				if (Bird8 < Bird3) {
					RankBird8 = RankBird8 + 1;
				}
				if (Bird8 < Bird4) {
					RankBird8 = RankBird8 + 1;
				}
				if (Bird8 < Bird5) {
					RankBird8 = RankBird8 + 1;
				}
				if (Bird8 < Bird6) {
					RankBird8 = RankBird8 + 1;
				}
				if (Bird8 < Bird7) {
					RankBird8 = RankBird8 + 1;
				}
				if (RankBird8 == RankBird7) {
					RankBird8 = RankBird8 + 1;
				}
				if (RankBird8 == RankBird6) {
					RankBird8 = RankBird8 + 1;
				}
				if (RankBird8 == RankBird5) {
					RankBird8 = RankBird8 + 1;
				}
				if (RankBird8 == RankBird4) {
					RankBird8 = RankBird8 + 1;
				}
				if (RankBird8 == RankBird3) {
					RankBird8 = RankBird8 + 1;
				}
				if (RankBird8 == RankBird2) {
					RankBird8 = RankBird8 + 1;
				}
				if (RankBird8 == RankBird1) {
					RankBird8 = RankBird8 + 1;
				}
				if (RankBird7 == RankBird6) {
					RankBird7 = RankBird7 + 1;
				}
				if (RankBird7 == RankBird5) {
					RankBird7 = RankBird7 + 1;
				}
				if (RankBird7 == RankBird4) {
					RankBird7 = RankBird7 + 1;
				}
				if (RankBird7 == RankBird3) {
					RankBird7 = RankBird7 + 1;
				}
				if (RankBird7 == RankBird2) {
					RankBird7 = RankBird7 + 1;
				}
				if (RankBird7 == RankBird1) {
					RankBird7 = RankBird7 + 1;
				}
				if (RankBird6 == RankBird5) {
					RankBird6 = RankBird6 + 1;
				}
				if (RankBird6 == RankBird4) {
					RankBird6 = RankBird6 + 1;
				}
				if (RankBird6 == RankBird3) {
					RankBird6 = RankBird6 + 1;
				}
				if (RankBird6 == RankBird2) {
					RankBird6 = RankBird6 + 1;
				}
				if (RankBird6 == RankBird1) {
					RankBird6 = RankBird6 + 1;
				}
				if (RankBird5 == RankBird4) {
					RankBird5 = RankBird5 + 1;
				}
				if (RankBird5 == RankBird3) {
					RankBird5 = RankBird5 + 1;
				}
				if (RankBird5 == RankBird2) {
					RankBird5 = RankBird5 + 1;
				}
				if (RankBird5 == RankBird1) {
					RankBird5 = RankBird5 + 1;
				}
				if (RankBird4 == RankBird3) {
					RankBird4 = RankBird4 + 1;
				}
				if (RankBird4 == RankBird2) {
					RankBird4 = RankBird4 + 1;
				}
				if (RankBird4 == RankBird1) {
					RankBird4 = RankBird4 + 1;
				}
				if (RankBird3 == RankBird2) {
					RankBird3 = RankBird3 + 1;
				}
				if (RankBird3 == RankBird1) {
					RankBird3 = RankBird3 + 1;
				}
				if (RankBird2 == RankBird1) {
					RankBird2 = RankBird2 + 1;
				}
				if(RankUpdateReady == true){
					RankUpdateReady = false;
					StartCoroutine(RankUpdateWait());
					if (RankBird8 == 1) {
						Place.text = "1st";
						PlaceColoured.text = "1st";
					}
					else if (RankBird8 == 2) {
						Place.text = "2nd";
						PlaceColoured.text = "2nd";
					} 
					else if (RankBird8 == 3) {
						Place.text = "3rd";
						PlaceColoured.text = "3rd";
					} 
					else if (RankBird8 > 3) {
						Place.text = RankBird8 + "th";
						PlaceColoured.text = RankBird8 + "th";
					}
					Place1 = GameObject.Find ("PlaceName" + RankBird1);
					Place1.GetComponent<Text> ().text = Name1;
					Place2 = GameObject.Find ("PlaceName" + RankBird2);
					Place2.GetComponent<Text> ().text = Name2;
					Place3 = GameObject.Find ("PlaceName" + RankBird3);
					Place3.GetComponent<Text> ().text = Name3;
					Place4 = GameObject.Find ("PlaceName" + RankBird4);
					Place4.GetComponent<Text> ().text = Name4;
					Place5 = GameObject.Find ("PlaceName" + RankBird5);
					Place5.GetComponent<Text> ().text = Name5;
					Place6 = GameObject.Find ("PlaceName" + RankBird6);
					Place6.GetComponent<Text> ().text = Name6;
					Place7 = GameObject.Find ("PlaceName" + RankBird7);
					Place7.GetComponent<Text> ().text = Name7;
					Place8 = GameObject.Find ("PlaceName" + RankBird8);
					Place8.GetComponent<Text> ().text = Name8;
					Item1 = GameObject.Find ("PlaceItem" + RankBird1);
					Item1.GetComponent<Image>().sprite = PUP12.sprite;
					Item1.GetComponent<Image>().color = PUP12.color;
					Item2 = GameObject.Find ("PlaceItem" + RankBird2);
					Item2.GetComponent<Image>().sprite = PUP22.sprite;
					Item2.GetComponent<Image>().color = PUP22.color;
					Item3 = GameObject.Find ("PlaceItem" + RankBird3);
					Item3.GetComponent<Image>().sprite = PUP32.sprite;
					Item3.GetComponent<Image>().color = PUP32.color;
					Item4 = GameObject.Find ("PlaceItem" + RankBird4);
					Item4.GetComponent<Image>().sprite = PUP42.sprite;
					Item4.GetComponent<Image>().color = PUP42.color;
					Item5 = GameObject.Find ("PlaceItem" + RankBird5);
					Item5.GetComponent<Image>().sprite = PUP52.sprite;
					Item5.GetComponent<Image>().color = PUP52.color;
					Item6 = GameObject.Find ("PlaceItem" + RankBird6);
					Item6.GetComponent<Image>().sprite = PUP62.sprite;
					Item6.GetComponent<Image>().color = PUP62.color;
					Item7 = GameObject.Find ("PlaceItem" + RankBird7);
					Item7.GetComponent<Image>().sprite = PUP72.sprite;
					Item7.GetComponent<Image>().color = PUP72.color;
					Item8 = GameObject.Find ("PlaceItem" + RankBird8);
					Item8.GetComponent<Image>().sprite = PUP82.sprite;
					Item8.GetComponent<Image>().color = PUP82.color;
					if(Item1.GetComponent<Image>().sprite == null){
						Item1.GetComponent<Image>().color = new Color(0, 0, 0, 0);
					}
					if(Item2.GetComponent<Image>().sprite == null){
						Item2.GetComponent<Image>().color = new Color(0, 0, 0, 0);
					}
					if(Item3.GetComponent<Image>().sprite == null){
						Item3.GetComponent<Image>().color = new Color(0, 0, 0, 0);
					}
					if(Item4.GetComponent<Image>().sprite == null){
						Item4.GetComponent<Image>().color = new Color(0, 0, 0, 0);
					}
					if(Item5.GetComponent<Image>().sprite == null){
						Item5.GetComponent<Image>().color = new Color(0, 0, 0, 0);
					}
					if(Item6.GetComponent<Image>().sprite == null){
						Item6.GetComponent<Image>().color = new Color(0, 0, 0, 0);
					}
					if(Item7.GetComponent<Image>().sprite == null){
						Item7.GetComponent<Image>().color = new Color(0, 0, 0, 0);
					}
					if(Item8.GetComponent<Image>().sprite == null){
						Item8.GetComponent<Image>().color = new Color(0, 0, 0, 0);
					}
				}
				if(LapBird1Tracker == 2 && LapBird1 == 4){
					LapBird1Tracker = 5;
					Player1.SetActive(false);
					Bird1 = Bird1 * 5;
					Bird1 = Bird1 - (RankBird1 * 1000);
					Board1 = GameObject.Find("Time" + RankBird1);
					Board1.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board1 = GameObject.Find("Time" + RankBird1 + "Coloured");
					Board1.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board1 = GameObject.Find("Name" + RankBird1);
					Board1.GetComponent<Text>().text = Name1;
					Board1 = GameObject.Find("Name" + RankBird1 + "Coloured");
					Board1.GetComponent<Text>().text = Name1;
				}
				if(LapBird2Tracker == 2 && LapBird2 == 4){
					LapBird2Tracker = 5;
					Player2.SetActive(false);
					Bird2 = Bird2 * 5;
					Bird2 = Bird2 - (RankBird2 * 1000);
					Board2 = GameObject.Find("Time" + RankBird2);
					Board2.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board2 = GameObject.Find("Time" + RankBird2 + "Coloured");
					Board2.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board2 = GameObject.Find("Name" + RankBird2);
					Board2.GetComponent<Text>().text = Name2;
					Board2 = GameObject.Find("Name" + RankBird2 + "Coloured");
					Board2.GetComponent<Text>().text = Name2;
				}
				if(LapBird3Tracker == 2 && LapBird3 == 4){
					LapBird3Tracker = 5;
					Player3.SetActive(false);
					Bird3 = Bird3 * 5;
					Bird3 = Bird3 - (RankBird3 * 1000);
					Board3 = GameObject.Find("Time" + RankBird3);
					Board3.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board3 = GameObject.Find("Time" + RankBird3 + "Coloured");
					Board3.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board3 = GameObject.Find("Name" + RankBird3);
					Board3.GetComponent<Text>().text = Name3;
					Board3 = GameObject.Find("Name" + RankBird3 + "Coloured");
					Board3.GetComponent<Text>().text = Name3;
				}
				if(LapBird4Tracker == 2 && LapBird4 == 4){
					LapBird4Tracker = 5;
					Player4.SetActive(false);
					Bird4 = Bird4 * 5;
					Bird4 = Bird4 - (RankBird4 * 1000);
					Board4 = GameObject.Find("Time" + RankBird4);
					Board4.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board4 = GameObject.Find("Time" + RankBird4 + "Coloured");
					Board4.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board4 = GameObject.Find("Name" + RankBird4);
					Board4.GetComponent<Text>().text = Name4;
					Board4 = GameObject.Find("Name" + RankBird4 + "Coloured");
					Board4.GetComponent<Text>().text = Name4;
				}
				if(LapBird5Tracker == 2 && LapBird5 == 4){
					LapBird5Tracker = 5;
					Player5.SetActive(false);
					Bird5 = Bird5 * 5;
					Bird5 = Bird5 - (RankBird5 * 1000);
					Board5 = GameObject.Find("Time" + RankBird5);
					Board5.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board5 = GameObject.Find("Time" + RankBird5 + "Coloured");
					Board5.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board5 = GameObject.Find("Name" + RankBird5);
					Board5.GetComponent<Text>().text = Name5;
					Board5 = GameObject.Find("Name" + RankBird5 + "Coloured");
					Board5.GetComponent<Text>().text = Name5;
				}
				if(LapBird6Tracker == 2 && LapBird6 == 4){
					LapBird6Tracker = 5;
					Player6.SetActive(false);
					Bird6 = Bird6 * 5;
					Bird6 = Bird6 - (RankBird6 * 1000);
					Board6 = GameObject.Find("Time" + RankBird6);
					Board6.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board6 = GameObject.Find("Time" + RankBird6 + "Coloured");
					Board6.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board6 = GameObject.Find("Name" + RankBird6);
					Board6.GetComponent<Text>().text = Name6;
					Board6 = GameObject.Find("Name" + RankBird6 + "Coloured");
					Board6.GetComponent<Text>().text = Name6;
				}
				if(LapBird7Tracker == 2 && LapBird7 == 4){
					LapBird7Tracker = 5;
					Player7.SetActive(false);
					Bird7 = Bird7 * 5;
					Bird7 = Bird7 - (RankBird7 * 1000);
					Board7 = GameObject.Find("Time" + RankBird7);
					Board7.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board7 = GameObject.Find("Time" + RankBird7 + "Coloured");
					Board7.GetComponent<Text>().text = minutes + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
					Board7 = GameObject.Find("Name" + RankBird7);
					Board7.GetComponent<Text>().text = Name7;
					Board7 = GameObject.Find("Name" + RankBird7 + "Coloured");
					Board7.GetComponent<Text>().text = Name7;
				}
				if(LapBird8Tracker == 2 && LapBird8 == 2){
					Lap.text = "2/3";
					LapColoured.text = "2/3";
					LapBird8Tracker = 3;
					LapComplete.text = "LAP 2";
					LapCompleteColoured.text = "LAP 2";
					StartCoroutine(LapCompleteWait());
				}
				else if(LapBird8Tracker == 3 && LapBird8 == 3){
					Lap.text = "3/3";
					LapColoured.text = "3/3";
					LapBird8Tracker = 4;
					LapComplete.text = "LAST LAP";
					LapCompleteColoured.text = "LAST LAP";
					StartCoroutine(LapCompleteWait());
				}
				else if(LapBird8Tracker == 4 && Bird8/Length > 1400){
					Fireworks.SetActive(true);
					LapBird8Tracker = 6;
				}
				else if(LapBird8Tracker == 6 && LapBird8 == 4){
					time0 = Time.time;
					LapBird8Tracker = 5;
					Lap.text = "3/3";
					LapColoured.text = "3/3";
					LapComplete.text = "FINISHED";
					LapCompleteColoured.text = "FINISHED";
					StartCoroutine(LapCompleteWait());
					MainCamera.transform.position = Player8.transform.position;
					MainCamera.SetActive(true);
					MiniMapCamera.SetActive(false);
					Player8.SetActive(false);
					Bird8 = Bird8 * 5;
					Bird8 = Bird8 - (RankBird8 * 1000);
					Board8 = GameObject.Find("Time" + RankBird8);
					Board8.GetComponent<Text>().text = timecounter.text;
					Board8 = GameObject.Find("Time" + RankBird8 + "Coloured");
					Board8.GetComponent<Text>().text = timecounter.text;
					Board8 = GameObject.Find("Name" + RankBird8);
					Board8.GetComponent<Text>().text = Name8;
					Board8 = GameObject.Find("Name" + RankBird8 + "Coloured");
					Board8.GetComponent<Text>().text = Name8;
				}
				if(LapBird8Tracker == 5){
					if(doublecolour == true){
						time1 = Time.time - time0;
						DoubleEarn.color = Color.Lerp(PrefColour, PrefColour1, time1);
						if(time1 >= 1){
							doublecolour = false;
							time0 = Time.time;
						}
					}
					else if(doublecolour == false){
						time1 = Time.time - time0;
						DoubleEarn.color = Color.Lerp(PrefColour1, PrefColour, time1);
						if(time1 >= 1){
							doublecolour = true;
							time0 = Time.time;
						}
					}
				}
			}
		}

		public void OnClickPause (){
			Time.timeScale = 0;
			paused = true;
			SoundSource.Pause ();
			MusicSource.Pause ();
			PauseButton.SetActive (false);
			PauseButtonColoured.SetActive (false);
			PauseButton1.SetActive (true);
			PauseButtonColoured1.SetActive (true);
			PauseClick.SetActive (true);
		}

		public void OnClickUnPause (){
			Time.timeScale = 1;
			paused = false;
			SoundSource.UnPause ();
			MusicSource.UnPause ();
			PauseButton.SetActive (true);
			PauseButtonColoured.SetActive (true);
			PauseButton1.SetActive (false);
			PauseButtonColoured1.SetActive (false);
			PauseClick.SetActive (false);
		}

		void AIBird (){
			SpriteRenderer PUP2AI = null;
			SpriteRenderer PUP1AI = null;
			if(BirdAI == "Bird1"){
				PUP2AI = PUP12;
				PUP1AI = PUP11;
			}
			else if(BirdAI == "Bird2"){
				PUP2AI = PUP22;
				PUP1AI = PUP21;
			}
			else if(BirdAI == "Bird3"){
				PUP2AI = PUP32;
				PUP1AI = PUP31;
			}
			else if(BirdAI == "Bird4"){
				PUP2AI = PUP42;
				PUP1AI = PUP41;
			}
			else if(BirdAI == "Bird5"){
				PUP2AI = PUP52;
				PUP1AI = PUP51;
			}
			else if(BirdAI == "Bird6"){
				PUP2AI = PUP62;
				PUP1AI = PUP61;
			}
			else if(BirdAI == "Bird7"){
				PUP2AI = PUP72;
				PUP1AI = PUP71;
			}
			if(PUPBirdAI == 1){
				PUPBirdAI = 0;
				PUP2AI.sprite = null;
				GameObject PUPBirdPoop = (GameObject) Instantiate(PUPBird, PlayerAI.transform.position, PlayerAI.transform.rotation);
				PUPBirdPoop.tag = "PUP_BirdPoop";
				PUPBirdPoop.GetComponent<PUPBird>().BirdCreate = BirdAI;
				PUPBirdPoop.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdPoop");
				PUPBirdPoop.GetComponent<SpriteRenderer>().color = new Color(0.4f, 0.26f, 0.13f);
			}
			else if(PUPBirdAI == 2){
				PUPBirdAI = 1;
				PUP1AI.sprite = null;
				GameObject PUPBirdPoop = (GameObject) Instantiate(PUPBird, PlayerAI.transform.position, PlayerAI.transform.rotation);
				PUPBirdPoop.tag = "PUP_BirdPoop";
				PUPBirdPoop.GetComponent<PUPBird>().BirdCreate = BirdAI;
				PUPBirdPoop.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdPoop");
				PUPBirdPoop.GetComponent<SpriteRenderer>().color = new Color(0.4f, 0.26f, 0.13f);
			}
			else if(PUPBirdAI == 3){
				PUPBirdAI = 0;
				PUP2AI.sprite = null;
				if(BirdAI == "Bird1"){
					Player1.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird2"){
					Player2.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird3"){
					Player3.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird4"){
					Player4.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird5"){
					Player5.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird6"){
					Player6.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird7"){
					Player7.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
			}
			else if(PUPBirdAI == 4){
				PUPBirdAI = 3;
				PUP1AI.sprite = null;
				if(BirdAI == "Bird1"){
					Player1.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird2"){
					Player2.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird3"){
					Player3.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird4"){
					Player4.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird5"){
					Player5.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird6"){
					Player6.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
				else if(BirdAI == "Bird7"){
					Player7.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 1;
				}
			}
			else if(PUPBirdAI == 5){
				PUPBirdAI = 0;
				PUP2AI.sprite = null;
				GameObject PUPBirdEggRed = (GameObject) Instantiate(PUPBird, PlayerAI.transform.position, PlayerAI.transform.rotation);
				PUPBirdEggRed.tag = "PUP_BirdEggRed";
				PUPBirdEggRed.GetComponent<PUPBird>().BirdCreate = BirdAI;
				PUPBirdEggRed.GetComponent<PUPBird>().Rank = RankBirdAI;
				PUPBirdEggRed.GetComponent<PUPBird>().BirdPos = PlayerAI;
				PUPBirdEggRed.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
				PUPBirdEggRed.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
			}
			else if(PUPBirdAI == 6){
				PUPBirdAI = 5;
				PUP1AI.sprite = null;
				GameObject PUPBirdEggRed = (GameObject) Instantiate(PUPBird, PlayerAI.transform.position, PlayerAI.transform.rotation);
				PUPBirdEggRed.tag = "PUP_BirdEggRed";
				PUPBirdEggRed.GetComponent<PUPBird>().BirdCreate = BirdAI;
				PUPBirdEggRed.GetComponent<PUPBird>().Rank = RankBirdAI;
				PUPBirdEggRed.GetComponent<PUPBird>().BirdPos = PlayerAI;
				PUPBirdEggRed.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
				PUPBirdEggRed.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
			}
			else if(PUPBirdAI == 7){
				PUPBirdAI = 0;
				PUP2AI.sprite = null;
				GameObject PUPBirdEggBlue = (GameObject) Instantiate(PUPBird, PlayerAI.transform.position, PlayerAI.transform.rotation);
				PUPBirdEggBlue.tag = "PUP_BirdEggBlue";
				PUPBirdEggBlue.GetComponent<PUPBird>().BirdCreate = BirdAI;
				PUPBirdEggBlue.GetComponent<PUPBird>().Rank = RankBirdAI;
				PUPBirdEggBlue.GetComponent<PUPBird>().BirdPos = PlayerAI;
				PUPBirdEggBlue.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
				PUPBirdEggBlue.GetComponent<SpriteRenderer>().color = new Color(0, 0.5f, 1);
			}
			else if(PUPBirdAI == 8){
				PUPBirdAI = 0;
				PUP2AI.sprite = null;
				GameObject PUPRottenEgg = (GameObject) Instantiate(PUPBird, PlayerAI.transform.position, PlayerAI.transform.rotation);
				PUPRottenEgg.tag = "PUP_RottenEgg";
				PUPRottenEgg.GetComponent<PUPBird>().BirdCreate = BirdAI;
				PUPRottenEgg.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
				PUPRottenEgg.GetComponent<SpriteRenderer>().color = new Color(0, 0.25f, 0);
			}
			else if(PUPBirdAI == 9){
				PUPBirdAI = 0;
				PUP2AI.sprite = null;
				if(BirdAI == "Bird1"){
					Player1.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 2;
				}
				else if(BirdAI == "Bird2"){
					Player2.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 2;
				}
				else if(BirdAI == "Bird3"){
					Player3.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 2;
				}
				else if(BirdAI == "Bird4"){
					Player4.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 2;
				}
				else if(BirdAI == "Bird5"){
					Player5.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 2;
				}
				else if(BirdAI == "Bird6"){
					Player6.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 2;
				}
				else if(BirdAI == "Bird7"){
					Player7.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 2;
				}
			}
			else if(PUPBirdAI == 10){
				PUPBirdAI = 0;
				PUP2AI.sprite = null;
				Oil1.enabled = true;
				Oil2.enabled = true;
				Oil3.enabled = true;
				Oil4.enabled = true;
				Oil5.enabled = true;
				Oil6.enabled = true;
				Oil7.enabled = true;
				Oil8.enabled = true;
				OilScreen1.enabled = true;
				if(BirdAI == "Bird1"){
					Oil1.enabled = false;
				}
				else if(BirdAI == "Bird2"){
					Oil2.enabled = false;
				}
				else if(BirdAI == "Bird3"){
					Oil3.enabled = false;
				}
				else if(BirdAI == "Bird4"){
					Oil4.enabled = false;
				}
				else if(BirdAI == "Bird5"){
					Oil5.enabled = false;
				}
				else if(BirdAI == "Bird6"){
					Oil6.enabled = false;
				}
				else if(BirdAI == "Bird7"){
					Oil7.enabled = false;
				}
				StartCoroutine(OilRemove());
			}
			else if(PUPBirdAI == 11){
				PUPBirdAI = 0;
				PUP2AI.sprite = null;
				if(BirdAI == "Bird1"){
					Player1.GetComponent<UnitySampleAssets.Utility.WaypointProgressTracker>().progressDistance = Bird1 + 2000;
					Player1.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 3;
				}
				else if(BirdAI == "Bird2"){
					Player2.GetComponent<UnitySampleAssets.Utility.WaypointProgressTracker>().progressDistance = Bird2 + 2000;
					Player2.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 3;
				}
				else if(BirdAI == "Bird3"){
					Player3.GetComponent<UnitySampleAssets.Utility.WaypointProgressTracker>().progressDistance = Bird3 + 2000;
					Player3.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 3;
				}
				else if(BirdAI == "Bird4"){
					Player4.GetComponent<UnitySampleAssets.Utility.WaypointProgressTracker>().progressDistance = Bird4 + 2000;
					Player4.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 3;
				}
				else if(BirdAI == "Bird5"){
					Player5.GetComponent<UnitySampleAssets.Utility.WaypointProgressTracker>().progressDistance = Bird5 + 2000;
					Player5.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 3;
				}
				else if(BirdAI == "Bird6"){
					Player6.GetComponent<UnitySampleAssets.Utility.WaypointProgressTracker>().progressDistance = Bird6 + 2000;
					Player6.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 3;
				}
				else if(BirdAI == "Bird7"){
					Player7.GetComponent<UnitySampleAssets.Utility.WaypointProgressTracker>().progressDistance = Bird7 + 2000;
					Player7.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().PUPID = 3;
				}
			}
			if(PUPBirdAI != 0){
				if(BirdAI == "Bird1"){
					PUPBird1 = PUPBirdAI;
				}
				else if(BirdAI == "Bird2"){
					PUPBird2 = PUPBirdAI;
				}
				else if(BirdAI == "Bird3"){
					PUPBird3 = PUPBirdAI;
				}
				else if(BirdAI == "Bird4"){
					PUPBird4 = PUPBirdAI;
				}
				else if(BirdAI == "Bird5"){
					PUPBird5 = PUPBirdAI;
				}
				else if(BirdAI == "Bird6"){
					PUPBird6 = PUPBirdAI;
				}
				else if(BirdAI == "Bird7"){
					PUPBird7 = PUPBirdAI;
				}

			}
			AIWait = false;
		}

		IEnumerator AIWaiting1(){
			yield return new WaitForSeconds(Random.Range (0f, 10f));
			AIWait1 = 10;
		}

		IEnumerator AIWaiting2(){
			yield return new WaitForSeconds(Random.Range (0f, 10f));
			AIWait2 = 10;
		}

		IEnumerator AIWaiting3(){
			yield return new WaitForSeconds(Random.Range (0f, 10f));
			AIWait3 = 10;
		}

		IEnumerator AIWaiting4(){
			yield return new WaitForSeconds(Random.Range (0f, 10f));
			AIWait4 = 10;
		}

		IEnumerator AIWaiting5(){
			yield return new WaitForSeconds(Random.Range (0f, 10f));
			AIWait5 = 10;
		}

		IEnumerator AIWaiting6(){
			yield return new WaitForSeconds(Random.Range (0f, 10f));
			AIWait6 = 10;
		}

		IEnumerator AIWaiting7(){
			yield return new WaitForSeconds(Random.Range (0f, 10f));
			AIWait7 = 10;
		}

		IEnumerator LapCompleteWait() {
			yield return new WaitForSeconds(3);
			LapComplete.text = "";
			LapCompleteColoured.text = "";
			if(LapBird8Tracker == 5){
				PanelGame.transform.localScale = new Vector3(0, 0, 0);
				PanelBoard.transform.localScale = new Vector3(1, 1, 1);
			}
		}

		IEnumerator Waittillstart() {
			yield return new WaitForSeconds(1);
			Length = circuit.Length/circuit.editorVisualisationSubsteps; 
			yield return new WaitForSeconds(6);
			timestarted = Time.time;
			started = true;
		}

		IEnumerator RankUpdateWait (){
			yield return new WaitForSeconds (0.2f);
			RankUpdateReady = true;
		}

		IEnumerator WaitChirping (){
			yield return new WaitForSeconds (1.4f);
			Chirping = false;
		}

		IEnumerator OilRemove (){
			yield return new WaitForSeconds (5);
			Oil1.GetComponent<SpriteRenderer>().enabled = false;
			Oil2.GetComponent<SpriteRenderer>().enabled = false;
			Oil3.GetComponent<SpriteRenderer>().enabled = false;
			Oil4.GetComponent<SpriteRenderer>().enabled = false;
			Oil5.GetComponent<SpriteRenderer>().enabled = false;
			Oil6.GetComponent<SpriteRenderer>().enabled = false;
			Oil7.GetComponent<SpriteRenderer>().enabled = false;
			Oil8.GetComponent<SpriteRenderer>().enabled = false;
			OilScreen1.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}