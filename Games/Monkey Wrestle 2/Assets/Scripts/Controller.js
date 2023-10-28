#pragma strict
import UnityEngine.UI;
import System.IO.File;

public var googleAnalytics : GoogleAnalyticsV3;
private var ray : Ray;
private var hit : RaycastHit;
static public var Colour : Color = Color.white;
static public var P1Colour : Color;
static public var P2Colour : Color;
var monkeywrestlead : Image;
var advert : boolean = false;
var monkeywrestlead1 : GameObject;
var monkeywrestleadx : GameObject;
var MainCamera : GameObject;
var MainMenu1 : GameObject;
var SettingMenu : GameObject;
var Game : GameObject;
var Select : GameObject;
var Play : GameObject;
var Kbvstudios : GameObject;
var Settings : GameObject;
var Check1 : GameObject;
var Check2 : GameObject;
var Check3 : GameObject;
var Audio : GameObject;
var Back : GameObject;
var Back1 : GameObject;
var P1 : GameObject;
var P2 : GameObject;
var Kbvstudios1 : GameObject;
var click : AudioClip;
var SettingMenuController : RuntimeAnimatorController;
var BackController : RuntimeAnimatorController;
var x : int = 0;
var play1 : int = 0;
var kbvstudios2 : int = 0;
var kbvstudios12 : int = 0;
var back2 : int = 0;
var back12 : int = 0;
var check12 : int = 0;
var check22 : int = 0;
var check32 : int = 0;
var settings2 : int = 0;
var p12 : int = 0;
var p22 : int = 0;
var play2 : int = 0;
var round : int = 0;
var P1Col : int = 0;
var P2Col : int = 0;
var P1Red : int = 0;
var P1Green : int = 0;
var P1Blue : int = 0;
var P2Red : int = 0;
var P2Green : int = 0;
var P2Blue : int = 0;
var SettingsPressed = 0;
var BackPressed = 0;
var Player1C : SpriteRenderer;
var Player1C1 : SpriteRenderer;
var Player2C : SpriteRenderer;
var Player2C1 : SpriteRenderer;
var P1HueButton : Image;
var P2HueButton : Image;
var P1HueSlider : Slider;
var P2HueSlider : Slider;
var P1Scores : TextMesh;
var P1Scores1 : TextMesh;
var P2Scores : TextMesh;
var P2Scores1 : TextMesh;

