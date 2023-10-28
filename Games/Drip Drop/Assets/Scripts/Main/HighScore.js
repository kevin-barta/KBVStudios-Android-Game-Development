#pragma strict
var HighScore : TextMesh;

function Start () {

}
function Awake () {
HighScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore");
}