#pragma strict
private var ray : Ray;
private var hit : RaycastHit;
var NM1 : int = 0;
var NT1 : int = 0;
var TM1 : int = 0;
var TT1 : int = 0;
var TimeF : String = "";
var MovesF : String = "";
var DisplayTime : int = 0;
var DisplayMoves : int = 0;
var Medal : int = 0;
var LevelOn : int = 0;
var LevelNext : int = 0;
var Tut : int = 0;
private var TTMoves : int = 0;
private var TTTime : int = 0;
var m : TextMesh;
var t : TextMesh;
public var Gold : GameObject;
public var Silver : GameObject;

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
TM1 = PlayerPrefs.GetInt("TotalM");
TT1 = PlayerPrefs.GetInt("TotalT");
NM1 = PlayerPrefs.GetInt("NumM");
NT1 = PlayerPrefs.GetInt("NumT");
TimeF = PlayerPrefs.GetString("TF");
MovesF = PlayerPrefs.GetString("MF");
Medal = PlayerPrefs.GetInt("Med");
LevelOn = PlayerPrefs.GetInt("Level");
LevelNext = LevelOn + 1;
if(PlayerPrefs.GetInt("Try")== 1){
DisplayMoves = TM1 - NM1;
DisplayTime = TT1 - NT1;
Gold.active = true;
Silver.active = false;
}
else if(PlayerPrefs.GetInt("Try")== 2){
DisplayMoves = TM1 - NM1;
DisplayTime = NT1 - TT1;
Gold.active = false;
Silver.active = true;
}
else if(PlayerPrefs.GetInt("Try")== 3){
DisplayMoves = NM1 - TM1;
DisplayTime = TT1 - NT1;
Gold.active = false;
Silver.active = true;
}
m.text = "Moves: " + DisplayMoves + MovesF;
t.text = "Time: " + DisplayTime + TimeF;
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Completed Level " + LevelOn);
SaveData();
}
function Update () {
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(PlayerPrefs.GetInt("A") == 10){
PlayerPrefs.SetInt("A", 0);
PlayerPrefs.Save();
if(hit.transform.name == "Next"){
if(LevelNext == 2){
TTMoves = 7;
TTTime = 13;
}
if(LevelNext == 3){
if(PlayerPrefs.GetInt("Tutorial") == 10){
TTMoves = 7;
TTTime = 15;
}
else{
Tut = 5;
PlayerPrefs.SetInt("Tutorial", 2);
PlayerPrefs.Save();
Application.LoadLevel(8);
}
}
if(LevelNext == 4){
TTMoves = 10;
TTTime = 15;
}
if(LevelNext == 5){
TTMoves = 9;
TTTime = 15;
}
if(LevelNext == 6){
TTMoves = 9;
TTTime = 15;
}
if(LevelNext == 7){
TTMoves = 9;
TTTime = 15;
}
if(LevelNext == 8){
TTMoves = 11;
TTTime = 15;
}
if(LevelNext == 9){
TTMoves = 10;
TTTime = 17;
}
if(LevelNext == 10){
TTMoves = 13;
TTTime = 20;
}
if(LevelNext == 11){
TTMoves = 11;
TTTime = 20;
}
if(LevelNext == 12){
TTMoves = 12;
TTTime = 20;
}
if(LevelNext == 13){
TTMoves = 12;
TTTime = 22;
}
if(LevelNext == 14){
TTMoves = 14;
TTTime = 22;
}
if(LevelNext == 15){
TTMoves = 13;
TTTime = 22;
}
if(LevelNext == 16){
TTMoves = 17;
TTTime = 22;
}
if(LevelNext == 17){
TTMoves = 23;
TTTime = 25;
}
if(LevelNext == 18){
TTMoves = 13;
TTTime = 22;
}
if(LevelNext == 19){
if(PlayerPrefs.GetInt("Tutorial") == 10){
TTMoves = 23;
TTTime = 25;
}
else{
Tut = 5;
PlayerPrefs.SetInt("Tutorial", 3);
PlayerPrefs.Save();
Application.LoadLevel(8);
}
}
if(LevelNext == 20){
TTMoves = 41;
TTTime = 35;
}
if(LevelNext < 21 && Tut == 0){
PlayerPrefs.SetInt("TotalM", TTMoves);
PlayerPrefs.SetInt("TotalT", TTTime);
PlayerPrefs.SetInt("Level", LevelNext);
PlayerPrefs.Save();
Application.LoadLevel(2);
}
}
if(hit.transform.name == "Retry"){
PlayerPrefs.SetInt("Level", LevelOn);
PlayerPrefs.Save();
Application.LoadLevel(2);
}
if(hit.transform.name == "Menu"){
Application.LoadLevel(9);
}
}
}
}
}
function SaveData () {
if (LevelOn == 1){
if (PlayerPrefs.GetInt("1")< Medal){
PlayerPrefs.SetInt("1", Medal);
if (PlayerPrefs.GetInt("2")< 2){
PlayerPrefs.SetInt("2", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 2){
if (PlayerPrefs.GetInt("2")< Medal){
PlayerPrefs.SetInt("2", Medal);
if (PlayerPrefs.GetInt("3")== 1){
PlayerPrefs.SetInt("3", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 3){
if (PlayerPrefs.GetInt("3")< Medal){
PlayerPrefs.SetInt("3", Medal);
if (PlayerPrefs.GetInt("4")== 1){
PlayerPrefs.SetInt("4", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 4){
if (PlayerPrefs.GetInt("4")< Medal){
PlayerPrefs.SetInt("4", Medal);
if (PlayerPrefs.GetInt("5")== 1){
PlayerPrefs.SetInt("5", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 5){
if (PlayerPrefs.GetInt("5")< Medal){
PlayerPrefs.SetInt("5", Medal);
if (PlayerPrefs.GetInt("6")== 1){
PlayerPrefs.SetInt("6", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 6){
if (PlayerPrefs.GetInt("6")< Medal){
PlayerPrefs.SetInt("6", Medal);
if (PlayerPrefs.GetInt("7")== 1){
PlayerPrefs.SetInt("7", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 7){
if (PlayerPrefs.GetInt("7")< Medal){
PlayerPrefs.SetInt("7", Medal);
if (PlayerPrefs.GetInt("8")== 1){
PlayerPrefs.SetInt("8", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 8){
if (PlayerPrefs.GetInt("8")< Medal){
PlayerPrefs.SetInt("8", Medal);
if (PlayerPrefs.GetInt("9")== 1){
PlayerPrefs.SetInt("9", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 9){
if (PlayerPrefs.GetInt("9")< Medal){
PlayerPrefs.SetInt("9", Medal);
if (PlayerPrefs.GetInt("10")== 1){
PlayerPrefs.SetInt("10", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 10){
if (PlayerPrefs.GetInt("10")< Medal){
PlayerPrefs.SetInt("10", Medal);
if (PlayerPrefs.GetInt("11")== 1){
PlayerPrefs.SetInt("11", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 11){
if (PlayerPrefs.GetInt("11")< Medal){
PlayerPrefs.SetInt("11", Medal);
if (PlayerPrefs.GetInt("12")== 1){
PlayerPrefs.SetInt("12", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 12){
if (PlayerPrefs.GetInt("12")< Medal){
PlayerPrefs.SetInt("12", Medal);
if (PlayerPrefs.GetInt("13")== 1){
PlayerPrefs.SetInt("13", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 13){
if (PlayerPrefs.GetInt("13")< Medal){
PlayerPrefs.SetInt("13", Medal);
if (PlayerPrefs.GetInt("14")== 1){
PlayerPrefs.SetInt("14", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 14){
if (PlayerPrefs.GetInt("14")< Medal){
PlayerPrefs.SetInt("14", Medal);
if (PlayerPrefs.GetInt("15")== 1){
PlayerPrefs.SetInt("15", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 15){
if (PlayerPrefs.GetInt("15")< Medal){
PlayerPrefs.SetInt("15", Medal);
if (PlayerPrefs.GetInt("16")== 1){
PlayerPrefs.SetInt("16", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 16){
if (PlayerPrefs.GetInt("16")< Medal){
PlayerPrefs.SetInt("16", Medal);
if (PlayerPrefs.GetInt("17")== 1){
PlayerPrefs.SetInt("17", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 17){
if (PlayerPrefs.GetInt("17")< Medal){
PlayerPrefs.SetInt("17", Medal);
if (PlayerPrefs.GetInt("18")== 1){
PlayerPrefs.SetInt("18", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 18){
if (PlayerPrefs.GetInt("18")< Medal){
PlayerPrefs.SetInt("18", Medal);
if (PlayerPrefs.GetInt("19")== 1){
PlayerPrefs.SetInt("19", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 19){
if (PlayerPrefs.GetInt("19")< Medal){
PlayerPrefs.SetInt("19", Medal);
if (PlayerPrefs.GetInt("20")== 1){
PlayerPrefs.SetInt("20", 2);
}
PlayerPrefs.Save();
}
}
if (LevelOn == 20){
if (PlayerPrefs.GetInt("20")< Medal){
PlayerPrefs.SetInt("20", Medal);
if (PlayerPrefs.GetInt("21")== 1){
PlayerPrefs.SetInt("21", 2);
}
PlayerPrefs.Save();
}
}
if (PlayerPrefs.GetInt("1")== 4){
if (PlayerPrefs.GetInt("2")== 4){
if (PlayerPrefs.GetInt("3")== 4){
if (PlayerPrefs.GetInt("4")== 4){
if (PlayerPrefs.GetInt("5")== 4){
if (PlayerPrefs.GetInt("6")== 4){
if (PlayerPrefs.GetInt("7")== 4){
if (PlayerPrefs.GetInt("8")== 4){
if (PlayerPrefs.GetInt("9")== 4){
if (PlayerPrefs.GetInt("10")== 4){
PlayerPrefs.SetInt("GoodStart", 10);
PlayerPrefs.Save();
}
}
}
}
}
}
}
}
}
}
if (PlayerPrefs.GetInt("11")== 4){
if (PlayerPrefs.GetInt("12")== 4){
if (PlayerPrefs.GetInt("13")== 4){
if (PlayerPrefs.GetInt("14")== 4){
if (PlayerPrefs.GetInt("15")== 4){
if (PlayerPrefs.GetInt("16")== 4){
if (PlayerPrefs.GetInt("17")== 4){
if (PlayerPrefs.GetInt("18")== 4){
if (PlayerPrefs.GetInt("19")== 4){
if (PlayerPrefs.GetInt("20")== 4){
PlayerPrefs.SetInt("GettingThere", 10);
PlayerPrefs.Save();
}
}
}
}
}
}
}
}
}
}
yield WaitForSeconds(5);
PlayerPrefs.SetInt("A", 10);
PlayerPrefs.Save();
}