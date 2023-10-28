using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {
	public RectTransform Audio2;
	private float time;

	void Start () {
		StartCoroutine (LoadMain());
		time = Time.time;
	}

	void Update () {
		if((Time.time - time) * 2 >= 1){
			time = Time.time;
		}
		Audio2.anchoredPosition = Vector2.Lerp(new Vector2 (20, -100), new Vector2 (35, -100), (Time.time - time) * 2);
	}

	IEnumerator LoadMain(){
		yield return new WaitForSeconds(1);
		SceneManager.LoadSceneAsync (1);
	}
}
