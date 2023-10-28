using UnityEngine;
using System.Collections;

public class Dots : MonoBehaviour {
	public float time;
	public float posx;
	public float posy;
	public float oldposx;
	public float oldposy;
	public float startingposx;
	public float startingposy;

	void Start(){
		startingposx = transform.localPosition.x;
		startingposy = transform.localPosition.y;
		oldposx = startingposx;
		oldposy = startingposy;
		GetComponent<TrailRenderer> ().time = 0f;
		StartCoroutine(TR ());
	}

	void Update (){
		if(Time.time - time <= 0.1f){
			transform.localPosition = Vector3.Lerp (new Vector3(oldposx, oldposy, 0), new Vector3(posx, posy, 0), (Time.time - time) * 10f);
		}
	}

	IEnumerator TR() {
		GetComponent<TrailRenderer> ().sortingOrder = -50;
		yield return new WaitForSeconds (0.1f);
		GetComponent<TrailRenderer> ().time = 0.5f;
	}
}