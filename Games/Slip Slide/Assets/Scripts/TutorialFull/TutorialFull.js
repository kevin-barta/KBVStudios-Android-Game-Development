#pragma strict

private var TMoves : int = 0;
private var TTime : int = 0;
public var Continue1 : GameObject;
public var Continue2 : GameObject;
public var Continue3 : GameObject;
private var ray : Ray;
private var hit : RaycastHit;

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
if(PlayerPrefs.GetInt("Tutorial") == 1){
Continue2.active = false;
Continue3.active = false;
Continue1.active = true;
PlayerPrefs.SetInt("Tutorial", 0);
PlayerPrefs.Save();
}
if(PlayerPrefs.GetInt("Tutorial") == 2){
Continue2.active = true;
Continue3.active = false;
Continue1.active = false;
PlayerPrefs.SetInt("Tutorial", 0);
PlayerPrefs.Save();
}
if(PlayerPrefs.GetInt("Tutorial") == 3){
Continue2.active = false;
Continue3.active = true;
Continue1.active = false;
PlayerPrefs.SetInt("Tutorial", 0);
PlayerPrefs.Save();
}
}

function Update () {
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(hit.transform.name == "Continue1"){
if(PlayerPrefs.GetInt("HowToPlay") == 10){
Continue2.active = true;
Continue3.active = false;
Continue1.active = false;
}
else{
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
}
if(hit.transform.name == "Continue2"){
if(PlayerPrefs.GetInt("HowToPlay") == 10){
Continue2.active = false;
Continue3.active = true;
Continue1.active = false;
}
else{
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
}
if(hit.transform.name == "Continue3"){
if(PlayerPrefs.GetInt("HowToPlay") == 10){
Application.LoadLevel(9);
}
else{
TMoves = 25;
TTime = 22;
PlayerPrefs.SetInt("Tutorial", 10);
PlayerPrefs.SetInt("TotalM", TMoves);
PlayerPrefs.SetInt("TotalT", TTime);
PlayerPrefs.SetInt("Level", 19);
PlayerPrefs.Save();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Play Level19");
Application.LoadLevel(2);
}
}
}
}
}
