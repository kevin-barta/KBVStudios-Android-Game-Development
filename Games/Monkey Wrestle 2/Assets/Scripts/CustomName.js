#pragma strict
import System.Text.RegularExpressions;
private var ray : Ray;
private var hit : RaycastHit;
var Player1 : TextMesh;
var Player2 : TextMesh;
var Player3 : TextMesh;
private var keyboard : TouchScreenKeyboard;
private var keyboard1 : TouchScreenKeyboard;
private var keyboard2 : TouchScreenKeyboard;
public var text = "";
public var text1 = "";
public var text2 = "";
var key1 : int = 0;
var key2 : int = 0;
var key3 : int = 0;

function Start () {
}

function Update () {
if (keyboard != null && keyboard.done && key1 == 10){
	key1 = 0;
	text = keyboard.text;
	text = text.ToUpper();
	if(text.Length > 8){
	text = text.Substring(0,8);
	}
	text = Regex.Replace(text, "[^a-zA-Z0-9 ]", String.Empty);
	Player1.GetComponent(TextMesh).text = text;
	PlayerPrefs.SetString("Player1", text);
	PlayerPrefs.Save();
}
if (keyboard1 != null && keyboard1.done && key2 == 10){
	key2 = 0;
	text1 = keyboard1.text;
	text1 = text1.ToUpper();
	if(text1.Length > 8){
	text1 = text1.Substring(0,8);
	}
	text1 = Regex.Replace(text1, "[^a-zA-Z0-9 ]", String.Empty);
	Player3.GetComponent(TextMesh).text = text1;
	PlayerPrefs.SetString("Player1", text1);
	PlayerPrefs.Save();
}
if (keyboard2 != null && keyboard2.done && key3 == 10){
	key3 = 0;
	text2 = keyboard2.text;
	text2 = text2.ToUpper();
	if(text2.Length > 8){
	text2 = text2.Substring(0,8);
	}
	text2 = Regex.Replace(text2, "[^a-zA-Z0-9 ]", String.Empty);
	Player2.GetComponent(TextMesh).text = text2;
	PlayerPrefs.SetString("Player2", text2);
	PlayerPrefs.Save();
}

if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(PlayerPrefs.GetInt("P1") == 10){
if(hit.transform.name == "centerleft" || hit.transform.name == "centerright"){
key1 = 10;
keyboard = TouchScreenKeyboard.Open(text, TouchScreenKeyboardType.Default);
}
}
if(PlayerPrefs.GetInt("P2") == 10){
if(hit.transform.name == "centerleft"){
key2 = 10;
keyboard1 = TouchScreenKeyboard.Open(text1, TouchScreenKeyboardType.Default);
}
if(hit.transform.name == "centerright"){
key3 = 10;
keyboard2 = TouchScreenKeyboard.Open(text2, TouchScreenKeyboardType.Default);
}
}
}
}
}