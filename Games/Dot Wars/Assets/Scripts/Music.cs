using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	private static AudioSource instance;

	void Awake () {
		if (instance != null && instance != GetComponent<AudioSource>()) {
			Destroy(gameObject);
			return;
		}
		else {
			instance = GetComponent<AudioSource>();
		}
		DontDestroyOnLoad(gameObject);
	}
}
