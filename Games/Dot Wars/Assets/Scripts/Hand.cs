using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SVGImporter;

public class Hand : MonoBehaviour {
	public Dot Player;
	public Material Player1Mat;
	public Material Player2Mat;
	public Material Player3Mat;
	public Material Player4Mat;
	public GameObject MainCamera;
	public Text WhoHit;
	public float speed;
	public int p;
	public bool die;
	public string whohittext;
	private bool dieready;
	private bool tuttrail;
	private int p1score;
	private int p2score;
	private int p3score;
	private int p4score;
	private int p1place;
	private int p2place;
	private int p3place;
	private int p4place;
	private int pcoins;
	private int p1coins;
	private int p2coins;
	private int p3coins;
	private int p4coins;

	void FixedUpdate () {
		transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z + speed * Time.fixedDeltaTime);
		transform.localPosition = new Vector3(-0.71f, 1.35f, 0);
	}

	void Update (){
		if(tuttrail == true){
			tuttrail = false;
			MainCamera.GetComponent<Encrypt> ().Player.GetComponent <TrailRenderer> ().time = 0.5f;
		}
		if (die == true && MainCamera.GetComponent<Encrypt> ().tut != 0) {
			die = false;
			MainCamera.GetComponent<Encrypt> ().deadp = false;
			MainCamera.GetComponent<Encrypt> ().Player.SetActive (true);
			MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale> ().enabled = false;
			MainCamera.GetComponent<Encrypt> ().Player.GetComponent <TrailRenderer> ().time = 0;
			MainCamera.GetComponent<Encrypt> ().Player.transform.localPosition = new Vector3(200, 0, 0);
			tuttrail = true;
		}
		else if(die == true && p1score == 0 && p2score == 0 && p3score == 0 && p4score == 0){
			die = false;
			if(p != 0){
				MainCamera.GetComponent<Encrypt> ().startad = true;
				p1score = int.Parse(MainCamera.GetComponent<Encrypt>().KillP1.text);
				p2score = int.Parse(MainCamera.GetComponent<Encrypt>().KillP2.text);
				p3score = int.Parse(MainCamera.GetComponent<Encrypt>().KillP3.text);
				p4score = int.Parse(MainCamera.GetComponent<Encrypt>().KillP4.text);
				if (p1score < p2score) {
					p1place++;
				}
				else {
					p2place++;
				}
				if (p1score < p3score) {
					p1place++;
				}
				else {
					p3place++;
				}
				if (p1score < p4score) {
					p1place++;
				}
				else {
					p4place++;
				}
				if (p2score < p3score) {
					p2place++;
				}
				else {
					p3place++;
				}
				if (p2score < p4score) {
					p2place++;
				}
				else {
					p4place++;
				}
				if (p3score < p4score) {
					p3place++;
				}
				else {
					p4place++;
				}
				p1coins = p1place;
				p2coins = p2place;
				p3coins = p3place;
				p4coins = p4place;
				if (p4score == p3score) {
					p4coins = p3coins;
				}
				if (p4score == p2score) {
					p4coins = p2coins;
				}
				if (p4score == p1score) {
					p4coins = p1coins;
				}
				if (p3score == p2score) {
					p3coins = p2coins;
				}
				if (p3score == p1score) {
					p3coins = p1coins;
				}
				if (p2score == p1score) {
					p2coins = p1coins;
				}
				if (p1place == 0) {
					GameObject.Find ("WinnerDot").GetComponent<SVGImage> ().material = Player1Mat;
					GameObject.Find ("Winner").GetComponent<Text> ().text = "PLAYER 1 WINS";
				}
				else if (p2place == 0) {
					GameObject.Find ("WinnerDot").GetComponent<SVGImage> ().material = Player2Mat;
					GameObject.Find ("Winner").GetComponent<Text> ().text = "PLAYER 2 WINS";
				}
				else if (p3place == 0) {
					GameObject.Find ("WinnerDot").GetComponent<SVGImage> ().material = Player3Mat;
					GameObject.Find ("Winner").GetComponent<Text> ().text = "PLAYER 3 WINS";
				}
				else if (p4place == 0) {
					GameObject.Find ("WinnerDot").GetComponent<SVGImage> ().material = Player4Mat;
					GameObject.Find ("Winner").GetComponent<Text> ().text = "PLAYER 4 WINS";
				}
				if (p1place == 1) {
					GameObject.Find ("2ndDot").GetComponent<SVGImage> ().material = Player1Mat;
					GameObject.Find ("2ndDotText").GetComponent<Text> ().text = p1score.ToString();
					GameObject.Find ("2ndPlace").GetComponent<Text> ().text = "2ND - Player 1";
				}
				else if (p2place == 1) {
					GameObject.Find ("2ndDot").GetComponent<SVGImage> ().material = Player2Mat;
					GameObject.Find ("2ndDotText").GetComponent<Text> ().text = p2score.ToString();
					GameObject.Find ("2ndPlace").GetComponent<Text> ().text = "2ND - Player 2";
				}
				else if (p3place == 1) {
					GameObject.Find ("2ndDot").GetComponent<SVGImage> ().material = Player3Mat;
					GameObject.Find ("2ndDotText").GetComponent<Text> ().text = p3score.ToString();
					GameObject.Find ("2ndPlace").GetComponent<Text> ().text = "2ND - Player 3";
				}
				else if (p4place == 1) {
					GameObject.Find ("2ndDot").GetComponent<SVGImage> ().material = Player4Mat;
					GameObject.Find ("2ndDotText").GetComponent<Text> ().text = p4score.ToString();
					GameObject.Find ("2ndPlace").GetComponent<Text> ().text = "2ND - Player 4";
				}
				if (p1place == 2) {
					GameObject.Find ("3rdDot").GetComponent<SVGImage> ().material = Player1Mat;
					GameObject.Find ("3rdDotText").GetComponent<Text> ().text = p1score.ToString();
					if (p1coins == 1) {
						GameObject.Find ("3rdPlace").GetComponent<Text> ().text = "2ND - Player 1";
						GameObject.Find ("3rdCoins").GetComponent<Text> ().text = "+150 Coins";
					}
					else if (p1coins == 2) {
						GameObject.Find ("3rdPlace").GetComponent<Text> ().text = "3RD - Player 1";
						GameObject.Find ("3rdCoins").GetComponent<Text> ().text = "+100 Coins";
					}
				}
				else if (p2place == 2) {
					GameObject.Find ("3rdDot").GetComponent<SVGImage> ().material = Player2Mat;
					GameObject.Find ("3rdDotText").GetComponent<Text> ().text = p2score.ToString();
					if (p2coins == 1) {
						GameObject.Find ("3rdPlace").GetComponent<Text> ().text = "2ND - Player 2";
						GameObject.Find ("3rdCoins").GetComponent<Text> ().text = "+150 Coins";
					}
					else if (p2coins == 2) {
						GameObject.Find ("3rdPlace").GetComponent<Text> ().text = "3RD - Player 2";
						GameObject.Find ("3rdCoins").GetComponent<Text> ().text = "+100 Coins";
					}
				}
				else if (p3place == 2) {
					GameObject.Find ("3rdDot").GetComponent<SVGImage> ().material = Player3Mat;
					GameObject.Find ("3rdDotText").GetComponent<Text> ().text = p3score.ToString();
					if (p3coins == 1) {
						GameObject.Find ("3rdPlace").GetComponent<Text> ().text = "2ND - Player 3";
						GameObject.Find ("3rdCoins").GetComponent<Text> ().text = "+150 Coins";
					}
					else if (p3coins == 2) {
						GameObject.Find ("3rdPlace").GetComponent<Text> ().text = "3RD - Player 3";
						GameObject.Find ("3rdCoins").GetComponent<Text> ().text = "+100 Coins";
					}
				}
				else if (p4place == 2) {
					GameObject.Find ("3rdDot").GetComponent<SVGImage> ().material = Player4Mat;
					GameObject.Find ("3rdDotText").GetComponent<Text> ().text = p4score.ToString();
					if (p4coins == 1) {
						GameObject.Find ("3rdPlace").GetComponent<Text> ().text = "2ND - Player 4";
						GameObject.Find ("3rdCoins").GetComponent<Text> ().text = "+150 Coins";
					}
					else if (p4coins == 2) {
						GameObject.Find ("3rdPlace").GetComponent<Text> ().text = "3RD - Player 4";
						GameObject.Find ("3rdCoins").GetComponent<Text> ().text = "+100 Coins";
					}
				}
				if (p1place == 3) {
					GameObject.Find ("4thDot").GetComponent<SVGImage> ().material = Player1Mat;
					GameObject.Find ("4thDotText").GetComponent<Text> ().text = p1score.ToString();
					if (p1coins == 1) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "2ND - Player 1";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+150 Coins";
					}
					else if (p1coins == 2) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "3RD - Player 1";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+100 Coins";
					}
					else if (p1coins == 3) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "4TH - Player 1";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+75 Coins";
					}
				}
				else if (p2place == 3) {
					GameObject.Find ("4thDot").GetComponent<SVGImage> ().material = Player2Mat;
					GameObject.Find ("4thDotText").GetComponent<Text> ().text = p2score.ToString();
					if (p2coins == 1) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "2ND - Player 2";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+150 Coins";
					}
					else if (p2coins == 2) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "3RD - Player 2";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+100 Coins";
					}
					else if (p2coins == 3) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "4TH - Player 2";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+75 Coins";
					}
				}
				else if (p3place == 3) {
					GameObject.Find ("4thDot").GetComponent<SVGImage> ().material = Player3Mat;
					GameObject.Find ("4thDotText").GetComponent<Text> ().text = p3score.ToString();
					if (p3coins == 1) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "2ND - Player 3";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+150 Coins";
					}
					else if (p3coins == 2) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "3RD - Player 3";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+100 Coins";
					}
					else if (p3coins == 3) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "4TH - Player 3";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+75 Coins";
					}
				}
				else if (p4place == 3) {
					GameObject.Find ("4thDot").GetComponent<SVGImage> ().material = Player4Mat;
					GameObject.Find ("4thDotText").GetComponent<Text> ().text = p4score.ToString();
					if (p4coins == 1) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "2ND - Player 4";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+150 Coins";
					}
					else if (p4coins == 2) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "3RD - Player 4";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+100 Coins";
					}
					else if (p4coins == 3) {
						GameObject.Find ("4thPlace").GetComponent<Text> ().text = "4TH - Player 4";
						GameObject.Find ("4thCoins").GetComponent<Text> ().text = "+75 Coins";
					}
				}
				if(p == 1){
					pcoins = p1coins;
				}
				else if(p == 2){
					pcoins = p2coins;
				}
				else if(p == 3){
					pcoins = p3coins;
				}
				else if(p == 4){
					pcoins = p4coins;
				}
				if (pcoins == 0) {
					StoreData.SetCoins (0, 0, true, "0n00250");
				}
				else if (pcoins == 1) {
					StoreData.SetCoins (0, 0, true, "0n00150");
				}
				else if (pcoins == 2) {
					StoreData.SetCoins (0, 0, true, "0n00100");
				}
				else if (pcoins == 3) {
					StoreData.SetCoins (0, 0, true, "0n00075");
				}
			}
			MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale> ().enabled = true;
			MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale> ().rampOffset = 0;
			dieready = true;
		}
		if (dieready == true) {
			WhoHit.text = whohittext;
			WhoHit.enabled = true;
			if (MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale> ().rampOffset < 1f) {
				MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale> ().rampOffset += 0.5f * Time.deltaTime;
			}
			else {
				dieready = false;
				if(p == 0){
					WhoHit.enabled = false;
					WhoHit.text = "";
					MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale> ().rampOffset = 0;
					MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale> ().enabled = false;
					MainCamera.GetComponent<Encrypt> ().deadp = false;
					int pl = MainCamera.GetComponent<Encrypt> ().p;
					MainCamera.GetComponent<Encrypt> ().Player.SetActive (true);
					MainCamera.GetComponent<Encrypt>().Player.GetComponent<Dot> ().Powerupactive = false;
					if(pl == 1){
						MainCamera.GetComponent<Encrypt> ().Player.transform.localPosition = new Vector3(200, 0, 0);
					}
					else if(pl == 2){
						MainCamera.GetComponent<Encrypt> ().Player.transform.localPosition = new Vector3(100, -175, 0);
					}
					else if(pl == 3){
						MainCamera.GetComponent<Encrypt> ().Player.transform.localPosition = new Vector3(-100, -175, 0);
					}
					else if(pl == 4){
						MainCamera.GetComponent<Encrypt> ().Player.transform.localPosition = new Vector3(-200, 0, 0);
					}
					MainCamera.GetComponent<Encrypt> ().Powerup (10);
				}
				else{
					WhoHit.enabled = false;
					WhoHit.text = "";
					MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale> ().rampOffset = 0;
					MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale> ().enabled = false;
					GameObject.Find ("ScoreBoardHolder").transform.localScale = new Vector3 (1, 1, 1);
					MainCamera.GetComponent<Encrypt>().StartCoroutine(MainCamera.GetComponent<Encrypt>().GameDone());
					Destroy (GameObject.Find("Canvas"));
				}
			}
		}
	}

	public IEnumerator BotP1Died(){
		yield return new WaitForSeconds (2);

		MainCamera.GetComponent<Encrypt> ().Player1.SetActive (true);
		MainCamera.GetComponent<Encrypt> ().Player1.transform.localPosition = new Vector3(200, 0, 0);
		MainCamera.GetComponent<Encrypt>().Player1.GetComponent<Bot> ().Powerupactive = false;
		MainCamera.GetComponent<Encrypt> ().Player1.GetComponent<Bot> ().StartCoroutine (MainCamera.GetComponent<Encrypt> ().Player1.GetComponent<Bot> ().Invincible(1.5f));
		if(MainCamera.GetComponent<Encrypt>().b1active == true){
			MainCamera.GetComponent<Encrypt> ().deadb1 = false;
		}
	}

	public IEnumerator BotP2Died(){
		yield return new WaitForSeconds (2);

		MainCamera.GetComponent<Encrypt> ().Player2.SetActive (true);
		MainCamera.GetComponent<Encrypt> ().Player2.transform.localPosition = new Vector3(100, -175, 0);
		MainCamera.GetComponent<Encrypt>().Player2.GetComponent<Bot> ().Powerupactive = false;
		MainCamera.GetComponent<Encrypt> ().Player2.GetComponent<Bot> ().StartCoroutine (MainCamera.GetComponent<Encrypt> ().Player2.GetComponent<Bot> ().Invincible(1.5f));
		if(MainCamera.GetComponent<Encrypt>().b2active == true){
			MainCamera.GetComponent<Encrypt> ().deadb2 = false;
		}
	}

	public IEnumerator BotP3Died(){
		yield return new WaitForSeconds (2);

		MainCamera.GetComponent<Encrypt> ().Player3.SetActive (true);
		MainCamera.GetComponent<Encrypt> ().Player3.transform.localPosition = new Vector3(-100, -175, 0);
		MainCamera.GetComponent<Encrypt>().Player3.GetComponent<Bot> ().Powerupactive = false;
		MainCamera.GetComponent<Encrypt> ().Player3.GetComponent<Bot> ().StartCoroutine (MainCamera.GetComponent<Encrypt> ().Player3.GetComponent<Bot> ().Invincible(1.5f));
		if(MainCamera.GetComponent<Encrypt>().b3active == true){
			MainCamera.GetComponent<Encrypt> ().deadb3 = false;
		}
	}

	public IEnumerator BotP4Died(){
		yield return new WaitForSeconds (2);

		MainCamera.GetComponent<Encrypt> ().Player4.SetActive (true);
		MainCamera.GetComponent<Encrypt> ().Player4.transform.localPosition = new Vector3(-200, 0, 0);
		MainCamera.GetComponent<Encrypt>().Player4.GetComponent<Bot> ().Powerupactive = false;
		MainCamera.GetComponent<Encrypt> ().Player4.GetComponent<Bot> ().StartCoroutine (MainCamera.GetComponent<Encrypt> ().Player4.GetComponent<Bot> ().Invincible(1.5f));
		if(MainCamera.GetComponent<Encrypt>().b4active == true){
			MainCamera.GetComponent<Encrypt> ().deadb4 = false;
		}
	}
}