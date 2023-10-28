using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SVGImporter;

//In this "game", the controller uses data from the analyses is used to create some simple visuals.
public class BackgroundSong : MonoBehaviour
{

	/// <summary>
	/// RythmTool.
	/// </summary>
	public RhythmTool rhythmTool;


	public AudioClip Song;
	public SVGImage Circle;
	public SVGImage CircleInner;
	public bool initialized = false;
	private int lastFrame;
	private Analysis low;
	private Vector2 Bounce = new Vector2(120, 120);
	private float time;
	private float onset;
	private int TotalFrames;
	private int CurrentFrame;

	void Start()
	{
		rhythmTool.NewSong(Song);
		Application.runInBackground = true;

		rhythmTool = GetComponent<RhythmTool>();
	}


	void OnReadyToPlay()
	{
		//Start playing and analyzing the song.
		rhythmTool.Play ();
		low = rhythmTool.Low;
		lastFrame = 0;
		TotalFrames = rhythmTool.TotalFrames - 1;
		CurrentFrame = 0;

		initialized = true;
	}

	// Update is called once per frame
	void Update ()
	{
		if (TotalFrames <= CurrentFrame) {
			initialized = false;
		}

		//If not initialized for some reason (no song loaded), don't do anything.
		if (!initialized) {
			OnReadyToPlay ();
			return;
		}
		if(rhythmTool.CurrentFrame != 0){
			CurrentFrame = rhythmTool.CurrentFrame;
		}

		for (int i = lastFrame+1; i<rhythmTool.CurrentFrame; i++) {

			if (i > rhythmTool.TotalFrames - 1) {
				break;
			}
			//if there is an onset, create a new line representing this onset.
			Bounce = Vector2.Lerp (Bounce, new Vector2 (120, 120), (Time.time - time) / 2);
			if(CircleInner.enabled == false){
				Circle.rectTransform.sizeDelta = Bounce;
				CircleInner.rectTransform.offsetMax = new Vector2(30, 30);
				CircleInner.rectTransform.sizeDelta = new Vector2(60, 60);
			}
			else{
				Circle.rectTransform.sizeDelta = new Vector2(120, 120);
				CircleInner.rectTransform.offsetMax = new Vector2(30 * (Bounce.x / 120), 30 * (Bounce.x / 120));
				CircleInner.rectTransform.sizeDelta = new Vector2(Bounce.x / 2, Bounce.x / 2);
			}
			if (low.GetOnset (i) > 0) {
				onset = 120 + low.GetOnset (i);
				if (Bounce.x < onset) {
					if(onset > 160){
						onset = 160;
					}
					Bounce = new Vector2 (onset, onset);
					time = Time.time;
				}
			}
			lastFrame = i;
		}
	}
}
