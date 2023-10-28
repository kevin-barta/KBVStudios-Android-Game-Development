using UnityEngine;
using System.Collections;

public class NotDestroy : MonoBehaviour {

	void Awake () {
		DontDestroyOnLoad (gameObject);
	}
}
