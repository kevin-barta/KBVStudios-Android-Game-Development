using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SVGImporter;

public class Bot : MonoBehaviour {
	public Transform Shot;
	public PolyNavAgent PlayerAgent;
	public GameObject PlayerBot;
	public Material PlayerMat;
	public GameObject Hand;
	public GameObject ShotPrefab;
	public GameObject MinePrefab;
	public GameObject MainCamera;
	public int player = 0;
	public int totalshots = 3;
	public int shotnumber = 1;
	public bool Powerupactive;
	//public bool jumpshot = false;
	//public bool jump = false;
	private GameObject Player2;
	private GameObject Player3;
	private GameObject Player4;
	//private bool jumpready = true;
	private float shoottime = 0f;
	private float shotinterval = 0f;
	private float timetolive = 0f;
	private float pathinterval = 0f;
	private float updatepath = 0f;
	private float poweruptime = 0f;
	private int shooton = 0;
	private int player2 = 0;
	private int player3 = 0;
	private int player4 = 0;
	private int playerfollowing = 0;
	private bool shoot = false;
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
		GetComponent<TrailRenderer> ().time = 0f;
		StartCoroutine(TR ());
		int playerrandom = Random.Range (1, 4);
		if (playerrandom == 1) {
			playerfollowing = player2;
		}
		else if (playerrandom == 2) {
			playerfollowing = player3;
		}
		else if (playerrandom == 3) {
			playerfollowing = player4;
		}
		pathinterval = Time.time + Random.Range (0.05f, 0.5f);
		timetolive = Time.time + Random.Range (7f, 12f);
	}

	/*void OnTriggerEnter2D (Collider2D other){
		if(other.gameObject.layer == 20){
			jump = true;
		}
	}*/

	void Update () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		/*if (jump == true) {
			if (jumpready == true) {
				StartCoroutine (Jump ());
			}
		}*/
		/*if(40000 < (transform.localPosition.x * transform.localPosition.x) + (transform.localPosition.y * transform.localPosition.y)){
			transform.localPosition = new Vector3(Mathf.Sqrt(transform.localPosition.x * transform.localPosition.x * (1f / (transform.localPosition.x * transform.localPosition.x) / 40000f)), Mathf.Sqrt(transform.localPosition.y * transform.localPosition.y * (1f / (transform.localPosition.y * transform.localPosition.y) / 40000f)), 0);
		}*/
		if(GameObject.Find("Player" + playerfollowing) == null || timetolive - Time.time <= 0f){
			int playerrandom = Random.Range (1, 4);
			if (playerrandom == 1) {
				playerfollowing = player2;
			}
			else if (playerrandom == 2) {
				playerfollowing = player3;
			}
			else if (playerrandom == 3) {
				playerfollowing = player4;
			}
			pathinterval = Time.time + Random.Range (0.05f, 0.25f);
			timetolive = Time.time + Random.Range (7f, 12f);
		}
		if (pathinterval != 0f && pathinterval - Time.time <= 0f && GameObject.Find("Player" + playerfollowing) != null) {
			pathinterval = 0f;
			updatepath = Time.time + Random.Range (0.05f, 0.25f);
			PlayerAgent.SetDestination (GameObject.Find ("Player" + playerfollowing).transform.position);
		}
		if(updatepath - Time.time <= 0 && PlayerAgent.hasPath == true && PlayerAgent.pathPending == false && GameObject.Find("Player" + playerfollowing) != null){
			updatepath = Time.time + Random.Range (0.05f, 0.25f);
			PlayerAgent.SetDestination (GameObject.Find ("Player" + playerfollowing).transform.position);
		}
		if(shoottime > 0){
			shoottime -= Time.deltaTime;
		}
		if(shoottime < 0 && shooton == 1){
			shooton = 0;
		}
		else if(shoottime < 3 && shooton == 2){
			shooton = 1;
		}
		else if(shoottime < 6 && shooton == 3){
			shooton = 2;
		}
		if(PlayerAgent.hasPath == true && PlayerAgent.nextPoint == PlayerAgent.primeGoal){
			if (Powerupactive == false && (poweruptime - Time.time) <= 0) {
				poweruptime = Time.time + 2;
				int r = Random.Range (0, 100);
				if(r <= 2){
					StartCoroutine (Invincible (3));
				}
				else if(r <= 8 && GameObject.Find ("P" + player + "Mine") == null){
					PowerupMine ();
				}
				else if(r <= 15){
					Powerupactive = true;
					StartCoroutine (Powerup5Shooter ());
				}
				else if(shooton != 3 && (shotinterval - Time.time) <= 0){
					if (Player2.GetActive () != false || Player3.GetActive () != false || Player4.GetActive () != false) {
						shoot = true;
					}
				}
			}
			else if(Powerupactive == false && shooton != 3 && (shotinterval - Time.time) <= 0){
				if (Player2.GetActive () != false || Player3.GetActive () != false || Player4.GetActive () != false) {
					shoot = true;
				}
			}
		}
		if (shoot == true || PU5shooter == true){
			if(PU5shooter == true){
				PU5shooter = false;
			}
			else if(shoot == true){
				shoot = false;
				shooton++;
				shoottime += 3;
				shotinterval = Time.time + Random.Range (0.5f, 3f);
			}
			GameObject shotpre = (GameObject)Instantiate(ShotPrefab, transform.position, transform.rotation);
			shotnumber++;
			if(shotnumber == 100){
				shotnumber = 1;
			}
			shotpre.name = "P" + player + "Shot" + shotnumber;
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
			shotpre.GetComponent<Rigidbody2D>().AddForce(shotpre.transform.forward);
			shotpre.transform.eulerAngles = new Vector3(0, 0, 0);
			shotpre.GetComponent<SVGImage>().material = PlayerMat;
			shotpre.GetComponent<TrailRenderer>().material = PlayerMat; 
			shotpre.transform.SetParent(transform.parent);
			shotpre.transform.SetAsFirstSibling ();
			shotpre.layer = player + 14;
			Shot = shotpre.transform;
		}
	}
	
	void OnCollisionEnter2D(Collision2D other){
		if(gameObject.GetComponent<Bot>().enabled == true && Hand.GetComponent<Hand>().p == 0){
			if (other.gameObject.layer == 8) {
				if(MainCamera.GetComponent<Encrypt>().b1active == true && player == 1){
					MainCamera.GetComponent<Encrypt> ().deadb1 = true;
				}
				else if(MainCamera.GetComponent<Encrypt>().b2active == true && player == 2){
					MainCamera.GetComponent<Encrypt> ().deadb2 = true;
				}
				else if(MainCamera.GetComponent<Encrypt>().b3active == true && player == 3){
					MainCamera.GetComponent<Encrypt> ().deadb3 = true;
				}
				else if(MainCamera.GetComponent<Encrypt>().b4active == true && player == 4){
					MainCamera.GetComponent<Encrypt> ().deadb4 = true;
				}
				gameObject.SetActive(false);
				if (player == 1) {
					Hand.GetComponent<Hand> ().StartCoroutine (Hand.GetComponent<Hand> ().BotP1Died());
				}
				if (player == 2) {
					Hand.GetComponent<Hand> ().StartCoroutine (Hand.GetComponent<Hand> ().BotP2Died());
				}
				else if (player == 3) {
					Hand.GetComponent<Hand> ().StartCoroutine (Hand.GetComponent<Hand> ().BotP3Died());
				}
				else if (player == 4) {
					Hand.GetComponent<Hand> ().StartCoroutine (Hand.GetComponent<Hand> ().BotP4Died());
				}
			}
			if (other.gameObject.tag == "Shot"  && other.gameObject.layer != player + 14 && Hand.GetComponent<Hand>().p == 0) {
				Encrypt e = MainCamera.GetComponent<Encrypt> ();
				if (other.gameObject.GetComponent<SVGImage> ().material != PlayerMat) {
					if (other.gameObject.GetComponent<SVGImage> ().material == MainCamera.GetComponent<Encrypt> ().P1Material) {
						e.p1add = true;
					}
					else if (other.gameObject.GetComponent<SVGImage> ().material == MainCamera.GetComponent<Encrypt> ().P2Material) {
						e.p2add = true;
					}
					else if (other.gameObject.GetComponent<SVGImage> ().material == MainCamera.GetComponent<Encrypt> ().P3Material) {
						e.p3add = true;
					}
					else if (other.gameObject.GetComponent<SVGImage> ().material == MainCamera.GetComponent<Encrypt> ().P4Material) {
						e.p4add = true;
					}
				}
				if(MainCamera.GetComponent<Encrypt>().b1active == true && player == 1){
					MainCamera.GetComponent<Encrypt> ().deadb1 = true;
				}
				else if(MainCamera.GetComponent<Encrypt>().b2active == true && player == 2){
					MainCamera.GetComponent<Encrypt> ().deadb2 = true;
				}
				else if(MainCamera.GetComponent<Encrypt>().b3active == true && player == 3){
					MainCamera.GetComponent<Encrypt> ().deadb3 = true;
				}
				else if(MainCamera.GetComponent<Encrypt>().b4active == true && player == 4){
					MainCamera.GetComponent<Encrypt> ().deadb4 = true;
				}
				gameObject.SetActive(false);
				if (player == 1) {
					Hand.GetComponent<Hand> ().StartCoroutine (Hand.GetComponent<Hand> ().BotP1Died());
				}
				if (player == 2) {
					Hand.GetComponent<Hand> ().StartCoroutine (Hand.GetComponent<Hand> ().BotP2Died());
				}
				else if (player == 3) {
					Hand.GetComponent<Hand> ().StartCoroutine (Hand.GetComponent<Hand> ().BotP3Died());
				}
				else if (player == 4) {
					Hand.GetComponent<Hand> ().StartCoroutine (Hand.GetComponent<Hand> ().BotP4Died());
				}
			}
		}
	}

	public void PowerupMine(){
		float rot = -1.5707961f - Mathf.Atan2 (PlayerAgent.movingDirection.x, PlayerAgent.movingDirection.y);
		GameObject minepre = (GameObject)Instantiate(MinePrefab, new Vector3(transform.position.x + 30 * Mathf.Cos(rot), transform.position.y + 30 * Mathf.Sin(rot), 0), transform.rotation);
		minepre.name = "P" + player + "Mine";
		minepre.transform.FindChild("MineInside").GetComponent<SVGImage>().color = GetComponent<SVGImage>().color;
		minepre.GetComponent<Mine> ().bot = this;
		minepre.GetComponent<Mine> ().PlayerMat = PlayerMat;
		minepre.GetComponent<SVGImage>().material = PlayerMat;
		minepre.transform.SetParent (transform.parent);
		minepre.transform.SetAsFirstSibling ();
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

	IEnumerator Powerup5Shooter(){
		Powerupactive = true;
		for(int i = 0; i < 5; i++){
			PU5shooter = true;
			yield return PU5shooter == false;
			yield return new WaitForSeconds(0.3f);
		}
		Powerupactive = false;
	}
	
	/*IEnumerator Jump(){
		if (Physics2D.GetIgnoreLayerCollision (player + 8, 8) == false) {
			jump = false;
			jumpready = false;
			Physics2D.IgnoreLayerCollision (player + 8, 8, true);
			Physics2D.IgnoreLayerCollision (player + 8, 13, true);
			Physics2D.IgnoreLayerCollision (player + 8, 15, true);
			Physics2D.IgnoreLayerCollision (player + 8, 16, true);
			Physics2D.IgnoreLayerCollision (player + 8, 17, true);
			Physics2D.IgnoreLayerCollision (player + 8, 18, true);
			Physics2D.IgnoreCollision (GetComponent<Collider2D> (), Hand.GetComponent<Collider2D> (), true);
			while (GetComponent<RectTransform> ().rect.width != 30) {
				GetComponent<RectTransform> ().sizeDelta = new Vector2 (GetComponent<RectTransform> ().sizeDelta.x + 1, GetComponent<RectTransform> ().sizeDelta.y + 1);
				yield return new WaitForSeconds (0.03f);
			}
			while (GetComponent<RectTransform> ().rect.width != 20) {
				GetComponent<RectTransform> ().sizeDelta = new Vector2 (GetComponent<RectTransform> ().sizeDelta.x - 1, GetComponent<RectTransform> ().sizeDelta.y - 1);
				yield return new WaitForSeconds (0.03f);
			}
			Physics2D.IgnoreLayerCollision (player + 8, 8, false);
			Physics2D.IgnoreLayerCollision (player + 8, 13, false);
			Physics2D.IgnoreLayerCollision (player + 8, 15, false);
			Physics2D.IgnoreLayerCollision (player + 8, 16, false);
			Physics2D.IgnoreLayerCollision (player + 8, 17, false);
			Physics2D.IgnoreLayerCollision (player + 8, 18, false);
			Physics2D.IgnoreCollision (GetComponent<Collider2D> (), Hand.GetComponent<Collider2D> (), false);
			yield return new WaitForSeconds (1);
			jump = false;
			jumpshot = false;
			jumpready = true;
		}
	}*/
	
	IEnumerator TR() {
		GetComponent<TrailRenderer> ().sortingOrder = -100;
		yield return new WaitForSeconds (0.1f);
		GetComponent<TrailRenderer> ().time = 0.5f;
	}
}
