#pragma strict

var dm : TextMesh;
var DisplayTM : int = 0;
var DisplayNM : int = 0;
var DisplayMove : int = 0;

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
DisplayTM = PlayerPrefs.GetInt("TotalM");
dm.text = "Moves " + DisplayTM;
//DisplayMoves();
}

/*function DisplayMoves () {
yield WaitForSeconds(0.5);
DisplayNM = PlayerPrefs.GetInt("T");
DisplayMove = DisplayTM - DisplayNM;
dm.text = "Moves " + DisplayMove;
RestartMoves();
}

function RestartMoves () {
if (DisplayMove > 0){
DisplayMoves();
}
}
*/