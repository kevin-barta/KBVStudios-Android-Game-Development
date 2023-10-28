#pragma strict
private var ray : Ray;
private var hit : RaycastHit;
var NM2 : int = 0;
var NT2 : int = 0;
var TM2 : int = 0;
var TT2 : int = 0;
var DisplayTime1 : int = 0;
var DisplayMoves1 : int = 0;
var LevelOn1 : int = 0;
var mm : TextMesh;
var tt : TextMesh;

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
TM2 = PlayerPrefs.GetInt("TotalM");
TT2 = PlayerPrefs.GetInt("TotalT");
NM2 = PlayerPrefs.GetInt("NumM");
NT2 = PlayerPrefs.GetInt("NumT");
LevelOn1 = PlayerPrefs.GetInt("Level");
DisplayMoves1 = NM2 - TM2;
DisplayTime1 = NT2 - TT2;
mm.text = "Moves: " + DisplayMoves1 + " over";
tt.text = "Time: " + DisplayTime1 + "s over";
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Failed Level " + LevelOn1);
if (LevelOn1 == 1) {
	PlayerPrefs.SetInt("JustPlainHorrible", 10);
	PlayerPrefs.Save();
	}
}

function Update () {
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(hit.transform.name == "Menu"){
Application.LoadLevel(9);
}
if(hit.transform.name == "Retry"){
PlayerPrefs.SetInt("Level", LevelOn1);
PlayerPrefs.Save();
Application.LoadLevel(2);
}
}
}
}