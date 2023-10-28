#pragma strict
var Player1 : GameObject;
var Player2 : GameObject;
var MainCamera : GameObject;
var p2hearts : float = 0f;
var p2hearts1 : GameObject;
var p2hearts2 : GameObject;
var p2hearts3 : GameObject;
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
var SectionPlayer2 : String = "";
var YourSection : String = "";

function OnTriggerEnter(other : Collider) {
if (other.gameObject.tag == "Player1Bottom") {
PlayerPrefs.SetInt("Ended", 10);
PlayerPrefs.Save();
yield WaitForSeconds (1);
Player1.transform.position = new Vector3 (-10f, -3.75, -1);
Player2.transform.position = new Vector3 (10f, -3.75, 0);
MainCamera.transform.position = new Vector3 (-10, 0, -10);
PlayerPrefs.SetInt("Ended", 0);
PlayerPrefs.Save();
p2hearts = PlayerPrefs.GetFloat("Player2Hearts");
p2hearts = p2hearts - 1;
if(p2hearts <= 0){
p2hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p2hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p2hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
PlayerPrefs.SetInt("Winner", 1);
PlayerPrefs.Save();
var winner1 : TextMesh = Winner.GetComponent(TextMesh);
winner1.text = "Player 1 Wins";
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
SectionPlayer2 = PlayerPrefs.GetString("Player2Section");
if(ColourPlayer1 == "Red"){
YourSection = PlayerPrefs.GetString("Red");
YourSection += SectionPlayer2+"-";
PlayerPrefs.SetString("Red", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer1 == "Blue"){
YourSection = PlayerPrefs.GetString("Blue");
YourSection += SectionPlayer2+"-";
PlayerPrefs.SetString("Blue", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer1 == "Yellow"){
YourSection = PlayerPrefs.GetString("Yellow");
YourSection += SectionPlayer2+"-";
PlayerPrefs.SetString("Yellow", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer1 == "Green"){
YourSection = PlayerPrefs.GetString("Green");
YourSection += SectionPlayer2+"-";
PlayerPrefs.SetString("Green", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer1 == "Cyan"){
YourSection = PlayerPrefs.GetString("Cyan");
YourSection += SectionPlayer2+"-";
PlayerPrefs.SetString("Cyan", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer1 == "Purple"){
YourSection = PlayerPrefs.GetString("Purple");
YourSection += SectionPlayer2+"-";
PlayerPrefs.SetString("Purple", YourSection);
PlayerPrefs.Save();
}
if(ColourPlayer2 == "Red"){
YourSection = PlayerPrefs.GetString("Red");
YourSection = YourSection.Replace(SectionPlayer2+"-", "");
PlayerPrefs.SetString("Red", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer2 == "Blue"){
YourSection = PlayerPrefs.GetString("Blue");
YourSection = YourSection.Replace(SectionPlayer2+"-", "");
PlayerPrefs.SetString("Blue", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer2 == "Yellow"){
YourSection = PlayerPrefs.GetString("Yellow");
YourSection = YourSection.Replace(SectionPlayer2+"-", "");
PlayerPrefs.SetString("Yellow", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer2 == "Green"){
YourSection = PlayerPrefs.GetString("Green");
YourSection = YourSection.Replace(SectionPlayer2+"-", "");
PlayerPrefs.SetString("Green", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer2 == "Cyan"){
YourSection = PlayerPrefs.GetString("Cyan");
YourSection = YourSection.Replace(SectionPlayer2+"-", "");
PlayerPrefs.SetString("Cyan", YourSection);
PlayerPrefs.Save();
}
else if(ColourPlayer2 == "Purple"){
YourSection = PlayerPrefs.GetString("Purple");
YourSection = YourSection.Replace(SectionPlayer2+"-", "");
PlayerPrefs.SetString("Purple", YourSection);
PlayerPrefs.Save();
}
PlayerPrefs.SetInt("NewGame", 10);
PlayerPrefs.Save();
Application.LoadLevel(2);
}
if(p2hearts == 0.5){
p2hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("hearthalf", typeof(Sprite)) as Sprite;
p2hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p2hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p2hearts == 1){
p2hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p2hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
p2hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p2hearts == 1.5){
p2hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p2hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("hearthalf", typeof(Sprite)) as Sprite;
p2hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p2hearts == 2){
p2hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p2hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p2hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartempty", typeof(Sprite)) as Sprite;
}
if(p2hearts == 2.5){
p2hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p2hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p2hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("hearthalf", typeof(Sprite)) as Sprite;
}
if(p2hearts == 3){
p2hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p2hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p2hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
}
PlayerPrefs.SetFloat("Player2Hearts", p2hearts);
PlayerPrefs.Save();
}
}