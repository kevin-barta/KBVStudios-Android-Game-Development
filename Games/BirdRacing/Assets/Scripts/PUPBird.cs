using UnityEngine;
using System.Collections;

public class PUPBird : MonoBehaviour {
	public GameObject BigBang;
	public GameObject LandMine;
	public string BirdCreate = "";
	public int Rank;
	public GameObject BirdPos;
	private GameObject BirdToPos;
	private GameObject MainC;
	private Transform BirdEggBlueTransform;
	private Transform BirdEggRedTransform;
	private Vector3 BirdPosVector3;
	private Vector3 BirdToPosVector3;
	public bool done = false;
	private bool Det = false;
	private float timestarted;

	void Awake (){
		MainC = GameObject.Find ("Main Camera");
		StartCoroutine (WaitPUPBird ());
	}

	void Start(){
		if(gameObject.tag == "PUP_RottenEgg"){
			StartCoroutine(RottenEgg());
		}
		if(gameObject.tag == "PUP_BirdEggRed"){
			Rank = Rank - 1;
			if(Rank != 0){
				GameObject MainMenu = GameObject.Find("MainMenu");
				int Bird1 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird1;
				int Bird2 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird2;
				int Bird3 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird3;
				int Bird4 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird4;
				int Bird5 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird5;
				int Bird6 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird6;
				int Bird7 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird7;
				int Bird8 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird8;
				timestarted = Time.time;
				if(Rank == Bird1){
					BirdToPos = GameObject.Find ("bird1");
				}
				else if(Rank == Bird2){
					BirdToPos = GameObject.Find ("bird2");
				}
				else if(Rank == Bird3){
					BirdToPos = GameObject.Find ("bird3");
				}
				else if(Rank == Bird4){
					BirdToPos = GameObject.Find ("bird4");
				}
				else if(Rank == Bird5){
					BirdToPos = GameObject.Find ("bird5");
				}
				else if(Rank == Bird6){
					BirdToPos = GameObject.Find ("bird6");
				}
				else if(Rank == Bird7){
					BirdToPos = GameObject.Find ("bird7");
				}
				else if(Rank == Bird8){
					BirdToPos = GameObject.Find ("bird8");
				}
			}
		}
		if(gameObject.tag == "PUP_BirdEggBlue"){
			if(Rank != 1){
				GameObject MainMenu = GameObject.Find("MainMenu");
				int Bird1 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird1;
				int Bird2 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird2;
				int Bird3 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird3;
				int Bird4 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird4;
				int Bird5 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird5;
				int Bird6 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird6;
				int Bird7 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird7;
				int Bird8 = MainMenu.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird8;
				timestarted = Time.time;
				if(Bird1 == 1){
					BirdToPos = GameObject.Find ("bird1");
				}
				else if(Bird2 == 1){
					BirdToPos = GameObject.Find ("bird2");
				}
				else if(Bird3 == 1){
					BirdToPos = GameObject.Find ("bird3");
				}
				else if(Bird4 == 1){
					BirdToPos = GameObject.Find ("bird4");
				}
				else if(Bird5 == 1){
					BirdToPos = GameObject.Find ("bird5");
				}
				else if(Bird6 == 1){
					BirdToPos = GameObject.Find ("bird6");
				}
				else if(Bird7 == 1){
					BirdToPos = GameObject.Find ("bird7");
				}
				else if(Bird8 == 1){
					BirdToPos = GameObject.Find ("bird8");
				}
			}
		}
	}

