using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Point : MonoBehaviour {
	public string score;
	public Color color;
	private float time;

	void Start () {
		transform.localScale = new Vector3(1, 1, 1);
		GetComponent<Text> ().color = color;
		GetComponent<Text> ().text = score;
		time = Time.time;
		Destroy(gameObject, 1);
	}

	void Update () {
		GetComponent<Text> ().color = new Color (color.r, color.g, color.b, 1 - (Time.time - time));
		transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y + 100 * Time.deltaTime, transform.localPosition.z);
	}
}
