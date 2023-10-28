using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	private int lives = 0;
	public TextMesh Buckets;
	public TextMesh Score;
	public GoogleAnalyticsV4 googleAnalytics;
	public Destroy_Score Destroy1;

	void OnTriggerEnter2D(Collider2D collisionObject) {

		if (collisionObject.gameObject.tag == "Driplet") {
						Destroy (collisionObject.gameObject);
			     if (PlayerPrefs.GetInt ("Lives-Left") > 0) {
				 Destroy (collisionObject.gameObject);
				 lives = PlayerPrefs.GetInt ("Lives-Left");
				 lives = lives - 1;
				 PlayerPrefs.SetInt ("Lives-Left", lives);
				 PlayerPrefs.Save ();
				 Buckets.text = ("Lives: " + PlayerPrefs.GetInt("Lives-Left"));
			     }
			     else if (PlayerPrefs.GetInt ("Lives-Left") == 0) {
						        if (PlayerPrefs.GetInt ("GameScore") > PlayerPrefs.GetInt ("HighScore")) {
								PlayerPrefs.SetInt ("HighScore", PlayerPrefs.GetInt ("GameScore"));
								PlayerPrefs.Save ();
						        }
						        Time.timeScale = 1.0f;
				                Destroy (collisionObject.gameObject);
								googleAnalytics.LogScreen("Died: " + Score.text.Substring(7));
								Destroy1.bannerView.Destroy();
						        Application.LoadLevel (2);
			                    }
				}
		 else if (collisionObject.gameObject.tag == "Dirty") {
						Destroy (collisionObject.gameObject);
				}
		 else if (collisionObject.gameObject.tag == "Live") {
			Destroy (collisionObject.gameObject);
		}
	}
}