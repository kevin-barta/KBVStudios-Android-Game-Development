#pragma strict

var dt : TextMesh;
var DisplayTT : int = 0;
var DisplayNT : int = 0;

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
DisplayTT = PlayerPrefs.GetInt("TotalT");
DisplayTT = DisplayTT + 1;
dt.text = "Time " + DisplayTT + "s";
DisplayNT = DisplayTT;
DisplayTime();
}

function DisplayTime () {
yield WaitForSeconds(1);
DisplayNT = DisplayNT - 1;
dt.text = "Time " + DisplayNT + "s";
RestartTime();
}

function RestartTime () {
if (DisplayNT > 0){
DisplayTime();
}
}