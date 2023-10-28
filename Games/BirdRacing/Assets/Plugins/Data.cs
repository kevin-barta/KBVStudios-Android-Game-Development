using UnityEngine;
using System.IO;
using System.Collections;
using System.Security.Cryptography;

public class Data : MonoBehaviour {
	
}

public class PlayerPref : Data {

	public static Data Instance;
	private static string[] User1DataFileArray = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""};
	private static string User1DataFile;
	private static string User1DataFile1;
	private static string User1DataFile2;
	private static string User1DataFile3;
	private static string Key1 = "w8VTJv8BQQj8nnIID3hPC7AW2QsmMssMCpMXke6xTAB=";
	private static int User1Id = 0;

	void Awake (){
		if(Instance){
			DestroyImmediate(gameObject);
		}
		else {
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
	}

	public static void SetId(string id){
		User1Id = int.Parse(id);
		SetString (0, GetString(0));
	}

	public static string GetId(){
		SetString(0, GetString(0));
		string id = User1Id.ToString("000000000");
		return id;
	}

	public static void SetString(int key, string value) {
		using (AesManaged myAes = new AesManaged()) {
			User1DataFile = PlayerPrefs.GetString("User1");
			User1DataFile1 = User1DataFile.Substring (0, 7);
			User1DataFile2 = User1DataFile.Substring (31, 3);
			User1DataFile3 = User1DataFile.Substring (User1DataFile.Length - 14);
			User1DataFile3 = User1DataFile2 + User1DataFile1 + User1DataFile3;
			User1DataFile1 = User1DataFile.Substring (7, 24);
			User1DataFile2 = User1DataFile.Substring (34, User1DataFile.Length - 48);
			string iddata1 = User1DataFile1.Substring (10, 1);
			string iddata2 = User1DataFile1.Substring (21, 1);
			string iddata3 = User1DataFile1.Substring (2, 1);
			string iddata4 = User1DataFile1.Substring (15, 1);
			if(iddata1 == iddata2){
				iddata2 = "@";
			}
			if(iddata1 == iddata3){
				iddata4 = "#";
			}
			if(iddata1 == iddata4){
				iddata4 = "%";
			}
			if(iddata2 == iddata3){
				iddata3 = "#";
			}
			if(iddata2 == iddata4){
				iddata4 = "%";
			}
			if(iddata3 == iddata4){
				iddata4 = "%";
			}
			User1DataFile2 = User1DataFile2.Replace(iddata2, "-");
			User1DataFile2 = User1DataFile2.Replace(iddata3, "*");
			User1DataFile2 = User1DataFile2.Replace(iddata4, "&");
			User1DataFile2 = User1DataFile2.Replace(iddata1, "$");
			User1DataFile2 = User1DataFile2.Replace("-", iddata1);
			User1DataFile2 = User1DataFile2.Replace("*", iddata2);
			User1DataFile2 = User1DataFile2.Replace("&", iddata3);
			User1DataFile2 = User1DataFile2.Replace("$", iddata4);
			User1DataFile = DecryptStringFromBytes_Aes(System.Convert.FromBase64String(User1DataFile2), System.Convert.FromBase64String(Key1), System.Convert.FromBase64String(User1DataFile3));
			User1DataFile1 = DecryptStringFromBytes_Aes(System.Convert.FromBase64String(User1DataFile1), System.Convert.FromBase64String(Key1), System.Convert.FromBase64String(User1DataFile3));
			if(User1Id == 0){
				User1Id = int.Parse(User1DataFile1);
			}
			User1DataFileArray = User1DataFile.Split(',');
			bool User1DataFileArrayLength = false;
			if(User1DataFileArray.Length != 41){
				User1DataFileArrayLength = true;
			}
			if(User1DataFileArray.Length == 0){
				System.Array.Resize(ref User1DataFileArray, 1);
				User1DataFileArray[0] = "UNNAMED";
			}
			if(User1DataFileArray.Length == 1){
				System.Array.Resize(ref User1DataFileArray, 2);
				User1DataFileArray[1] = "01";
			}
			if(User1DataFileArray.Length == 2){
				System.Array.Resize(ref User1DataFileArray, 3);
				User1DataFileArray[2] = "0000";
			}
			if(User1DataFileArray.Length == 3){
				System.Array.Resize(ref User1DataFileArray, 4);
				User1DataFileArray[3] = "01";
			}
			if(User1DataFileArray.Length == 4){
				System.Array.Resize(ref User1DataFileArray, 5);
				User1DataFileArray[4] = "0000";
			}
			if(User1DataFileArray.Length == 5){
				System.Array.Resize(ref User1DataFileArray, 6);
				User1DataFileArray[5] = "80";
			}
			if(User1DataFileArray.Length == 6){
				System.Array.Resize(ref User1DataFileArray, 7);
				User1DataFileArray[6] = "01";
			}
			if(User1DataFileArray.Length == 7){
				System.Array.Resize(ref User1DataFileArray, 8);
				User1DataFileArray[7] = "0000";
			}
			if(User1DataFileArray.Length == 8){
				System.Array.Resize(ref User1DataFileArray, 9);
				User1DataFileArray[8] = "01";
			}
			if(User1DataFileArray.Length == 9){
				System.Array.Resize(ref User1DataFileArray, 10);
				User1DataFileArray[9] = "0000";
			}
			if(User1DataFileArray.Length == 10){
				System.Array.Resize(ref User1DataFileArray, 11);
				User1DataFileArray[10] = "01";
			}
			if(User1DataFileArray.Length == 11){
				System.Array.Resize(ref User1DataFileArray, 12);
				User1DataFileArray[11] = "0000";
			}
			if(User1DataFileArray.Length == 12){
				System.Array.Resize(ref User1DataFileArray, 13);
				User1DataFileArray[12] = "001";
			}
			if(User1DataFileArray.Length == 13){
				System.Array.Resize(ref User1DataFileArray, 14);
				User1DataFileArray[13] = "0000";
			}
			if(User1DataFileArray.Length == 14){
				System.Array.Resize(ref User1DataFileArray, 15);
				User1DataFileArray[14] = "00";
			}
			if(User1DataFileArray.Length == 15){
				System.Array.Resize(ref User1DataFileArray, 16);
				User1DataFileArray[15] = "000001";
			}
			if(User1DataFileArray.Length == 16){
				System.Array.Resize(ref User1DataFileArray, 17);
				User1DataFileArray[16] = "10";
			}
			if(User1DataFileArray.Length == 17){
				System.Array.Resize(ref User1DataFileArray, 18);
				User1DataFileArray[17] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 18){
				System.Array.Resize(ref User1DataFileArray, 19);
				User1DataFileArray[18] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 19){
				System.Array.Resize(ref User1DataFileArray, 20);
				User1DataFileArray[19] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 20){
				System.Array.Resize(ref User1DataFileArray, 21);
				User1DataFileArray[20] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 21){
				System.Array.Resize(ref User1DataFileArray, 22);
				User1DataFileArray[21] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 22){
				System.Array.Resize(ref User1DataFileArray, 23);
				User1DataFileArray[22] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 23){
				System.Array.Resize(ref User1DataFileArray, 24);
				User1DataFileArray[23] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 24){
				System.Array.Resize(ref User1DataFileArray, 25);
				User1DataFileArray[24] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 25){
				System.Array.Resize(ref User1DataFileArray, 26);
				User1DataFileArray[25] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 26){
				System.Array.Resize(ref User1DataFileArray, 27);
				User1DataFileArray[26] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 27){
				System.Array.Resize(ref User1DataFileArray, 28);
				User1DataFileArray[27] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 28){
				System.Array.Resize(ref User1DataFileArray, 29);
				User1DataFileArray[28] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 29){
				System.Array.Resize(ref User1DataFileArray, 30);
				User1DataFileArray[29] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 30){
				System.Array.Resize(ref User1DataFileArray, 31);
				User1DataFileArray[30] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 31){
				System.Array.Resize(ref User1DataFileArray, 32);
				User1DataFileArray[31] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 32){
				System.Array.Resize(ref User1DataFileArray, 33);
				User1DataFileArray[32] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 33){
				System.Array.Resize(ref User1DataFileArray, 34);
				User1DataFileArray[33] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 34){
				System.Array.Resize(ref User1DataFileArray, 35);
				User1DataFileArray[34] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 35){
				System.Array.Resize(ref User1DataFileArray, 36);
				User1DataFileArray[35] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 36){
				System.Array.Resize(ref User1DataFileArray, 37);
				User1DataFileArray[36] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 37){
				System.Array.Resize(ref User1DataFileArray, 38);
				User1DataFileArray[37] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 38){
				System.Array.Resize(ref User1DataFileArray, 39);
				User1DataFileArray[38] = "110894000128255";
			}
			if(User1DataFileArray.Length == 39){
				System.Array.Resize(ref User1DataFileArray, 40);
				User1DataFileArray[39] = "1";
			}
			if(User1DataFileArray.Length == 40){
				System.Array.Resize(ref User1DataFileArray, 41);
				User1DataFileArray[40] = "040303";
			}
			if(User1DataFileArrayLength == true){
				myAes.GenerateIV();
				byte[] encrypted3 = EncryptStringToBytes_Aes(User1DataFile3, System.Convert.FromBase64String(Key1), myAes.IV);
				string encrypteddata3 = System.Convert.ToBase64String(encrypted3);
				User1DataFile3 = User1Id.ToString("000000000");
				byte[] encrypted4 = EncryptStringToBytes_Aes(User1DataFile3, System.Convert.FromBase64String(Key1), myAes.IV);
				User1DataFile1 = System.Convert.ToBase64String(encrypted4);
				string iddata31 = User1DataFile1.Substring (10, 1);
				string iddata32 = User1DataFile1.Substring (21, 1);
				string iddata33 = User1DataFile1.Substring (2, 1);
				string iddata34 = User1DataFile1.Substring (15, 1);
				if(iddata31 == iddata32){
					iddata32 = "@";
				}
				if(iddata31 == iddata33){
					iddata34 = "#";
				}
				if(iddata31 == iddata34){
					iddata34 = "%";
				}
				if(iddata32 == iddata33){
					iddata33 = "#";
				}
				if(iddata32 == iddata34){
					iddata34 = "%";
				}
				if(iddata33 == iddata34){
					iddata34 = "%";
				}
				encrypteddata3 = encrypteddata3.Replace(iddata31, "-");
				encrypteddata3 = encrypteddata3.Replace(iddata32, "*");
				encrypteddata3 = encrypteddata3.Replace(iddata33, "&");
				encrypteddata3 = encrypteddata3.Replace(iddata34, "$");
				encrypteddata3 = encrypteddata3.Replace("-", iddata32);
				encrypteddata3 = encrypteddata3.Replace("*", iddata33);
				encrypteddata3 = encrypteddata3.Replace("&", iddata34);
				encrypteddata3 = encrypteddata3.Replace("$", iddata31);
				User1DataFile3 = System.Convert.ToBase64String(myAes.IV);
				PlayerPrefs.SetString("User1", User1DataFile3.Substring(3, 7) + User1DataFile1 + User1DataFile3.Substring(0, 3) + encrypteddata3 + User1DataFile3.Substring(10));
				PlayerPrefs.Save ();
			}
			User1DataFileArray[key] = value;
			User1DataFile = string.Join(",", User1DataFileArray);
			myAes.GenerateIV();
			byte[] encrypted1 = EncryptStringToBytes_Aes(User1DataFile, System.Convert.FromBase64String(Key1), myAes.IV);
			string encrypteddata1 = System.Convert.ToBase64String(encrypted1);
			User1DataFile1 = User1Id.ToString("000000000");
			byte[] encrypted2 = EncryptStringToBytes_Aes(User1DataFile1, System.Convert.FromBase64String(Key1), myAes.IV);
			User1DataFile1 = System.Convert.ToBase64String(encrypted2);
			string iddata11 = User1DataFile1.Substring (10, 1);
			string iddata12 = User1DataFile1.Substring (21, 1);
			string iddata13 = User1DataFile1.Substring (2, 1);
			string iddata14 = User1DataFile1.Substring (15, 1);
			if(iddata11 == iddata12){
				iddata12 = "@";
			}
			if(iddata11 == iddata13){
				iddata14 = "#";
			}
			if(iddata11 == iddata14){
				iddata14 = "%";
			}
			if(iddata12 == iddata13){
				iddata13 = "#";
			}
			if(iddata12 == iddata14){
				iddata14 = "%";
			}
			if(iddata13 == iddata14){
				iddata14 = "%";
			}
			encrypteddata1 = encrypteddata1.Replace(iddata11, "-");
			encrypteddata1 = encrypteddata1.Replace(iddata12, "*");
			encrypteddata1 = encrypteddata1.Replace(iddata13, "&");
			encrypteddata1 = encrypteddata1.Replace(iddata14, "$");
			encrypteddata1 = encrypteddata1.Replace("-", iddata12);
			encrypteddata1 = encrypteddata1.Replace("*", iddata13);
			encrypteddata1 = encrypteddata1.Replace("&", iddata14);
			encrypteddata1 = encrypteddata1.Replace("$", iddata11);
			User1DataFile3 = System.Convert.ToBase64String(myAes.IV);
			PlayerPrefs.SetString("User1", User1DataFile3.Substring(3, 7) + User1DataFile1 + User1DataFile3.Substring(0, 3) + encrypteddata1 + User1DataFile3.Substring(10));
			PlayerPrefs.Save ();
		}
	}

	public static string GetString(int key) {
		using (AesManaged myAes = new AesManaged()) {
			//7(File3)+24(File1)+3(File3)+(File2)+(File3Rest)
			if(PlayerPrefs.GetString("User1") == ""){
				using (AesManaged myAes1 = new AesManaged()) {
					PlayerPrefs.SetString("IMPORTANT NOTICE", "YOUR DATA WILL BE CORRUPTED IF USER DATA FILE(S) ARE MODIFIED!");
					PlayerPrefs.Save();
					User1DataFileArray[0] = "UNNAMED";//Username
					User1DataFileArray[1] = "01";//Body Type
					User1DataFileArray[2] = "0000";//Body Color
					User1DataFileArray[3] = "01";//Wing Type
					User1DataFileArray[4] = "0000";//Wing Color
					User1DataFileArray[5] = "80";//Wing Size
					User1DataFileArray[6] = "01";//Claw Type
					User1DataFileArray[7] = "0000";//Claw Color
					User1DataFileArray[8] = "01";//Eye Type
					User1DataFileArray[9] = "0000";//Eye Color
					User1DataFileArray[10] = "01";//Beak Type
					User1DataFileArray[11] = "0000";//Beak Color
					User1DataFileArray[12] = "001";//Accessories Type
					User1DataFileArray[13] = "0000";//Accessories Color
					User1DataFileArray[14] = "00";//Xp Levelup
					User1DataFileArray[15] = "000001";//Xp
					User1DataFileArray[16] = "10";//Lvl & Difficulty
					User1DataFileArray[17] = "N/A0:00:00";//Easy Lvl1 Place & Time
					User1DataFileArray[18] = "N/A0:00:00";//Easy Lvl2 Place & Time
					User1DataFileArray[19] = "N/A0:00:00";//Easy Lvl3 Place & Time
					User1DataFileArray[20] = "N/A0:00:00";//Easy Lvl4 Place & Time
					User1DataFileArray[21] = "N/A0:00:00";//Easy Lvl5 Place & Time
					User1DataFileArray[22] = "N/A0:00:00";//Easy Lvl6 Place & Time
					User1DataFileArray[23] = "N/A0:00:00";//Easy Lvl7 Place & Time
					User1DataFileArray[24] = "N/A0:00:00";//Hard Lvl1 Place & Time
					User1DataFileArray[25] = "N/A0:00:00";//Hard Lvl2 Place & Time
					User1DataFileArray[26] = "N/A0:00:00";//Hard Lvl3 Place & Time
					User1DataFileArray[27] = "N/A0:00:00";//Hard Lvl4 Place & Time
					User1DataFileArray[28] = "N/A0:00:00";//Hard Lvl5 Place & Time
					User1DataFileArray[29] = "N/A0:00:00";//Hard Lvl6 Place & Time
					User1DataFileArray[30] = "N/A0:00:00";//Hard Lvl7 Place & Time
					User1DataFileArray[31] = "N/A0:00:00";//Extreme Lvl1 Place & Time
					User1DataFileArray[32] = "N/A0:00:00";//Extreme Lvl2 Place & Time
					User1DataFileArray[33] = "N/A0:00:00";//Extreme Lvl3 Place & Time
					User1DataFileArray[34] = "N/A0:00:00";//Extreme Lvl4 Place & Time
					User1DataFileArray[35] = "N/A0:00:00";//Extreme Lvl5 Place & Time
					User1DataFileArray[36] = "N/A0:00:00";//Extreme Lvl6 Place & Time
					User1DataFileArray[37] = "N/A0:00:00";//Extreme Lvl7 Place & Time
					User1DataFileArray[38] = "110894000128255";//Settings (Sound, Music, Color)
					User1DataFileArray[39] = "1";//Tutorial
					User1DataFileArray[40] = "040303";//Upgrades
					User1DataFile = string.Join(",", User1DataFileArray);
					myAes1.GenerateIV();
					byte[] encrypted1 = EncryptStringToBytes_Aes(User1DataFile, System.Convert.FromBase64String(Key1), myAes1.IV);
					string encrypteddata1 = System.Convert.ToBase64String(encrypted1);
					User1DataFile1 = User1Id.ToString("000000000");
					byte[] encrypted2 = EncryptStringToBytes_Aes(User1DataFile1, System.Convert.FromBase64String(Key1), myAes1.IV);
					User1DataFile1 = System.Convert.ToBase64String(encrypted2);
					string iddata11 = User1DataFile1.Substring (10, 1);
					string iddata12 = User1DataFile1.Substring (21, 1);
					string iddata13 = User1DataFile1.Substring (2, 1);
					string iddata14 = User1DataFile1.Substring (15, 1);
					if(iddata11 == iddata12){
						iddata12 = "@";
					}
					if(iddata11 == iddata13){
						iddata14 = "#";
					}
					if(iddata11 == iddata14){
						iddata14 = "%";
					}
					if(iddata12 == iddata13){
						iddata13 = "#";
					}
					if(iddata12 == iddata14){
						iddata14 = "%";
					}
					if(iddata13 == iddata14){
						iddata14 = "%";
					}
					encrypteddata1 = encrypteddata1.Replace(iddata11, "-");
					encrypteddata1 = encrypteddata1.Replace(iddata12, "*");
					encrypteddata1 = encrypteddata1.Replace(iddata13, "&");
					encrypteddata1 = encrypteddata1.Replace(iddata14, "$");
					encrypteddata1 = encrypteddata1.Replace("-", iddata12);
					encrypteddata1 = encrypteddata1.Replace("*", iddata13);
					encrypteddata1 = encrypteddata1.Replace("&", iddata14);
					encrypteddata1 = encrypteddata1.Replace("$", iddata11);
					User1DataFile3 = System.Convert.ToBase64String(myAes1.IV);
					PlayerPrefs.SetString("User1", User1DataFile3.Substring(3, 7) + User1DataFile1 + User1DataFile3.Substring(0, 3) + encrypteddata1 + User1DataFile3.Substring(10));
					PlayerPrefs.Save ();
				}
			}
			User1DataFile = PlayerPrefs.GetString("User1");
			User1DataFile1 = User1DataFile.Substring (0, 7);
			User1DataFile2 = User1DataFile.Substring (31, 3);
			User1DataFile3 = User1DataFile.Substring (User1DataFile.Length - 14);
			User1DataFile3 = User1DataFile2 + User1DataFile1 + User1DataFile3;
			User1DataFile1 = User1DataFile.Substring (7, 24);
			User1DataFile2 = User1DataFile.Substring (34, User1DataFile.Length - 48);
			string iddata1 = User1DataFile1.Substring (10, 1);
			string iddata2 = User1DataFile1.Substring (21, 1);
			string iddata3 = User1DataFile1.Substring (2, 1);
			string iddata4 = User1DataFile1.Substring (15, 1);
			if(iddata1 == iddata2){
				iddata2 = "@";
			}
			if(iddata1 == iddata3){
				iddata4 = "#";
			}
			if(iddata1 == iddata4){
				iddata4 = "%";
			}
			if(iddata2 == iddata3){
				iddata3 = "#";
			}
			if(iddata2 == iddata4){
				iddata4 = "%";
			}
			if(iddata3 == iddata4){
				iddata4 = "%";
			}
			User1DataFile2 = User1DataFile2.Replace(iddata2, "-");
			User1DataFile2 = User1DataFile2.Replace(iddata3, "*");
			User1DataFile2 = User1DataFile2.Replace(iddata4, "&");
			User1DataFile2 = User1DataFile2.Replace(iddata1, "$");
			User1DataFile2 = User1DataFile2.Replace("-", iddata1);
			User1DataFile2 = User1DataFile2.Replace("*", iddata2);
			User1DataFile2 = User1DataFile2.Replace("&", iddata3);
			User1DataFile2 = User1DataFile2.Replace("$", iddata4);
			User1DataFile = DecryptStringFromBytes_Aes(System.Convert.FromBase64String(User1DataFile2), System.Convert.FromBase64String(Key1), System.Convert.FromBase64String(User1DataFile3));
			User1DataFileArray = User1DataFile.Split(',');
			bool User1DataFileArrayLength = false;
			if(User1DataFileArray.Length != 41){
				User1DataFileArrayLength = true;
			}
			if(User1DataFileArray.Length == 0){
				System.Array.Resize(ref User1DataFileArray, 1);
				User1DataFileArray[0] = "UNNAMED";
			}
			if(User1DataFileArray.Length == 1){
				System.Array.Resize(ref User1DataFileArray, 2);
				User1DataFileArray[1] = "01";
			}
			if(User1DataFileArray.Length == 2){
				System.Array.Resize(ref User1DataFileArray, 3);
				User1DataFileArray[2] = "0000";
			}
			if(User1DataFileArray.Length == 3){
				System.Array.Resize(ref User1DataFileArray, 4);
				User1DataFileArray[3] = "01";
			}
			if(User1DataFileArray.Length == 4){
				System.Array.Resize(ref User1DataFileArray, 5);
				User1DataFileArray[4] = "0000";
			}
			if(User1DataFileArray.Length == 5){
				System.Array.Resize(ref User1DataFileArray, 6);
				User1DataFileArray[5] = "80";
			}
			if(User1DataFileArray.Length == 6){
				System.Array.Resize(ref User1DataFileArray, 7);
				User1DataFileArray[6] = "01";
			}
			if(User1DataFileArray.Length == 7){
				System.Array.Resize(ref User1DataFileArray, 8);
				User1DataFileArray[7] = "0000";
			}
			if(User1DataFileArray.Length == 8){
				System.Array.Resize(ref User1DataFileArray, 9);
				User1DataFileArray[8] = "01";
			}
			if(User1DataFileArray.Length == 9){
				System.Array.Resize(ref User1DataFileArray, 10);
				User1DataFileArray[9] = "0000";
			}
			if(User1DataFileArray.Length == 10){
				System.Array.Resize(ref User1DataFileArray, 11);
				User1DataFileArray[10] = "01";
			}
			if(User1DataFileArray.Length == 11){
				System.Array.Resize(ref User1DataFileArray, 12);
				User1DataFileArray[11] = "0000";
			}
			if(User1DataFileArray.Length == 12){
				System.Array.Resize(ref User1DataFileArray, 13);
				User1DataFileArray[12] = "001";
			}
			if(User1DataFileArray.Length == 13){
				System.Array.Resize(ref User1DataFileArray, 14);
				User1DataFileArray[13] = "0000";
			}
			if(User1DataFileArray.Length == 14){
				System.Array.Resize(ref User1DataFileArray, 15);
				User1DataFileArray[14] = "00";
			}
			if(User1DataFileArray.Length == 15){
				System.Array.Resize(ref User1DataFileArray, 16);
				User1DataFileArray[15] = "000001";
			}
			if(User1DataFileArray.Length == 16){
				System.Array.Resize(ref User1DataFileArray, 17);
				User1DataFileArray[16] = "10";
			}
			if(User1DataFileArray.Length == 17){
				System.Array.Resize(ref User1DataFileArray, 18);
				User1DataFileArray[17] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 18){
				System.Array.Resize(ref User1DataFileArray, 19);
				User1DataFileArray[18] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 19){
				System.Array.Resize(ref User1DataFileArray, 20);
				User1DataFileArray[19] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 20){
				System.Array.Resize(ref User1DataFileArray, 21);
				User1DataFileArray[20] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 21){
				System.Array.Resize(ref User1DataFileArray, 22);
				User1DataFileArray[21] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 22){
				System.Array.Resize(ref User1DataFileArray, 23);
				User1DataFileArray[22] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 23){
				System.Array.Resize(ref User1DataFileArray, 24);
				User1DataFileArray[23] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 24){
				System.Array.Resize(ref User1DataFileArray, 25);
				User1DataFileArray[24] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 25){
				System.Array.Resize(ref User1DataFileArray, 26);
				User1DataFileArray[25] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 26){
				System.Array.Resize(ref User1DataFileArray, 27);
				User1DataFileArray[26] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 27){
				System.Array.Resize(ref User1DataFileArray, 28);
				User1DataFileArray[27] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 28){
				System.Array.Resize(ref User1DataFileArray, 29);
				User1DataFileArray[28] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 29){
				System.Array.Resize(ref User1DataFileArray, 30);
				User1DataFileArray[29] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 30){
				System.Array.Resize(ref User1DataFileArray, 31);
				User1DataFileArray[30] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 31){
				System.Array.Resize(ref User1DataFileArray, 32);
				User1DataFileArray[31] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 32){
				System.Array.Resize(ref User1DataFileArray, 33);
				User1DataFileArray[32] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 33){
				System.Array.Resize(ref User1DataFileArray, 34);
				User1DataFileArray[33] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 34){
				System.Array.Resize(ref User1DataFileArray, 35);
				User1DataFileArray[34] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 35){
				System.Array.Resize(ref User1DataFileArray, 36);
				User1DataFileArray[35] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 36){
				System.Array.Resize(ref User1DataFileArray, 37);
				User1DataFileArray[36] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 37){
				System.Array.Resize(ref User1DataFileArray, 38);
				User1DataFileArray[37] = "N/A0:00:00";
			}
			if(User1DataFileArray.Length == 38){
				System.Array.Resize(ref User1DataFileArray, 39);
				User1DataFileArray[38] = "110894000128255";
			}
			if(User1DataFileArray.Length == 39){
				System.Array.Resize(ref User1DataFileArray, 40);
				User1DataFileArray[39] = "1";
			}
			if(User1DataFileArray.Length == 40){
				System.Array.Resize(ref User1DataFileArray, 41);
				User1DataFileArray[40] = "040303";
			}
			if(User1DataFileArrayLength == true){
				myAes.GenerateIV();
				byte[] encrypted1 = EncryptStringToBytes_Aes(User1DataFile, System.Convert.FromBase64String(Key1), myAes.IV);
				string encrypteddata1 = System.Convert.ToBase64String(encrypted1);
				User1DataFile1 = User1Id.ToString("000000000");
				byte[] encrypted2 = EncryptStringToBytes_Aes(User1DataFile1, System.Convert.FromBase64String(Key1), myAes.IV);
				User1DataFile1 = System.Convert.ToBase64String(encrypted2);
				string iddata11 = User1DataFile1.Substring (10, 1);
				string iddata12 = User1DataFile1.Substring (21, 1);
				string iddata13 = User1DataFile1.Substring (2, 1);
				string iddata14 = User1DataFile1.Substring (15, 1);
				if(iddata11 == iddata12){
					iddata12 = "@";
				}
				if(iddata11 == iddata13){
					iddata14 = "#";
				}
				if(iddata11 == iddata14){
					iddata14 = "%";
				}
				if(iddata12 == iddata13){
					iddata13 = "#";
				}
				if(iddata12 == iddata14){
					iddata14 = "%";
				}
				if(iddata13 == iddata14){
					iddata14 = "%";
				}
				encrypteddata1 = encrypteddata1.Replace(iddata11, "-");
				encrypteddata1 = encrypteddata1.Replace(iddata12, "*");
				encrypteddata1 = encrypteddata1.Replace(iddata13, "&");
				encrypteddata1 = encrypteddata1.Replace(iddata14, "$");
				encrypteddata1 = encrypteddata1.Replace("-", iddata12);
				encrypteddata1 = encrypteddata1.Replace("*", iddata13);
				encrypteddata1 = encrypteddata1.Replace("&", iddata14);
				encrypteddata1 = encrypteddata1.Replace("$", iddata11);
				User1DataFile3 = System.Convert.ToBase64String(myAes.IV);
				PlayerPrefs.SetString("User1", User1DataFile3.Substring(3, 7) + User1DataFile1 + User1DataFile3.Substring(0, 3) + encrypteddata1 + User1DataFile3.Substring(10));
				PlayerPrefs.Save ();
			}
			string value = User1DataFileArray[key];
			return value;
		}
	}
	
	static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV) {

		byte[] encrypted;
		// Create an AesCryptoServiceProvider object 
		// with the specified key and IV. 
		using (AesManaged  aesAlg = new AesManaged ())
		{
			aesAlg.Padding = PaddingMode.PKCS7;
			aesAlg.Mode = CipherMode.CBC;
			aesAlg.KeySize = Key.Length * 8;
			aesAlg.Key = Key;
			aesAlg.IV = IV;
			
			// Create a decrytor to perform the stream transform.
			ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
			
			// Create the streams used for encryption. 
			using (MemoryStream msEncrypt = new MemoryStream())
			{
				using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
				{
					using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
					{
						
						//Write all data to the stream.
						swEncrypt.Write(plainText);
					}
				}
				encrypted = msEncrypt.ToArray();
			}
		}
		// Return the encrypted bytes from the memory stream. 
		return encrypted;
	}
	
	static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV) {
		
		// Declare the string used to hold 
		// the decrypted text. 
		string plaintext = null;
		
		// Create an AesCryptoServiceProvider object 
		// with the specified key and IV. 
		using (AesManaged aesAlg = new AesManaged ())
		{
			aesAlg.Padding = PaddingMode.PKCS7;
			aesAlg.Mode = CipherMode.CBC;
			aesAlg.KeySize = Key.Length * 8;
			aesAlg.Key = Key;
			aesAlg.IV = IV;
			
			// Create a decrytor to perform the stream transform.
			ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
			
			// Create the streams used for decryption. 
			using (MemoryStream msDecrypt = new MemoryStream(cipherText))
			{
				using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
				{
					using (StreamReader srDecrypt = new StreamReader(csDecrypt))
					{
						
						// Read the decrypted bytes from the decrypting stream
						// and place them in a string.
						plaintext = srDecrypt.ReadToEnd();
					}
				}
			}
		}
		return plaintext;
	}
}
