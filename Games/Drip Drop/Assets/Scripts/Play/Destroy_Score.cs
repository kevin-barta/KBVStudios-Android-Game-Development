using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class Destroy_Score : MonoBehaviour {

	private int myScore = 0;
	private int lives = 0;
	static private string Textscore;
	public GoogleAnalyticsV4 googleAnalytics;
	public TextMesh TextObject;
	public TextMesh Buckets;
	private int ScoreReset = 0;
	private int Score0 = 50;
	private int Score1 = 100;
	private int Score2 = 150;
	private int Score3 = 200;
	private int Score4 = 300;
	private int Score5 = 400;
	private int Score6 = 500;
	private int Score7 = 700;
	private int Score8 = 800;
	public BannerView bannerView;
	public AudioClip myLife;
	public AudioClip LoseLife;

	void Start () {
		Time.timeScale = 1.0f;
		PlayerPrefs.SetInt ("Lives-Left", 2 );
		PlayerPrefs.Save ();
		Buckets.text = ("Lives: " + 2);
		PlayerPrefs.SetInt ("GameScore", 0 );
		PlayerPrefs.Save ();
		System.GC.Collect();
		Resources.UnloadUnusedAssets();
		googleAnalytics.LogScreen("Game");
		bannerView = new BannerView("ca-app-pub-8870763355959902/9639491470", AdSize.Banner, AdPosition.Top);
		AdRequest request = new AdRequest.Builder().Build();
		bannerView.LoadAd(request);
	}

	void Update (){
		if (myScore >= ScoreReset) {
			Time.timeScale = 1.0f;
		}
		if (myScore >= Score0) {
			Time.timeScale = 1.1f;
		}
		if (myScore >= Score1) {
			Time.timeScale = 1.15f;
		}
		if (myScore >= Score2) {
		Time.timeScale = 1.2f;
		}
		if (myScore >= Score3) {
			Time.timeScale = 1.25f;
		}
		if (myScore >= Score4) {
			Time.timeScale = 1.3f;
		}
		if (myScore >= Score5) {
			Time.timeScale = 1.35f;
		}
		if (myScore >= Score6) {
			Time.timeScale = 1.4f;
		}
		if (myScore >= Score7) {
			Time.timeScale = 1.45f;
		}
		if (myScore >= Score8) {
			Time.timeScale = 1.5f;
		}

	}
	
	void OnTriggerEnter2D(Collider2D collisionObject) {

		if (collisionObject.gameObject.tag == "Driplet") {
						Destroy (collisionObject.gameObject);
						myScore = myScore + 5;
						PlayerPrefs.SetInt ("GameScore", myScore);
						PlayerPrefs.Save ();
						TextObject.text = "Score: " + myScore;
				} 
		else if (collisionObject.gameObject.tag == "Dirty") {
						if (PlayerPrefs.GetInt ("Lives-Left") > 0) {
								Destroy (collisionObject.gameObject);
				                GetComponent<AudioSource>().PlayOneShot (LoseLife);
				                lives = PlayerPrefs.GetInt ("Lives-Left");
				                lives = lives - 1;
				                PlayerPrefs.SetInt ("Lives-Left", lives);
								PlayerPrefs.Save ();
				                Buckets.text = ("Lives: " + PlayerPrefs.GetInt("Lives-Left"));
						}
			            else if (PlayerPrefs.GetInt ("Lives-Left") == 0) {
				                Destroy (collisionObject.gameObject);
				                if (PlayerPrefs.GetInt ("GameScore") > PlayerPrefs.GetInt ("HighScore")) {
				                PlayerPrefs.SetInt ("HighScore", PlayerPrefs.GetInt ("GameScore"));
				                PlayerPrefs.Save ();
				                }
				                PlayerPrefs.Save ();
				                Time.timeScale = 1.0f;
								googleAnalytics.LogScreen("Died: " + myScore);
								bannerView.Destroy();
				                Application.LoadLevel (2);
		
			         }
		      }
		else if (collisionObject.gameObject.tag == "Live") {
				Destroy (collisionObject.gameObject);
			    GetComponent<AudioSource>().PlayOneShot (myLife);
			    lives = PlayerPrefs.GetInt ("Lives-Left");
			    lives = lives + 1;
				PlayerPrefs.SetInt ("Lives-Left", lives);
				PlayerPrefs.Save ();
				Buckets.text = ("Lives: " + PlayerPrefs.GetInt("Lives-Left"));
			}
		}
	}