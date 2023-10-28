using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SVGImporter;

public class EveryplayTest : MonoBehaviour
{
	public GameObject rec1;
	public GameObject rec2;
	public GameObject rec3;
	public GameObject pause;
	public GameObject resume;
	public SVGImage background1;
	public SVGImage background2;
	public SVGImage background3;
	public SVGImage background4;
	public SVGImage background5;
	public SVGImage background6;
	public SVGImage background7;
	public Text time;
	public bool supported;
	private Gradient gr;
	private float lastsec;
	private float lastsec1;
	private int min;
	private int sec;

	void Start()
	{
		gr = GameObject.Find ("Controller").GetComponent<Gradient>();
		if (!Everyplay.IsRecordingSupported ()) {
			rec1.SetActive (false);
			rec2.SetActive (false);
			rec3.SetActive (false);
		}
		else {
			supported = true;
			Everyplay.RecordingStarted += RecordingStarted;
			Everyplay.RecordingStopped += RecordingStopped;

			Everyplay.UploadDidStart += UploadDidStart;
			Everyplay.UploadDidProgress += UploadDidProgress;
			Everyplay.UploadDidComplete += UploadDidComplete;
		}
	}

	void Update(){
		if (rec1.activeSelf == true) {
			background1.color = gr.colorrel;
		}
		else if (rec2.activeSelf == true) {
			background2.color = gr.colorrel;
			background3.color = gr.colorrel;
			background4.color = gr.colorrel;
		}
		else if (rec3.activeSelf == true) {
			background5.color = gr.colorrel;
			background6.color = gr.colorrel;
			background7.color = gr.colorrel;
		}
		//when rec start set Lastsec to Time.time
		if(lastsec != 0 && (Time.time - lastsec) >= 1){
			lastsec++;
			sec++;
			if(sec == 60){
				sec = 0;
				min++;
			}
			time.text = min + ":" + sec.ToString ("00");
		}
	}

    public void Destroy()
	{
        Everyplay.RecordingStarted -= RecordingStarted;
        Everyplay.RecordingStopped -= RecordingStopped;

		Everyplay.UploadDidStart -= UploadDidStart;
		Everyplay.UploadDidProgress -= UploadDidProgress;
		Everyplay.UploadDidComplete -= UploadDidComplete;
    }

	public void OnClick(int clickid){
		if(clickid == 1){
			Everyplay.StartRecording();
		}
		else if(clickid == 2){
			Everyplay.StopRecording();
		}
		else if(clickid == 3){
			Everyplay.PauseRecording();
			pause.SetActive (false);
			resume.SetActive (true);
			lastsec1 = Time.time - lastsec;
			lastsec = 0;
		}
		else if(clickid == 4){
			Everyplay.ResumeRecording();
			resume.SetActive (false);
			pause.SetActive (true);
			lastsec = Time.time - lastsec;
			lastsec1 = 0;
		}
		else if(clickid == 5){
			Everyplay.PlayLastRecording();
		}
		else if(clickid == 6){
			Everyplay.ShowSharingModal();
		}
	}

    private void RecordingStarted()
    {
		time.text = "0:00";
		lastsec = Time.time;
		rec3.SetActive (false);
		rec1.SetActive (false);
		rec2.SetActive (true);
		resume.SetActive (false);
		pause.SetActive (true);
    }

    private void RecordingStopped()
    {
		lastsec = 0;
		lastsec1 = 0;
		sec = 0;
		min = 0;
		rec1.SetActive (false);
		rec2.SetActive (false);
		rec3.SetActive (true);
    }

    private void UploadDidStart(int videoId)
    {

    }

    private void UploadDidProgress(int videoId, float progress)
    {
		
    }

    private void UploadDidComplete(int videoId)
    {
        StartCoroutine(ResetUploadStatusAfterDelay(2.0f));
    }

    private IEnumerator ResetUploadStatusAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);
    }
}