	void Update (){
		if(MainC != null){
			gameObject.transform.rotation = MainC.transform.rotation;
		}
		if(gameObject.tag == "PUP_BirdEggRed"){
			if(Rank != 0){
				if(done == false && (Time.time - timestarted)/2 > 1){
					StartCoroutine(WaitDone());
				}
				if(done == false){
					BirdPosVector3 = new Vector3 (BirdPos.transform.position.x, BirdPos.transform.position.y + 50, BirdPos.transform.position.z);
					BirdToPosVector3 = new Vector3(BirdToPos.transform.position.x, BirdToPos.transform.position.y + 50, BirdToPos.transform.position.z);
					gameObject.transform.position = Vector3.Lerp(BirdPosVector3, BirdToPosVector3, (Time.time - timestarted)/2);
				}
				else if(done == true){
					gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, BirdToPos.transform.position, (Time.time - timestarted)* 10);
				}
			}
		}
		if(gameObject.tag == "PUP_BirdEggBlue"){
			if(Rank != 1){
				if(done == false && (Time.time - timestarted)/2 > 1){
					StartCoroutine(WaitDone());
				}
				if(done == false){
					BirdPosVector3 = new Vector3 (BirdPos.transform.position.x, BirdPos.transform.position.y + 50, BirdPos.transform.position.z);
					BirdToPosVector3 = new Vector3(BirdToPos.transform.position.x, BirdToPos.transform.position.y + 50, BirdToPos.transform.position.z);
					gameObject.transform.position = Vector3.Lerp(BirdPosVector3, BirdToPosVector3, (Time.time - timestarted)/2);
				}
				else if(done == true){
					gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, BirdToPos.transform.position, (Time.time - timestarted)* 10);
				}
			}
		}
	}

	void OnTriggerEnter (Collider other){
		if(other.tag == "Bird1" || other.tag == "Bird2" || other.tag == "Bird3" || other.tag == "Bird4" || other.tag == "Bird5" || other.tag == "Bird6" || other.tag == "Bird7" || other.tag == "Bird8"){
			if(other.tag != BirdCreate){
				if(gameObject.tag == "PUP_BirdPoop"){
					other.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().ThrottleChanger(0f);
					Destroy (this.gameObject);
				}
				else if(gameObject.tag == "PUP_BirdEggRed"){
					if(timestarted != 1){
						timestarted = 1;
						BirdEggRedTransform = other.transform;
						StartCoroutine(DetonateBirdEggRed());
						other.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().ThrottleChanger(0f);
					}
				}
				else if(gameObject.tag == "PUP_BirdEggBlue"){
					if(timestarted != 1){
						timestarted = 1;
						BirdEggBlueTransform = other.transform;
						StartCoroutine(DetonateBirdEggBlue());
						other.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().ThrottleChanger(0f);
					}
				}
				else if(gameObject.tag == "PUP_RottenEgg"){
					if(Det == false){
						Det = true;
						gameObject.GetComponent<BoxCollider>().enabled = false;
						gameObject.GetComponent<SphereCollider>().enabled = true;
						StartCoroutine(DetonateRottenEgg());
					}
					other.GetComponent<UnitySampleAssets.Vehicles.Aeroplane.AeroplaneController>().ThrottleChanger(0f);
				}
			}
		}
	}

	IEnumerator WaitPUPBird(){
		yield return new WaitForSeconds (1);
		BirdCreate = "";
	}

	IEnumerator RottenEgg (){
		yield return new WaitForSeconds (5);
		gameObject.GetComponent<BoxCollider>().enabled = false;
		gameObject.GetComponent<SphereCollider>().enabled = true;
		if(Det == false){
			Det = true;
			StartCoroutine(DetonateRottenEgg());
		}
	}

	IEnumerator DetonateRottenEgg (){
		GameObject DetRottenEgg = (GameObject) Instantiate(BigBang, transform.position, transform.rotation);
		yield return new WaitForSeconds(1);
		gameObject.GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0, 0);
		yield return new WaitForSeconds(3);
		Destroy(DetRottenEgg);
		Destroy (this.gameObject);
	}

	IEnumerator DetonateBirdEggRed(){
		GameObject DetBirdEggRed = (GameObject) Instantiate(LandMine, transform.position, transform.rotation);
		DetBirdEggRed.transform.parent = BirdEggRedTransform;
		Destroy(DetBirdEggRed.transform.Find ("Landmine1").gameObject);
		yield return new WaitForSeconds(0.1f);
		gameObject.GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0, 0);
		yield return new WaitForSeconds(1.9f);
		Destroy(DetBirdEggRed);
		Destroy (this.gameObject);
	}

	IEnumerator DetonateBirdEggBlue(){
		GameObject DetBirdEggBlue = (GameObject) Instantiate(LandMine, transform.position, transform.rotation);
		DetBirdEggBlue.transform.parent = BirdEggBlueTransform;
		Destroy(DetBirdEggBlue.transform.Find ("Landmine2").gameObject);
		yield return new WaitForSeconds(0.1f);
		gameObject.GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0, 0);
		yield return new WaitForSeconds(1.9f);
		Destroy(DetBirdEggBlue);
		Destroy (this.gameObject);
	}

	IEnumerator WaitDone (){
		yield return new WaitForSeconds(0.5f);
		done = true;
		timestarted = Time.time;
	}
}