function Start () {
googleAnalytics.LogScreen("MainMenu");
PlayerPrefs.SetInt("P1", 0);
PlayerPrefs.SetInt("P2", 0);
PlayerPrefs.Save();
MainMenu1.GetComponent(Animator).speed = 0;
	if(PlayerPrefs.GetInt("Music") == 10){
	Audio.GetComponent.<AudioSource>().Pause();
	}
	if(PlayerPrefs.GetInt("Music") == 0){
	Audio.GetComponent.<AudioSource>().Play();
	}
	if(PlayerPrefs.GetInt("Hardcore") == 10){
	Check1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCheckmark", typeof(Sprite)) as Sprite;
	}
	else if(PlayerPrefs.GetInt("Hardcore") == 0){
	Check1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCross", typeof(Sprite)) as Sprite;
	}
	if(PlayerPrefs.GetInt("Music") == 10){
	Check2.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCross", typeof(Sprite)) as Sprite;
	}
	else if(PlayerPrefs.GetInt("Music") == 0){
	Check2.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCheckmark", typeof(Sprite)) as Sprite;
	}
	if(PlayerPrefs.GetInt("Sound") == 10){
	Check3.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCross", typeof(Sprite)) as Sprite;
	}
	else if(PlayerPrefs.GetInt("Sound") == 0){
	Check3.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCheckmark", typeof(Sprite)) as Sprite;
	}
	P1ColourChanger();
	P2ColourChanger();
	var www2 : WWW = new WWW("http://kbvstudios.com/monkeywrestle/version.txt");
	yield www2;
	if(PlayerPrefs.GetInt("Version") < int.Parse(www2.text) && int.Parse(www2.text) != 0){
		PlayerPrefs.SetInt("Version", int.Parse(www2.text));
		PlayerPrefs.SetInt("Error", 0);
		PlayerPrefs.SetInt("Progress", 0);
		PlayerPrefs.Save();
		var www0: WWW = new WWW("http://kbvstudios.com/monkeywrestle/ad.jpg");
		while(www0.isDone == false){
			if(!String.IsNullOrEmpty(www0.error)){
				var errors : int = PlayerPrefs.GetInt("Error");
				PlayerPrefs.SetInt("Error", errors + 1);
				PlayerPrefs.Save();
			}
		}
		var ww3: WWW = new WWW("http://kbvstudios.com/monkeywrestle/link.txt");
		yield ww3;
		PlayerPrefs.SetString("Link", ww3.text);
		PlayerPrefs.SetInt("Progress", 1);
		PlayerPrefs.Save();
		var bytes : byte[] = www0.texture.EncodeToJPG();
		WriteAllBytes(Application.persistentDataPath + "ad.jpg", bytes);
	}
	else if(PlayerPrefs.GetInt("Error") != 0 || PlayerPrefs.GetInt("Progress") == 0 && int.Parse(www2.text) != 0){
		PlayerPrefs.SetInt("Error", 0);
		PlayerPrefs.SetInt("Progress", 0);
		PlayerPrefs.Save();
		var www1: WWW = new WWW("http://kbvstudios.com/monkeywrestle/ad.jpg");
		while(www1.isDone == false){
			if(!String.IsNullOrEmpty(www1.error)){
				var errors1 : int = PlayerPrefs.GetInt("Error");
				PlayerPrefs.SetInt("Error", errors1 + 1);
				PlayerPrefs.Save();
			}
		}
		var ww4: WWW = new WWW("http://kbvstudios.com/monkeywrestle/link.txt");
		yield ww4;
		PlayerPrefs.SetString("Link", ww4.text);
		PlayerPrefs.SetInt("Progress", 1);
		PlayerPrefs.Save();
		var bytes1 : byte[] = www1.texture.EncodeToJPG();
		WriteAllBytes(Application.persistentDataPath + "ad.jpg", bytes1);
	}
	else if(PlayerPrefs.GetInt("Error") == 0 && PlayerPrefs.GetInt("Progress") == 1 && PlayerPrefs.GetInt("Version") != 0){
		if(PlayerPrefs.GetInt("Round") == 0){
			PlayerPrefs.SetInt("Round", 5);
			PlayerPrefs.Save();
			var tex : Texture2D = new Texture2D(2, 2);
			tex.LoadImage(ReadAllBytes(Application.persistentDataPath + "ad.jpg"));
			monkeywrestlead.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
			monkeywrestlead1.SetActive(true);
			monkeywrestleadx.SetActive(true);
			advert = true;
		}
		round = PlayerPrefs.GetInt("Round");
		PlayerPrefs.SetInt("Round", round - 1);
		PlayerPrefs.Save();
	}
}

