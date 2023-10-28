using UnityEngine;
using System.Collections;

public class AutoMatch : MonoBehaviour {
	public GameObject MultiplayerAutoMatch;
	public GameObject MultiplayerAutoMatchLoading;
	public GameObject MultiplayerAutoMatchError;
	public int player = 0;
	public int ID = 0;
	public int Bot = 0;
	public bool tut = false;
	private bool ready = false;
	
	public void OnClickAutoMatch(){
		StartCoroutine (AutoMatcher ());
		MultiplayerAutoMatch.SetActive (false);
		MultiplayerAutoMatchLoading.SetActive (true);
	}

	public void OnClickAutoMatchErrorBack (){
		MultiplayerAutoMatchError.SetActive (false);
		MultiplayerAutoMatch.SetActive (true);
	}
	
	IEnumerator AutoMatcher () {
		WWW w = new WWW("http://kbvstudios.com/dotwars/dotwarsgamecreatorupload.php");
		yield return w;
		if(w.text.Length > 0){
			if(w.text.Substring(0, 1) == "1" || w.text.Substring(0, 1) == "2" || w.text.Substring(0, 1) == "3" || w.text.Substring(0, 1) == "4"){
				player = int.Parse(w.text.Substring (0, 1));
				ID = int.Parse(w.text.Substring (1));	
			}
			else{
				NoConnection();
				StopAllCoroutines();
			}
		}
		else{
			NoConnection();
			StopAllCoroutines();
		}
		WWWForm form = new WWWForm();
		form.AddField("ID", ID);
		form.AddField("Player", player);
		while(ready == false){
			WWW w1 = new WWW("http://kbvstudios.com/dotwars/dotwarsgamecreatorcheck.php", form);
			yield return w1;
			if(w1.text == "Ready"){
				Bot = 0;
				ready = true;
			}
			else if(w1.text == "1Ready"){
				Bot = 3;
				ready = true;
			}
			else if(w1.text == "2Ready"){
				Bot = 2;
				ready = true;
			}
			else if(w1.text == "3Ready"){
				Bot = 1;
				ready = true;
			}
			else if(w1.text == "Not Ready"){
				yield return new WaitForSeconds(0.5f);
			}
			else{
				NoConnection();
				StopAllCoroutines();
			}
		}
		DontDestroyOnLoad (this.gameObject);
		Application.LoadLevel (2);
	}

	void NoConnection(){
		MultiplayerAutoMatchLoading.SetActive (false);
		MultiplayerAutoMatchError.SetActive (true);
	}
}
