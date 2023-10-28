#pragma strict

private var HighScore2 : int = 0;

function Start () {
HighScore2 = PlayerPrefs.GetInt ("HighScore");
var tm : TextMesh = gameObject.GetComponent(TextMesh);
tm.text = "Highscore: " + HighScore2;
}