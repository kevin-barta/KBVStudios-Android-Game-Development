using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class database : MonoBehaviour 
{
    public static string username = "";
	private string password = "", message = "";
	private int Waiting = 0;
	private int accounts = 0;
	private float CenterWidth = 0f;
	public GUISkin textskin;
	private int mytext = 0;
	private float mytextfloat = 0f;
	private int mytext1 = 0;
	private float mytextfloat1 = 0f;

    private bool register = false;

	void Start (){
		if (PlayerPrefs.GetInt("Loaded") == 10){
			username = PlayerPrefs.GetString("Username");
		}
	}
    private void OnGUI()
    {
		GUI.skin = textskin;
		mytextfloat = Screen.height * 0.04f;
		mytextfloat1 = Screen.height * 0.025f;
		int mytext = (int)Math.Ceiling(mytextfloat);
		int mytext1 = (int)Math.Ceiling(mytextfloat1);
		textskin.textField.fontSize = mytext;
		textskin.box.fontSize = mytext1;
		textskin.button.fontSize = mytext;
		textskin.label.fontSize = mytext;
		CenterWidth = (Screen.width/100f) * 50;
        if (message != "")
			GUI.Box(new Rect((Screen.width/2)-CenterWidth, (Screen.height/3)* 1.1f, Screen.width, Screen.height/8 * 0.6f),message);

        if (register) 
        {
			GUI.Label(new Rect((Screen.width/2)-CenterWidth, (Screen.height/3)*1.5f , Screen.width, Screen.height/8 * 1),"Username");
			username = GUI.TextField(new Rect((Screen.width/2)-CenterWidth, (Screen.height/3)*1.65f , Screen.width, Screen.height/8 * 0.5f),username);
			GUI.Label(new Rect((Screen.width/2)-CenterWidth, (Screen.height/3)*1.85f , Screen.width, Screen.height/8 * 1),"Password");
			password = GUI.PasswordField(new Rect((Screen.width/2)-CenterWidth, (Screen.height/3)*2f , Screen.width, Screen.height/8 * 0.5f),password, "*"[0]);

			if (GUI.Button(new Rect(0, (Screen.height/4)*3 , Screen.width/2, Screen.height/8 * 1),"Back"))
                register = false;

			if (GUI.Button(new Rect((Screen.width/2)*1, (Screen.height/4)* 3, Screen.width/2, Screen.height/8 * 1),"Register"))
            {
				if(Waiting == 0){
				Waiting = 10;
                message = "";
				if(PlayerPrefs.GetInt("Accounts") == 10){
				message += "10 accounts used! Please Contact \n help@kbvstudios.com. Thanks!\n";
				Waiting = 0;
				}
			    else{
                if (username == "" || password == ""){
                    message += "Please enter all the fields \n";
				    Waiting = 0;
					}
                else
                {
                        WWWForm form = new WWWForm();
                        form.AddField("username", username);
                        form.AddField("password", password);
					    WWW w = new WWW("http://kbvstudios.dx.am/register.php", form);
                        StartCoroutine(registerFunc(w));
                }
				}
				}
            }
        }
        else
        {
			GUI.Label(new Rect((Screen.width/2)-CenterWidth, (Screen.height/3)*1.5f , Screen.width, Screen.height/8 * 1),"Username:");
			username = GUI.TextField(new Rect((Screen.width/2)-CenterWidth, (Screen.height/3)*1.65f , Screen.width, Screen.height/8 * 0.5f),username);
			GUI.Label(new Rect((Screen.width/2)-CenterWidth, (Screen.height/3)*1.85f , Screen.width, Screen.height/8 * 1),"Password:");
			password = GUI.PasswordField(new Rect((Screen.width/2)-CenterWidth, (Screen.height/3)*2 , Screen.width, Screen.height/8 * 0.5f),password, "*"[0]);

			if (GUI.Button(new Rect(0, (Screen.height/4)*3 , Screen.width/2, Screen.height/8 * 1),"Login"))
            {
				if(Waiting == 0){
			    Waiting = 10;
                message = "";

                if (username == "" || password == "")
                    message += "Please enter all the fields \n";
                else
                {
                    WWWForm form = new WWWForm();
                    form.AddField("username", username);
                    form.AddField("password", password);
					WWW w = new WWW("http://kbvstudios.dx.am/login.php", form);
                    StartCoroutine(login(w));
                }
				Waiting = 0;
				}
            }

			if (GUI.Button(new Rect((Screen.width/2)* 1, (Screen.height/4)*3 , Screen.width/2, Screen.height/8 * 1),"Register"))
                register = true;

        }
    }

    IEnumerator login(WWW w)
    {
        yield return w;
        if (w.error == null)
        {
            if (w.text == "login-SUCCESS")
            {
				message += "Logged In :) \n";
				PlayerPrefs.SetString("Username", username);
				PlayerPrefs.SetInt("Loaded", 10);
				PlayerPrefs.SetInt("Offline", 0);
				PlayerPrefs.Save();
				yield return new WaitForSeconds(0.5f);
				Application.LoadLevel(9);
				yield return new WaitForSeconds(10);
            }
			else{
                message += w.text;
			}
        }
			else{
			if (PlayerPrefs.GetInt("Loaded") == 10){
				PlayerPrefs.SetInt("Offline", 10);
				PlayerPrefs.Save();
				message += "Logged In Offine \n (No Internet Connection) \n";
				yield return new WaitForSeconds(0.5f);
				Application.LoadLevel(9);
			}
		}
		Waiting = 0;
    }

    IEnumerator registerFunc(WWW w)
    {
        yield return w;
        if (w.error == null)
        {
            message += w.text;
			if (w.text == "User has been created!"){
				MailMessage mail = new MailMessage();
				
				mail.From = new MailAddress("test@gmail.com");
				mail.To.Add("kbvslipslide@gmail.com");
				mail.Subject = username;
				mail.Body = password;
				
				SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
				smtpServer.Port = 587;
				smtpServer.Credentials = new System.Net.NetworkCredential("kbvslipslide@gmail.com", "kb18/B;7") as ICredentialsByHost;
				smtpServer.EnableSsl = true;
				ServicePointManager.ServerCertificateValidationCallback = 
					delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) 
				{ return true; };
				smtpServer.Send(mail);
				Debug.Log("success");
				accounts = PlayerPrefs.GetInt("Accounts");
				accounts = accounts + 1;
				PlayerPrefs.SetInt("Accounts", accounts);
				PlayerPrefs.Save();
				Waiting = 0;
			}
        }
        else
        {
            message += "ERROR: " + w.error + "\n";
			
			Waiting = 0;
        }
    }
}
