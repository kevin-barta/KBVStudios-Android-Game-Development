using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using SVGImporter;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class Shape : MonoBehaviour {
	public GameObject scoreprefab;
	public GameObject noteprefab;
	public GameObject pausearea;
	public Transform canvas;
	public InputField Title;
	public InputField Artist;
	public Button uploadbutton;
	public Text songtitle;
	public Text display;
	public Text misstext;
	public Text goodtext;
	public Text greattext;
	public Text perfecttext;
	public Text totaltext;
	public Text missscoretext;
	public Text goodscoretext;
	public Text greatscoretext;
	public Text perfectscoretext;
	public Text totalscoretext;
	public RectTransform Point1;
	public RectTransform Point2;
	public RectTransform Point3;
	public RectTransform Point4;
	public RectTransform Point5;
	public RectTransform Point6;
	public RectTransform Point7;
	public RectTransform Point8;
	public RectTransform Point1Inner;
	public RectTransform Point2Inner;
	public RectTransform Point3Inner;
	public RectTransform Point4Inner;
	public RectTransform Point5Inner;
	public RectTransform Point6Inner;
	public RectTransform Point7Inner;
	public RectTransform Point8Inner;
	public int point1enabled;
	public int point2enabled;
	public int point3enabled;
	public int point4enabled;
	public int point5enabled;
	public int point6enabled;
	public int point7enabled;
	public int point8enabled;
	public bool finished;
	public List<int> pointsinner;
	public List<float> points;
	private GameObject controller;
	private BannerView bannerView;
	private string songname;
	private string point = "0";
	private int tut;
	private int songown;
	private int misspoint;
	private int goodpoint;
	private int greatpoint;
	private int perfectpoint;
	private int misspointperm;
	private int goodpointperm;
	private int greatpointperm;
	private int perfectpointperm;
	private int missscoreperm;
	private int perfectscoreperm;
	private int oldrandom;
	private int random;
	private int random1;
	private int Red;
	private int Green;
	private int Blue;
	private float t1;
	private float t2;
	private float t3;
	private float t4;
	private float t5;
	private float t6;
	private float t7;
	private float t8;
	private float centroidx;
	private float centroidy;
	private float prefwidth;
	private bool songsave;
	private bool rec1active;
	private bool rec2active;
	private bool rec3active;

	void Start (){
		AudioSource songname1 = GameObject.Find ("Controller").GetComponent<AudioSource> ();
		if (songname1.clip.name.Substring (songname1.clip.name.Length - 4) == ".mp3") {
			songsave = false;
			songname = songname1.clip.name.Substring (0, songname1.clip.name.Length - 4);
			songtitle.text = songname1.clip.name.Substring (0, songname1.clip.name.Length - 4) + "\t\t\t\t\t" + songname1.clip.name.Substring (0, songname1.clip.name.Length - 4) + "\t\t\t\t\t";
			if (PlayerPref.GetString (songname + GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.TotalFrames) != "") {
				display.text = "Best " + PlayerPref.GetString (songname + GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.TotalFrames);
			}
		}
		else {
			songsave = true;
			songtitle.text = songname1.clip.name + "\t\t\t\t\t" + songname1.clip.name + "\t\t\t\t\t";
			songown = GameObject.Find ("Controller").GetComponent<VisualizerController> ().songownnumber;
			if (PlayerPref.GetString (songown + "Song") != "") {
				display.text = "Best " + PlayerPref.GetString (songown + "Song");
			}
		}
		prefwidth = (-songtitle.preferredWidth / 2) + 350;
		songtitle.rectTransform.sizeDelta = new Vector2 (Mathf.CeilToInt (songtitle.preferredWidth), 100);
		songtitle.transform.localPosition = new Vector3 ((songtitle.preferredWidth / 2) + 400, 0, 0);
		RequestBanner ();
	}

	private void RequestBanner()
	{
		#if UNITY_ANDROID
		string adUnitId = "ca-app-pub-8870763355959902/3017249478";
		#elif UNITY_IPHONE
		string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
		AdRequest request = new AdRequest.Builder().Build();
		bannerView.LoadAd(request);
	}

	public string GetPoint(){
		return point;
	}

	public void Pause (int pause){
		if(GameObject.Find("Controller").GetComponent<VisualizerController>().initialized == true){
			if (pause != 0) {
				Point1Inner.GetComponent<Button> ().interactable = true;
				Point2Inner.GetComponent<Button> ().interactable = true;
				Point3Inner.GetComponent<Button> ().interactable = true;
				Point4Inner.GetComponent<Button> ().interactable = true;
				Point5Inner.GetComponent<Button> ().interactable = true;
				Point6Inner.GetComponent<Button> ().interactable = true;
				Point7Inner.GetComponent<Button> ().interactable = true;
				Point8Inner.GetComponent<Button> ().interactable = true;
			}
			else {
				Point1Inner.GetComponent<Button> ().interactable = false;
				Point2Inner.GetComponent<Button> ().interactable = false;
				Point3Inner.GetComponent<Button> ().interactable = false;
				Point4Inner.GetComponent<Button> ().interactable = false;
				Point5Inner.GetComponent<Button> ().interactable = false;
				Point6Inner.GetComponent<Button> ().interactable = false;
				Point7Inner.GetComponent<Button> ().interactable = false;
				Point8Inner.GetComponent<Button> ().interactable = false;
			}
			if (pause == 0) {
				Time.timeScale = 0;
				GetComponent<EveryplayTest>().OnClick(3);
				if (GetComponent<EveryplayTest> ().supported == true) {
					rec1active = false;
					rec2active = false;
					rec3active = false;
					if(GetComponent<EveryplayTest> ().rec1.activeSelf == true){
						rec1active = true;
						GetComponent<EveryplayTest> ().rec1.SetActive (false);
					}
					if (GetComponent<EveryplayTest> ().rec2.activeSelf == true) {
						rec2active = true;
						GetComponent<EveryplayTest> ().rec2.SetActive (false);
					}
					if (GetComponent<EveryplayTest> ().rec3.activeSelf == true) {
						rec3active = true;
						GetComponent<EveryplayTest> ().rec3.SetActive (false);
					}
				}
				display.gameObject.SetActive (false);
				pausearea.SetActive (true);
				GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.Pause ();
			}
			else if(pause == 1){
				Time.timeScale = 1;
				pausearea.SetActive (false);
				display.gameObject.SetActive (true);
				GetComponent<EveryplayTest>().OnClick(4);
				if (GetComponent<EveryplayTest> ().supported == true) {
					GetComponent<EveryplayTest> ().rec1.SetActive (rec1active);
					GetComponent<EveryplayTest> ().rec2.SetActive (rec2active);
					GetComponent<EveryplayTest> ().rec3.SetActive (rec3active);
				}
				GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.Play ();
			}
			else if(pause == 2){
				misspoint = 0;
				goodpoint = 0;
				greatpoint = 0;
				perfectpoint = 0;
				misspointperm = 0;
				goodpointperm = 0;
				greatpointperm = 0;
				perfectpointperm = 0;
				display.text = "Ready!";
				Time.timeScale = 1;
				pausearea.SetActive (false);
				display.gameObject.SetActive (true);
				GameObject.Find ("Controller").GetComponent<VisualizerController> ().initialized = false;
				GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.Play ();
				GetComponent<EveryplayTest>().OnClick(2);
			}
			else if(pause == 3){
				Time.timeScale = 1;
				GetComponent<EveryplayTest>().OnClick(2);
				GetComponent<EveryplayTest> ().Destroy ();
				if (bannerView != null) {
					bannerView.Destroy ();
				}
				SceneManager.LoadScene (3);
			}
		}
	}

	public void Upload (){
		WWWForm form = new WWWForm();
		VisualizerController control = GameObject.Find ("Controller").GetComponent<VisualizerController> ();
		form.AddField("UserID", control.userid);
		form.AddField("SongData", control.start + "," + control.end + "," + control.song1);
		form.AddField("SongTitle", Title.text + " (" + Artist.text + ")");
		form.AddField ("Score", int.Parse(point));
		WWW w1 = new WWW("http://kbvstudios.com/musixxenon/musixxenonupload.php", form);
		if (songsave == true) {
			PlayerPref.SetString ("Song" + songown + "Song", Title.text + Artist.text);
		}
		else {
			PlayerPref.SetString ("Song" + songname + GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.TotalFrames, Title.text + Artist.text);
		}
		uploadbutton.interactable = false;
	}

	public void LoadingScreen (){
		if (bannerView != null) {
			bannerView.Destroy ();
		}
		GetComponent<EveryplayTest> ().Destroy ();
		SceneManager.LoadScene (3);
	}

	void Update (){
		songtitle.transform.localPosition = new Vector3 (songtitle.transform.localPosition.x - (100 * Time.deltaTime), 0, 0);
		if(songtitle.transform.localPosition.x <= prefwidth){
			songtitle.transform.localPosition = new Vector3 (350, 0, 0);
		}
		if(finished == true){
			misstext.text = "Miss x" + misspointperm;
			goodtext.text = "Good x" + goodpointperm;
			greattext.text = "Great x" + greatpointperm;
			perfecttext.text = "Perfect x" + perfectpointperm;
			totaltext.text = "Total x" + (misspointperm + goodpointperm + greatpointperm + perfectpointperm);
			missscoretext.text = "-" + missscoreperm;
			goodscoretext.text = "+" + (20 * goodpointperm);
			greatscoretext.text = "+" + (30 * greatpointperm);
			perfectscoretext.text = "+" + perfectscoreperm;
			if (int.Parse (point) < 0) {
				point = "+0";
			}
			else {
				point = "+" + point;
			}
			totalscoretext.text = point;
			canvas.gameObject.SetActive (false);
			if (songsave == true) {
				if (PlayerPref.GetString (songown + "Song") == ""){
					PlayerPref.SetString (songown + "Song", point);
				}
				else if (int.Parse (PlayerPref.GetString (songown + "Song")) < int.Parse (point)) {
					PlayerPref.SetString (songown + "Song", point);
				}
				if (songown == 1) {
					Title.text = "Akiam Dance";
					Artist.text = "Snabisch";
				}
				else if (songown == 2) {
					Title.text = "Slow Pipes";
					Artist.text = "RawGameStudios";
				}
				else if (songown == 3) {
					Title.text = "The Tunnel";
					Artist.text = "Snabisch";
				}
				else if (songown == 4) {
					Title.text = "At The Other End On The Party";
					Artist.text = "Snabisch";
				}
				else if (songown == 5) {
					Title.text = "Irelands Coast Travelog Edition";
					Artist.text = "Matthew Pablo";
				}
				else if (songown == 6) {
					Title.text = "The Old Song";
					Artist.text = "Snabisch";
				}
				else if (songown == 7) {
					Title.text = "Hello";
					Artist.text = "OMFG";
				}
				else if (songown == 8) {
					Title.text = "Sea Star";
					Artist.text = "Snabisch";
				}
				else if (songown == 9) {
					Title.text = "Laser Millenium";
					Artist.text = "Neocrey";
				}
				else if (songown == 10) {
					Title.text = "Disco Century";
					Artist.text = "Neocrey";
				}
				else if (songown == 11) {
					Title.text = "Zombies Also Love To Play The Fool";
					Artist.text = "Alexandr Zhelanov";
				}
				else if (songown == 12) {
					Title.text = "No Joke Is All That Counts";
					Artist.text = "Snabisch";
				}
				else if (songown == 13) {
					Title.text = "Night Adventure";
					Artist.text = "Alexandr Zhelanov";
				}
				else if (songown == 14) {
					Title.text = "Runner";
					Artist.text = "Alexandr Zhelanov";
				}
				else if (songown == 15) {
					Title.text = "Chocolate Addiction";
					Artist.text = "Snabisch";
				}
				Title.interactable = false;
				Artist.interactable = false;
			}
			else {
				Title.text = songname;
				if (PlayerPref.GetString (songname + GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.TotalFrames) == "") {
					PlayerPref.SetString (songname + GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.TotalFrames, point);
				}
				else if (int.Parse(PlayerPref.GetString (songname + GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.TotalFrames)) < int.Parse (point)) {
					PlayerPref.SetString (songname + GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.TotalFrames, point);
				}
			}
		}
		if(Time.time - t1 >= 1 && point1enabled == 2){
			if (tut != 0) {
				Tutorial ();
			}
			else {
				Point1Inner.sizeDelta = new Vector2 (0, 0);
				point1enabled = 1;
				OnClickPoint (Point1Inner);
			}
		}
		else if(point1enabled == 2){
			Point1Inner.sizeDelta = Vector2.Lerp (new Vector2(0, 0), new Vector2(130, 130), Time.time - t1);
		}
		if(Time.time - t2 >= 1 && point2enabled == 2){
			if (tut != 0) {
				Tutorial ();
			}
			else {
				Point2Inner.sizeDelta = new Vector2 (0, 0);
				point2enabled = 1;
				OnClickPoint (Point2Inner);
			}
		}
		else if(point2enabled == 2){
			Point2Inner.sizeDelta = Vector2.Lerp (new Vector2(0, 0), new Vector2(130, 130), Time.time - t2);
		}
		if(Time.time - t3 >= 1 && point3enabled == 2){
			if (tut != 0) {
				Tutorial ();
			}
			else {
				Point3Inner.sizeDelta = new Vector2 (0, 0);
				point3enabled = 1;
				OnClickPoint (Point3Inner);
			}
		}
		else if(point3enabled == 2){
			Point3Inner.sizeDelta = Vector2.Lerp (new Vector2(0, 0), new Vector2(130, 130), Time.time - t3);
		}
		if(Time.time - t4 >= 1 && point4enabled == 2){
			if (tut != 0) {
				Tutorial ();
			}
			else {
				Point4Inner.sizeDelta = new Vector2 (0, 0);
				point4enabled = 1;
				OnClickPoint (Point4Inner);
			}
		}
		else if(point4enabled == 2){
			Point4Inner.sizeDelta = Vector2.Lerp (new Vector2(0, 0), new Vector2(130, 130), Time.time - t4);
		}
		if (Time.time - t5 >= 1 && point5enabled == 2) {
			if (tut != 0) {
				Tutorial ();
			}
			else {
				Point5Inner.sizeDelta = new Vector2 (0, 0);
				point5enabled = 1;
				OnClickPoint (Point5Inner);
			}
		}
		else if(point5enabled == 2){
			Point5Inner.sizeDelta = Vector2.Lerp (new Vector2(0, 0), new Vector2(130, 130), Time.time - t5);
		}
		if (Time.time - t6 >= 1 && point6enabled == 2) {
			if (tut != 0) {
				Tutorial ();
			}
			else {
				Point6Inner.sizeDelta = new Vector2 (0, 0);
				point6enabled = 1;
				OnClickPoint (Point6Inner);
			}
		}
		else if(point6enabled == 2){
			Point6Inner.sizeDelta = Vector2.Lerp (new Vector2(0, 0), new Vector2(130, 130), Time.time - t6);
		}
		if(Time.time - t7 >= 1 && point7enabled == 2){
			if (tut != 0) {
				Tutorial ();
			}
			else {
				Point7Inner.sizeDelta = new Vector2 (0, 0);
				point7enabled = 1;
				OnClickPoint (Point7Inner);
			}
		}
		else if(point7enabled == 2){
			Point7Inner.sizeDelta = Vector2.Lerp (new Vector2(0, 0), new Vector2(130, 130), Time.time - t7);
		}
		if(Time.time - t8 >= 1 && point8enabled == 2){
			if (tut != 0) {
				Tutorial ();
			}
			else {
				Point8Inner.sizeDelta = new Vector2 (0, 0);
				point8enabled = 1;
				OnClickPoint (Point8Inner);
			}
		}
		else if(point8enabled == 2){
			Point8Inner.sizeDelta = Vector2.Lerp (new Vector2(0, 0), new Vector2(130, 130), Time.time - t8);
		}
		if(points.Count != 0){
			AddPoint (points[0], false, 0);
		}
	}
		public void Tutorial (){
			if (Time.timeScale != 0) {
				Time.timeScale = 0;
				GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.Pause ();
				if (tut == 1) {
					display.text = "Tap when the circle is full of color. Try It Now!";
					display.fontSize = 40;
				}
				else if (tut == 2) {
					display.text = "It is better to tap earlier than later!";
					display.fontSize = 40;
				}
				else if (tut == 3) {
					display.text = "Perfect you are getting the hang of it!";
					display.fontSize = 40;
				}
				else if (tut == 4) {
					display.text = "You can also play with your own songs!";
					display.fontSize = 40;
				}
				else if (tut == 5) {
					display.text = "Next time full speed!";
					display.fontSize = 40;
				}
			}
		}
		public void AddPoint (float time, bool controller, int tutint){
		bool array = false;
		float pointx = 0;
		float pointy = 0;
		int id = 0;
		tut = tutint;
		pointsinner.Clear ();
		if(controller == true){
			time = Time.time - time;
		}
		else {
			array = true;
		}
		if (point1enabled == 1)
			pointsinner.Add (1);
		if (point2enabled == 1)
			pointsinner.Add (2);
		if (point3enabled == 1)
			pointsinner.Add (3);
		if (point4enabled == 1)
			pointsinner.Add (4);
		if (point5enabled == 1)
			pointsinner.Add (5);
		if (point6enabled == 1)
			pointsinner.Add (6);
		if (point7enabled == 1)
			pointsinner.Add (7);
		if (point8enabled == 1)
			pointsinner.Add (8);
		if (pointsinner.Count != 0) {
			random1 = Random.Range (1, pointsinner.Count + 1);
			random1 = pointsinner [random1 - 1];
			if (random1 == 1) {
				t1 = time;
				point1enabled = 2;
				pointx = Point1.localPosition.x;
				pointy = Point1.localPosition.y;
				id = 1;
				Point1Inner.GetComponent<SVGImage> ().color = GameObject.Find("Controller").GetComponent<Gradient>().colorrel;
			}
			else if (random1 == 2) {
				t2 = time;
				point2enabled = 2;
				pointx = Point2.localPosition.x;
				pointy = Point2.localPosition.y;
				id = 2;
				Point2Inner.GetComponent<SVGImage> ().color = GameObject.Find("Controller").GetComponent<Gradient>().colorrel;
			}
			else if (random1 == 3) {
				t3 = time;
				point3enabled = 2;
				pointx = Point3.localPosition.x;
				pointy = Point3.localPosition.y;
				id = 3;
				Point3Inner.GetComponent<SVGImage> ().color = GameObject.Find("Controller").GetComponent<Gradient>().colorrel;
			}
			else if (random1 == 4) {
				t4 = time;
				point4enabled = 2;
				pointx = Point4.localPosition.x;
				pointy = Point4.localPosition.y;
				id = 4;
				Point4Inner.GetComponent<SVGImage> ().color = GameObject.Find("Controller").GetComponent<Gradient>().colorrel;
			}
			else if (random1 == 5) {
				t5 = time;
				point5enabled = 2;
				pointx = Point5.localPosition.x;
				pointy = Point5.localPosition.y;
				id = 5;
				Point5Inner.GetComponent<SVGImage> ().color = GameObject.Find("Controller").GetComponent<Gradient>().colorrel;
			}
			else if (random1 == 6) {
				t6 = time;
				point6enabled = 2;
				pointx = Point6.localPosition.x;
				pointy = Point6.localPosition.y;
				id = 6;
				Point6Inner.GetComponent<SVGImage> ().color = GameObject.Find("Controller").GetComponent<Gradient>().colorrel;
			}
			else if (random1 == 7) {
				t7 = time;
				point7enabled = 2;
				pointx = Point7.localPosition.x;
				pointy = Point7.localPosition.y;
				id = 7;
				Point7Inner.GetComponent<SVGImage> ().color = GameObject.Find("Controller").GetComponent<Gradient>().colorrel;
			}
			else if (random1 == 8) {
				t8 = time;
				point8enabled = 2;
				pointx = Point8.localPosition.x;
				pointy = Point8.localPosition.y;
				id = 8;
				Point8Inner.GetComponent<SVGImage> ().color = GameObject.Find("Controller").GetComponent<Gradient>().colorrel;
			}
			if (array == true) {
				points.RemoveAt (0);
			}
			GameObject note = Instantiate (noteprefab);
			note.transform.SetParent (canvas);
			note.GetComponent<Notes> ().id = id;
			note.GetComponent<Notes> ().timer = time;
			note.GetComponent<Notes> ().centroidx = centroidx;
			note.GetComponent<Notes> ().centroidy = centroidy;
			note.GetComponent<Notes> ().pointx = pointx;
			note.GetComponent<Notes> ().pointy = pointy;
		}
		else if (array == false) {
			points.Add (time);
		}
	}

	public void OnClickPoint (RectTransform PointInner) {
		if(Time.timeScale == 0){
			display.fontSize = 80;
			Time.timeScale = 1;
			GameObject.Find ("Controller").GetComponent<VisualizerController> ().rhythmTool.Play ();
		}
		int pointenabled = 0;
		if (PointInner.name == "Point1Inner") {
			pointenabled = point1enabled;
		}
		else if (PointInner.name == "Point2Inner") {
			pointenabled = point2enabled;
		}
		else if (PointInner.name == "Point3Inner") {
			pointenabled = point3enabled;
		}
		else if (PointInner.name == "Point4Inner") {
			pointenabled = point4enabled;
		}
		else if (PointInner.name == "Point5Inner") {
			pointenabled = point5enabled;
		}
		else if (PointInner.name == "Point6Inner") {
			pointenabled = point6enabled;
		}
		else if (PointInner.name == "Point7Inner") {
			pointenabled = point7enabled;
		}
		else if (PointInner.name == "Point8Inner") {
			pointenabled = point8enabled;
		}
		GameObject s = Instantiate (scoreprefab);
		s.transform.SetParent (canvas);
		s.transform.position = PointInner.transform.position;
		s.GetComponent<Point> ().color = PointInner.GetComponent<SVGImage> ().color;
		if (pointenabled == 2) {
			if (PointInner.sizeDelta.x < 20) {
				misspoint++;
				misspointperm++;
				goodpoint = 0;
				greatpoint = 0;
				perfectpoint = 0;
			}
			else if (PointInner.sizeDelta.x < 60) {
				goodpoint++;
				goodpointperm++;
				point = (int.Parse(point) + 20).ToString();
				s.GetComponent<Point> ().score = "+20";
				misspoint = 0;
				greatpoint = 0;
				perfectpoint = 0;
			}
			else if (PointInner.sizeDelta.x < 100) {
				greatpoint++;
				greatpointperm++;
				point = (int.Parse(point) + 30).ToString();
				s.GetComponent<Point> ().score = "+30";
				misspoint = 0;
				goodpoint = 0;
				perfectpoint = 0;
			}
			else {
				perfectpoint++;
				perfectpointperm++;
				misspoint = 0;
				goodpoint = 0;
				greatpoint = 0;
			}
			PointInner.sizeDelta = new Vector2 (0, 0);
			if (PointInner.name == "Point1Inner") {
				point1enabled = 1;
			}
			else if (PointInner.name == "Point2Inner") {
				point2enabled = 1;
			}
			else if (PointInner.name == "Point3Inner") {
				point3enabled = 1;
			}
			else if (PointInner.name == "Point4Inner") {
				point4enabled = 1;
			}
			else if (PointInner.name == "Point5Inner") {
				point5enabled = 1;
			}
			else if (PointInner.name == "Point6Inner") {
				point6enabled = 1;
			}
			else if (PointInner.name == "Point7Inner") {
				point7enabled = 1;
			}
			else if (PointInner.name == "Point8Inner") {
				point8enabled = 1;
			}
		}
		else {
			misspoint++;
			misspointperm++;
			goodpoint = 0;
			greatpoint = 0;
			perfectpoint = 0;
		}
		if(misspoint == 1){
			display.text = "Miss";
			s.GetComponent<Point> ().score = "0";
		}
		else if(misspoint > 1){
			display.text = "Miss x" + misspoint;
			point = (int.Parse(point) - (-10 + (10 * misspoint))).ToString();
			s.GetComponent<Point> ().score = "-" + (-10 + (10 * misspoint));
			missscoreperm += -10 + (10 * misspoint);
		}
		else if(goodpoint == 1){
			display.text = "Good";
		}
		else if(goodpoint > 1){
			display.text = "Good x" + goodpoint;
		}
		else if(greatpoint == 1){
			display.text = "Great";
		}
		else if(greatpoint > 1){
			display.text = "Great x" + greatpoint;
		}
		else if(perfectpoint == 1){
			display.text = "Perfect";
			point = (int.Parse(point) + 50).ToString();
			s.GetComponent<Point> ().score = "+50";
			perfectscoreperm += 50;
		}
		else if(perfectpoint > 1){
			display.text = "Perfect x" + perfectpoint;
			point = (int.Parse(point) + (50 + (10 * perfectpoint))).ToString();
			s.GetComponent<Point> ().score = "+" + (50 + (10 * perfectpoint));
			perfectscoreperm += 50 + (10 * perfectpoint);
		}
	}

	public void Change () {
		foreach(GameObject g in GameObject.FindGameObjectsWithTag("Note")){
			Destroy (g);
		}
		Point1Inner.GetComponent<SVGImage> ().enabled = true;
		Point2Inner.GetComponent<SVGImage> ().enabled = true;
		Point3Inner.GetComponent<SVGImage> ().enabled = true;
		Point4Inner.GetComponent<SVGImage> ().enabled = true;
		Point5Inner.GetComponent<SVGImage> ().enabled = true;
		Point6Inner.GetComponent<SVGImage> ().enabled = true;
		Point7Inner.GetComponent<SVGImage> ().enabled = true;
		Point8Inner.GetComponent<SVGImage> ().enabled = true;
		while(random == oldrandom){
			random = Random.Range (1, 9);
		}
		oldrandom = random;
		Point1Inner.sizeDelta = new Vector2 (0, 0);
		Point2Inner.sizeDelta = new Vector2 (0, 0);
		Point3Inner.sizeDelta = new Vector2 (0, 0);
		Point4Inner.sizeDelta = new Vector2 (0, 0);
		Point5Inner.sizeDelta = new Vector2 (0, 0);
		Point6Inner.sizeDelta = new Vector2 (0, 0);
		Point7Inner.sizeDelta = new Vector2 (0, 0);
		Point8Inner.sizeDelta = new Vector2 (0, 0);
		Point1.GetComponent<SVGImage> ().enabled = false;
		Point2.GetComponent<SVGImage> ().enabled = false;
		Point3.GetComponent<SVGImage> ().enabled = false;
		Point4.GetComponent<SVGImage> ().enabled = false;
		Point5.GetComponent<SVGImage> ().enabled = false;
		Point6.GetComponent<SVGImage> ().enabled = false;
		Point7.GetComponent<SVGImage> ().enabled = false;
		Point8.GetComponent<SVGImage> ().enabled = false;
		point1enabled = 0;
		point2enabled = 0;
		point3enabled = 0;
		point4enabled = 0;
		point5enabled = 0;
		point6enabled = 0;
		point7enabled = 0;
		point8enabled = 0;
		Point1.localPosition = new Vector3 (0,-100,0);
		Point2.localPosition = new Vector3 (0,-100,0);
		Point3.localPosition = new Vector3 (0,-100,0);
		Point4.localPosition = new Vector3 (0,-100,0);
		Point5.localPosition = new Vector3 (0,-100,0);
		Point6.localPosition = new Vector3 (0,-100,0);
		Point7.localPosition = new Vector3 (0,-100,0);
		Point8.localPosition = new Vector3 (0,-100,0);
		if(random == 1){
			Circle ();
		}
		else if(random == 2){
			Heptagon ();
		}
		else if(random == 3){
			Hexagon ();
		}
		else if(random == 4){
			Octogon ();
		}
		else if(random == 5){
			Pentagon ();
		}
		else if(random == 6){
			Rectangle ();
		}
		else if(random == 7){
			Square ();
		}
		else if(random == 8){
			Triangle ();
		}
		if(Point1.GetComponent<SVGImage>().enabled == true){
			point1enabled = 1;
		}
		if(Point2.GetComponent<SVGImage>().enabled == true){
			point2enabled = 1;
		}
		if(Point3.GetComponent<SVGImage>().enabled == true){
			point3enabled = 1;
		}
		if(Point4.GetComponent<SVGImage>().enabled == true){
			point4enabled = 1;
		}
		if(Point5.GetComponent<SVGImage>().enabled == true){
			point5enabled = 1;
		}
		if(Point6.GetComponent<SVGImage>().enabled == true){
			point6enabled = 1;
		}
		if(Point7.GetComponent<SVGImage>().enabled == true){
			point7enabled = 1;
		}
		if(Point8.GetComponent<SVGImage>().enabled == true){
			point8enabled = 1;
		}
	}

	private void Circle (){
		Point1.localPosition = new Vector3 (0,165,0);
		Point2.localPosition = new Vector3 (160,-130,0);
		Point3.localPosition = new Vector3 (0,-425,0);
		Point4.localPosition = new Vector3 (-160,-130,0);
		Point1.GetComponent<SVGImage> ().enabled = true;
		Point2.GetComponent<SVGImage> ().enabled = true;
		Point3.GetComponent<SVGImage> ().enabled = true;
		Point4.GetComponent<SVGImage> ().enabled = true;
		centroidx = (Point1.localPosition.x + Point2.localPosition.x + Point3.localPosition.x + Point4.localPosition.x) / 4;
		centroidy = (Point1.localPosition.y + Point2.localPosition.y + Point3.localPosition.y + Point4.localPosition.y) / 4;
	}

	private void Heptagon (){
		Point1.localPosition = new Vector3 (0,165,0);
		Point2.localPosition = new Vector3 (240,45,0);
		Point3.localPosition = new Vector3 (305,-200,0);
		Point4.localPosition = new Vector3 (125,-425,0);
		Point5.localPosition = new Vector3 (-125,-425,0);
		Point6.localPosition = new Vector3 (-305,-200,0);
		Point7.localPosition = new Vector3 (-240,45,0);
		Point1.GetComponent<SVGImage> ().enabled = true;
		Point2.GetComponent<SVGImage> ().enabled = true;
		Point3.GetComponent<SVGImage> ().enabled = true;
		Point4.GetComponent<SVGImage> ().enabled = true;
		Point5.GetComponent<SVGImage> ().enabled = true;
		Point6.GetComponent<SVGImage> ().enabled = true;
		Point7.GetComponent<SVGImage> ().enabled = true;
		centroidx = (Point1.localPosition.x + Point2.localPosition.x + Point3.localPosition.x + Point4.localPosition.x + Point5.localPosition.x + Point6.localPosition.x + Point7.localPosition.x) / 7;
		centroidy = (Point1.localPosition.y + Point2.localPosition.y + Point3.localPosition.y + Point4.localPosition.y + Point5.localPosition.y + Point6.localPosition.y + Point7.localPosition.y) / 7;
	}

	private void Hexagon (){
		Point1.localPosition = new Vector3 (140,140,0);
		Point2.localPosition = new Vector3 (295,-110,0);
		Point3.localPosition = new Vector3 (140,-390,0);
		Point4.localPosition = new Vector3 (-140,-390,0);
		Point5.localPosition = new Vector3 (-295,-110,0);
		Point6.localPosition = new Vector3 (-140,140,0);
		Point1.GetComponent<SVGImage> ().enabled = true;
		Point2.GetComponent<SVGImage> ().enabled = true;
		Point3.GetComponent<SVGImage> ().enabled = true;
		Point4.GetComponent<SVGImage> ().enabled = true;
		Point5.GetComponent<SVGImage> ().enabled = true;
		Point6.GetComponent<SVGImage> ().enabled = true;
		centroidx = (Point1.localPosition.x + Point2.localPosition.x + Point3.localPosition.x + Point4.localPosition.x + Point5.localPosition.x + Point6.localPosition.x) / 6;
		centroidy = (Point1.localPosition.y + Point2.localPosition.y + Point3.localPosition.y + Point4.localPosition.y + Point5.localPosition.y + Point6.localPosition.y) / 6;
	}

	private void Octogon (){
		Point1.localPosition = new Vector3 (110,165,0);
		Point2.localPosition = new Vector3 (300,-20,0);
		Point3.localPosition = new Vector3 (300,-240,0);
		Point4.localPosition = new Vector3 (110,-425,0);
		Point5.localPosition = new Vector3 (-110,-425,0);
		Point6.localPosition = new Vector3 (-300,-240,0);
		Point7.localPosition = new Vector3 (-300,-20,0);
		Point8.localPosition = new Vector3 (-110,165,0);
		Point1.GetComponent<SVGImage> ().enabled = true;
		Point2.GetComponent<SVGImage> ().enabled = true;
		Point3.GetComponent<SVGImage> ().enabled = true;
		Point4.GetComponent<SVGImage> ().enabled = true;
		Point5.GetComponent<SVGImage> ().enabled = true;
		Point6.GetComponent<SVGImage> ().enabled = true;
		Point7.GetComponent<SVGImage> ().enabled = true;
		Point8.GetComponent<SVGImage> ().enabled = true;
		centroidx = (Point1.localPosition.x + Point2.localPosition.x + Point3.localPosition.x + Point4.localPosition.x + Point5.localPosition.x + Point6.localPosition.x + Point7.localPosition.x + Point8.localPosition.x) / 8;
		centroidy = (Point1.localPosition.y + Point2.localPosition.y + Point3.localPosition.y + Point4.localPosition.y + Point5.localPosition.y + Point6.localPosition.y + Point7.localPosition.y + Point8.localPosition.y) / 8;
	}

	private void Pentagon (){
		Point1.localPosition = new Vector3 (0,165,0);
		Point2.localPosition = new Vector3 (295,-70,0);
		Point3.localPosition = new Vector3 (180,-425,0);
		Point4.localPosition = new Vector3 (-180,-425,0);
		Point5.localPosition = new Vector3 (-295,-70,0);
		Point1.GetComponent<SVGImage> ().enabled = true;
		Point2.GetComponent<SVGImage> ().enabled = true;
		Point3.GetComponent<SVGImage> ().enabled = true;
		Point4.GetComponent<SVGImage> ().enabled = true;
		Point5.GetComponent<SVGImage> ().enabled = true;
		centroidx = (Point1.localPosition.x + Point2.localPosition.x + Point3.localPosition.x + Point4.localPosition.x + Point5.localPosition.x) / 5;
		centroidy = (Point1.localPosition.y + Point2.localPosition.y + Point3.localPosition.y + Point4.localPosition.y + Point5.localPosition.y) / 5;
	}

	private void Rectangle (){
		Point1.localPosition = new Vector3 (300,105,0);
		Point2.localPosition = new Vector3 (300,-350,0);
		Point3.localPosition = new Vector3 (-300,-350,0);
		Point4.localPosition = new Vector3 (-300,105,0);
		Point1.GetComponent<SVGImage> ().enabled = true;
		Point2.GetComponent<SVGImage> ().enabled = true;
		Point3.GetComponent<SVGImage> ().enabled = true;
		Point4.GetComponent<SVGImage> ().enabled = true;
		centroidx = (Point1.localPosition.x + Point2.localPosition.x + Point3.localPosition.x + Point4.localPosition.x) / 4;
		centroidy = (Point1.localPosition.y + Point2.localPosition.y + Point3.localPosition.y + Point4.localPosition.y) / 4;
	}

	private void Square (){
		Point1.localPosition = new Vector3 (300,165,0);
		Point2.localPosition = new Vector3 (300,-425,0);
		Point3.localPosition = new Vector3 (-300,-425,0);
		Point4.localPosition = new Vector3 (-300,165,0);
		Point1.GetComponent<SVGImage> ().enabled = true;
		Point2.GetComponent<SVGImage> ().enabled = true;
		Point3.GetComponent<SVGImage> ().enabled = true;
		Point4.GetComponent<SVGImage> ().enabled = true;
		centroidx = (Point1.localPosition.x + Point2.localPosition.x + Point3.localPosition.x + Point4.localPosition.x) / 4;
		centroidy = (Point1.localPosition.y + Point2.localPosition.y + Point3.localPosition.y + Point4.localPosition.y) / 4;
	}

	private void Triangle (){
		Point1.localPosition = new Vector3 (0,140,0);
		Point2.localPosition = new Vector3 (300,-395,0);
		Point3.localPosition = new Vector3 (-300,-395,0);
		Point1.GetComponent<SVGImage> ().enabled = true;
		Point2.GetComponent<SVGImage> ().enabled = true;
		Point3.GetComponent<SVGImage> ().enabled = true;
		centroidx = (Point1.localPosition.x + Point2.localPosition.x + Point3.localPosition.x) / 3;
		centroidy = (Point1.localPosition.y + Point2.localPosition.y + Point3.localPosition.y) / 3;
	}
}