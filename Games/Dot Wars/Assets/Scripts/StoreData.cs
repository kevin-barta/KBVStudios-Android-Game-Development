using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StoreData : MonoBehaviour {
	public Text storeinfotext;
	public Text cointext;
	public Text buy1;
	public Text buy2;
	public Text buy3;
	public Text buy4;
	public Text buy5;
	public Text speed;
	public Text shots;
	public Text scened;
	public Text scene1;
	public Text scene2;
	public Text scene3;
	public Text scene4;
	//private GoogleAnalyticsV4 googleAnalytics;

	public void Start (){
		//googleAnalytics = GameObject.Find ("GAv4").GetComponent<GoogleAnalyticsV4>();
	}

	public void OnClickStoreData(string sectionandbuyid){
		ReadyToGetStoreData(int.Parse(sectionandbuyid.Split (',') [0]), int.Parse(sectionandbuyid.Split (',') [1]));
	}

	public void ReadyToGetStoreData(int sectionid, int itembuyid){
		if(sectionid == 0){
			GetCoins(cointext, true, true);
			//googleAnalytics.LogTiming (new TimingHitBuilder().SetTimingName("Amount Of Coins").SetTimingInterval(System.Convert.ToInt64(GetQuickCoins())));
		}
		else if(sectionid == 1){
			if (itembuyid == 0) {
				//no internet connection
				buy1.text = int.Parse (GetStoreData (1, 1)) + "\n" + "Coins";
				buy2.text = int.Parse (GetStoreData (1, 2)) + "\n" + "Coins";
				buy3.text = int.Parse (GetStoreData (1, 3)) + "\n" + "Coins";
				buy4.text = int.Parse (GetStoreData (1, 4)) + "\n" + "Coins";
				buy5.text = int.Parse (GetStoreData (1, 5)) + "\n" + "Coins";
			}
			/*TEMP DISABLED!

			else if (itembuyid == 1) {
				//oncoinsverified
				SetCoins(1, 1, true, "");
				storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
			}
			else if (itembuyid == 2) {
				//oncoinsverified
				SetCoins(1, 2, true, "");
				storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
			}
			else if (itembuyid == 3) {
				//oncoinsverified
				SetCoins(1, 3, true, "");
				storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
			}
			else if (itembuyid == 4) {
				//oncoinsverified
				SetCoins(1, 4, true, "");
				storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
			}
			else if (itembuyid == 5) {
				//oncoinsverified
				SetCoins(1, 5, true, "");
				storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
			}*/
			else {
				//googleAnalytics.LogScreen ("Wanted To Purchase Coins Package " + itembuyid);
				storeinfotext.text = "Coin Purchases Are Temporarily Disabled!";
			}
			
		}
		else if(sectionid == 2){
			if (itembuyid == 0) {
				string s = GetStoreData (2, 1);
				if (s.Length > 6) {
					speed.text = "Speed (" + s.Substring (8) + ")" + "\n" + int.Parse(s.Substring (0, 6)) + " Coins";
				}
				else {
					speed.text = "Speed (10)" + "\n" + "Max Speed";
					speed.GetComponentInParent<Button> ().interactable = false;
				}
				s = GetStoreData (2, 2);
				if (s.Length > 6) {
					shots.text = "Shots (" + s.Substring (8) + ")" + "\n" + int.Parse(s.Substring (0, 6)) + " Coins";
				}
				else {
					shots.text = "Shots (3)" + "\n" + "Max Shots";
					shots.GetComponentInParent<Button> ().interactable = false;
				}
			}
			else if(itembuyid == 1){
				if (SetCoins (2, 1, false, "") == true) {
					SetStoreData (2, 1);
					//googleAnalytics.LogScreen ("Upgraded Speed");
					storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
					ReadyToGetStoreData (2, 0);
				}
				else {
					storeinfotext.text = "Not Enough Coins!";
				}
			}
			else if(itembuyid == 2){
				if (SetCoins (2, 2, false, "") == true) {
					SetStoreData (2, 2);
					//googleAnalytics.LogScreen ("Upgraded Shots");
					storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
					ReadyToGetStoreData (2, 0);
				}
				else {
					storeinfotext.text = "Not Enough Coins!";
				}
			}
		}
		else if(sectionid == 3){
			if (itembuyid == 0) {
				int s = int.Parse (GetStoreData (3, 0));
				if(s == 1){
					scened.GetComponentInParent<Button> ().interactable = true;
					scened.text = "";
				}
				else if(s == 2){
					scened.GetComponentInParent<Button> ().interactable = false;
					scened.text = "ACTIVE";
				}
				s = int.Parse (GetStoreData (3, 1));
				if(s == 1){
					scene1.GetComponentInParent<Button> ().interactable = true;
					scene1.text = "";
				}
				else if(s == 2){
					scene1.GetComponentInParent<Button> ().interactable = false;
					scene1.text = "ACTIVE";
				}
				else{
					scene1.text = s + "\n" + "Coins";
				}
				s = int.Parse (GetStoreData (3, 2));
				if(s == 1){
					scene2.GetComponentInParent<Button> ().interactable = true;
					scene2.text = "";
				}
				else if(s == 2){
					scene2.GetComponentInParent<Button> ().interactable = false;
					scene2.text = "ACTIVE";
				}
				else{
					scene2.text = s + "\n" + "Coins";
				}
				s = int.Parse (GetStoreData (3, 3));
				if(s == 1){
					scene3.GetComponentInParent<Button> ().interactable = true;
					scene3.text = "";
				}
				else if(s == 2){
					scene3.GetComponentInParent<Button> ().interactable = false;
					scene3.text = "ACTIVE";
				}
				else{
					scene3.text = s + "\n" + "Coins";
				}
				s = int.Parse (GetStoreData (3, 4));
				if(s == 1){
					scene4.GetComponentInParent<Button> ().interactable = true;
					scene4.text = "";
				}
				else if(s == 2){
					scene4.GetComponentInParent<Button> ().interactable = false;
					scene4.text = "ACTIVE";
				}
				else{
					scene4.text = s + "\n" + "Coins";
				}
			}
			else if(itembuyid == -1){
				SetStoreData (3, 0);
				//googleAnalytics.LogScreen ("Scene Default Active");
				storeinfotext.text = "Scene Change Successful!";
				ReadyToGetStoreData (3, 0);
			}
			else if(itembuyid == 1){
				if(GetStoreData(3, 1) != "1"){
					if (SetCoins (3, 1, false, "") == true) {
						SetStoreData (3, 1);
						//googleAnalytics.LogScreen ("Purchased Scene 1");
						storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
						ReadyToGetStoreData (3, 0);
					}
					else {
						storeinfotext.text = "Not Enough Coins!";
					}
				}
				else{
					SetStoreData (3, 1);
					//googleAnalytics.LogScreen ("Scene 1 Active");
					storeinfotext.text = "Scene Change Successful!";
					ReadyToGetStoreData (3, 0);
				}
			}
			else if(itembuyid == 2){
				if(GetStoreData(3, 2) != "1"){
					if (SetCoins (3, 2, false, "") == true) {
						SetStoreData (3, 2);
						//googleAnalytics.LogScreen ("Purchased Scene 2");
						storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
						ReadyToGetStoreData (3, 0);
					}
					else {
						storeinfotext.text = "Not Enough Coins!";
					}
				}
				else{
					SetStoreData (3, 2);
					//googleAnalytics.LogScreen ("Scene 2 Active");
					storeinfotext.text = "Scene Change Successful!";
					ReadyToGetStoreData (3, 0);
				}
			}
			else if(itembuyid == 3){
				if(GetStoreData(3, 3) != "1"){
					if (SetCoins (3, 3, false, "") == true) {
						SetStoreData (3, 3);
						//googleAnalytics.LogScreen ("Purchased Scene 3");
						storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
						ReadyToGetStoreData (3, 0);
					}
					else {
						storeinfotext.text = "Not Enough Coins!";
					}
				}
				else{
					SetStoreData (3, 3);
					//googleAnalytics.LogScreen ("Scene 3 Active");
					storeinfotext.text = "Scene Change Successful!";
					ReadyToGetStoreData (3, 0);
				}
			}
			else if(itembuyid == 4){
				if(GetStoreData(3, 4) != "1"){
					if (SetCoins (3, 4, false, "") == true) {
						SetStoreData (3, 4);
						//googleAnalytics.LogScreen ("Purchased Scene 4");
						storeinfotext.text = "Purchase Successful! \n You now have " + GetQuickCoins() + " Coins!";
						ReadyToGetStoreData (3, 0);
					}
					else {
						storeinfotext.text = "Not Enough Coins!";
					}
				}
				else{
					SetStoreData (3, 4);
					//googleAnalytics.LogScreen ("Scene 4 Active");
					storeinfotext.text = "Scene Change Successful!";
					ReadyToGetStoreData (3, 0);
				}
			}
		}
	}

	public static string GetQuickCoins (){
		if(PlayerPref.GetString("Coins") == ""){
			PlayerPref.SetString ("Coins", "n000n0000");
		}
		string c = PlayerPref.GetString ("Coins").Substring (1, 3);
		string c1 = PlayerPref.GetString ("Coins").Substring (5, 4);
		return int.Parse (c + c1).ToString ("000000");
	}

	public static void GetCoins(Text cointext, bool nextline, bool frontzeros){
		if(PlayerPref.GetString("Coins") == ""){
			PlayerPref.SetString ("Coins", "n000n0000");
		}
		string c = PlayerPref.GetString ("Coins").Substring (1, 3);
		string c1 = PlayerPref.GetString ("Coins").Substring (5, 4);
		if (nextline == true && frontzeros == true) {
			cointext.text = "Coins: " + "\n" + int.Parse(c + c1).ToString ("000000");
		}
		else if (nextline == true) {
			cointext.text = "Coins: " + "\n" + c + c1;
		}
		else if (frontzeros == true) {
			cointext.text = "Coins: " + int.Parse(c + c1).ToString ("000000");
		}
		else{
			cointext.text = "Coins: " + c + c1;
		}
	}

	/// <param name="letterandincreasevalue">6 zeros and second from front "n" letter and increase value.</param>
	public static bool SetCoins(int sectionid, int itemid, bool increase, string letterandincreasevalue){
		if(PlayerPref.GetString("Coins") == ""){
			PlayerPref.SetString ("Coins", "n000n0000");
		}
		string c = PlayerPref.GetString ("Coins");
		int place1 = int.Parse(c.Substring(1, 1));
		int place2 = int.Parse(c.Substring(2, 1));
		int place3 = int.Parse(c.Substring(3, 1));
		int place4 = int.Parse(c.Substring(5, 1));
		int place5 = int.Parse(c.Substring(6, 1));
		int place6 = int.Parse(c.Substring(7, 1));
		int place7 = int.Parse(c.Substring(8, 1));
		if (increase == true) {
			if(letterandincreasevalue != ""){
				place2 += int.Parse (letterandincreasevalue.Substring (0, 1));
				place3 += int.Parse (letterandincreasevalue.Substring (2, 1));
				place4 += int.Parse (letterandincreasevalue.Substring (3, 1));
				place5 += int.Parse (letterandincreasevalue.Substring (4, 1));
				place6 += int.Parse (letterandincreasevalue.Substring (5, 1));
				place7 += int.Parse (letterandincreasevalue.Substring (6, 1));
			}
			else{
				string cpositive = GetStoreData (sectionid, itemid).Substring (0, 6);
				place2 += int.Parse (cpositive.Substring (0, 1));
				place3 += int.Parse (cpositive.Substring (1, 1));
				place4 += int.Parse (cpositive.Substring (2, 1));
				place5 += int.Parse (cpositive.Substring (3, 1));
				place6 += int.Parse (cpositive.Substring (4, 1));
				place7 += int.Parse (cpositive.Substring (5, 1));
			}
			if (place7 > 9) {
				place6++;
				place7 -= 10;
			}
			if (place6 > 9) {
				place5++;
				place6 -= 10;
			}
			if (place5 > 9) {
				place4++;
				place5 -= 10;
			}
			if (place4 > 9) {
				place3++;
				place4 -= 10;
			}
			if (place3 > 9) {
				place2++;
				place3 -= 10;
			}
			if (place2 > 9) {
				place1++;
				place2 -= 10;
			}
		}
		else{
			if (letterandincreasevalue != "") {
				place2 -= int.Parse (letterandincreasevalue.Substring (0, 1));
				place3 -= int.Parse (letterandincreasevalue.Substring (2, 1));
				place4 -= int.Parse (letterandincreasevalue.Substring (3, 1));
				place5 -= int.Parse (letterandincreasevalue.Substring (4, 1));
				place6 -= int.Parse (letterandincreasevalue.Substring (5, 1));
				place7 -= int.Parse (letterandincreasevalue.Substring (6, 1));
			}
			else {
				string cnegative = GetStoreData (sectionid, itemid).Substring (0, 6);
				place2 -= int.Parse (cnegative.Substring (0, 1));
				place3 -= int.Parse (cnegative.Substring (1, 1));
				place4 -= int.Parse (cnegative.Substring (2, 1));
				place5 -= int.Parse (cnegative.Substring (3, 1));
				place6 -= int.Parse (cnegative.Substring (4, 1));
				place7 -= int.Parse (cnegative.Substring (5, 1));
			}
			if (place7 < 0) {
				place6--;
				place7 += 10;
			}
			if (place6 < 0) {
				place5--;
				place6 += 10;
			}
			if (place5 < 0) {
				place4--;
				place5 += 10;
			}
			if (place4 < 0) {
				place3--;
				place4 += 10;
			}
			if (place3 < 0) {
				place2--;
				place3 += 10;
			}
			if (place2 < 0) {
				place1--;
				place2 += 10;
			}
		}
		bool verified = false;
		if (place1 < 0 || place2 < 0 || place3 < 0 || place4 < 0 || place5 < 0 || place6 < 0 || place7 < 0) {
			verified = false;
		}
		else {
			verified = true;
			PlayerPref.SetString ("Coins", "n" + place1 + place2 + place3 + "n" + place4 + place5 + place6 + place7);
		}
		return verified;
	}

	public static string GetStoreData(int sectionid, int itemid) {
		string sdata = "";
		if(sectionid == 1){
			if(itemid == 1){
				sdata = "005000";
			}
			else if(itemid == 2){
				sdata = "011000";
			}
			else if(itemid == 3){
				sdata = "032500";
			}
			else if(itemid == 4){
				sdata = "075000";
			}
			else if(itemid == 5){
				sdata = "200000";
			}
		}
		else if(sectionid == 2){
			if(itemid == 1){
				string s = PlayerPref.GetString ("StoreSpeed");
				if (s == ""){
					sdata = "000500, 5";
				}
				else if (s == "12") {
					sdata = "001000, 6";
				}
				else if (s == "14") {
					sdata = "002000, 7";
				}
				else if (s == "16") {
					sdata = "004000, 8";
				} 
				else if (s == "18") {
					sdata = "008000, 9";
				} 
				else if (s == "20") {
					sdata = "1, 10";
				}
			}
			else if (itemid == 2){
				string s = PlayerPref.GetString ("StoreShots");
				if (s == ""){
					sdata = "001500, 1";
				}
				else if (s == "2") {
					sdata = "003000, 2";
				}
				else if (s == "3") {
					sdata = "1, 3";
				}
			}
		}
		else if(sectionid == 3){
			// "1" means bought, "2" means active, "2500" means buy
			if(itemid == 0){
				sdata = PlayerPref.GetString ("StoreSceneD");
				if (sdata == "") {
					sdata = "2";
				}
			}
			if(itemid == 1){
				sdata = PlayerPref.GetString ("StoreScene1");
				if(sdata == ""){
					sdata = "002500";
				}
			}
			else if(itemid == 2){
				sdata = PlayerPref.GetString ("StoreScene2");
				if(sdata == ""){
					sdata = "002500";
				}
			}
			else if(itemid == 3){
				sdata = PlayerPref.GetString ("StoreScene3");
				if(sdata == ""){
					sdata = "002500";
				}
			}
			else if(itemid == 4){
				sdata = PlayerPref.GetString ("StoreScene4");
				if(sdata == ""){
					sdata = "002500";
				}
			}
		}
		return sdata;
	}

	public static void SetStoreData(int sectionid, int itemid) {
		if (sectionid == 2) {
			if(itemid == 1){
				string s = PlayerPref.GetString ("StoreSpeed");
				if(s == ""){
					s = "5";
				}
				PlayerPref.SetString ("StoreSpeed", (int.Parse(s) + 2).ToString());
			}
			else if(itemid == 2){
				string s = PlayerPref.GetString ("StoreShots");
				if(s == ""){
					s = "1";
				}
				PlayerPref.SetString ("StoreShots", (int.Parse(s) + 1).ToString());
			}
		}
		else if (sectionid == 3) {
			int sceneD = 1;
			int scene1 = 0;
			int scene2 = 0;
			int scene3 = 0;
			int scene4 = 0;
			if (PlayerPref.GetString ("StoreScene1").Length == 1) {
				scene1 = 1;
			}
			if (PlayerPref.GetString ("StoreScene2").Length == 1) {
				scene2 = 1;
			}
			if (PlayerPref.GetString ("StoreScene3").Length == 1) {
				scene3 = 1;
			}
			if (PlayerPref.GetString ("StoreScene4").Length == 1) {
				scene4 = 1;
			}
			if(itemid == 0){
				sceneD = 2;
			}
			else if(itemid == 1){
				scene1 = 2;
			}
			else if(itemid == 2){
				scene2 = 2;
			}
			else if(itemid == 3){
				scene3 = 2;
			}
			else if(itemid == 4){
				scene4 = 2;
			}
			PlayerPref.SetString ("StoreSceneD", sceneD.ToString());
			if (scene1 != 0) {
				PlayerPref.SetString ("StoreScene1", scene1.ToString ());
			}
			if (scene2 != 0) {
				PlayerPref.SetString ("StoreScene2", scene2.ToString ());
			}
			if (scene3 != 0) {
				PlayerPref.SetString ("StoreScene3", scene3.ToString ());
			}
			if (scene4 != 0) {
				PlayerPref.SetString ("StoreScene4", scene4.ToString());
			}
		}
	}
}
