using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using SVGImporter;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class Encrypt : MonoBehaviour {
	public GameObject Polynav;
	public PhotonView photonview;

	public Material LightMaterial;
	public Material DarkMaterial;
	public Material P1Material;
	public Material P2Material;
	public Material P3Material;
	public Material P4Material;


	public Text KillP1;
	public Text KillP2;
	public Text KillP3;
	public Text KillP4;


	public float timesincestart = 0f;
	public int sendrate = 10;
	public int p = 0;
	public int tut;
	public int P1ShotsOn;
	public int P2ShotsOn;
	public int P3ShotsOn;
	public int P4ShotsOn;
	public bool p1add;
	public bool p2add;
	public bool p3add;
	public bool p4add;
	public bool deadp = false;
	public bool deadb1 = false;
	public bool deadb2 = false;
	public bool deadb3 = false;
	public bool deadb4 = false;
	public bool b1active = false;
	public bool b2active = false;
	public bool b3active = false;
	public bool b4active = false;
	public bool startad;
	public GameObject ShotPrefab;
	public GameObject MinePrefab;
	public GameObject Player;
	public GameObject Player1;
	public GameObject Player2;
	public GameObject Player3;
	public GameObject Player4;
	private GameObject Bot1;
	private GameObject Bot2;
	private InterstitialAd interstitial;
	//private GoogleAnalyticsV4 googleAnalytics;
	private float adtime;
	private float timeupdate;
	private int order;
	private int orderp1;
	private int orderp2;
	private int orderp3;
	private int orderp4;
	private int loadedmatch = 0;
	private bool winner;
	private bool mine;
	private double timestart = -1236;
	private double nettime = -12345;
	private double photontime = -12345;
	private double photontimep1 = -12345;
	private double photontimep2 = -12345;
	private double photontimep3 = -12345;
	private double photontimep4 = -12345;

	void Awake (){
		System.GC.Collect();
		Resources.UnloadUnusedAssets();
		Physics2D.IgnoreLayerCollision(9, 8, true);
		Physics2D.IgnoreLayerCollision(9, 13, true);
		Physics2D.IgnoreLayerCollision(9, 15, true);
		Physics2D.IgnoreLayerCollision(9, 16, true);
		Physics2D.IgnoreLayerCollision(9, 17, true);
		Physics2D.IgnoreLayerCollision(9, 18, true);
		Physics2D.IgnoreLayerCollision(10, 8, true);
		Physics2D.IgnoreLayerCollision(10, 13, true);
		Physics2D.IgnoreLayerCollision(10, 15, true);
		Physics2D.IgnoreLayerCollision(10, 16, true);
		Physics2D.IgnoreLayerCollision(10, 17, true);
		Physics2D.IgnoreLayerCollision(10, 18, true);
		Physics2D.IgnoreLayerCollision(11, 8, true);
		Physics2D.IgnoreLayerCollision(11, 13, true);
		Physics2D.IgnoreLayerCollision(11, 15, true);
		Physics2D.IgnoreLayerCollision(11, 16, true);
		Physics2D.IgnoreLayerCollision(11, 17, true);
		Physics2D.IgnoreLayerCollision(11, 18, true);
		Physics2D.IgnoreLayerCollision(12, 8, true);
		Physics2D.IgnoreLayerCollision(12, 13, true);
		Physics2D.IgnoreLayerCollision(12, 15, true);
		Physics2D.IgnoreLayerCollision(12, 16, true);
		Physics2D.IgnoreLayerCollision(12, 17, true);
		Physics2D.IgnoreLayerCollision(12, 18, true);
		if (PhotonNetwork.player.name == "") {
			tut = 1;
			GameObject.Find("Overlay").SetActive (false);
			GameObject.Find("PlayerNumberText").SetActive (false);
			GameObject.Find("PlayerColour").SetActive (false);
			GameObject.Find ("TutorialText").GetComponent<Text>().enabled = true;
			GameObject.Find ("TutorialCentreText").GetComponent<Text>().enabled = true;
			GameObject.Find("TutorialCentre").GetComponent<Button> ().interactable = true;
			p = 1;
			Physics2D.IgnoreLayerCollision(p + 8, 8, false);
			Player = GameObject.Find("Player1");
			Player.GetComponent<Dot> ().enabled = true;
		}
		else{
			if (PhotonNetwork.player.name == "Player1") {
				p = 1;
				GameObject.Find("PlayerNumberText").GetComponent<Text>().text = "YOU ARE PLAYER 1";
				GameObject.Find ("PlayerColour").GetComponent<SVGImage> ().material = GameObject.Find ("Player1").GetComponent<SVGImage> ().material;
			}
			else if (PhotonNetwork.player.name == "Player2") {
				p = 2;
				GameObject.Find("PlayerNumberText").GetComponent<Text>().text = "YOU ARE PLAYER 2";
				GameObject.Find ("PlayerColour").GetComponent<SVGImage> ().material = GameObject.Find ("Player2").GetComponent<SVGImage> ().material;
			}
			else if (PhotonNetwork.player.name == "Player3") {
				p = 3;
				GameObject.Find("PlayerNumberText").GetComponent<Text>().text = "YOU ARE PLAYER 3";
				GameObject.Find ("PlayerColour").GetComponent<SVGImage> ().material = GameObject.Find ("Player3").GetComponent<SVGImage> ().material;
			}
			else if (PhotonNetwork.player.name == "Player4") {
				p = 4;
				GameObject.Find("PlayerNumberText").GetComponent<Text>().text = "YOU ARE PLAYER 4";
				GameObject.Find ("PlayerColour").GetComponent<SVGImage> ().material = GameObject.Find ("Player4").GetComponent<SVGImage> ().material;
			}
			Player = GameObject.Find ("Player" + p);
			Player1 = GameObject.Find ("Player1");
			Player2 = GameObject.Find ("Player2");
			Player3 = GameObject.Find ("Player3");
			Player4 = GameObject.Find ("Player4");
			Physics2D.IgnoreLayerCollision(p + 8, 8, false);
			Physics2D.IgnoreLayerCollision(p + 8, 13, false);
			Physics2D.IgnoreLayerCollision(p + 8, 15, false);
			Physics2D.IgnoreLayerCollision(p + 8, 16, false);
			Physics2D.IgnoreLayerCollision(p + 8, 17, false);
			Physics2D.IgnoreLayerCollision(p + 8, 18, false);
			GameObject.Find("ClockHand").GetComponent<Hand>().Player = Player.GetComponent<Dot>();
			photonview.RPC ("LoadedMatch", PhotonTargets.MasterClient);
			Application.runInBackground = true;
		}
		Color light = Color.white;
		Color dark = Color.black;
		Color p1col = Color.white;
		Color p2col = Color.white;
		Color p3col = Color.white;
		Color p4col = Color.white;
		if (StoreData.GetStoreData (3, 0) == "2") {
			light = new Color (0.25f, 0.63f, 1);
			dark = new Color (0.25f, 0.44f, 1);
			p1col = new Color (1, 0.25f, 0.5f);
			p2col = new Color (0, 1, 0.5f);
			p3col = new Color (1, 1, 0.38f);
			p4col = new Color (0.5f, 0.5f, 1);
		}
			else if (StoreData.GetStoreData (3, 1) == "2") {
			light = new Color (0, 0.75f, 0.38f);
			dark = new Color (0.19f, 0.16f, 0.13f);
			p1col = new Color (1, 0.5f, 0.25f);
			p2col = new Color (0, 0.5f, 1);
			p3col = new Color (1, 0.13f, 0.38f);
			p4col = new Color (1, 1, 0.5f);
		}
		else if (StoreData.GetStoreData (3, 2) == "2") {
			light = new Color (0.25f, 0.25f, 0.63f);
			dark = new Color (0.88f, 0.25f, 0.31f);
			p1col = new Color (0.25f, 0.75f, 0.75f);
			p2col = new Color (1, 0.63f, 0.25f);
			p3col = new Color (0.88f, 0.31f, 0.25f);
			p4col = new Color (0.5f, 0.38f, 0.38f);
		}
		else if (StoreData.GetStoreData (3, 3) == "2") {
			light = new Color (1, 0.38f, 0.19f);
			dark = new Color (1, 0.19f, 0.19f);
			p1col = new Color (0.5f, 0.38f, 1);	
			p2col = new Color (0.82f, 0, 0.31f);
			p3col = new Color (0, 0.63f, 0.82f);
			p4col = new Color (0.31f, 0.75f, 0.5f);
		}
		else if (StoreData.GetStoreData (3, 4) == "2") {
			light = new Color (0.5f, 0.44f, 0.63f);
			dark = new Color (1, 0.75f, 0.25f);
			p1col = new Color (0.88f, 0.38f, 0.44f);
			p2col = new Color (1, 0.56f, 0.38f);
			p3col = new Color (0.5f, 0.82f, 0.5f);
			p4col = new Color (0.75f, 0.44f, 0.56f);
		}
		LightMaterial.color = light;
		DarkMaterial.color = dark;
		P1Material.color = p1col;
		P2Material.color = p2col;
		P3Material.color = p3col;
		P4Material.color = p4col;
		//googleAnalytics = GameObject.Find ("GAv4").GetComponent<GoogleAnalyticsV4>();
	}

	[PunRPC]
	void LoadedMatch () {
		loadedmatch++;
		if(loadedmatch == (PhotonNetwork.room.playerCount)){
			nettime = -12345;
			if (PhotonNetwork.time + 5 > 4294967.295) {
				nettime = PhotonNetwork.time - 4294962.295;
			}
			else {
				nettime = PhotonNetwork.time + 5;
			}
			photonview.RPC ("TimeToStartMatch", PhotonTargets.All, nettime);
		}
	}

	[PunRPC]
	void TimeToStartMatch (double servertime) {
		timestart = servertime;
		if (timestart - 5 < 0) {
			nettime = timestart + 4294972.295;
		}
		else {
			nettime = timestart + 5;
		}
	}

	[PunRPC]
	void Winner (int win) {
		if(KillP1.text != "10" || KillP2.text != "10" || KillP3.text != "10" || KillP4.text != "10"){
			if(win == 1){
				KillP1.text = "10";
				GameObject.Find("ClockHand").GetComponent<Hand>().whohittext = "PLAYER 1 \n WINS!";
			}
			else if(win == 2){
				KillP2.text = "10";
				GameObject.Find("ClockHand").GetComponent<Hand>().whohittext = "PLAYER 2 \n WINS!";
			}
			else if(win == 3){
				KillP3.text = "10";
				GameObject.Find("ClockHand").GetComponent<Hand>().whohittext = "PLAYER 3 \n WINS!";
			}
			else if(win == 4){
				KillP4.text = "10";
				GameObject.Find("ClockHand").GetComponent<Hand>().whohittext = "PLAYER 4 \n WINS!";
			}
		}
	}

	[PunRPC]
	void SH (string sh) {
		GameObject TempPlayer = null;
		Material TempMaterial = null;
		if(sh.Substring(0, 1) != "9"){
			int templayer = 0;
			if(sh.Substring(0, 1) == "1"){
				TempPlayer = Player1;
				TempMaterial = P1Material;
				templayer = 15;
			}
			else if(sh.Substring(0, 1) == "2"){
				TempPlayer = Player2;
				TempMaterial = P2Material;
				templayer = 16;
			}
			else if(sh.Substring(0, 1) == "3"){
				TempPlayer = Player3;
				TempMaterial = P3Material;
				templayer = 17;
			}
			else if(sh.Substring(0, 1) == "4"){
				TempPlayer = Player4;
				TempMaterial = P4Material;
				templayer = 18;
			}
			if(TempPlayer != null){
				GameObject shotpre = (GameObject)Instantiate(ShotPrefab, TempPlayer.transform.position, TempPlayer.transform.rotation);
				shotpre.name = "P" + sh.Substring(0, 1) + "Shot" + sh.Substring(2, 2);
				if(sh.Substring(1, 1) == "0"){
					shotpre.transform.LookAt(GameObject.Find("ClockHandMiddle").transform);
				}
				if(sh.Substring(1, 1) == "1" && Player1 != null){
					shotpre.transform.LookAt(Player1.transform);
				}
				else if(sh.Substring(1, 1) == "2" && Player2 != null){
					shotpre.transform.LookAt(Player2.transform);
				}
				else if(sh.Substring(1, 1) == "3" && Player3 != null){
					shotpre.transform.LookAt(Player3.transform);
				}
				else if(sh.Substring(1, 1) == "4" && Player4 != null){
					shotpre.transform.LookAt(Player4.transform);
				}
				shotpre.GetComponent<Rigidbody2D>().AddForce(shotpre.transform.forward);
				shotpre.transform.eulerAngles = new Vector3(0, 0, 0);
				shotpre.GetComponent<SVGImage>().material = TempMaterial;
				shotpre.GetComponent<TrailRenderer>().material = TempMaterial; 
				shotpre.transform.SetParent(TempPlayer.transform.parent);
				shotpre.transform.SetAsFirstSibling ();
				shotpre.layer = templayer;
			}
		}
		else{
			if(sh.Substring(1, 1) == "1"){
				TempPlayer = Player1;
				TempMaterial = P1Material;
			}
			else if(sh.Substring(1, 1) == "2"){
				TempPlayer = Player2;
				TempMaterial = P2Material;
			}
			else if(sh.Substring(1, 1) == "3"){
				TempPlayer = Player3;
				TempMaterial = P3Material;
			}
			else if(sh.Substring(1, 1) == "4"){
				TempPlayer = Player4;
				TempMaterial = P4Material;
			}
			if(TempPlayer != null){
				int tempshoton = 0;
				for (int i = 0; i < 360; i += 60) {
					GameObject shotpre = (GameObject)Instantiate (ShotPrefab, TempPlayer.transform.position, TempPlayer.transform.rotation);
					shotpre.name = "P" + sh.Substring(1, 1) + "Shot" + sh.Substring(2, 2);
					shotpre.transform.localEulerAngles = new Vector3 (0, 0, i);
					shotpre.GetComponent<Rigidbody2D>().AddForce(shotpre.transform.up);
					shotpre.transform.localEulerAngles = new Vector3(0, 0, 0);
					shotpre.GetComponent<SVGImage>().material = TempMaterial;
					shotpre.GetComponent<TrailRenderer>().material = TempMaterial;
					shotpre.transform.SetParent(TempPlayer.transform.parent);
					shotpre.transform.SetAsFirstSibling ();
					tempshoton++;
				}
			}
		}
	}

	[PunRPC]
	void Add1 () {
		KillP1.text = (int.Parse (KillP1.text) + 1).ToString ();
	}

	[PunRPC]
	void Add2 () {
		KillP2.text = (int.Parse (KillP2.text) + 1).ToString ();
	}

	[PunRPC]
	void Add3 () {
		KillP3.text = (int.Parse (KillP3.text) + 1).ToString ();
	}

	[PunRPC]
	void Add4 () {
		KillP4.text = (int.Parse (KillP4.text) + 1).ToString ();
	}

	[PunRPC]
	void P1 (string encryptionstring) {
		UpdateData (1, encryptionstring);
	}

	[PunRPC]
	void P2 (string encryptionstring) {
		UpdateData (2, encryptionstring);
	}

	[PunRPC]
	void P3 (string encryptionstring) {
		UpdateData (3, encryptionstring);
	}

	[PunRPC]
	void P4 (string encryptionstring) {
		UpdateData (4, encryptionstring);
	}

	public void RunSH (string shotdata){
		if (PhotonNetwork.room.playerCount != 1) {
			photonview.RPC ("SH", PhotonTargets.Others, shotdata);
		}
	}

	public void OnClickContinue(){
		tut++;
		if (tut == 2) {
			GameObject.Find ("TutorialText").GetComponent<Text> ().text = "OBJECTIVE: Shoot the Other Dots a Total of 10 Times to Win!";
		}
		else if (tut == 3) {
			GameObject.Find ("PointerJoyStick").GetComponent<SVGImage> ().enabled = true;
			GameObject.Find ("TutorialText").GetComponent<Text> ().text = "Use the Joystick to Move your Dot!";
		}
		else if (tut == 4) {
			GameObject.Find ("PointerJoyStick").GetComponent<SVGImage> ().enabled = false;
			GameObject.Find ("PointerShootButton").GetComponent<SVGImage> ().enabled = true;
			GameObject.Find ("TutorialText").GetComponent<Text> ().text = "Use the Shoot Button to Shoot at the Closet Dot!\nThe Other 3 Buttons are Powerups!";
		}
		else if (tut == 5) {
			GameObject.Find ("PointerShootButton").GetComponent<SVGImage> ().enabled = false;
			GameObject.Find ("Pointer5Shooter").GetComponent<SVGImage> ().enabled = true;
			GameObject.Find ("PointerMine").GetComponent<SVGImage> ().enabled = true;
			GameObject.Find ("PointerInvincible").GetComponent<SVGImage> ().enabled = true;
			GameObject.Find ("TutorialText").GetComponent<Text> ().text = "The Other 3 Buttons are Powerups! (Active Only in Game)";
		}
		else if (tut == 6) {
			GameObject.Find ("Pointer5Shooter").GetComponent<SVGImage> ().enabled = false;
			GameObject.Find ("PointerMine").GetComponent<SVGImage> ().enabled = false;
			GameObject.Find ("PointerInvincible").GetComponent<SVGImage> ().enabled = false;
			GameObject.Find ("TutorialText").GetComponent<Text> ().text = "Loading...";
			PlayerPref.SetString("Tutorial", "1");
			SceneManager.LoadScene (1);
		}
	}

	public void Powerup(int powerupnumber){
		if (timestart == -12364 || tut != 0) {
			/*if (powerupnumber == 1) {
				if (Physics2D.GetIgnoreLayerCollision (Player.layer, 8) == false) {
					Player.GetComponent<Dot> ().jumpbutton = true;
				}
			}*/
			if (powerupnumber == 5 && tut == 0) {
				if (StoreData.SetCoins (0, 0, false, "0n00050") == true) {
					GameObject.Find ("InfoText").GetComponent<InfoText> ().UpdateInfoText ("Purchase Successful! " + StoreData.GetQuickCoins () + " Coins Left!", 2, 1);
					Player.GetComponent<Dot> ().StartCoroutine (Player.GetComponent<Dot> ().Invincible (3));
				}
				else {
					GameObject.Find ("InfoText").GetComponent<InfoText> ().UpdateInfoText ("Purchase Failed! Not Enough Coins!", 2, 1);
				}
			}
			else if (powerupnumber == 10) {
				Player.GetComponent<Dot> ().StartCoroutine (Player.GetComponent<Dot> ().Invincible (1.5f));
			}
			if (Player.GetComponent<Dot> ().Powerupactive == false) {
				if (powerupnumber == 2 && Player.GetComponent<Dot> ().shootbutton == false) {
					Player.GetComponent<Dot> ().shootbutton = true;
				}
				else if (powerupnumber == 3 && tut == 0) {
					if (StoreData.SetCoins (0, 0, false, "0n00010") == true) {
						GameObject.Find ("InfoText").GetComponent<InfoText> ().UpdateInfoText ("Purchase Successful! " + StoreData.GetQuickCoins () + " Coins Left!", 2, 1);
						Player.GetComponent<Dot> ().StartCoroutine ("Powerup5Shooter");
					}
					else {
						GameObject.Find ("InfoText").GetComponent<InfoText> ().UpdateInfoText ("Purchase Failed! Not Enough Coins!", 2, 1);
					}
				}
				else if (powerupnumber == 4 && tut == 0) {
					if (GameObject.Find ("P" + p + "Mine") == null) {
						if (StoreData.SetCoins (0, 0, false, "0n00025") == true) {
							GameObject.Find ("InfoText").GetComponent<InfoText> ().UpdateInfoText ("Purchase Successful! " + StoreData.GetQuickCoins () + " Coins Left!", 2, 1);
							Player.GetComponent<Dot> ().PowerupMine ();
						}
						else {
							GameObject.Find ("InfoText").GetComponent<InfoText> ().UpdateInfoText ("Purchase Failed! Not Enough Coins!", 2, 1);
						}
					}
				}
			}
		}
	}


	private void OnEvent(byte eventCode, object content, int senderId)
	{
		if (eventCode == 1 && Player1 != null){
			UpdateData (1, content.ToString());
		}
		else if (eventCode == 2 && Player2 != null){
			UpdateData (2, content.ToString());
		}
		else if (eventCode == 3 && Player3 != null){
			UpdateData (3, content.ToString());
		}
		else if (eventCode == 4 && Player4 != null){
			UpdateData (4, content.ToString());
		}
	}

	void UpdateData(int pl, string encryptionstring){
		encryptionstring = Decryption(encryptionstring);
		print (encryptionstring);
		GameObject PlGameObject = null;
		int o = 0;
		if (pl == 1) {
			o = orderp1;
			PlGameObject = Player1;
			photontimep1 = PhotonNetwork.time;
		}
		else if (pl == 2) {
			o = orderp2;
			PlGameObject = Player2;
			photontimep2 = PhotonNetwork.time;
		}
		else if (pl == 3) {
			o = orderp3;
			PlGameObject = Player3;
			photontimep3 = PhotonNetwork.time;
		}
		else if (pl == 4) {
			o = orderp4;
			PlGameObject = Player4;
			photontimep4 = PhotonNetwork.time;
		}
		string[] en = encryptionstring.Split(',');
		int tempo = o + 50;
		bool correct = false;
		if (tempo > 99) {
			tempo -= 99;
			if(o <= int.Parse(en[0]) || tempo > int.Parse(en[0])){
				correct = true;
			}
		}
		else if(o <= int.Parse(en[0]) && tempo >= int.Parse(en[0])){
			correct = true;
		}
		if(correct == true){
			if (pl == 1) {
				orderp1 = int.Parse (en [0]);
			}
			else if (pl == 2) {
				orderp2 = int.Parse (en [0]);
			}
			else if (pl == 3) {
				orderp3 = int.Parse (en [0]);
			}
			else if (pl == 4) {
				orderp4 = int.Parse (en [0]);
			}
			if(en[1] != "" && en[2] != ""){
				PlGameObject.SetActive (true);
				PlGameObject.GetComponent<Dots> ().time = Time.time;
				PlGameObject.GetComponent<Dots> ().oldposx = PlGameObject.transform.localPosition.x;
				PlGameObject.GetComponent<Dots> ().oldposy = PlGameObject.transform.localPosition.y;
				PlGameObject.GetComponent<Dots> ().posx = int.Parse(en[1]) / 10f;
				PlGameObject.GetComponent<Dots> ().posy = int.Parse(en[2]) / 10f;
			}
			else{
				PlGameObject.GetComponent<Dots> ().time = 0;
				PlGameObject.transform.localPosition = new Vector3(PlGameObject.GetComponent<Dots> ().startingposx, PlGameObject.GetComponent<Dots> ().startingposy, 0);
				PlGameObject.SetActive (false);

			}
			if(en[3] == "1"){
				PlGameObject.transform.FindChild ("PlayerPointer").GetComponent<SVGImage> ().enabled = true;
				PlGameObject.GetComponent<TrailRenderer> ().enabled = false;
				PlGameObject.GetComponent<SVGImage> ().enabled = false;
			}
			else{
				PlGameObject.GetComponent<SVGImage> ().enabled = true;
				PlGameObject.GetComponent<TrailRenderer> ().enabled = true;
				PlGameObject.transform.FindChild ("PlayerPointer").GetComponent<SVGImage> ().enabled = false;
			}
			if(en[4] != ""){
				GameObject minepre = (GameObject)Instantiate(MinePrefab);
				minepre.name = "P" + pl + "Mine";
				minepre.transform.FindChild("MineInside").GetComponent<SVGImage>().color = PlGameObject.GetComponent<SVGImage>().color;
				minepre.GetComponent<Mine> ().PlayerMat = PlGameObject.GetComponent<SVGImage>().material;
				minepre.GetComponent<SVGImage> ().material = PlGameObject.GetComponent<SVGImage>().material;
				minepre.transform.SetParent (PlGameObject.transform.parent);
				minepre.transform.SetAsFirstSibling ();
				minepre.transform.localPosition = new Vector3 (int.Parse (en [4]) / 10f, int.Parse (en [5]) / 10f, 0);
			}
			/*if(en.Length > 6){
				int shname = 0;
				int shoton = 8;
				int shotnum = int.Parse(en [6]);
				int shotnum1 = shotnum + 50;
				if(shotnum1 > 99){
					shotnum -= 99;
				}
				foreach (GameObject sh in GameObject.FindGameObjectsWithTag("Shot")) {
					if (sh.name != "ShotAI" && sh.name != "MineInside" && sh.name.Substring (1) != "Mine" && int.Parse (sh.name.Substring (1, 1)) == pl) {
						shname = int.Parse (sh.name.Substring (6));
						if (shname <= shotnum && shotnum + 50 >= shname) {
						}
						else {
							Destroy (sh);
						}
					}
				}	
				for (int i = 7; i < en.Length; i += 2) {
					if (GameObject.Find ("P" + pl + "Shot" + shotnum)) {
						GameObject.Find ("P" + pl + "Shot" + shotnum).transform.localPosition = new Vector3 (int.Parse (en [shoton]) / 10f, int.Parse (en [shoton + 1]) / 10f, 0);
					}
					else {
						GameObject shotpre = (GameObject)Instantiate(ShotPrefab, PlGameObject.transform.position, PlGameObject.transform.rotation);
						shotpre.name = "P" + pl + "Shot" + shotnum;
						shotpre.transform.eulerAngles = new Vector3(0, 0, 0);
						shotpre.GetComponent<SVGImage>().material = PlGameObject.GetComponent<SVGImage>().material;
						shotpre.GetComponent<TrailRenderer>().material = PlGameObject.GetComponent<SVGImage>().material; 
						shotpre.transform.SetParent(PlGameObject.transform.parent);
						shotpre.transform.SetAsFirstSibling ();
					}
					shotnum++;
					if(shotnum == 100){
						shotnum = 1;
					}
				}
			}
			else{
				foreach (GameObject sh in GameObject.FindGameObjectsWithTag("Shot")) {
					if (sh.name != "ShotAI" && sh.name != "MineInside" && sh.name.Substring (1) != "Mine" && int.Parse (sh.name.Substring (1, 1)) == pl) {
						Destroy (sh);
					}
				}	
			}*/
		}
		else if(en[4] != ""){
			GameObject minepre = (GameObject)Instantiate(MinePrefab);
			minepre.name = "P" + pl + "Mine";
			minepre.transform.FindChild("MineInside").GetComponent<SVGImage>().color = PlGameObject.GetComponent<SVGImage>().color;
			minepre.GetComponent<Mine> ().PlayerMat = PlGameObject.GetComponent<SVGImage>().material;
			minepre.GetComponent<SVGImage> ().material = PlGameObject.GetComponent<SVGImage>().material;
			minepre.transform.SetParent (PlGameObject.transform.parent);
			minepre.transform.SetAsFirstSibling ();
			minepre.transform.localPosition = new Vector3 (int.Parse (en [4]) / 10f, int.Parse (en [5]) / 10f, 0);
		}
	}

	void Update (){
		if(tut == 0 && timestart != -12364 && PhotonNetwork.time - timestart > 0 && PhotonNetwork.time - timestart < 65000){
			timestart = -12364;
			PhotonNetwork.OnEventCall += this.OnEvent;
			Destroy(GameObject.Find ("Overlay"));
			Destroy(GameObject.Find ("PlayerNumberText"));
			Destroy(GameObject.Find ("PlayerColour"));
			GameObject.Find ("ClockHand").GetComponent<Hand> ().speed = -60;
			Player.GetComponent<Dot> ().enabled = true;
			if (PhotonNetwork.isMasterClient) {
				bool p1picked = false;
				bool p2picked = false;
				bool p3picked = false;
				bool p4picked = false;
				foreach(PhotonPlayer pp in PhotonNetwork.playerList) {
					if (pp.name == "Player1") {
						p1picked = true;
					}
					else if (pp.name == "Player2") {
						p2picked = true;
					}
					else if (pp.name == "Player3") {
						p3picked = true;
					}
					else if (pp.name == "Player4") {
						p4picked = true;
					}
				}
				if(p1picked == false){
					b1active = true;
					Polynav.SetActive (true);
					Player1.GetComponent<Bot> ().enabled = true;
					Player1.GetComponent<PolyNavAgent> ().enabled = true;
					Physics2D.IgnoreLayerCollision(9, 8, false);
					Physics2D.IgnoreLayerCollision(9, 13, false);
					Physics2D.IgnoreLayerCollision(9, 15, false);
					Physics2D.IgnoreLayerCollision(9, 16, false);
					Physics2D.IgnoreLayerCollision(9, 17, false);
					Physics2D.IgnoreLayerCollision(9, 18, false);
				}
				if(p2picked == false){
					b2active = true;
					Polynav.SetActive (true);
					Player2.GetComponent<Bot> ().enabled = true;
					Player2.GetComponent<PolyNavAgent> ().enabled = true;
					Physics2D.IgnoreLayerCollision(10, 8, false);
					Physics2D.IgnoreLayerCollision(10, 13, false);
					Physics2D.IgnoreLayerCollision(10, 15, false);
					Physics2D.IgnoreLayerCollision(10, 16, false);
					Physics2D.IgnoreLayerCollision(10, 17, false);
					Physics2D.IgnoreLayerCollision(10, 18, false);
				}
				if(p3picked == false){
					b3active = true;
					Polynav.SetActive (true);
					Player3.GetComponent<Bot> ().enabled = true;
					Player3.GetComponent<PolyNavAgent> ().enabled = true;
					Physics2D.IgnoreLayerCollision(11, 8, false);
					Physics2D.IgnoreLayerCollision(11, 13, false);
					Physics2D.IgnoreLayerCollision(11, 15, false);
					Physics2D.IgnoreLayerCollision(11, 16, false);
					Physics2D.IgnoreLayerCollision(11, 17, false);
					Physics2D.IgnoreLayerCollision(11, 18, false);
				}
				if(p4picked == false){
					b4active = true;
					Polynav.SetActive (true);
					Player4.GetComponent<Bot> ().enabled = true;
					Player4.GetComponent<PolyNavAgent> ().enabled = true;
					Physics2D.IgnoreLayerCollision(12, 8, false);
					Physics2D.IgnoreLayerCollision(12, 13, false);
					Physics2D.IgnoreLayerCollision(12, 15, false);
					Physics2D.IgnoreLayerCollision(12, 16, false);
					Physics2D.IgnoreLayerCollision(12, 17, false);
					Physics2D.IgnoreLayerCollision(12, 18, false);
				}
			}
		}
		else if(timestart != -12364 && timestart != -1236){
			if (nettime > 4294972.295 && PhotonNetwork.time < 10) {
				GameObject.Find ("PlayerColourText").GetComponent<Text> ().text = Mathf.CeilToInt((float)(timestart - PhotonNetwork.time + 4294967.295)).ToString();
			}
			else {
				GameObject.Find ("PlayerColourText").GetComponent<Text> ().text = Mathf.CeilToInt((float)(timestart - PhotonNetwork.time)).ToString();
			}
		}
			
		if(timestart == -12364){
			if (PhotonNetwork.room.playerCount != 1 && PhotonNetwork.time - photontime > 0.5f && PhotonNetwork.time > 1 && photontime != -12345) {
				if(GameObject.Find("Canvas") != null){
					GameObject.Find ("Canvas").SetActive (false);
					PhotonNetwork.Disconnect ();
					SceneManager.LoadScene (1);
				}
			}
			else {
				photontime = PhotonNetwork.time;
			}
			if (PhotonNetwork.time - photontimep1 > 0.5f && PhotonNetwork.time > 1 && photontimep1 != -12345 && Player1 != null) {
				Player1.SetActive (false);
			}
			if (PhotonNetwork.time - photontimep2 > 0.5f && PhotonNetwork.time > 1 && photontimep2 != -12345 && Player2 != null) {
				Player2.SetActive (false);
			}
			if (PhotonNetwork.time - photontimep3 > 0.5f && PhotonNetwork.time > 1 && photontimep3 != -12345 && Player3 != null) {
				Player3.SetActive (false);
			}
			if (PhotonNetwork.time - photontimep4 > 0.5f && PhotonNetwork.time > 1 && photontimep4 != -12345 && Player4 != null) {
				Player4.SetActive (false);
			}
			if(interstitial == null && startad == true){
				RequestInterstitial ();
			}
			if (interstitial != null && interstitial.IsLoaded()) {
				adtime = Time.time;
				interstitial.Show();
			}
			if (KillP1.text == "9" && p1add == true && winner == false) {
				p1add = false;
				winner = true;
				photonview.RPC ("Winner", PhotonTargets.AllViaServer, 1);
			}
			else if (KillP2.text == "9" && p2add == true && winner == false) {
				p2add = false;
				winner = true;
				photonview.RPC ("Winner", PhotonTargets.AllViaServer, 2);
			}
			else if (KillP3.text == "9" && p3add == true && winner == false) {
				p3add = false;
				winner = true;
				photonview.RPC ("Winner", PhotonTargets.AllViaServer, 3);
			}
			else if (KillP4.text == "9" && p4add == true && winner == false) {
				p4add = false;
				winner = true;
				photonview.RPC ("Winner", PhotonTargets.AllViaServer, 4);
			}
			if (p1add == true) {
				p1add = false;
				photonview.RPC ("Add1", PhotonTargets.AllViaServer);
			}
			if (p2add == true) {
				p2add = false;
				photonview.RPC ("Add2", PhotonTargets.AllViaServer);
			}
			if (p3add == true) {
				p3add = false;
				photonview.RPC ("Add3", PhotonTargets.AllViaServer);
			}
			if (p4add == true) {
				p4add = false;
				photonview.RPC ("Add4", PhotonTargets.AllViaServer);
			}
			//Order(length 2), PlayerPosx(length 4), PlayerPosy(length 4), Invincible(length 1), MinePosx(length 4), Mineposy(length 4), Shot#(length 2), ShotsPosx(length 4 * #ofshots), ShotsPosy(length 4 * #ofshots)
			if (Time.time - timeupdate >= 1f/sendrate && PhotonNetwork.room.playerCount != 1) {
				timeupdate = Time.time;
				order++;
				if (order == 100) {
					order = 0;
				}
				for (int pl = 1; pl < 5; pl++) {
					if (pl == 1 && p != pl && b1active == false) {
					}
					else if (pl == 2 && p != pl && b2active == false) {
					}
					else if (pl == 3 && p != pl && b3active == false) {
					}
					else if (pl == 4 && p != pl && b4active == false) {
					}
					else{
						string encryptionstring = order.ToString ();
						if (GameObject.Find ("Player" + pl) != null) {
							string i = "";
							int spx = 0;
							int spy = 0;
							GameObject Playerpl = GameObject.Find ("Player" + pl);
							if (Playerpl.transform.GetChild (2).GetComponent<SVGImage> ().enabled == true) {
								i = "1";
							}
							encryptionstring += "," + Mathf.RoundToInt (Playerpl.transform.localPosition.x * 10).ToString () + "," + Mathf.RoundToInt (Playerpl.transform.localPosition.y * 10).ToString () + "," + i;
						}
						else {
							encryptionstring += ",,,";
						}
						if (GameObject.Find ("P" + pl + "Mine") != null && mine == false) {
							mine = true;
							encryptionstring += "," + Mathf.RoundToInt ((GameObject.Find ("P" + pl + "Mine").transform.localPosition.x * 10)).ToString () + "," + Mathf.RoundToInt ((GameObject.Find ("P" + pl + "Mine").transform.localPosition.y * 10)).ToString () + ",";
						}
						else {
							if(GameObject.Find ("P" + pl + "Mine") == null){
								mine = false;
							}
							encryptionstring += ",,,";
						}
						/*int shotnum = 100;
						for (int i = 1; i < 100; i++) {
							if (GameObject.Find ("P" + pl + "Shot" + i) != null) {
								if (GameObject.Find ("P" + pl + "Shot1") != null) {
									if (i > 50 && shotnum > i) {
										shotnum = i;
									}
								}
								else if (shotnum > i) {
									shotnum = i;
								}
							}
						}
						if (GameObject.Find ("P" + pl + "Shot" + shotnum) != null) {
							encryptionstring += "," + shotnum;
							for (int i = 1; i < 100; i++) {
								if (GameObject.Find ("P" + pl + "Shot" + shotnum) != null) {
									Transform s1 = GameObject.Find ("P" + pl + "Shot" + shotnum).transform;
									encryptionstring += "," + Mathf.RoundToInt (s1.localPosition.x * 10).ToString () + "," + Mathf.RoundToInt (s1.localPosition.y * 10).ToString ();
									shotnum++;
									if (shotnum == 100) {
										shotnum = 1;
									}
								}
								else {
									i = 100;
								}
							}
						}*/
						byte bb = 0;
						if(pl == 1){
							bb = 1;
						}
						else if(pl == 2){
							bb = 2;
						}
						else if(pl == 3){
							bb = 3;
						}
						else if(pl == 4){
							bb = 4;
						}
						PhotonNetwork.RaiseEvent(bb, Encryption (encryptionstring) , false, RaiseEventOptions.Default);
					}
				}
			}
		}
	}

	private void RequestInterstitial(){
		#if UNITY_ANDROID
		string adUnitId = "ca-app-pub-8870763355959902/6408559876";
		#elif UNITY_IPHONE
		string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		// Initialize an InterstitialAd.
		interstitial = new InterstitialAd(adUnitId);
		//register events
		interstitial.OnAdFailedToLoad += Interstitial_OnAdFailedToLoad;
		interstitial.OnAdLoaded += Interstitial_OnAdLoaded;
		interstitial.OnAdLeavingApplication += Interstitial_OnAdLeavingApplication;;
		interstitial.OnAdClosed += Interstitial_OnAdClosed;
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the interstitial with the request.
		interstitial.LoadAd(request);
	}

	void Interstitial_OnAdLeavingApplication (object sender, System.EventArgs e){
		//googleAnalytics.LogScreen ("Interstitual AD Clicked");
	}

	void Interstitial_OnAdFailedToLoad (object sender, AdFailedToLoadEventArgs e){
		//googleAnalytics.LogScreen ("Interstitual AD Failed To Load");
	}

	void Interstitial_OnAdLoaded (object sender, System.EventArgs e){
		//googleAnalytics.LogScreen ("Interstitual AD Shown");
	}

	void Interstitial_OnAdClosed (object sender, System.EventArgs e){
		//googleAnalytics.LogTiming (new TimingHitBuilder().SetTimingName("Interstitual AD Time").SetTimingInterval(System.Convert.ToInt64(Time.time - adtime)));
		interstitial.Destroy ();
	}

	public IEnumerator GameDone (){
		yield return new WaitForSeconds (5);
		SceneManager.LoadScene (1);
	}

	private string Encryption (string encryptionstring) {
		if(encryptionstring.Length % 2 != 0){
			encryptionstring += "?";
		}
		string[] str = new string[encryptionstring.Length/2];
		int k = 0;
		for (int i = 0; i < encryptionstring.Length; i++)
		{
			str[k] = encryptionstring[i].ToString() + encryptionstring[i + 1].ToString();
			i += 1;
			k += 1;
		}
		for (int m = 0; m < str.Length; m++) {
			if(str[m] == "00"){
				str[m] = "a";
			}
			else if(str[m] == "01"){
				str[m] = "b";
			}
			else if(str[m] == "02"){
				str[m] = "c";
			}
			else if(str[m] == "03"){
				str[m] = "d";
			}
			else if(str[m] == "04"){
				str[m] = "e";
			}
			else if(str[m] == "05"){
				str[m] = "f";
			}
			else if(str[m] == "06"){
				str[m] = "g";
			}
			else if(str[m] == "07"){
				str[m] = "h";
			}
			else if(str[m] == "08"){
				str[m] = "i";
			}
			else if(str[m] == "09"){
				str[m] = "j";
			}
			else if(str[m] == "10"){
				str[m] = "k";
			}
			else if(str[m] == "11"){
				str[m] = "l";
			}
			else if(str[m] == "12"){
				str[m] = "m";
			}
			else if(str[m] == "13"){
				str[m] = "n";
			}
			else if(str[m] == "14"){
				str[m] = "o";
			}
			else if(str[m] == "15"){
				str[m] = "p";
			}
			else if(str[m] == "16"){
				str[m] = "q";
			}
			else if(str[m] == "17"){
				str[m] = "r";
			}
			else if(str[m] == "18"){
				str[m] = "s";
			}
			else if(str[m] == "19"){
				str[m] = "t";
			}
			else if(str[m] == "20"){
				str[m] = "u";
			}
			else if(str[m] == "21"){
				str[m] = "v";
			}
			else if(str[m] == "22"){
				str[m] = "w";
			}
			else if(str[m] == "23"){
				str[m] = "x";
			}
			else if(str[m] == "24"){
				str[m] = "y";
			}
			else if(str[m] == "25"){
				str[m] = "z";
			}
			else if(str[m] == "26"){
				str[m] = "A";
			}
			else if(str[m] == "27"){
				str[m] = "B";
			}
			else if(str[m] == "28"){
				str[m] = "C";
			}
			else if(str[m] == "29"){
				str[m] = "D";
			}
			else if(str[m] == "30"){
				str[m] = "E";
			}
			else if(str[m] == "31"){
				str[m] = "F";
			}
			else if(str[m] == "32"){
				str[m] = "G";
			}
			else if(str[m] == "33"){
				str[m] = "H";
			}
			else if(str[m] == "34"){
				str[m] = "I";
			}
			else if(str[m] == "35"){
				str[m] = "J";
			}
			else if(str[m] == "36"){
				str[m] = "K";
			}
			else if(str[m] == "37"){
				str[m] = "L";
			}
			else if(str[m] == "38"){
				str[m] = "M";
			}
			else if(str[m] == "39"){
				str[m] = "N";
			}
			else if(str[m] == "40"){
				str[m] = "O";
			}
			else if(str[m] == "41"){
				str[m] = "P";
			}
			else if(str[m] == "42"){
				str[m] = "Q";
			}
			else if(str[m] == "43"){
				str[m] = "R";
			}
			else if(str[m] == "44"){
				str[m] = "S";
			}
			else if(str[m] == "45"){
				str[m] = "T";
			}
			else if(str[m] == "46"){
				str[m] = "U";
			}
			else if(str[m] == "47"){
				str[m] = "V";
			}
			else if(str[m] == "48"){
				str[m] = "W";
			}
			else if(str[m] == "49"){
				str[m] = "X";
			}
			else if(str[m] == "50"){
				str[m] = "Y";
			}
			else if(str[m] == "51"){
				str[m] = "Z";
			}
			else if(str[m] == "52"){
				str[m] = "1";
			}
			else if(str[m] == "53"){
				str[m] = "2";
			}
			else if(str[m] == "54"){
				str[m] = "3";
			}
			else if(str[m] == "55"){
				str[m] = "4";
			}
			else if(str[m] == "56"){
				str[m] = "5";
			}
			else if(str[m] == "57"){
				str[m] = "6";
			}
			else if(str[m] == "58"){
				str[m] = "7";
			}
			else if(str[m] == "59"){
				str[m] = "8";
			}
			else if(str[m] == "60"){
				str[m] = "9";
			}
			else if(str[m] == "61"){
				str[m] = "0";
			}
			else if(str[m] == "62"){
				str[m] = "!";
			}
			else if(str[m] == "63"){
				str[m] = "@";
			}
			else if(str[m] == "64"){
				str[m] = "#";
			}
			else if(str[m] == "65"){
				str[m] = "$";
			}
			else if(str[m] == "66"){
				str[m] = "%";
			}
			else if(str[m] == "67"){
				str[m] = "^";
			}
			else if(str[m] == "68"){
				str[m] = "&";
			}
			else if(str[m] == "69"){
				str[m] = "*";
			}
			else if(str[m] == "70"){
				str[m] = "(";
			}
			else if(str[m] == "71"){
				str[m] = ")";
			}
			else if(str[m] == "72"){
				str[m] = "~";
			}
			else if(str[m] == "73"){
				str[m] = "`";
			}
			else if(str[m] == "74"){
				str[m] = "_";
			}
			else if(str[m] == "75"){
				str[m] = "+";
			}
			else if(str[m] == "76"){
				str[m] = "=";
			}
			else if(str[m] == "77"){
				str[m] = "[";
			}
			else if(str[m] == "78"){
				str[m] = "{";
			}
			else if(str[m] == "79"){
				str[m] = "]";
			}
			else if(str[m] == "80"){
				str[m] = "}";
			}
			else if(str[m] == "81"){
				str[m] = "|";
			}
			else if(str[m] == "82"){
				str[m] = ":";
			}
			else if(str[m] == "83"){
				str[m] = ";";
			}
			else if(str[m] == "84"){
				str[m] = "'";
			}
			else if(str[m] == "85"){
				str[m] = "<";
			}
			else if(str[m] == "86"){
				str[m] = ">";
			}
			else if(str[m] == "87"){
				str[m] = ".";
			}
			else if(str[m] == "88"){
				str[m] = "/";
			}
			else if(str[m] == "89"){
				str[m] = "?0";
			}
			else if(str[m] == "90"){
				str[m] = "?1";
			}
			else if(str[m] == "91"){
				str[m] = "?2";
			}
			else if(str[m] == "92"){
				str[m] = "?3";
			}
			else if(str[m] == "93"){
				str[m] = "?4";
			}
			else if(str[m] == "94"){
				str[m] = "?5";
			}
			else if(str[m] == "95"){
				str[m] = "?6";
			}
			else if(str[m] == "96"){
				str[m] = "?7";
			}
			else if(str[m] == "97"){
				str[m] = "?8";
			}
			else if(str[m] == "98"){
				str[m] = "?9";
			}
			else if(str[m] == "99"){
				str[m] = "?A";
			}
			else if(str[m] == ",0"){
				str[m] = "?B";
			}
			else if(str[m] == ",1"){
				str[m] = "?C";
			}
			else if(str[m] == ",2"){
				str[m] = "?D";
			}
			else if(str[m] == ",3"){
				str[m] = "?E";
			}
			else if(str[m] == ",4"){
				str[m] = "?F";
			}
			else if(str[m] == ",5"){
				str[m] = "?G";
			}
			else if(str[m] == ",6"){
				str[m] = "?H";
			}
			else if(str[m] == ",7"){
				str[m] = "?I";
			}
			else if(str[m] == ",8"){
				str[m] = "?J";
			}
			else if(str[m] == ",9"){
				str[m] = "?K";
			}
			else if(str[m] == "0,"){
				str[m] = "?L";
			}
			else if(str[m] == "1,"){
				str[m] = "?M";
			}
			else if(str[m] == "2,"){
				str[m] = "?N";
			}
			else if(str[m] == "3,"){
				str[m] = "?O";
			}
			else if(str[m] == "4,"){
				str[m] = "?P";
			}
			else if(str[m] == "5,"){
				str[m] = "?Q";
			}
			else if(str[m] == "6,"){
				str[m] = "?R";
			}
			else if(str[m] == "7,"){
				str[m] = "?S";
			}
			else if(str[m] == "8,"){
				str[m] = "?T";
			}
			else if(str[m] == "9,"){
				str[m] = "?U";
			}
			else if(str[m] == "-0"){
				str[m] = "?V";
			}
			else if(str[m] == "-1"){
				str[m] = "?W";
			}
			else if(str[m] == "-2"){
				str[m] = "?X";
			}
			else if(str[m] == "-3"){
				str[m] = "?Y";
			}
			else if(str[m] == "-4"){
				str[m] = "?Z";
			}
			else if(str[m] == "-5"){
				str[m] = "?a";
			}
			else if(str[m] == "-6"){
				str[m] = "?b";
			}
			else if(str[m] == "-7"){
				str[m] = "?c";
			}
			else if(str[m] == "-8"){
				str[m] = "?d";
			}
			else if(str[m] == "-9"){
				str[m] = "?e";
			}
			else if(str[m] == "0-"){
				str[m] = "?f";
			}
			else if(str[m] == "1-"){
				str[m] = "?g";
			}
			else if(str[m] == "2-"){
				str[m] = "?h";
			}
			else if(str[m] == "3-"){
				str[m] = "?i";
			}
			else if(str[m] == "4-"){
				str[m] = "?j";
			}
			else if(str[m] == "5-"){
				str[m] = "?k";
			}
			else if(str[m] == "6-"){
				str[m] = "?l";
			}
			else if(str[m] == "7-"){
				str[m] = "?m";
			}
			else if(str[m] == "8-"){
				str[m] = "?n";
			}
			else if(str[m] == "9-"){
				str[m] = "?o";
			}
			else if(str[m] == ",,"){
				str[m] = "?p";
			}
			else if(str[m] == "--"){
				str[m] = "?q";
			}
			else if(str[m] == ",-"){
				str[m] = "?r";
			}
			else if(str[m] == "-,"){
				str[m] = "?s";
			}
			else if(str[m] == "0?"){
				str[m] = "?t";
			}
			else if(str[m] == "1?"){
				str[m] = "?u";
			}
			else if(str[m] == "2?"){
				str[m] = "?v";
			}
			else if(str[m] == "3?"){
				str[m] = "?w";
			}
			else if(str[m] == "4?"){
				str[m] = "?x";
			}
			else if(str[m] == "5?"){
				str[m] = "?y";
			}
			else if(str[m] == "6?"){
				str[m] = "?z";
			}
			else if(str[m] == "7?"){
				str[m] = "?A";
			}
			else if(str[m] == "8?"){
				str[m] = "?B";
			}
			else if(str[m] == "9?"){
				str[m] = "?C";
			}
			else if(str[m] == "-?"){
				str[m] = "?D";
			}
			else if(str[m] == ",?"){
				str[m] = "?E";
			}
		}
		string str1 = string.Join ("", str);
		return (str1);
	}

	private string Decryption (string decryptionstring){
		//string[] str0 = new string[1];
		//str0 [0] = decryptionstring;
		string[] str0 = decryptionstring.Split(' ');
		decryptionstring = "";
		for (int z = 0; z < str0.Length; z++){
			string str2 = str0[z];
			string str4 = "";
			for (int n = 0; n < str2.Length; n++) {
				bool correct = true;
				if(str2.Substring(n, 1) == "?"){
					if(str2.Substring(n + 1, 1) == "0"){
						str4 += "89";
					}
					else if(str2.Substring(n + 1, 1) == "1"){
						str4 += "90";
					}
					else if(str2.Substring(n + 1, 1) == "2"){
						str4 += "91";
					}
					else if(str2.Substring(n + 1, 1) == "3"){
						str4 += "92";
					}
					else if(str2.Substring(n + 1, 1) == "4"){
						str4 += "93";
					}
					else if(str2.Substring(n + 1, 1) == "5"){
						str4 += "94";
					}
					else if(str2.Substring(n + 1, 1) == "6"){
						str4 += "95";
					}
					else if(str2.Substring(n + 1, 1) == "7"){
						str4 += "96";
					}
					else if(str2.Substring(n + 1, 1) == "8"){
						str4 += "97";
					}
					else if(str2.Substring(n + 1, 1) == "9"){
						str4 += "98";
					}
					else if(str2.Substring(n + 1, 1) == "A"){
						str4 += "99";
					}
					else if(str2.Substring(n + 1, 1) == "B"){
						str4 += ",0";
					}
					else if(str2.Substring(n + 1, 1) == "C"){
						str4 += ",1";
					}
					else if(str2.Substring(n + 1, 1) == "D"){
						str4 += ",2";
					}
					else if(str2.Substring(n + 1, 1) == "E"){
						str4 += ",3";
					}
					else if(str2.Substring(n + 1, 1) == "F"){
						str4 += ",4";
					}
					else if(str2.Substring(n + 1, 1) == "G"){
						str4 += ",5";
					}
					else if(str2.Substring(n + 1, 1) == "H"){
						str4 += ",6";
					}
					else if(str2.Substring(n + 1, 1) == "I"){
						str4 += ",7";
					}
					else if(str2.Substring(n + 1, 1) == "J"){
						str4 += ",8";
					}
					else if(str2.Substring(n + 1, 1) == "K"){
						str4 += ",9";
					}
					else if(str2.Substring(n + 1, 1) == "L"){
						str4 += "0,";
					}
					else if(str2.Substring(n + 1, 1) == "M"){
						str4 += "1,";
					}
					else if(str2.Substring(n + 1, 1) == "N"){
						str4 += "2,";
					}
					else if(str2.Substring(n + 1, 1) == "O"){
						str4 += "3,";
					}
					else if(str2.Substring(n + 1, 1) == "P"){
						str4 += "4,";
					}
					else if(str2.Substring(n + 1, 1) == "Q"){
						str4 += "5,";
					}
					else if(str2.Substring(n + 1, 1) == "R"){
						str4 += "6,";
					}
					else if(str2.Substring(n + 1, 1) == "S"){
						str4 += "7,";
					}
					else if(str2.Substring(n + 1, 1) == "T"){
						str4 += "8,";
					}
					else if(str2.Substring(n + 1, 1) == "U"){
						str4 += "9,";
					}
					else if(str2.Substring(n + 1, 1) == "V"){
						str4 += "-0";
					}
					else if(str2.Substring(n + 1, 1) == "W"){
						str4 += "-1";
					}
					else if(str2.Substring(n + 1, 1) == "X"){
						str4 += "-2";
					}
					else if(str2.Substring(n + 1, 1) == "Y"){
						str4 += "-3";
					}
					else if(str2.Substring(n + 1, 1) == "Z"){
						str4 += "-4";
					}
					else if(str2.Substring(n + 1, 1) == "a"){
						str4 += "-5";
					}
					else if(str2.Substring(n + 1, 1) == "b"){
						str4 += "-6";
					}
					else if(str2.Substring(n + 1, 1) == "c"){
						str4 += "-7";
					}
					else if(str2.Substring(n + 1, 1) == "d"){
						str4 += "-8";
					}
					else if(str2.Substring(n + 1, 1) == "e"){
						str4 += "-9";
					}
					else if(str2.Substring(n + 1, 1) == "f"){
						str4 += "0-";
					}
					else if(str2.Substring(n + 1, 1) == "g"){
						str4 += "1-";
					}
					else if(str2.Substring(n + 1, 1) == "h"){
						str4 += "2-";
					}
					else if(str2.Substring(n + 1, 1) == "i"){
						str4 += "3-";
					}
					else if(str2.Substring(n + 1, 1) == "j"){
						str4 += "4-";
					}
					else if(str2.Substring(n + 1, 1) == "k"){
						str4 += "5-";
					}
					else if(str2.Substring(n + 1, 1) == "l"){
						str4 += "6-";
					}
					else if(str2.Substring(n + 1, 1) == "m"){
						str4 += "7-";
					}
					else if(str2.Substring(n + 1, 1) == "n"){
						str4 += "8-";
					}
					else if(str2.Substring(n + 1, 1) == "o"){
						str4 += "9-";
					}
					else if(str2.Substring(n + 1, 1) == "p"){
						str4 += ",,";
					}
					else if(str2.Substring(n + 1, 1) == "q"){
						str4 += "--";
					}
					else if(str2.Substring(n + 1, 1) == "r"){
						str4 += ",-";
					}
					else if(str2.Substring(n + 1, 1) == "s"){
						str4 += "-,";
					}
					else if(str2.Substring(n + 1, 1) == "t"){
						str4 += "0";
					}
					else if(str2.Substring(n + 1, 1) == "u"){
						str4 += "1";
					}
					else if(str2.Substring(n + 1, 1) == "v"){
						str4 += "2";
					}
					else if(str2.Substring(n + 1, 1) == "w"){
						str4 += "3";
					}
					else if(str2.Substring(n + 1, 1) == "x"){
						str4 += "4";
					}
					else if(str2.Substring(n + 1, 1) == "y"){
						str4 += "5";
					}
					else if(str2.Substring(n + 1, 1) == "z"){
						str4 += "6";
					}
					else if(str2.Substring(n + 1, 1) == "A"){
						str4 += "7";
					}
					else if(str2.Substring(n + 1, 1) == "B"){
						str4 += "8";
					}
					else if(str2.Substring(n + 1, 1) == "C"){
						str4 += "9";
					}
					else if(str2.Substring(n + 1, 1) == "D"){
						str4 += "-";
					}
					else if(str2.Substring(n + 1, 1) == "E"){
						str4 += ",";
					}
					else{
						correct = false;
					}
					if(correct == true){
						n += 1;
					}
				}
				else if(str2.Substring(n, 1) == "a"){
					str4 += "00";
				}
				else if(str2.Substring(n, 1) == "b"){
					str4 += "01";
				}
				else if(str2.Substring(n, 1) == "c"){
					str4 += "02";
				}
				else if(str2.Substring(n, 1) == "d"){
					str4 += "03";
				}
				else if(str2.Substring(n, 1) == "e"){
					str4 += "04";
				}
				else if(str2.Substring(n, 1) == "f"){
					str4 += "05";
				}
				else if(str2.Substring(n, 1) == "g"){
					str4 += "06";
				}
				else if(str2.Substring(n, 1) == "h"){
					str4 += "07";
				}
				else if(str2.Substring(n, 1) == "i"){
					str4 += "08";
				}
				else if(str2.Substring(n, 1) == "j"){
					str4 += "09";
				}
				else if(str2.Substring(n, 1) == "k"){
					str4 += "10";
				}
				else if(str2.Substring(n, 1) == "l"){
					str4 += "11";
				}
				else if(str2.Substring(n, 1) == "m"){
					str4 += "12";
				}
				else if(str2.Substring(n, 1) == "n"){
					str4 += "13";
				}
				else if(str2.Substring(n, 1) == "o"){
					str4 += "14";
				}
				else if(str2.Substring(n, 1) == "p"){
					str4 += "15";
				}
				else if(str2.Substring(n, 1) == "q"){
					str4 += "16";
				}
				else if(str2.Substring(n, 1) == "r"){
					str4 += "17";
				}
				else if(str2.Substring(n, 1) == "s"){
					str4 += "18";
				}
				else if(str2.Substring(n, 1) == "t"){
					str4 += "19";
				}
				else if(str2.Substring(n, 1) == "u"){
					str4 += "20";
				}
				else if(str2.Substring(n, 1) == "v"){
					str4 += "21";
				}
				else if(str2.Substring(n, 1) == "w"){
					str4 += "22";
				}
				else if(str2.Substring(n, 1) == "x"){
					str4 += "23";
				}
				else if(str2.Substring(n, 1) == "y"){
					str4 += "24";
				}
				else if(str2.Substring(n, 1) == "z"){
					str4 += "25";
				}
				else if(str2.Substring(n, 1) == "A"){
					str4 += "26";
				}
				else if(str2.Substring(n, 1) == "B"){
					str4 += "27";
				}
				else if(str2.Substring(n, 1) == "C"){
					str4 += "28";
				}
				else if(str2.Substring(n, 1) == "D"){
					str4 += "29";
				}
				else if(str2.Substring(n, 1) == "E"){
					str4 += "30";
				}
				else if(str2.Substring(n, 1) == "F"){
					str4 += "31";
				}
				else if(str2.Substring(n, 1) == "G"){
					str4 += "32";
				}
				else if(str2.Substring(n, 1) == "H"){
					str4 += "33";
				}
				else if(str2.Substring(n, 1) == "I"){
					str4 += "34";
				}
				else if(str2.Substring(n, 1) == "J"){
					str4 += "35";
				}
				else if(str2.Substring(n, 1) == "K"){
					str4 += "36";
				}
				else if(str2.Substring(n, 1) == "L"){
					str4 += "37";
				}
				else if(str2.Substring(n, 1) == "M"){
					str4 += "38";
				}
				else if(str2.Substring(n, 1) == "N"){
					str4 += "39";
				}
				else if(str2.Substring(n, 1) == "O"){
					str4 += "40";
				}
				else if(str2.Substring(n, 1) == "P"){
					str4 += "41";
				}
				else if(str2.Substring(n, 1) == "Q"){
					str4 += "42";
				}
				else if(str2.Substring(n, 1) == "R"){
					str4 += "43";
				}
				else if(str2.Substring(n, 1) == "S"){
					str4 += "44";
				}
				else if(str2.Substring(n, 1) == "T"){
					str4 += "45";
				}
				else if(str2.Substring(n, 1) == "U"){
					str4 += "46";
				}
				else if(str2.Substring(n, 1) == "V"){
					str4 += "47";
				}
				else if(str2.Substring(n, 1) == "W"){
					str4 += "48";
				}
				else if(str2.Substring(n, 1) == "X"){
					str4 += "49";
				}
				else if(str2.Substring(n, 1) == "Y"){
					str4 += "50";
				}
				else if(str2.Substring(n, 1) == "Z"){
					str4 += "51";
				}
				else if(str2.Substring(n, 1) == "1"){
					str4 += "52";
				}
				else if(str2.Substring(n, 1) == "2"){
					str4 += "53";
				}
				else if(str2.Substring(n, 1) == "3"){
					str4 += "54";
				}
				else if(str2.Substring(n, 1) == "4"){
					str4 += "55";
				}
				else if(str2.Substring(n, 1) == "5"){
					str4 += "56";
				}
				else if(str2.Substring(n, 1) == "6"){
					str4 += "57";
				}
				else if(str2.Substring(n, 1) == "7"){
					str4 += "58";
				}
				else if(str2.Substring(n, 1) == "8"){
					str4 += "59";
				}
				else if(str2.Substring(n, 1) == "9"){
					str4 += "60";
				}
				else if(str2.Substring(n, 1) == "0"){
					str4 += "61";
				}
				else if(str2.Substring(n, 1) == "!"){
					str4 += "62";
				}
				else if(str2.Substring(n, 1) == "@"){
					str4 += "63";
				}
				else if(str2.Substring(n, 1) == "#"){
					str4 += "64";
				}
				else if(str2.Substring(n, 1) == "$"){
					str4 += "65";
				}
				else if(str2.Substring(n, 1) == "%"){
					str4 += "66";
				}
				else if(str2.Substring(n, 1) == "^"){
					str4 += "67";
				}
				else if(str2.Substring(n, 1) == "&"){
					str4 += "68";
				}
				else if(str2.Substring(n, 1) == "*"){
					str4 += "69";
				}
				else if(str2.Substring(n, 1) == "("){
					str4 += "70";
				}
				else if(str2.Substring(n, 1) == ")"){
					str4 += "71";
				}
				else if(str2.Substring(n, 1) == "~"){
					str4 += "72";
				}
				else if(str2.Substring(n, 1) == "`"){
					str4 += "73";
				}
				else if(str2.Substring(n, 1) == "_"){
					str4 += "74";
				}
				else if(str2.Substring(n, 1) == "+"){
					str4 += "75";
				}
				else if(str2.Substring(n, 1) == "="){
					str4 += "76";
				}
				else if(str2.Substring(n, 1) == "["){
					str4 += "77";
				}
				else if(str2.Substring(n, 1) == "{"){
					str4 += "78";
				}
				else if(str2.Substring(n, 1) == "]"){
					str4 += "79";
				}
				else if(str2.Substring(n, 1) == "}"){
					str4 += "80";
				}
				else if(str2.Substring(n, 1) == "|"){
					str4 += "81";
				}
				else if(str2.Substring(n, 1) == ":"){
					str4 += "82";
				}
				else if(str2.Substring(n, 1) == ";"){
					str4 += "83";
				}
				else if(str2.Substring(n, 1) == "'"){
					str4 += "84";
				}
				else if(str2.Substring(n, 1) == "<"){
					str4 += "85";
				}
				else if(str2.Substring(n, 1) == ">"){
					str4 += "86";
				}
				else if(str2.Substring(n, 1) == "."){
					str4 += "87";
				}
				else if(str2.Substring(n, 1) == "/"){
					str4 += "88";
				}
				else{
					correct = false;
				}
				if(correct == false){
					print ("ERROR " + n);
				}
			}
			decryptionstring += str4; 
		}
		return (decryptionstring);
	}
}