function Update () {
if(BackPressed == 10){
	SettingMenu.GetComponent(Animation).Play("Back", PlayMode.StopAll);
}
if(SettingsPressed == 10){
	SettingMenu.GetComponent(Animation).Play("SettingMenu", PlayMode.StopAll);
}
if(PlayerPrefs.GetInt("P1C") == 10){
	PlayerPrefs.SetInt("P1C", 0);
	PlayerPrefs.Save();
	P1ColourChanger();
}
if(PlayerPrefs.GetInt("P2C") == 10){
	PlayerPrefs.SetInt("P2C", 0);
	PlayerPrefs.Save();
	P2ColourChanger();
}
if(advert == false){
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(hit.transform.name == "Kbvstudios"){
googleAnalytics.LogScreen("Kbvstudios-Main");
x = 10;
kbvstudios2 = 10;
Kbvstudios.transform.localScale += Vector3(0.2,0.2,0);
}
if(hit.transform.name == "Kbvstudios1"){
googleAnalytics.LogScreen("Kbvstudios-Settings");
x = 10;
kbvstudios12 = 10;
Kbvstudios1.transform.localScale += Vector3(0.2,0.2,0);
}
if(hit.transform.name == "Back"){
googleAnalytics.LogScreen("Back-Settings");
x = 10;
back2 = 10;
Back.transform.localScale += Vector3(0.2,0.2,0);
}
if(hit.transform.name == "Play" && play2 == 0){
googleAnalytics.LogScreen("Play");
x = 10;
play1 = 10;
Play.transform.localScale += Vector3(0.2,0.2,0);
}
if(hit.transform.name == "P1"){
googleAnalytics.LogScreen("Player1");
x = 10;
p12 = 10;
P1.transform.localScale += Vector3(0.2,0.2,0);
}
if(hit.transform.name == "P2"){
googleAnalytics.LogScreen("Player2");
x = 10;
p22 = 10;
P2.transform.localScale += Vector3(0.2,0.2,0);
}
if(hit.transform.name == "Settings"){
googleAnalytics.LogScreen("Settings");
x = 10;
settings2 = 10;
Settings.transform.localScale += Vector3(0.2,0.2,0);
}
if(hit.transform.name == "Back1"){
googleAnalytics.LogScreen("Back-Game");
x = 10;
back12 = 10;
Back1.transform.localScale += Vector3(0.2,0.2,0);
}
if(hit.transform.name == "check1"){
x = 10;
check12 = 10;
Check1.transform.localScale += Vector3(0.2,0.2,0);
}
if(hit.transform.name == "check2"){
x = 10;
check22 = 10;
Check2.transform.localScale += Vector3(0.2,0.2,0);
}
if(hit.transform.name == "check3"){
x = 10;
check32 = 10;
Check3.transform.localScale += Vector3(0.2,0.2,0);
}
if(PlayerPrefs.GetInt("Sound") == 0 && x == 10){
x = 0;
GetComponent.<AudioSource>().clip = click;
GetComponent.<AudioSource>().Play();
}
}
}
if(Input.GetMouseButtonUp(0)){
	ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, hit)){
		if(hit.transform.name == "Kbvstudios" && kbvstudios2 == 10){
		Application.OpenURL("http://kbvstudios.com/");
		}
		if(hit.transform.name == "Kbvstudios1" && kbvstudios12 == 10){
		Application.OpenURL("http://kbvstudios.com/");
		}
		if(hit.transform.name == "Back" && back2 == 10){
		BackPressed = 10;
		SettingsFix();
		SettingMenu.SetActive(false);
		SettingMenu.SetActive(true);
		Play.GetComponent(BoxCollider).enabled = true;
		Kbvstudios.GetComponent(BoxCollider).enabled = true;
		Settings.GetComponent(SphereCollider).enabled = true;
		}
		if(hit.transform.name == "Play" && play1 == 10 && play2 == 0){
		Select.active = true;
		play2 = 10;
		Play.transform.localScale -= Vector3(0.2,0.2,0);
		}
		if(hit.transform.name == "P1" && p12 == 10){
		MainCamera.active = false;
		Game.active = true;
		Select.active = false;
		play2 = 10;
		MainMenu1.GetComponent(Animator).speed = 1.0;
		PlayerPrefs.SetInt("P1", 10);
		PlayerPrefs.Save();
		P2ColourChanger();
		}
		if(hit.transform.name == "P2" && p22 == 10){
		MainCamera.active = false;
		Game.active = true;
		Select.active = false;
		play2 = 10;
		MainMenu1.GetComponent(Animator).speed = 1.0;
		PlayerPrefs.SetInt("P2", 10);
		PlayerPrefs.Save();
		P1ColourChanger();
		P2ColourChanger();
		}
		if(hit.transform.name == "Settings" && settings2 == 10){
		SettingsPressed = 10;
		SettingsFix();
		Play.GetComponent(BoxCollider).enabled = false;
		Kbvstudios.GetComponent(BoxCollider).enabled = false;
		Settings.GetComponent(SphereCollider).enabled = false;
		SettingMenu.active = false;
		SettingMenu.active = true;
		BackReload();
		}
		if(hit.transform.name == "Back1" && back12 == 10){
		Application.LoadLevel(2);
		}
		if(hit.transform.name == "check1" && check12 == 10){
		if(PlayerPrefs.GetInt("Hardcore") == 0){
		googleAnalytics.LogScreen("Hardcore-On");
		Check1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCheckmark", typeof(Sprite)) as Sprite;
		PlayerPrefs.SetInt("Hardcore", 10);
		PlayerPrefs.Save();
		}
		else if(PlayerPrefs.GetInt("Hardcore") == 10){
		googleAnalytics.LogScreen("Hardcore-Off");
		Check1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCross", typeof(Sprite)) as Sprite;
		PlayerPrefs.SetInt("Hardcore", 0);
		PlayerPrefs.Save();
		}
		}
		if(hit.transform.name == "check2" && check22 == 10){
		if(PlayerPrefs.GetInt("Music") == 0){
		googleAnalytics.LogScreen("Music-Off");
		Check2.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCross", typeof(Sprite)) as Sprite;
		PlayerPrefs.SetInt("Music", 10);
		PlayerPrefs.Save();
		Audio.GetComponent.<AudioSource>().Pause();
		}
		else if(PlayerPrefs.GetInt("Music") == 10){
		googleAnalytics.LogScreen("Music-On");
		Check2.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCheckmark", typeof(Sprite)) as Sprite;
		PlayerPrefs.SetInt("Music", 0);
		PlayerPrefs.Save();
		Audio.GetComponent.<AudioSource>().Play();
		}
		}
		if(hit.transform.name == "check3" && check32 == 10){
		if(PlayerPrefs.GetInt("Sound") == 0){
		googleAnalytics.LogScreen("Sound-Off");
		Check3.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCross", typeof(Sprite)) as Sprite;
		PlayerPrefs.SetInt("Sound", 10);
		PlayerPrefs.Save();
		}
		else if(PlayerPrefs.GetInt("Sound") == 10){
		googleAnalytics.LogScreen("Sound-On");
		Check3.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_boxCheckmark", typeof(Sprite)) as Sprite;
		PlayerPrefs.SetInt("Sound", 0);
		PlayerPrefs.Save();
		}
		}
		}
		if(kbvstudios2 == 10){
		kbvstudios2 = 0;
		Kbvstudios.transform.localScale -= Vector3(0.2,0.2,0);
		}
		if(kbvstudios12 == 10){
		kbvstudios12 = 0;
		Kbvstudios1.transform.localScale -= Vector3(0.2,0.2,0);
		}
		if(back2 == 10){
		back2 = 0;
		Back.transform.localScale -= Vector3(0.2,0.2,0);
		}
		if(play1 == 10 && play2 == 0){
		play1 = 0;
		Play.transform.localScale -= Vector3(0.2,0.2,0);
		}
		if(settings2 == 10){
		settings2 = 0;
		Settings.transform.localScale -= Vector3(0.2,0.2,0);
		}
		if(p12 == 10){
		p12 = 0;
		P1.transform.localScale -= Vector3(0.2,0.2,0);
		if(play2 == 10){
		Reload();
		}
		}
		if(p22 == 10){
		p22 = 0;
		P2.transform.localScale -= Vector3(0.2,0.2,0);
		if(play2 == 10){
		Reload();
		}
		}
		if(back12 == 10){
		back12 = 0;
		Back1.transform.localScale -= Vector3(0.2,0.2,0);
		if(play2 == 0){
		Reload();
		}
		}
		if(check12 == 10){
		check12 = 0;
		Check1.transform.localScale -= Vector3(0.2,0.2,0);
		}
		if(check22 == 10){
		check22 = 0;
		Check2.transform.localScale -= Vector3(0.2,0.2,0);
		}
		if(check32 == 10){
		check32 = 0;
		Check3.transform.localScale -= Vector3(0.2,0.2,0);
		}
	}
}
}

