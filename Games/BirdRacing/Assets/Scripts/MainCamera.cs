using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(other.tag == "Bird"){
			other.transform.Find("Mats").gameObject.SetActive(false);
		}
	}

	void OnTriggerExit(Collider other){
		if(other.tag == "Bird"){
			other.transform.Find("Mats").gameObject.SetActive(true);
		}
	}
}
