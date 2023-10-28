using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SVGImporter;
using CnControls;

public class Dot : MonoBehaviour {
	public Material PlayerMat;
	public AudioSource MainCameraAudio;
	public AudioClip LaserAudio;
	public AudioClip DieAudio;
	public GameObject ShotPrefab;
	public GameObject MinePrefab;
	public GameObject MainCamera;
	public GameObject ClockHand;
	public Image ClockOutsideJump;
	public Image ClockOutsideShoot;
	private GameObject Player2;
	private GameObject Player3;
	private GameObject Player4;
	public int player = 0;
	public int totalshots = 1;
	public int shotnumber = 1;
	public float maxspeed = 2f;
	public float speedy = 0;
	public float speedx = 0;
	public bool Powerupactive;
	//public bool jumpbutton;
	public bool shootbutton;
	//private bool jumpready = true;
	private float jumptime = -5;
	private float shoottime1 = 0;
	private float shoottime2 = 0;
	private float shoottime3 = 0;
	private int player2 = 0;
	private int player3 = 0;
	private int player4 = 0;
	private float lastradius;
	private bool PU5shooter;

	void Start () {
		if(player == 1){
			player2 = 2;
			player3 = 3;
			player4 = 4;
		}
		else if(player == 2){
			player2 = 1;
			player3 = 3;
			player4 = 4;
		}
		else if(player == 3){
			player2 = 1;
			player3 = 2;
			player4 = 4;
		}
		else if(player == 4){
			player2 = 1;
			player3 = 2;
			player4 = 3;
		}
		Player2 = GameObject.Find ("Player" + player2);
		Player3 = GameObject.Find ("Player" + player3);
		Player4 = GameObject.Find ("Player" + player4);
		string s = StoreData.GetStoreData (2, 1);
		if (s.Length > 6) {
			maxspeed = (int.Parse(s.Substring (8)) / 2.5f);
		}
		else {
			maxspeed = 4f;
		}
		s = StoreData.GetStoreData (2, 2);
		if (s.Length > 6) {
			totalshots = int.Parse(s.Substring (8));
		}
		else {
			totalshots = 3;
		}
		GetComponent<TrailRenderer> ().time = 0f;
		StartCoroutine(TR ());
	}

