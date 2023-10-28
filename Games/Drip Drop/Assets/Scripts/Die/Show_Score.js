#pragma strict

private var GameScore2 : int = 0;

function Start () {
GameScore2 = PlayerPrefs.GetInt ("GameScore");
var tm : TextMesh = gameObject.GetComponent(TextMesh);
tm.text = "Score: " + GameScore2;
}