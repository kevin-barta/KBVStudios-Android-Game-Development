#pragma strict
var Player1 : GameObject;
var Player2 : GameObject;
var Highscore : int = 0;

function OnTriggerEnter2D(other : Collider2D) {
if (other.gameObject.tag == "Object") {
Destroy(other.gameObject);
Player1.GetComponent(BoxCollider2D).enabled = true;
Player2.GetComponent(BoxCollider2D).enabled = true;
Player1.transform.position = new Vector3 (-1.5, -4, -7);
Player2.transform.position = new Vector3 (1.5, -4, -7);
}
if (other.gameObject.tag == "Player1") {
Time.timeScale = 1;
var Highscore0 = PlayerPrefs.GetInt("Highscore0");
PlayerPrefs.SetInt("Highscore1", Highscore0);
PlayerPrefs.SetInt("PlayGame", 10);
PlayerPrefs.Save();
if(PlayerPrefs.GetInt("Highscore0") >= 10){
PlayerPrefs.SetInt("Get10Points", 10);
PlayerPrefs.Save();
}
if(PlayerPrefs.GetInt("Highscore0") >= 20){
PlayerPrefs.SetInt("Get20Points", 10);
PlayerPrefs.Save();
}
if(PlayerPrefs.GetInt("Highscore0") >= 50){
PlayerPrefs.SetInt("Get50Points", 10);
PlayerPrefs.Save();
}
if(PlayerPrefs.GetInt("Highscore0") >= 100){
PlayerPrefs.SetInt("Get100Points", 10);
PlayerPrefs.Save();
}
Highscore = PlayerPrefs.GetInt("Highscore");
if (Highscore0 > Highscore){
PlayerPrefs.SetInt("Highscore", Highscore0);
PlayerPrefs.Save();
}
Application.LoadLevel(0);
}
if (other.gameObject.tag == "Player2") {
Time.timeScale = 1;
var Highscore06 = PlayerPrefs.GetInt("Highscore0");
PlayerPrefs.SetInt("Highscore1", Highscore06);
PlayerPrefs.SetInt("PlayGame", 10);
PlayerPrefs.Save();
if(PlayerPrefs.GetInt("Highscore0") >= 10){
PlayerPrefs.SetInt("Get10Points", 10);
PlayerPrefs.Save();
}
if(PlayerPrefs.GetInt("Highscore0") >= 20){
PlayerPrefs.SetInt("Get20Points", 10);
PlayerPrefs.Save();
}
if(PlayerPrefs.GetInt("Highscore0") >= 50){
PlayerPrefs.SetInt("Get50Points", 10);
PlayerPrefs.Save();
}
if(PlayerPrefs.GetInt("Highscore0") >= 100){
PlayerPrefs.SetInt("Get100Points", 10);
PlayerPrefs.Save();
}
Highscore = PlayerPrefs.GetInt("Highscore");
if (Highscore06 > Highscore){
PlayerPrefs.SetInt("Highscore", Highscore0);
PlayerPrefs.Save();
}
Application.LoadLevel(0);
}
}