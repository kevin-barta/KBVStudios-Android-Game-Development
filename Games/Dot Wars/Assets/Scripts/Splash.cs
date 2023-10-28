using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

	void Start () {
		StartCoroutine(Next());
	}

	IEnumerator Next () {
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene(1);
	}
}
