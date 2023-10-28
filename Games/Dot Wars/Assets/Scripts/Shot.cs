using UnityEngine;
using System.Collections;
using SVGImporter;

public class Shot : MonoBehaviour {

	void Start () {
		GetComponent<TrailRenderer> ().sortingOrder = -100;
		StartCoroutine(ShotEnd());
	}

	/*void OnTriggerEnter2D (Collider2D other){
		if(other.gameObject.name == "Player2Bot" || other.gameObject.name == "Player3Bot" || other.gameObject.name == "Player4Bot"){
			if(other.GetComponentInParent<Bot>().enabled == true){
				other.GetComponentInParent<Bot>().jump = true;
				other.GetComponentInParent<Bot>().jumpshot = true;
			}
		}
	}*/

	IEnumerator ShotEnd (){
		yield return new WaitForSeconds (0.1f);
		GetComponent<CircleCollider2D> ().enabled = true;
		for (int i = 0; i < 28; i++) {
			if ((transform.localPosition.x * transform.localPosition.x) + (transform.localPosition.y * transform.localPosition.y) > 42000) {
				Destroy (gameObject);
			}
			else {
				yield return new WaitForSeconds (0.1f);
			}
		}
		Destroy (gameObject);
	}
}