	void Update () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		if (MainCamera.GetComponent<Encrypt> ().KillP1.text == "10" || MainCamera.GetComponent<Encrypt> ().KillP2.text == "10" || MainCamera.GetComponent<Encrypt> ().KillP3.text == "10" || MainCamera.GetComponent<Encrypt> ().KillP4.text == "10") {
			if (ClockHand.GetComponent<Hand> ().p == 0) {
				ClockHand.GetComponent<Hand> ().p = player;
				ClockHand.GetComponent<Hand> ().die = true;
			}
		}
		else{
			float d2 = 9999999f;
			float d3 = 9999999f;
			float d4 = 9999999f;
			if(Player2.GetActive() != false){
				d2 = Vector2.Distance(transform.position, Player2.transform.position);
			}
			if(Player3.GetActive() != false){
				d3 = Vector2.Distance(transform.position, Player3.transform.position);
			}
			if(Player4.GetActive() != false){
				d4 = Vector2.Distance(transform.position, Player4.transform.position);
			}
			if(d2 <= d3 && d2 <= d4){
				if(d3 != 9999999f){
					Player3.transform.Find("Selected").GetComponent<SVGImage>().enabled = false;
				}
				if(d4 != 9999999f){
					Player4.transform.Find("Selected").GetComponent<SVGImage>().enabled = false;
				}
				Player2.transform.Find("Selected").GetComponent<SVGImage>().enabled = true;
			}
			else if(d3 <= d2 && d3 <= d4){
				if(d2 != 9999999f){
					Player2.transform.Find("Selected").GetComponent<SVGImage>().enabled = false;
				}
				if(d4 != 9999999f){
					Player4.transform.Find("Selected").GetComponent<SVGImage>().enabled = false;
				}
				Player3.transform.Find("Selected").GetComponent<SVGImage>().enabled = true;
			}
			else if(d4 <= d2 && d4 <= d3){
				if(d2 != 9999999f){
					Player2.transform.Find("Selected").GetComponent<SVGImage>().enabled = false;
				}
				if(d3 != 9999999f){
					Player3.transform.Find("Selected").GetComponent<SVGImage>().enabled = false;
				}
				Player4.transform.Find("Selected").GetComponent<SVGImage>().enabled = true;
			}
		}
		if((Time.time - jumptime) / 1.695f <= 2){
			ClockOutsideJump.fillAmount = Mathf.Lerp (0, 1, (Time.time - jumptime) / 1.695f);
		}
		if(shoottime3 > 0){
			ClockOutsideShoot.fillAmount += 0.083333f * Time.deltaTime;
			shoottime3 -= Time.deltaTime;
		}
		else if(ClockOutsideShoot.fillAmount > 0.95f){
			ClockOutsideShoot.fillAmount += 0.083333f * Time.deltaTime;	
		}
		if(shoottime2 > 0){
			ClockOutsideShoot.fillAmount += 0.125f * Time.deltaTime;
			shoottime2 -= Time.deltaTime;
		}
		else if(ClockOutsideShoot.fillAmount > 0.95f){
			ClockOutsideShoot.fillAmount += 0.125f * Time.deltaTime;	
		}
		if(shoottime1 > 0){
			ClockOutsideShoot.fillAmount += 0.25f * Time.deltaTime;
			shoottime1 -= Time.deltaTime;
		}
		else if(ClockOutsideShoot.fillAmount > 0.95f){
			ClockOutsideShoot.fillAmount += 0.25f * Time.deltaTime;	
		}
		/*if (Input.GetKeyDown (KeyCode.Space) || jumpbutton == true) {
			if(jumpbutton == true){
				jumpbutton = false;
			}
			if(jumpready == true){
				StartCoroutine (Jump ());
			}
		}*/
		if (Input.GetKeyDown (KeyCode.RightShift) && Powerupactive == false || shootbutton == true || PU5shooter == true) {
			if(1f/totalshots <= ClockOutsideShoot.fillAmount || PU5shooter == true){
				MainCameraAudio.PlayOneShot (LaserAudio);
				if(totalshots == 1 && PU5shooter == false){
					ClockOutsideShoot.fillAmount -= 1;
					shoottime1 += 4;
				}
				if(totalshots == 2 && PU5shooter == false){
					shoottime2 += 4;
					ClockOutsideShoot.fillAmount -= 0.5f;
				}
				if(totalshots == 3 && PU5shooter == false){
					shoottime3 += 4;
					ClockOutsideShoot.fillAmount -= 0.333333f;
				}
				if(PU5shooter == true){
					PU5shooter = false;
				}
				else if(shootbutton == true){
					shootbutton = false;
				}
				GameObject shotpre = (GameObject)Instantiate(ShotPrefab, transform.position, transform.rotation);
				shotnumber++;
				if(shotnumber == 100){
					shotnumber = 1;
				}
				shotpre.name = "P" + player + "Shot" + shotnumber;
				if(Player2.GetActive() == false && Player3.GetActive() == false && Player4.GetActive() == false){
					shotpre.transform.LookAt(GameObject.Find("ClockHandMiddle").transform);
					MainCamera.GetComponent<Encrypt>().RunSH(player.ToString() + "0" + shotnumber.ToString("00"));
				}
				else{
					float d2 = 9999999f;
					float d3 = 9999999f;
					float d4 = 9999999f;
					if(Player2.GetActive() != false){
						d2 = Vector2.Distance(transform.position, Player2.transform.position);
					}
					if(Player3.GetActive() != false){
						d3 = Vector2.Distance(transform.position, Player3.transform.position);
					}
					if(Player4.GetActive() != false){
						d4 = Vector2.Distance(transform.position, Player4.transform.position);
					}
					if(d2 <= d3 && d2 <= d4){
						shotpre.transform.LookAt(Player2.transform);
						MainCamera.GetComponent<Encrypt>().RunSH(player.ToString() + player2.ToString() + shotnumber.ToString("00"));
					}
					else if(d3 <= d2 && d3 <= d4){
						shotpre.transform.LookAt(Player3.transform);
						MainCamera.GetComponent<Encrypt>().RunSH(player.ToString() + player3.ToString() + shotnumber.ToString("00"));
					}
					else if(d4 <= d2 && d4 <= d3){
						shotpre.transform.LookAt(Player4.transform);
						MainCamera.GetComponent<Encrypt>().RunSH(player.ToString() + player4.ToString() + shotnumber.ToString("00"));
					}
				}
				shotpre.GetComponent<Rigidbody2D>().AddForce(shotpre.transform.forward);
				shotpre.transform.eulerAngles = new Vector3(0, 0, 0);
				shotpre.GetComponent<SVGImage>().material = PlayerMat;
				shotpre.GetComponent<TrailRenderer>().material = PlayerMat; 
				shotpre.transform.SetParent(transform.parent);
				shotpre.transform.SetAsFirstSibling ();
				shotpre.layer = player + 14;
			}
			else{
				shootbutton = false;
			}
		}
		if (CnInputManager.GetAxis ("Vertical") != 0) {
			speedy = CnInputManager.GetAxis ("Vertical") * maxspeed * 25f;
			if (lastradius < 40000f) {
				transform.localPosition += new Vector3 (0, speedy * Time.deltaTime, 0);
			}
			else if(lastradius > (transform.localPosition.x * transform.localPosition.x) + ((transform.localPosition.y + (speedy * Time.deltaTime)) * (transform.localPosition.y + (speedy * Time.deltaTime)))){
				transform.localPosition += new Vector3 (0, speedy * Time.deltaTime, 0);
			}
			lastradius = (transform.localPosition.x * transform.localPosition.x) + (transform.localPosition.y * transform.localPosition.y);
		}
		else {
			speedy = 0;
		}
		if (CnInputManager.GetAxis("Horizontal") != 0) {
			speedx = CnInputManager.GetAxis("Horizontal") * maxspeed * 25f;
			if (lastradius < 40000f) {
				transform.localPosition += new Vector3 (speedx * Time.deltaTime, 0, 0);
			}
			else if(lastradius > ((transform.localPosition.x + (speedx * Time.deltaTime)) * (transform.localPosition.x + (speedx * Time.deltaTime))) + (transform.localPosition.y * transform.localPosition.y)){
				transform.localPosition += new Vector3 (speedx * Time.deltaTime, 0, 0);
			}
			lastradius = (transform.localPosition.x * transform.localPosition.x) + (transform.localPosition.y * transform.localPosition.y);
		}
		else {
			speedx = 0;
		}
	}

	void OnCollisionStay2D(Collision2D other){
		if(gameObject.GetComponent<Dot>().enabled == true){
			if (other.gameObject.name == "circle1") {
				speedy = -speedy /2;
				speedx = -speedx /2;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if(gameObject.GetComponent<Dot>().enabled == true){
			if (other.gameObject.name == "ClockHand") {
				MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale>().enabled = true;
				MainCamera.GetComponent<Encrypt> ().deadp = true;
				MainCameraAudio.PlayOneShot (DieAudio);
				ClockHand.GetComponent<Hand>().die = true;
				MainCamera.GetComponent<Encrypt> ().Player1.transform.GetChild(0).GetComponent<SVGImage>().enabled = false;
				MainCamera.GetComponent<Encrypt> ().Player2.transform.GetChild(0).GetComponent<SVGImage>().enabled = false;
				MainCamera.GetComponent<Encrypt> ().Player3.transform.GetChild(0).GetComponent<SVGImage>().enabled = false;
				MainCamera.GetComponent<Encrypt> ().Player4.transform.GetChild(0).GetComponent<SVGImage>().enabled = false;
				ClockHand.GetComponent<Hand>().whohittext = "THE HAND \n HIT YOU!";
				gameObject.SetActive (false);
			}
			if (other.gameObject.tag == "Shot" && other.gameObject.layer != player + 14) {
				Encrypt e = MainCamera.GetComponent<Encrypt> ();
				if (other.gameObject.GetComponent<SVGImage> ().material != PlayerMat) {
					if (other.gameObject.GetComponent<SVGImage> ().material == MainCamera.GetComponent<Encrypt> ().P1Material) {
						e.p1add = true;
						ClockHand.GetComponent<Hand> ().whohittext = "PLAYER 1 \n HIT YOU!";
					}
					else if (other.gameObject.GetComponent<SVGImage> ().material == MainCamera.GetComponent<Encrypt> ().P2Material) {
						e.p2add = true;
						ClockHand.GetComponent<Hand> ().whohittext = "PLAYER 2 \n HIT YOU!";
					}
					else if (other.gameObject.GetComponent<SVGImage> ().material == MainCamera.GetComponent<Encrypt> ().P3Material) {
						e.p3add = true;
						ClockHand.GetComponent<Hand> ().whohittext = "PLAYER 3 \n HIT YOU!";
					}
					else if (other.gameObject.GetComponent<SVGImage> ().material == MainCamera.GetComponent<Encrypt> ().P4Material) {
						e.p4add = true;
						ClockHand.GetComponent<Hand> ().whohittext = "PLAYER 4 \n HIT YOU!";
					}
				}
				if (e.KillP1.text != "9" || e.KillP2.text != "9" || e.KillP3.text != "9" || e.KillP4.text != "9") {
					MainCamera.GetComponent<UnityStandardAssets.ImageEffects.Grayscale> ().enabled = true;
					MainCamera.GetComponent<Encrypt> ().deadp = true;
					MainCameraAudio.PlayOneShot (DieAudio);
					ClockHand.GetComponent<Hand> ().die = true;
					MainCamera.GetComponent<Encrypt> ().Player1.transform.GetChild (0).GetComponent<SVGImage> ().enabled = false;
					MainCamera.GetComponent<Encrypt> ().Player2.transform.GetChild (0).GetComponent<SVGImage> ().enabled = false;
					MainCamera.GetComponent<Encrypt> ().Player3.transform.GetChild (0).GetComponent<SVGImage> ().enabled = false;
					MainCamera.GetComponent<Encrypt> ().Player4.transform.GetChild (0).GetComponent<SVGImage> ().enabled = false;
					gameObject.SetActive (false);
				}
			}
		}
	}

	public void PowerupMine(){
		float rot = -1.5707961f - Mathf.Atan2 (speedx / maxspeed, speedy / maxspeed);
		GameObject minepre = (GameObject)Instantiate(MinePrefab, new Vector3(transform.position.x + 30 * Mathf.Cos(rot), transform.position.y + 30 * Mathf.Sin(rot), 0), transform.rotation);
		minepre.name = "P" + player + "Mine";
		minepre.transform.FindChild("MineInside").GetComponent<SVGImage>().color = GetComponent<SVGImage>().color;
		minepre.GetComponent<Mine> ().dot = this;
		minepre.GetComponent<Mine> ().PlayerMat = PlayerMat;
		minepre.GetComponent<SVGImage>().material = PlayerMat;
		minepre.transform.SetParent (transform.parent);
		minepre.transform.SetAsFirstSibling ();
	}

	/*IEnumerator Jump(){
		jumpready = false;
		jumptime = Time.time;
		Physics2D.IgnoreLayerCollision(player + 8, 8, true);
		Physics2D.IgnoreLayerCollision(player + 8, 13, true);
		Physics2D.IgnoreLayerCollision(player + 8, 15, true);
		Physics2D.IgnoreLayerCollision(player + 8, 16, true);
		Physics2D.IgnoreLayerCollision(player + 8, 17, true);
		Physics2D.IgnoreLayerCollision(player + 8, 18, true);
		Physics2D.IgnoreCollision (GetComponent<Collider2D> (), ClockHand.GetComponent<Collider2D> (), true);
		while (GetComponent<RectTransform> ().rect.width != 30) {
			GetComponent<RectTransform> ().sizeDelta = new Vector2(GetComponent<RectTransform> ().sizeDelta.x + 1, GetComponent<RectTransform> ().sizeDelta.y + 1);
			yield return new WaitForSeconds (0.03f);
		}
		while (GetComponent<RectTransform> ().rect.width != 20) {
			GetComponent<RectTransform> ().sizeDelta = new Vector2(GetComponent<RectTransform> ().sizeDelta.x - 1, GetComponent<RectTransform> ().sizeDelta.y - 1);
			yield return new WaitForSeconds (0.03f);
		}
		Physics2D.IgnoreLayerCollision(player + 8, 8, false);
		Physics2D.IgnoreLayerCollision(player + 8, 13, false);
		Physics2D.IgnoreLayerCollision(player + 8, 15, false);
		Physics2D.IgnoreLayerCollision(player + 8, 16, false);
		Physics2D.IgnoreLayerCollision(player + 8, 17, false);
		Physics2D.IgnoreLayerCollision(player + 8, 18, false);
		Physics2D.IgnoreCollision (GetComponent<Collider2D> (), ClockHand.GetComponent<Collider2D> (), false);
		yield return new WaitForSeconds (1);
		jumpready = true;
	}*/

	IEnumerator Powerup5Shooter(){
		Powerupactive = true;
		for(int i = 0; i < 5; i++){
			PU5shooter = true;
			yield return PU5shooter == false;
			yield return new WaitForSeconds(0.3f);
		}
		Powerupactive = false;
	}

	public IEnumerator Invincible(float invincibletime){
		transform.FindChild ("PlayerPointer").GetComponent<SVGImage> ().enabled = true;
		GetComponent<TrailRenderer> ().enabled = false;
		GetComponent<SVGImage> ().enabled = false;
		Physics2D.IgnoreLayerCollision(player + 8, 8, true);
		Physics2D.IgnoreLayerCollision(player + 8, 13, true);
		Physics2D.IgnoreLayerCollision(player + 8, 15, true);
		Physics2D.IgnoreLayerCollision(player + 8, 16, true);
		Physics2D.IgnoreLayerCollision(player + 8, 17, true);
		Physics2D.IgnoreLayerCollision(player + 8, 18, true);
		yield return new WaitForSeconds(invincibletime);
		Physics2D.IgnoreLayerCollision(player + 8, 8, false);
		Physics2D.IgnoreLayerCollision(player + 8, 13, false);
		Physics2D.IgnoreLayerCollision(player + 8, 15, false);
		Physics2D.IgnoreLayerCollision(player + 8, 16, false);
		Physics2D.IgnoreLayerCollision(player + 8, 17, false);
		Physics2D.IgnoreLayerCollision(player + 8, 18, false);
		GetComponent<SVGImage> ().enabled = true;
		GetComponent<TrailRenderer> ().enabled = true;
		transform.FindChild ("PlayerPointer").GetComponent<SVGImage> ().enabled = false;
	}

	IEnumerator TR() {
		GetComponent<TrailRenderer> ().sortingOrder = -50;
		yield return new WaitForSeconds (0.1f);
		GetComponent<TrailRenderer> ().time = 0.5f;
	}
}