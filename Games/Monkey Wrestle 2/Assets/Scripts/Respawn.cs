using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Respawn : MonoBehaviour {

	public Transform Players;
	public Slider Health;
	float timer;
	float healthtimer;

	// Use this for initialization
	void Start () {
		
	}

	void Update () {
		if(timer > 2f){
			Players.position = new Vector3(104, 130, 0);
			Players.eulerAngles = new Vector3(0, 0, 0);
			timer = 0;
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "land" && Time.time - healthtimer > 0.5f) {
			healthtimer = Time.time;
			if (gameObject.name == "HeadP1") {
				Health.value -= Mathf.Pow(other.relativeVelocity.magnitude, 2) / 100;
			}
			else{
				Health.value += Mathf.Pow(other.relativeVelocity.magnitude, 2) / 100;
			}
		}
	}

	void OnCollisionStay2D(Collision2D other)
	{
		if (other.gameObject.tag == "land")
			timer += Time.deltaTime;
	}

	void OnCollisionExit2D(Collision2D other)
	{
		timer = 0;
	}
}