function Reload (){
if(play2 == 10){
yield WaitForSeconds(1.5);
MainMenu1.active = false;
Destroy(MainMenu1);
System.GC.Collect();
Resources.UnloadUnusedAssets();
}
}

function BackReload (){
yield WaitForSeconds(2);
SettingMenu.GetComponent(Animator).speed = 0;
}

function OnClickAd(){
	if(advert == true){
		Application.OpenURL(PlayerPrefs.GetString("Link"));
		advert = false;
		monkeywrestlead1.SetActive(false);
		monkeywrestleadx.SetActive(false);
	}
}

function OnClickClose(){
	if(advert == true){
		advert = false;
		monkeywrestlead1.SetActive(false);
		monkeywrestleadx.SetActive(false);
	}
}

function P1ColourChanger (){
P1Col = PlayerPrefs.GetInt("P1Col");
if(P1Col >= 1276){
	P1Red = 255;
	P1Green = 0;
	P1Blue = 1530 - P1Col;
}
else if(P1Col >= 1021){
	P1Red = P1Col - 1020;
	P1Green = 0;
	P1Blue = 255;
}
else if(P1Col >= 766){
	P1Red = 0;
	P1Green = 1020 - P1Col;
	P1Blue = 255;
}
else if(P1Col >= 511){
	P1Red = 0;
	P1Green = 255;
	P1Blue = P1Col - 510;
}
else if(P1Col >= 256){
	P1Red = 510 - P1Col;
	P1Green = 255;
	P1Blue = 0;
}
else if(P1Col >= 0){
	P1Red = 255;
	P1Green = P1Col;
	P1Blue = 0;
}
P1Colour = Color(P1Red / 255f, P1Green / 255f, P1Blue / 255f);
if(PlayerPrefs.GetInt("P1Col") == 0){
	P1Colour = Color(0.5f, 0f, 1f);
	P1Col = 1150;
}
P1HueButton.color = P1Colour;
P1HueSlider.value = P1Col;
Player1C.color = P1Colour;
Player1C1.color = P1Colour;
P1Scores.color = P1Colour;
P1Scores1.color = P1Colour;
}

