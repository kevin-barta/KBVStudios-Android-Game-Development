#pragma strict
private var ray : Ray;
private var hit : RaycastHit;
private var TMoves : int = 0;
private var TTime : int = 0;
public var l20 : GameObject;
public var l10 : GameObject;
var pic1 : Texture2D;
var pic2 : Texture2D;
var pic3 : Texture2D;

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
if (PlayerPrefs.GetInt("LMain") == 10){
l10.active = true;
l20.active = false;
}
else if (PlayerPrefs.GetInt("LMain") == 20){
l10.active = false;
l20.active = true;
}
}

function Update () {
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(hit.transform.name == "Level1"){
if(PlayerPrefs.GetInt("Tutorial") == 10){
TMoves = 3;
TTime = 7;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 1);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level1");
Application.LoadLevel(2);
}
else{
PlayerPrefs.SetInt("Tutorial", 1);
PlayerPrefs.Save();
Application.LoadLevel(8);
}
}
if(hit.transform.name == "Level2"){
if(PlayerPrefs.GetInt("2")>= 2){
TMoves = 7;
TTime = 13;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 2);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level2");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level3"){
if(PlayerPrefs.GetInt("3")>= 2){
if(PlayerPrefs.GetInt("Tutorial") == 10){
TMoves = 7;
TTime = 15;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 3);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level3");
Application.LoadLevel(2);
}
else{
PlayerPrefs.SetInt("Tutorial", 2);
PlayerPrefs.Save();
Application.LoadLevel(8);
}
}
}
if(hit.transform.name == "Level4"){
if(PlayerPrefs.GetInt("4")>= 2){
TMoves = 10;
TTime = 15;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 4);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level4");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level5"){
if(PlayerPrefs.GetInt("5")>= 2){
TMoves = 9;
TTime = 15;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 5);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level5");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level6"){
if(PlayerPrefs.GetInt("6")>= 2){
TMoves = 9;
TTime = 15;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 6);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level6");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level7"){
if(PlayerPrefs.GetInt("7")>= 2){
TMoves = 9;
TTime = 15;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 7);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level7");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level8"){
if(PlayerPrefs.GetInt("8")>= 2){
TMoves = 11;
TTime = 17;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 8);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level8");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level9"){
if(PlayerPrefs.GetInt("9")>= 2){
TMoves = 10;
TTime = 17;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 9);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level9");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level10"){
if(PlayerPrefs.GetInt("10")>= 2){
TMoves = 13;
TTime = 20;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 10);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level10");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level11"){
if(PlayerPrefs.GetInt("11")>= 2){
TMoves = 11;
TTime = 20;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 11);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level11");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level12"){
TMoves = 12;
TTime = 20;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
if(PlayerPrefs.GetInt("12")>= 2){
PlayerPrefs.SetInt("Level", 12);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level12");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level13"){
if(PlayerPrefs.GetInt("13")>= 2){
TMoves = 12;
TTime = 22;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 13);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level13");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level14"){
if(PlayerPrefs.GetInt("14")>= 2){
TMoves = 14;
TTime = 22;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 14);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level14");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level15"){
if(PlayerPrefs.GetInt("15")>= 2){
TMoves = 13;
TTime = 22;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 15);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level15");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level16"){
if(PlayerPrefs.GetInt("16")>= 2){
TMoves = 17;
TTime = 22;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 16);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level16");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level17"){
if(PlayerPrefs.GetInt("17")>= 2){
TMoves = 23;
TTime = 25;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 17);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level17");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level18"){
if(PlayerPrefs.GetInt("18")>= 2){
TMoves = 13;
TTime = 22;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 18);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level18");
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Level19"){
if(PlayerPrefs.GetInt("19")>= 2){
if(PlayerPrefs.GetInt("Tutorial") == 10){
TMoves = 25;
TTime = 22;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 19);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level19");
Application.LoadLevel(2);
}
else{
PlayerPrefs.SetInt("Tutorial", 3);
PlayerPrefs.Save();
Application.LoadLevel(8);
}
}
}
if(hit.transform.name == "Level20"){
if(PlayerPrefs.GetInt("20")>= 2){
TMoves = 41;
TTime = 35;
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 20);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level20");
Application.LoadLevel(2);
}
}
}
}
}
function OnGUI () {
    var centeredStyle = GUIStyle(GUI.skin.label);

		if (GUI.Button (Rect (.05 * Screen.width, .85 * Screen.height, .2 * Screen.width, .2 * Screen.height), pic1, GUI.skin.GetStyle ("Label"))){
		Application.LoadLevel(3);
		}
		if (GUI.Button (Rect (.73 * Screen.width, .85 * Screen.height, .2 * Screen.width, .2 * Screen.height), pic2, GUI.skin.GetStyle ("Label"))){
		Application.LoadLevel(4);
		}
		if (GUI.Button (Rect (.03 * Screen.width, .08 * Screen.height, .2 * Screen.width, .2 * Screen.height), pic3, GUI.skin.GetStyle ("Label"))){
		Application.LoadLevel(9);
		}
    }