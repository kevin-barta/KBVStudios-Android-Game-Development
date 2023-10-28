using UnityEngine;
using System.IO;
using System.Collections;
using System.Security.Cryptography;

public class Data : MonoBehaviour {
	
}

public class PlayerPref : Data {
	public static Data Instance;
	private static string[] User1DataFileArray = {""};
	private static string User1DataFile;
	private static string User1DataFile1;
	private static string User1DataFile2;
	private static string User1DataFile3;
	private static string Key1 = "w8VTJv8BQQj8nnIID3hPC7AW2QsmMssMCpMXke6xTAB=";
	private static int User1Id = 314159265;

	public static void SetString(string key, string value) {
		using (AesManaged myAes = new AesManaged()) {
			if(PlayerPrefs.GetString("User1") == ""){
				using (AesManaged myAes1 = new AesManaged()) {
					PlayerPrefs.SetString("IMPORTANT NOTICE", "YOUR DATA WILL BE CORRUPTED IF USER DATA FILE(S) ARE MODIFIED!");
					PlayerPrefs.Save();
					User1DataFileArray[0] = User1DataFileArray.Length.ToString();
					User1DataFile = string.Join(",", User1DataFileArray);
					myAes1.GenerateIV();
					byte[] encrypted5 = EncryptStringToBytes_Aes(User1DataFile, System.Convert.FromBase64String(Key1), myAes1.IV);
					string encrypteddata5 = System.Convert.ToBase64String(encrypted5);
					User1DataFile1 = User1Id.ToString("000000000");
					byte[] encrypted7 = EncryptStringToBytes_Aes(User1DataFile1, System.Convert.FromBase64String(Key1), myAes1.IV);
					User1DataFile1 = System.Convert.ToBase64String(encrypted7);
					string iddata21 = User1DataFile1.Substring (10, 1);
					string iddata22 = User1DataFile1.Substring (21, 1);
					string iddata23 = User1DataFile1.Substring (2, 1);
					string iddata24 = User1DataFile1.Substring (15, 1);
					if(iddata21 == iddata22){
						iddata22 = "@";
					}
					if(iddata21 == iddata23){
						iddata24 = "#";
					}
					if(iddata21 == iddata24){
						iddata24 = "%";
					}
					if(iddata22 == iddata23){
						iddata23 = "#";
					}
					if(iddata22 == iddata24){
						iddata24 = "%";
					}
					if(iddata23 == iddata24){
						iddata24 = "%";
					}
					encrypteddata5 = encrypteddata5.Replace(iddata21, "-");
					encrypteddata5 = encrypteddata5.Replace(iddata22, "*");
					encrypteddata5 = encrypteddata5.Replace(iddata23, "&");
					encrypteddata5 = encrypteddata5.Replace(iddata24, "$");
					encrypteddata5 = encrypteddata5.Replace("-", iddata22);
					encrypteddata5 = encrypteddata5.Replace("*", iddata23);
					encrypteddata5 = encrypteddata5.Replace("&", iddata24);
					encrypteddata5 = encrypteddata5.Replace("$", iddata21);
					User1DataFile3 = System.Convert.ToBase64String(myAes1.IV);
					PlayerPrefs.SetString("User1", User1DataFile3.Substring(3, 7) + User1DataFile1 + User1DataFile3.Substring(0, 3) + encrypteddata5 + User1DataFile3.Substring(10));
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
			User1DataFile1 = DecryptStringFromBytes_Aes(System.Convert.FromBase64String(User1DataFile1), System.Convert.FromBase64String(Key1), System.Convert.FromBase64String(User1DataFile3));
			User1DataFileArray = User1DataFile.Split(',');
			bool User1DataFileArrayLength = false;
			if(User1DataFileArray.Length != int.Parse(User1DataFileArray[0])){
				User1DataFileArrayLength = true;
			}
			if(User1DataFileArrayLength == true){
				myAes.GenerateIV();
				byte[] encrypted3 = EncryptStringToBytes_Aes((User1DataFileArray.Length + ","), System.Convert.FromBase64String(Key1), myAes.IV);
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
			bool i1 = false;
			for (int i = 0;i < User1DataFileArray.Length - 1; i++) {
				if (User1DataFileArray [i] == key) {
					if(User1DataFileArray.Length % 2 == 1){
						User1DataFileArray[i + 1] = value;
						i = User1DataFileArray.Length;
						i1 = true;
					}
				}
			}
			if(i1 == false){
				System.Array.Resize(ref User1DataFileArray, User1DataFileArray.Length + 2);
				User1DataFileArray[User1DataFileArray.Length - 2] = key;
				User1DataFileArray[User1DataFileArray.Length - 1] = value;
			}
			User1DataFileArray[0] = User1DataFileArray.Length.ToString();
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

	public static string GetString(string key) {
		using (AesManaged myAes = new AesManaged()) {
			//7(File3)+24(File1)+3(File3)+(File2)+(File3Rest)
			if(PlayerPrefs.GetString("User1") == ""){
				using (AesManaged myAes1 = new AesManaged()) {
					PlayerPrefs.SetString("IMPORTANT NOTICE", "YOUR DATA WILL BE CORRUPTED IF USER DATA FILE(S) ARE MODIFIED!");
					PlayerPrefs.Save();
					User1DataFileArray[0] = User1DataFileArray.Length.ToString();
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
			if(User1DataFileArray.Length != int.Parse(User1DataFileArray[0])){
				User1DataFileArrayLength = true;
			}
			if(User1DataFileArrayLength == true){
				myAes.GenerateIV();
				byte[] encrypted1 = EncryptStringToBytes_Aes(( User1DataFileArray.Length + ","), System.Convert.FromBase64String(Key1), myAes.IV);
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
			string value = "";
			for (int i = 0; i < User1DataFileArray.Length - 1; i++) {
				if (User1DataFileArray [i] == key) {
					if(User1DataFileArray.Length % 2 == 1){
						value = User1DataFileArray[i + 1];
						i = User1DataFileArray.Length;
					}
				}
			}
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