function P2ColourChanger (){
P2Col = PlayerPrefs.GetInt("P2Col");
if(P2Col >= 1276){
	P2Red = 255;
	P2Green = 0;
	P2Blue = 1530 - P2Col;
}
else if(P2Col >= 1021){
	P2Red = P2Col - 1020;
	P2Green = 0;
	P2Blue = 255;
}
else if(P2Col >= 766){
	P2Red = 0;
	P2Green = 1020 - P2Col;
	P2Blue = 255;
}
else if(P2Col >= 511){
	P2Red = 0;
	P2Green = 255;
	P2Blue = P2Col - 510;
}
else if(P2Col >= 256){
	P2Red = 510 - P2Col;
	P2Green = 255;
	P2Blue = 0;
}
else if(P2Col >= 0){
	P2Red = 255;
	P2Green = P2Col;
	P2Blue = 0;
}
P2Colour = Color(P2Red / 255f, P2Green / 255f, P2Blue / 255f);
if(PlayerPrefs.GetInt("P2Col") == 0){
	P2Colour = Color(0f, 0.5f, 1f);
	P2Col = 900;
}
P2HueButton.color = P2Colour;
P2HueSlider.value = P2Col;
Player2C.color = P2Colour;
Player2C1.color = P2Colour;
P2Scores.color = P2Colour;
P2Scores1.color = P2Colour;
}

function SettingsFix (){
	yield WaitForSeconds(2);
	BackPressed = 0;
	SettingsPressed = 0;
}