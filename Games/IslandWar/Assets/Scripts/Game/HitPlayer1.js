#pragma strict
var Player1 : GameObject;
var Player2 : GameObject;
var MainCamera : GameObject;
var p1hearts : float = 0f;
var p1hearts1 : GameObject;
var p1hearts2 : GameObject;
var p1hearts3 : GameObject;
var p1hearts4 : GameObject;
var p1hearts5 : GameObject;
var Winner : GameObject;
var Glass : GameObject;
var Powerup : GameObject;
var Info : GameObject;
var DisSection : GameObject;
var Wall : GameObject;
var Background : GameObject;
var Land : GameObject;
var Landmusic : AudioClip;
var leftarrow : GameObject;
var rightarrow : GameObject;
var jumpbutton : GameObject;
var pausebutton : GameObject;
var hearts : GameObject;
var winner : GameObject;
var ColourPlayer1 : String = "";
var ColourPlayer2 : String = "";
var Section1Player1 : int = 0;
var Section2Player1 : int = 0;
var Section3Player1 : int = 0;
var Section4Player1 : int = 0;
var YourSection : String = "";

function OnTriggerEnter(other : Collider) {
if (other.gameObject.tag == "Player2Bottom") {
PlayerPrefs.SetInt("Ended", 10);
PlayerPrefs.Save();
yield WaitForSeconds (1);
Player1.transform.position = new Vector3 (-10f, -3.75, -1);
Player2.transform.position = new Vector3 (10f, -3.75, 0);
MainCamera.transform.position = new Vector3 (-10, 0, -10);
PlayerPrefs.SetInt("Ended", 0);
PlayerPrefs.Save();
p1hearts = PlayerPrefs.GetFloat("Player1Hearts");
p1hearts = p1hearts - 1;
if(p1hearts <= 0){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
PlayerPrefs.SetInt("Winner", 2);
PlayerPrefs.Save();
var winner1 : TextMesh = Winner.GetComponent(TextMesh);
winner1.text = "Player 2 Wins";
yield WaitForSeconds (1);
DisSection.active = true;
Powerup.active = false;
Info.active = true;
Glass.active = false;
Background.active = false;
Wall.active = true;
Land.active = true;
leftarrow.active = false;
rightarrow.active = false;
jumpbutton.active = false;
pausebutton.active = false;
hearts.active = false;
winner.active = false;
MainCamera.audio.Pause();
MainCamera.audio.clip = Landmusic;
MainCamera.audio.Play();
PlayerPrefs.SetInt("Menu", 0);
PlayerPrefs.SetInt("War", 0);
PlayerPrefs.Save();
MainCamera.transform.position = new Vector3 (0, 0, -10);
ColourPlayer1 = PlayerPrefs.GetString("Player1");
ColourPlayer2 = PlayerPrefs.GetString("Player2");
Section1Player1 = PlayerPrefs.GetInt("Player1Section1");
Section2Player1 = PlayerPrefs.GetInt("Player1Section2");
Section3Player1 = PlayerPrefs.GetInt("Player1Section3");
Section4Player1 = PlayerPrefs.GetInt("Player1Section4");
if(ColourPlayer2 == "Red"){
YourSection = PlayerPrefs.GetString("Red");
if(Section1Player1 != 0){
YourSection += Section1Player1+"-";
}
if(Section2Player1 != 0){
YourSection += Section2Player1+"-";
}
if(Section3Player1 != 0){
YourSection += Section3Player1+"-";
}
if(Section4Player1 != 0){
YourSection += Section4Player1+"-";
}
PlayerPrefs.SetString("Red", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer2 == "Blue"){
YourSection = PlayerPrefs.GetString("Blue");
if(Section1Player1 != 0){
YourSection += Section1Player1+"-";
}
if(Section2Player1 != 0){
YourSection += Section2Player1+"-";
}
if(Section3Player1 != 0){
YourSection += Section3Player1+"-";
}
if(Section4Player1 != 0){
YourSection += Section4Player1+"-";
}
PlayerPrefs.SetString("Blue", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer2 == "Yellow"){
YourSection = PlayerPrefs.GetString("Yellow");
if(Section1Player1 != 0){
YourSection += Section1Player1+"-";
}
if(Section2Player1 != 0){
YourSection += Section2Player1+"-";
}
if(Section3Player1 != 0){
YourSection += Section3Player1+"-";
}
if(Section4Player1 != 0){
YourSection += Section4Player1+"-";
}
PlayerPrefs.SetString("Yellow", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer2 == "Green"){
YourSection = PlayerPrefs.GetString("Green");
if(Section1Player1 != 0){
YourSection += Section1Player1+"-";
}
if(Section2Player1 != 0){
YourSection += Section2Player1+"-";
}
if(Section3Player1 != 0){
YourSection += Section3Player1+"-";
}
if(Section4Player1 != 0){
YourSection += Section4Player1+"-";
}
PlayerPrefs.SetString("Green", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer2 == "Cyan"){
YourSection = PlayerPrefs.GetString("Cyan");
if(Section1Player1 != 0){
YourSection += Section1Player1+"-";
}
if(Section2Player1 != 0){
YourSection += Section2Player1+"-";
}
if(Section3Player1 != 0){
YourSection += Section3Player1+"-";
}
if(Section4Player1 != 0){
YourSection += Section4Player1+"-";
}
PlayerPrefs.SetString("Cyan", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer2 == "Purple"){
YourSection = PlayerPrefs.GetString("Purple");
if(Section1Player1 != 0){
YourSection += Section1Player1+"-";
}
if(Section2Player1 != 0){
YourSection += Section2Player1+"-";
}
if(Section3Player1 != 0){
YourSection += Section3Player1+"-";
}
if(Section4Player1 != 0){
YourSection += Section4Player1+"-";
}
PlayerPrefs.SetString("Purple", YourSection);
PlayerPrefs.Save();
}
if(ColourPlayer1 == "Red"){
YourSection = PlayerPrefs.GetString("Red");
if(Section1Player1 != 0){
YourSection = YourSection.Replace(Section1Player1+"-", "");
}
if(Section2Player1 != 0){
YourSection = YourSection.Replace(Section2Player1+"-", "");
}
if(Section3Player1 != 0){
YourSection = YourSection.Replace(Section3Player1+"-", "");
}
if(Section4Player1 != 0){
YourSection = YourSection.Replace(Section4Player1+"-", "");
}
PlayerPrefs.SetString("Red", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer1 == "Blue"){
YourSection = PlayerPrefs.GetString("Blue");
if(Section1Player1 != 0){
YourSection = YourSection.Replace(Section1Player1+"-", "");
}
if(Section2Player1 != 0){
YourSection = YourSection.Replace(Section2Player1+"-", "");
}
if(Section3Player1 != 0){
YourSection = YourSection.Replace(Section3Player1+"-", "");
}
if(Section4Player1 != 0){
YourSection = YourSection.Replace(Section4Player1+"-", "");
}
PlayerPrefs.SetString("Blue", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer1 == "Yellow"){
YourSection = PlayerPrefs.GetString("Yellow");
if(Section1Player1 != 0){
YourSection = YourSection.Replace(Section1Player1+"-", "");
}
if(Section2Player1 != 0){
YourSection = YourSection.Replace(Section2Player1+"-", "");
}
if(Section3Player1 != 0){
YourSection = YourSection.Replace(Section3Player1+"-", "");
}
if(Section4Player1 != 0){
YourSection = YourSection.Replace(Section4Player1+"-", "");
}
PlayerPrefs.SetString("Yellow", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer1 == "Green"){
YourSection = PlayerPrefs.GetString("Green");
if(Section1Player1 != 0){
YourSection = YourSection.Replace(Section1Player1+"-", "");
}
if(Section2Player1 != 0){
YourSection = YourSection.Replace(Section2Player1+"-", "");
}
if(Section3Player1 != 0){
YourSection = YourSection.Replace(Section3Player1+"-", "");
}
if(Section4Player1 != 0){
YourSection = YourSection.Replace(Section4Player1+"-", "");
}
PlayerPrefs.SetString("Green", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer1 == "Cyan"){
YourSection = PlayerPrefs.GetString("Cyan");
if(Section1Player1 != 0){
YourSection = YourSection.Replace(Section1Player1+"-", "");
}
if(Section2Player1 != 0){
YourSection = YourSection.Replace(Section2Player1+"-", "");
}
if(Section3Player1 != 0){
YourSection = YourSection.Replace(Section3Player1+"-", "");
}
if(Section4Player1 != 0){
YourSection = YourSection.Replace(Section4Player1+"-", "");
}
PlayerPrefs.SetString("Cyan", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer1 == "Purple"){
YourSection = PlayerPrefs.GetString("Purple");
if(Section1Player1 != 0){
YourSection = YourSection.Replace(Section1Player1+"-", "");
}
if(Section2Player1 != 0){
YourSection = YourSection.Replace(Section2Player1+"-", "");
}
if(Section3Player1 != 0){
YourSection = YourSection.Replace(Section3Player1+"-", "");
}
if(Section4Player1 != 0){
YourSection = YourSection.Replace(Section4Player1+"-", "");
}
PlayerPrefs.SetString("Purple", YourSection);
}
PlayerPrefs.SetInt("NewGame", 10);
PlayerPrefs.Save();
Application.LoadLevel(2);
}
if(p1hearts == 0.5){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("hearthalf", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p1hearts == 1){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p1hearts == 1.5){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("hearthalf", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p1hearts == 2){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p1hearts == 2.5){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("hearthalf", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p1hearts == 3){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p1hearts == 3.5){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("hearthalf", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p1hearts == 4){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p1hearts == 4.5){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("hearthalf", typeof(Sprite)) as Sprite;
}
if(p1hearts == 5){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts5.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
}
PlayerPrefs.SetFloat("Player1Hearts", p1hearts);
PlayerPrefs.Save();
}
}