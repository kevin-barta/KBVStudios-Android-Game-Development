using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PUP : MonoBehaviour {
	private int BirdRank = 0;
	private int PUPItem = 0;

	//1 Bird Poop 1
	//2 Bird Poop 2
	//3 Worms 1
	//4 Worms 2
	//5 Red Egg 1
	//6 Red Egg 2
	//7 Blue Egg
	//8 Rotten Egg
	//9 Fish
	//10 Oil
	//11 Teleport

	void OnTriggerEnter (Collider other){
		if(other.tag == "Bird1" || other.tag == "Bird2" || other.tag == "Bird3" || other.tag == "Bird4" || other.tag == "Bird5" || other.tag == "Bird6" || other.tag == "Bird7" || other.tag == "Bird8"){
			GameObject PUP2 = GameObject.Find (other.tag + "PUP_2");
			if(PUP2.GetComponent<SpriteRenderer>().sprite == null){
				GameObject _Ranking = GameObject.Find("MainMenu");
				if(other.tag == "Bird1"){
					BirdRank = _Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird1;
				}
				else if(other.tag == "Bird2"){
					BirdRank = _Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird2;
				}
				else if(other.tag == "Bird3"){
					BirdRank = _Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird3;
				}
				else if(other.tag == "Bird4"){
					BirdRank = _Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird4;
				}
				else if(other.tag == "Bird5"){
					BirdRank = _Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird5;
				}
				else if(other.tag == "Bird6"){
					BirdRank = _Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird6;
				}
				else if(other.tag == "Bird7"){
					BirdRank = _Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird7;
				}
				else if(other.tag == "Bird8"){
					BirdRank = _Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().RankBird8;
				}
				GameObject ItemPUP = GameObject.Find ("PlaceItem" + BirdRank);
				int BirdRank1 = Random.Range (1, 101);
				if(BirdRank == 1){
					if(BirdRank1 < 70){
						PUPItem = 1;
					}
					else if(BirdRank1 > 69 && BirdRank1 < 90){
						PUPItem = 2;
					}
					else if(BirdRank1 > 89){
						PUPItem = 3;
					}
				}
				else if(BirdRank == 2){
					if(BirdRank1 < 60){
						PUPItem = 1;
					}
					else if(BirdRank1 > 59 && BirdRank1 < 80){
						PUPItem = 2;
					}
					else if(BirdRank1 > 69 && BirdRank1 < 90){
						PUPItem = 5;
					}
					else if(BirdRank1 > 89){
						PUPItem = 3;
					}
				}
				else if(BirdRank == 3){
					if(BirdRank1 < 50){
						PUPItem = 1;
					}
					else if(BirdRank1 > 49 && BirdRank1 < 70){
						PUPItem = 2;
					}
					else if(BirdRank1 > 69 && BirdRank1 < 85){
						PUPItem = 5;
					}
					else if(BirdRank1 > 84 && BirdRank1 < 95){
						PUPItem = 3;
					}
					else if(BirdRank1 > 94){
						PUPItem = 4;
					}
				}
				else if(BirdRank == 4){
					if(BirdRank1 < 30){
						PUPItem = 1;
					}
					else if(BirdRank1 > 29 && BirdRank1 < 40){
						PUPItem = 2;
					}
					else if(BirdRank1 > 39 && BirdRank1 < 55){
						PUPItem = 5;
					}
					else if(BirdRank1 > 54 && BirdRank1 < 60){
						PUPItem = 6;
					}
					else if(BirdRank1 > 59 && BirdRank1 < 70){
						PUPItem = 8;
					}
					else if(BirdRank1 > 69 && BirdRank1 < 80){
						PUPItem = 9;
					}
					else if(BirdRank1 > 79 && BirdRank1 < 90){
						PUPItem = 3;
					}
					else if(BirdRank1 > 89 && BirdRank1 < 95){
						PUPItem = 4;
					}
					else if(BirdRank1 > 94){
						PUPItem = 7;
					}
				}
				else if(BirdRank == 5){
					if(BirdRank1 < 20){
						PUPItem = 1;
					}
					else if(BirdRank1 > 19 && BirdRank1 < 30){
						PUPItem = 2;
					}
					else if(BirdRank1 > 29 && BirdRank1 < 40){
						PUPItem = 5;
					}
					else if(BirdRank1 > 39 && BirdRank1 < 45){
						PUPItem = 6;
					}
					else if(BirdRank1 > 44 && BirdRank1 < 60){
						PUPItem = 8;
					}
					else if(BirdRank1 > 59 && BirdRank1 < 80){
						PUPItem = 9;
					}
					else if(BirdRank1 > 79 && BirdRank1 < 90){
						PUPItem = 3;
					}
					else if(BirdRank1 > 89 && BirdRank1 < 95){
						PUPItem = 4;
					}
					else if(BirdRank1 > 94){
						PUPItem = 7;
					}
				}
				else if(BirdRank == 6){
					if(BirdRank1 < 10){
						PUPItem = 2;
					}
					else if(BirdRank1 > 9 && BirdRank1 < 15){
						PUPItem = 5;
					}
					else if(BirdRank1 > 14 && BirdRank1 < 25){
						PUPItem = 6;
					}
					else if(BirdRank1 > 24 && BirdRank1 < 40){
						PUPItem = 8;
					}
					else if(BirdRank1 > 39 && BirdRank1 < 70){
						PUPItem = 9;
					}
					else if(BirdRank1 > 69 && BirdRank1 < 95){
						PUPItem = 4;
					}
					else if(BirdRank1 > 94){
						PUPItem = 7;
					}
				}
				else if(BirdRank == 7){
					if(BirdRank1 < 10){
						PUPItem = 5;
					}
					else if(BirdRank1 > 9 && BirdRank1 < 25){
						PUPItem = 6;
					}
					else if(BirdRank1 > 24 && BirdRank1 < 40){
						PUPItem = 9;
					}
					else if(BirdRank1 > 39 && BirdRank1 < 60){
						PUPItem = 10;
					}
					else if(BirdRank1 > 59 && BirdRank1 < 75){
						PUPItem = 11;
					}
					else if(BirdRank1 > 74 && BirdRank1 < 95){
						PUPItem = 4;
					}
					else if(BirdRank1 > 94){
						PUPItem = 7;
					}
				}
				else if(BirdRank == 8){
					if(BirdRank1 < 10){
						PUPItem = 5;
					}
					else if(BirdRank1 > 9 && BirdRank1 < 25){
						PUPItem = 6;
					}
					else if(BirdRank1 > 24 && BirdRank1 < 40){
						PUPItem = 9;
					}
					else if(BirdRank1 > 39 && BirdRank1 < 60){
						PUPItem = 10;
					}
					else if(BirdRank1 > 59 && BirdRank1 < 80){
						PUPItem = 11;
					}
					else if(BirdRank1 > 79 && BirdRank1 < 95){
						PUPItem = 4;
					}
					else if(BirdRank1 > 94){
						PUPItem = 7;
					}
				}
				foreach (Transform child in transform) {
					child.gameObject.SetActive(false);
				}
				gameObject.GetComponent<BoxCollider>().enabled = false;
				if(other.tag == "Bird1"){
					_Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().PUPBird1 = PUPItem;
				}
				else if(other.tag == "Bird2"){
					_Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().PUPBird2 = PUPItem;
				}
				else if(other.tag == "Bird3"){
					_Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().PUPBird3 = PUPItem;
				}
				else if(other.tag == "Bird4"){
					_Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().PUPBird4 = PUPItem;
				}
				else if(other.tag == "Bird5"){
					_Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().PUPBird5 = PUPItem;
				}
				else if(other.tag == "Bird6"){
					_Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().PUPBird6 = PUPItem;
				}
				else if(other.tag == "Bird7"){
					_Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().PUPBird7 = PUPItem;
				}
				else if(other.tag == "Bird8"){
					_Ranking.GetComponent<UnitySampleAssets.Utility.Ranking>().PUPBird8 = PUPItem;
				}
				if(PUPItem == 1 || PUPItem == 3 || PUPItem == 5 || PUPItem == 7 || PUPItem == 8 || PUPItem == 9 || PUPItem == 10 || PUPItem == 11){
					if(PUPItem == 1){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdPoop");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(0.4f, 0.26f, 0.13f);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdPoop");
						ItemPUP.GetComponent<Image>().color = new Color(0.4f, 0.26f, 0.13f);
					}
					else if(PUPItem == 3){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Worm");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(0.54f, 0.43f, 0.375f);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Worm");
						ItemPUP.GetComponent<Image>().color = new Color(0.54f, 0.43f, 0.375f);
					}
					else if(PUPItem == 5){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						ItemPUP.GetComponent<Image>().color = new Color(1, 0, 0);
					}
					else if(PUPItem == 7){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(0, 0.5f, 1);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						ItemPUP.GetComponent<Image>().color = new Color(0, 0.5f, 1);
					}
					else if(PUPItem == 8){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(0, 0.25f, 0);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						ItemPUP.GetComponent<Image>().color = new Color(0, 0.25f, 0);
					}
					else if(PUPItem == 9){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Fish");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 0);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Fish");
						ItemPUP.GetComponent<Image>().color = new Color(1, 1, 0);
					}
					else if(PUPItem == 10){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Oil");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Oil");
						ItemPUP.GetComponent<Image>().color = new Color(0, 0, 0);
					}
					else if(PUPItem == 11){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Teleport");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Teleport");
						ItemPUP.GetComponent<Image>().color = new Color(1, 1, 1);
					}
				}
				
				else if(PUPItem == 2 || PUPItem == 4 || PUPItem == 6){
					GameObject PUP1 = GameObject.Find (other.tag + "PUP_1");
					if(PUPItem == 2){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdPoop");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(0.4f, 0.26f, 0.13f);
						PUP1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdPoop");
						PUP1.GetComponent<SpriteRenderer>().color = new Color(0.4f, 0.26f, 0.13f);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdPoop");
						ItemPUP.GetComponent<Image>().color = new Color(0.4f, 0.26f, 0.13f);
					}
					else if(PUPItem == 4){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Worm");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(0.54f, 0.43f, 0.375f);
						PUP1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Worm");
						PUP1.GetComponent<SpriteRenderer>().color = new Color(0.54f, 0.43f, 0.375f);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_Worm");
						ItemPUP.GetComponent<Image>().color = new Color(0.54f, 0.43f, 0.375f);
					}
					else if(PUPItem == 6){
						PUP2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						PUP2.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
						PUP1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						PUP1.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
						ItemPUP.GetComponent<Image>().sprite = Resources.Load<Sprite> ("PUPS/PUP_BirdEgg");
						ItemPUP.GetComponent<Image>().color = new Color(1, 0, 0);
					}
				}
				StartCoroutine(MysteryBirdRespawn());
			}
		}
	}

	IEnumerator MysteryBirdRespawn(){
		yield return new WaitForSeconds (4);
		gameObject.GetComponent<BoxCollider>().enabled = true;
		foreach (Transform child in transform) {
			child.gameObject.SetActive(true);
		}
	}
}