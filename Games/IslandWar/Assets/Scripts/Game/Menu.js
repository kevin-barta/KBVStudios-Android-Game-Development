#pragma strict

var Section : String = "";
var Glass : GameObject;
var Powerup : GameObject;
var Info : GameObject;
var DisSection : GameObject;
var Flag : GameObject;
var War : GameObject;
var Cancel : GameObject;
var InfoButton : GameObject;
var PowerupButton : GameObject;
var TitleText : GameObject;
var ChanceText : GameObject;
var PowerupText : GameObject;
var TotalText : GameObject;
var PowerupTitle : GameObject;
var Coins : GameObject;
var Wall : GameObject;
var Background : GameObject;
var Land : GameObject;
private var ray : Ray;
private var hit : RaycastHit;
private var lasttaptime : float = -1;
private var taptime : float = -1;
private var doubletap : float = 0.3;
private var lastx : float = 0;
private var lasty : float = 0;
private var x : float = 0;
private var y : float = 0;
var war : int = 0;
var Player1 : String = "";
var Warmusic : AudioClip;
var p1 : float = 0f;
var war1 : int = 0;
var player1section1 : int = 0;
var player1section2 : int = 0;
var player1section3 : int = 0;
var player1section4 : int = 0;

function Start () {
yield WaitForSeconds(0.5);
if(PlayerPrefs.GetString("Player1") == "Red"){
Player1 = PlayerPrefs.GetString("Red");
}
else if(PlayerPrefs.GetString("Player1") == "Blue"){
Player1 = PlayerPrefs.GetString("Blue");
}
else if(PlayerPrefs.GetString("Player1") == "Yellow"){
Player1 = PlayerPrefs.GetString("Yellow");
}
else if(PlayerPrefs.GetString("Player1") == "Green"){
Player1 = PlayerPrefs.GetString("Green");
}
else if(PlayerPrefs.GetString("Player1") == "Cyan"){
Player1 = PlayerPrefs.GetString("Cyan");
}
else if(PlayerPrefs.GetString("Player1") == "Purple"){
Player1 = PlayerPrefs.GetString("Purple");
}
}

function Update () {
	if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
	lasttaptime = taptime;
	taptime = Time.time;
	
	if(taptime - lasttaptime < doubletap){
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, hit)){
			if(hit.transform.tag == "Section"){
			p1 = 0;
			war = 0;
			war1 = 0;
			Section = hit.transform.name;
			if(Section == "Section1"){
			if(Player1.Contains("-"+2+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 2;
			}
			if(Player1.Contains("-"+6+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 6;
			}
			}
			if(Section == "Section2"){
			if(Player1.Contains("-"+1+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 1;
			}
			if(Player1.Contains("-"+3+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 3;
			}
			if(Player1.Contains("-"+7+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 7;
			}
			}
			if(Section == "Section3"){
			if(Player1.Contains("-"+2+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 2;
			}
			if(Player1.Contains("-"+4+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 4;
			}
			if(Player1.Contains("-"+8+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 8;
			}
			}
			if(Section == "Section4"){
			if(Player1.Contains("-"+3+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 3;
			}
			if(Player1.Contains("-"+9+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 9;
			}
			}
			if(Section == "Section5"){
			if(Player1.Contains("-"+6+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 6;
			}
			if(Player1.Contains("-"+14+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 14;
			}
			}
			if(Section == "Section6"){
			if(Player1.Contains("-"+1+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 1;
			}
			if(Player1.Contains("-"+5+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 5;
			}
			if(Player1.Contains("-"+7+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 7;
			}
			if(Player1.Contains("-"+15+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 15;
			}
			}
			if(Section == "Section7"){
			if(Player1.Contains("-"+2+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 2;
			}
			if(Player1.Contains("-"+6+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 6;
			}
			if(Player1.Contains("-"+8+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 8;
			}
			if(Player1.Contains("-"+16+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 16;
			}
			}
			if(Section == "Section8"){
			if(Player1.Contains("-"+3+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 3;
			}
			if(Player1.Contains("-"+7+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 7;
			}
			if(Player1.Contains("-"+9+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 9;
			}
			if(Player1.Contains("-"+17+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 17;
			}
			}
			if(Section == "Section9"){
			if(Player1.Contains("-"+4+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 4;
			}
			if(Player1.Contains("-"+8+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 8;
			}
			if(Player1.Contains("-"+10+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 10;
			}
			if(Player1.Contains("-"+18+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 18;
			}
			}
			if(Section == "Section10"){
			if(Player1.Contains("-"+9+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 9;
			}
			if(Player1.Contains("-"+11+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 11;
			}
			if(Player1.Contains("-"+19+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 19;
			}
			}
			if(Section == "Section11"){
			if(Player1.Contains("-"+10+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 10;
			}
			if(Player1.Contains("-"+12+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 12;
			}
			if(Player1.Contains("-"+20+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 20;
			}
			}
			if(Section == "Section12"){
			if(Player1.Contains("-"+11+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 11;
			}
			if(Player1.Contains("-"+13+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 13;
			}
			if(Player1.Contains("-"+21+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 21;
			}
			}
			if(Section == "Section13"){
			if(Player1.Contains("-"+12+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 12;
			}
			if(Player1.Contains("-"+22+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 22;
			}
			}
			if(Section == "Section14"){
			if(Player1.Contains("-"+5+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 5;
			}
			if(Player1.Contains("-"+15+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 15;
			}
			if(Player1.Contains("-"+25+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 25;
			}
			}
			if(Section == "Section15"){
			if(Player1.Contains("-"+6+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 6;
			}
			if(Player1.Contains("-"+14+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 14;
			}
			if(Player1.Contains("-"+16+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 16;
			}
			if(Player1.Contains("-"+26+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 26;
			}
			}
			if(Section == "Section16"){
			if(Player1.Contains("-"+7+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 7;
			}
			if(Player1.Contains("-"+15+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 15;
			}
			if(Player1.Contains("-"+17+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 17;
			}
			if(Player1.Contains("-"+27+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 27;
			}
			}
			if(Section == "Section17"){
			if(Player1.Contains("-"+8+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 8;
			}
			if(Player1.Contains("-"+16+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 16;
			}
			if(Player1.Contains("-"+18+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 18;
			}
			if(Player1.Contains("-"+28+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 28;
			}
			}
			if(Section == "Section18"){
			if(Player1.Contains("-"+9+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 9;
			}
			if(Player1.Contains("-"+17+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 17;
			}
			if(Player1.Contains("-"+19+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 19;
			}
			if(Player1.Contains("-"+29+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 29;
			}
			}
			if(Section == "Section19"){
			if(Player1.Contains("-"+10+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 10;
			}
			if(Player1.Contains("-"+18+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 18;
			}
			if(Player1.Contains("-"+20+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 20;
			}
			if(Player1.Contains("-"+30+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 30;
			}
			}
			if(Section == "Section20"){
			if(Player1.Contains("-"+11+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 11;
			}
			if(Player1.Contains("-"+19+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 19;
			}
			if(Player1.Contains("-"+21+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 21;
			}
			if(Player1.Contains("-"+31+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 31;
			}
			}
			if(Section == "Section21"){
			if(Player1.Contains("-"+12+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 12;
			}
			if(Player1.Contains("-"+20+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 20;
			}
			if(Player1.Contains("-"+22+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 22;
			}
			if(Player1.Contains("-"+32+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 32;
			}
			}
			if(Section == "Section22"){
			if(Player1.Contains("-"+13+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 13;
			}
			if(Player1.Contains("-"+21+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 21;
			}
			if(Player1.Contains("-"+23+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 23;
			}
			if(Player1.Contains("-"+33+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 33;
			}
			}
			if(Section == "Section23"){
			if(Player1.Contains("-"+22+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 22;
			}
			if(Player1.Contains("-"+34+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 34;
			}
			}
			if(Section == "Section24"){
			if(Player1.Contains("-"+25+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 24;
			}
			if(Player1.Contains("-"+36+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 36;
			}
			}
			if(Section == "Section25"){
			if(Player1.Contains("-"+14+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 14;
			}
			if(Player1.Contains("-"+24+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 24;
			}
			if(Player1.Contains("-"+26+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 26;
			}
			if(Player1.Contains("-"+37+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 37;
			}
			}
			if(Section == "Section26"){
			if(Player1.Contains("-"+15+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 15;
			}
			if(Player1.Contains("-"+25+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 25;
			}
			if(Player1.Contains("-"+27+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 27;
			}
			if(Player1.Contains("-"+38+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 38;
			}
			}
			if(Section == "Section27"){
			if(Player1.Contains("-"+16+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 16;
			}
			if(Player1.Contains("-"+26+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 26;
			}
			if(Player1.Contains("-"+28+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 28;
			}
			if(Player1.Contains("-"+39+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 39;
			}
			}
			if(Section == "Section28"){
			if(Player1.Contains("-"+17+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 17;
			}
			if(Player1.Contains("-"+27+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 27;
			}
			if(Player1.Contains("-"+29+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 29;
			}
			if(Player1.Contains("-"+40+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 40;
			}
			}
			if(Section == "Section29"){
			if(Player1.Contains("-"+18+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 18;
			}
			if(Player1.Contains("-"+28+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 28;
			}
			if(Player1.Contains("-"+30+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 30;
			}
			if(Player1.Contains("-"+41+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 41;
			}
			}
			if(Section == "Section30"){
			if(Player1.Contains("-"+19+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 19;
			}
			if(Player1.Contains("-"+29+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 29;
			}
			if(Player1.Contains("-"+31+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 31;
			}
			if(Player1.Contains("-"+42+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 42;
			}
			}
			if(Section == "Section31"){
			if(Player1.Contains("-"+20+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 20;
			}
			if(Player1.Contains("-"+30+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 30;
			}
			if(Player1.Contains("-"+32+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 32;
			}
			if(Player1.Contains("-"+43+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 43;
			}
			}
			if(Section == "Section32"){
			if(Player1.Contains("-"+21+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 21;
			}
			if(Player1.Contains("-"+31+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 31;
			}
			if(Player1.Contains("-"+33+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 33;
			}
			if(Player1.Contains("-"+44+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 44;
			}
			}
			if(Section == "Section33"){
			if(Player1.Contains("-"+22+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 22;
			}
			if(Player1.Contains("-"+32+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 32;
			}
			if(Player1.Contains("-"+34+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 34;
			}
			if(Player1.Contains("-"+45+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 45;
			}
			}
			if(Section == "Section34"){
			if(Player1.Contains("-"+23+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 23;
			}
			if(Player1.Contains("-"+33+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 33;
			}
			if(Player1.Contains("-"+35+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 35;
			}
			if(Player1.Contains("-"+46+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 46;
			}
			}
			if(Section == "Section35"){
			if(Player1.Contains("-"+34+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 34;
			}
			}
			if(Section == "Section36"){
			if(Player1.Contains("-"+24+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 24;
			}
			if(Player1.Contains("-"+37+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 37;
			}
			if(Player1.Contains("-"+47+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 47;
			}
			}
			if(Section == "Section37"){
			if(Player1.Contains("-"+25+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 25;
			}
			if(Player1.Contains("-"+36+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 36;
			}
			if(Player1.Contains("-"+38+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 38;
			}
			if(Player1.Contains("-"+48+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 48;
			}
			}
			if(Section == "Section38"){
			if(Player1.Contains("-"+26+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 26;
			}
			if(Player1.Contains("-"+37+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 37;
			}
			if(Player1.Contains("-"+39+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 39;
			}
			if(Player1.Contains("-"+49+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 49;
			}
			}
			if(Section == "Section39"){
			if(Player1.Contains("-"+27+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 27;
			}
			if(Player1.Contains("-"+38+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 38;
			}
			if(Player1.Contains("-"+40+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 40;
			}
			if(Player1.Contains("-"+50+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 50;
			}
			}
			if(Section == "Section40"){
			if(Player1.Contains("-"+28+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 28;
			}
			if(Player1.Contains("-"+39+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 39;
			}
			if(Player1.Contains("-"+41+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 41;
			}
			if(Player1.Contains("-"+51+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 51;
			}
			}
			if(Section == "Section41"){
			if(Player1.Contains("-"+29+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 29;
			}
			if(Player1.Contains("-"+40+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 40;
			}
			if(Player1.Contains("-"+42+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 42;
			}
			if(Player1.Contains("-"+52+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 52;
			}
			}
			if(Section == "Section42"){
			if(Player1.Contains("-"+30+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 30;
			}
			if(Player1.Contains("-"+41+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 41;
			}
			if(Player1.Contains("-"+43+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 43;
			}
			if(Player1.Contains("-"+53+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 53;
			}
			}
			if(Section == "Section43"){
			if(Player1.Contains("-"+31+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 31;
			}
			if(Player1.Contains("-"+42+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 42;
			}
			if(Player1.Contains("-"+44+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 44;
			}
			if(Player1.Contains("-"+54+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 54;
			}
			}
			if(Section == "Section44"){
			if(Player1.Contains("-"+32+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 32;
			}
			if(Player1.Contains("-"+43+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 43;
			}
			if(Player1.Contains("-"+45+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 45;
			}
			if(Player1.Contains("-"+55+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 55;
			}
			}
			if(Section == "Section45"){
			if(Player1.Contains("-"+33+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 33;
			}
			if(Player1.Contains("-"+44+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 44;
			}
			if(Player1.Contains("-"+46+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 46;
			}
			if(Player1.Contains("-"+56+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 56;
			}
			}
			if(Section == "Section46"){
			if(Player1.Contains("-"+34+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 34;
			}
			if(Player1.Contains("-"+45+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 45;
			}
			if(Player1.Contains("-"+57+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 57;
			}
			}
			if(Section == "Section47"){
			if(Player1.Contains("-"+36+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 36;
			}
			if(Player1.Contains("-"+48+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 48;
			}
			if(Player1.Contains("-"+58+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 58;
			}
			}
			if(Section == "Section48"){
			if(Player1.Contains("-"+37+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 37;
			}
			if(Player1.Contains("-"+47+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 47;
			}
			if(Player1.Contains("-"+49+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 49;
			}
			if(Player1.Contains("-"+59+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 59;
			}
			}
			if(Section == "Section49"){
			if(Player1.Contains("-"+38+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 38;
			}
			if(Player1.Contains("-"+48+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 48;
			}
			if(Player1.Contains("-"+50+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 50;
			}
			if(Player1.Contains("-"+60+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 60;
			}
			}
			if(Section == "Section50"){
			if(Player1.Contains("-"+39+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 39;
			}
			if(Player1.Contains("-"+49+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 49;
			}
			if(Player1.Contains("-"+51+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 51;
			}
			if(Player1.Contains("-"+61+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 61;
			}
			}
			if(Section == "Section51"){
			if(Player1.Contains("-"+40+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 40;
			}
			if(Player1.Contains("-"+50+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 50;
			}
			if(Player1.Contains("-"+52+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3= 52;
			}
			if(Player1.Contains("-"+62+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 62;
			}
			}
			if(Section == "Section52"){
			if(Player1.Contains("-"+41+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 41;
			}
			if(Player1.Contains("-"+51+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 51;
			}
			if(Player1.Contains("-"+53+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 53;
			}
			if(Player1.Contains("-"+63+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 63;
			}
			}
			if(Section == "Section53"){
			if(Player1.Contains("-"+42+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 42;
			}
			if(Player1.Contains("-"+52+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 52;
			}
			if(Player1.Contains("-"+54+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 53;
			}
			if(Player1.Contains("-"+64+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 64;
			}
			}
			if(Section == "Section54"){
			if(Player1.Contains("-"+43+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 43;
			}
			if(Player1.Contains("-"+53+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 53;
			}
			if(Player1.Contains("-"+55+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 55;
			}
			if(Player1.Contains("-"+65+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 65;
			}
			}
			if(Section == "Section55"){
			if(Player1.Contains("-"+44+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 44;
			}
			if(Player1.Contains("-"+54+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 54;
			}
			if(Player1.Contains("-"+56+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 56;
			}
			if(Player1.Contains("-"+66+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 66;
			}
			}
			if(Section == "Section56"){
			if(Player1.Contains("-"+45+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 45;
			}
			if(Player1.Contains("-"+55+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 55;
			}
			if(Player1.Contains("-"+57+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 57;
			}
			if(Player1.Contains("-"+67+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 67;
			}
			}
			if(Section == "Section57"){
			if(Player1.Contains("-"+46+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 46;
			}
			if(Player1.Contains("-"+56+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 56;
			}
			if(Player1.Contains("-"+68+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 68;
			}
			}
			if(Section == "Section58"){
			if(Player1.Contains("-"+47+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 47;
			}
			if(Player1.Contains("-"+59+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 59;
			}
			}
			if(Section == "Section59"){
			if(Player1.Contains("-"+48+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 48;
			}
			if(Player1.Contains("-"+58+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 58;
			}
			if(Player1.Contains("-"+60+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 60;
			}
			if(Player1.Contains("-"+69+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 69;
			}
			}
			if(Section == "Section60"){
			if(Player1.Contains("-"+49+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 60;
			}
			if(Player1.Contains("-"+59+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 59;
			}
			if(Player1.Contains("-"+61+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 61;
			}
			if(Player1.Contains("-"+70+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 70;
			}
			}
			if(Section == "Section61"){
			if(Player1.Contains("-"+50+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 50;
			}
			if(Player1.Contains("-"+60+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 60;
			}
			if(Player1.Contains("-"+62+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 62;
			}
			if(Player1.Contains("-"+71+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 71;
			}
			}
			if(Section == "Section62"){
			if(Player1.Contains("-"+51+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 51;
			}
			if(Player1.Contains("-"+61+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 61;
			}
			if(Player1.Contains("-"+63+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 63;
			}
			if(Player1.Contains("-"+72+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 72;
			}
			}
			if(Section == "Section63"){
			if(Player1.Contains("-"+52+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 52;
			}
			if(Player1.Contains("-"+62+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 62;
			}
			if(Player1.Contains("-"+64+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 64;
			}
			if(Player1.Contains("-"+73+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 73;
			}
			}
			if(Section == "Section64"){
			if(Player1.Contains("-"+53+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 53;
			}
			if(Player1.Contains("-"+63+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 63;
			}
			if(Player1.Contains("-"+65+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 65;
			}
			if(Player1.Contains("-"+74+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 74;
			}
			}
			if(Section == "Section65"){
			if(Player1.Contains("-"+54+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 54;
			}
			if(Player1.Contains("-"+64+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 64;
			}
			if(Player1.Contains("-"+66+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 66;
			}
			if(Player1.Contains("-"+75+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 75;
			}
			}
			if(Section == "Section66"){
			if(Player1.Contains("-"+55+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 55;
			}
			if(Player1.Contains("-"+65+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 65;
			}
			if(Player1.Contains("-"+67+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 67;
			}
			if(Player1.Contains("-"+76+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 76;
			}
			}
			if(Section == "Section67"){
			if(Player1.Contains("-"+56+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 56;
			}
			if(Player1.Contains("-"+66+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 66;
			}
			if(Player1.Contains("-"+68+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 68;
			}
			}
			if(Section == "Section68"){
			if(Player1.Contains("-"+57+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 57;
			}
			if(Player1.Contains("-"+67+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 67;
			}
			}
			if(Section == "Section69"){
			if(Player1.Contains("-"+59+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 59;
			}
			if(Player1.Contains("-"+70+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 70;
			}
			}
			if(Section == "Section70"){
			if(Player1.Contains("-"+60+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 60;
			}
			if(Player1.Contains("-"+69+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 69;
			}
			if(Player1.Contains("-"+71+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 71;
			}
			if(Player1.Contains("-"+77+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 77;
			}
			}
			if(Section == "Section71"){
			if(Player1.Contains("-"+61+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 61;
			}
			if(Player1.Contains("-"+70+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 70;
			}
			if(Player1.Contains("-"+72+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 72;
			}
			if(Player1.Contains("-"+78+"-")){
			war = 10; p1 = p1 + 0.5f; player1section4 = 78;
			}
			}
			if(Section == "Section72"){
			if(Player1.Contains("-"+62+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 62;
			}
			if(Player1.Contains("-"+71+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 71;
			}
			if(Player1.Contains("-"+73+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 73;
			}
			}
			if(Section == "Section73"){
			if(Player1.Contains("-"+63+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 63;
			}
			if(Player1.Contains("-"+72+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 72;
			}
			if(Player1.Contains("-"+74+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 74;
			}
			}
			if(Section == "Section74"){
			if(Player1.Contains("-"+64+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 64;
			}
			if(Player1.Contains("-"+73+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 73;
			}
			if(Player1.Contains("-"+75+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 75;
			}
			}
			if(Section == "Section75"){
			if(Player1.Contains("-"+65+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 65;
			}
			if(Player1.Contains("-"+74+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 74;
			}
			if(Player1.Contains("-"+76+"-")){
			war = 10; p1 = p1 + 0.5f; player1section3 = 76;
			}
			}
			if(Section == "Section76"){
			if(Player1.Contains("-"+66+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 66;
			}
			if(Player1.Contains("-"+75+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 75;
			}
			}
			if(Section == "Section77"){
			if(Player1.Contains("-"+70+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 70;
			}
			if(Player1.Contains("-"+78+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 78;
			}
			}
			if(Section == "Section78"){
			if(Player1.Contains("-"+71+"-")){
			war = 10; p1 = p1 + 0.5f; player1section1 = 71;
			}
			if(Player1.Contains("-"+77+"-")){
			war = 10; p1 = p1 + 0.5f; player1section2 = 77;
			}
			}
			}
			Section = Section.Remove(0,7);
			PlayerPrefs.SetString("Player2Section", Section);
			PlayerPrefs.SetInt("Player1Section1", player1section1);
			PlayerPrefs.SetInt("Player1Section2", player1section2);
			PlayerPrefs.SetInt("Player1Section3", player1section3);
			PlayerPrefs.SetInt("Player1Section4", player1section4);
			PlayerPrefs.Save();
			if(Player1.Contains("-"+Section.ToString()+"-")){
			p1 = 0;
			war = 0;
			}
			if(PlayerPrefs.GetString("Red").Contains("-"+Section.ToString()+"-")){
			Flag.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
			Cancel.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_red_rectangle", typeof(Sprite)) as Sprite;
			War.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_red_rectangle", typeof(Sprite)) as Sprite;
			InfoButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_red_rectangle", typeof(Sprite)) as Sprite;
			PowerupButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_red_rectangle", typeof(Sprite)) as Sprite;
			Glass.GetComponent(SpriteRenderer).sprite =  Resources.Load("panelred", typeof(Sprite)) as Sprite;
			TitleText.GetComponent.<TextMesh>().color = Color(1,0,0,1);
			ChanceText.GetComponent.<TextMesh>().color = Color(1,0,0,1);
			PowerupText.GetComponent.<TextMesh>().color = Color(1,0,0,1);
			TotalText.GetComponent.<TextMesh>().color = Color(1,0,0,1);
			PowerupTitle.GetComponent.<TextMesh>().color = Color(1,0,0,1);
			Coins.GetComponent.<TextMesh>().color = Color(1,0,0,1);
			var titletextred : TextMesh = TitleText.GetComponent(TextMesh);
			titletextred.text = "Red";
			PlayerPrefs.SetString("Player2", "Red");
			PlayerPrefs.Save();
			}
   			if(PlayerPrefs.GetString("Blue").Contains("-"+Section.ToString()+"-")){
			Flag.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
			Cancel.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_blue_rectangle", typeof(Sprite)) as Sprite;
			War.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_blue_rectangle", typeof(Sprite)) as Sprite;
			InfoButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_blue_rectangle", typeof(Sprite)) as Sprite;
			PowerupButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_blue_rectangle", typeof(Sprite)) as Sprite;
			Glass.GetComponent(SpriteRenderer).sprite =  Resources.Load("panelblue", typeof(Sprite)) as Sprite;
			TitleText.GetComponent.<TextMesh>().color = Color(0,0,1,1);
			ChanceText.GetComponent.<TextMesh>().color = Color(0,0,1,1);
			PowerupText.GetComponent.<TextMesh>().color = Color(0,0,1,1);
			TotalText.GetComponent.<TextMesh>().color = Color(0,0,1,1);
			PowerupTitle.GetComponent.<TextMesh>().color = Color(0,0,1,1);
			Coins.GetComponent.<TextMesh>().color = Color(0,0,1,1);
			var titletextblue : TextMesh = TitleText.GetComponent(TextMesh);
			titletextblue.text = "Blue";
			PlayerPrefs.SetString("Player2", "Blue");
			PlayerPrefs.Save();
    		}
			if(PlayerPrefs.GetString("Yellow").Contains("-"+Section.ToString()+"-")){
			Flag.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
			Cancel.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_yellow_rectangle", typeof(Sprite)) as Sprite;
			War.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_yellow_rectangle", typeof(Sprite)) as Sprite;
			InfoButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_yellow_rectangle", typeof(Sprite)) as Sprite;
			PowerupButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_yellow_rectangle", typeof(Sprite)) as Sprite;
			Glass.GetComponent(SpriteRenderer).sprite =  Resources.Load("panelyellow", typeof(Sprite)) as Sprite;
			TitleText.GetComponent.<TextMesh>().color = Color(1,0.92,0.016,1);
			ChanceText.GetComponent.<TextMesh>().color = Color(1,0.92,0.016,1);
			PowerupText.GetComponent.<TextMesh>().color = Color(1,0.92,0.016,1);
			TotalText.GetComponent.<TextMesh>().color = Color(1,0.92,0.016,1);
			PowerupTitle.GetComponent.<TextMesh>().color = Color(1,0.92,0.016,1);
			Coins.GetComponent.<TextMesh>().color = Color(1,0.92,0.016,1);
			var titletextyellow : TextMesh = TitleText.GetComponent(TextMesh);
			titletextyellow.text = "Yellow";
			PlayerPrefs.SetString("Player2", "Yellow");
			PlayerPrefs.Save();
			}
			if(PlayerPrefs.GetString("Green").Contains("-"+Section.ToString()+"-")){/*
			Flag.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
			Cancel.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_green_rectangle", typeof(Sprite)) as Sprite;
			War.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_green_rectangle", typeof(Sprite)) as Sprite;
			InfoButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_green_rectangle", typeof(Sprite)) as Sprite;
			PowerupButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_green_rectangle", typeof(Sprite)) as Sprite;
			Glass.GetComponent(SpriteRenderer).sprite =  Resources.Load("panelgreen", typeof(Sprite)) as Sprite;
			TitleText.GetComponent.<TextMesh>().color = Color(0,1,0,1);
			ChanceText.GetComponent.<TextMesh>().color = Color(0,1,0,1);
			PowerupText.GetComponent.<TextMesh>().color = Color(0,1,0,1);
			TotalText.GetComponent.<TextMesh>().color = Color(0,1,0,1);
			PowerupTitle.GetComponent.<TextMesh>().color = Color(0,1,0,1);
			Coins.GetComponent.<TextMesh>().color = Color(0,1,0,1);
			var titletextgreen : TextMesh = TitleText.GetComponent(TextMesh);
			titletextgreen.text = "Green";*/
			PlayerPrefs.SetString("Player2", "Green");
			PlayerPrefs.Save();
			}
			if(PlayerPrefs.GetString("Cyan").Contains("-"+Section.ToString()+"-")){
			Flag.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
			Cancel.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_cyan_rectangle", typeof(Sprite)) as Sprite;
			War.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_cyan_rectangle", typeof(Sprite)) as Sprite;
			InfoButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_cyan_rectangle", typeof(Sprite)) as Sprite;
			PowerupButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_cyan_rectangle", typeof(Sprite)) as Sprite;
			Glass.GetComponent(SpriteRenderer).sprite =  Resources.Load("panelcyan", typeof(Sprite)) as Sprite;
			TitleText.GetComponent.<TextMesh>().color = Color(0,1,1,1);
			ChanceText.GetComponent.<TextMesh>().color = Color(0,1,1,1);
			PowerupText.GetComponent.<TextMesh>().color = Color(0,1,1,1);
			TotalText.GetComponent.<TextMesh>().color = Color(0,1,1,1);
			PowerupTitle.GetComponent.<TextMesh>().color = Color(0,1,1,1);
			Coins.GetComponent.<TextMesh>().color = Color(0,1,1,1);
			var titletextcyan : TextMesh = TitleText.GetComponent(TextMesh);
			titletextcyan.text = "Cyan";
			PlayerPrefs.SetString("Player2", "Cyan");
			PlayerPrefs.Save();
			}
			if(PlayerPrefs.GetString("Purple").Contains("-"+Section.ToString()+"-")){
			Flag.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
			Cancel.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_purple_rectangle", typeof(Sprite)) as Sprite;
			War.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_purple_rectangle", typeof(Sprite)) as Sprite;
			InfoButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_purple_rectangle", typeof(Sprite)) as Sprite;
			PowerupButton.GetComponent(SpriteRenderer).sprite =  Resources.Load("element_purple_rectangle", typeof(Sprite)) as Sprite;
			Glass.GetComponent(SpriteRenderer).sprite =  Resources.Load("panelpurple", typeof(Sprite)) as Sprite;
			TitleText.GetComponent.<TextMesh>().color = Color(0.5,0,1,1);
			ChanceText.GetComponent.<TextMesh>().color = Color(0.5,0,1,1);
			PowerupText.GetComponent.<TextMesh>().color = Color(0.5,0,1,1);
			TotalText.GetComponent.<TextMesh>().color = Color(0.5,0,1,1);
			PowerupTitle.GetComponent.<TextMesh>().color = Color(0.5,0,1,1);
			Coins.GetComponent.<TextMesh>().color = Color(0.5,0,1,1);
			var titletextpurple : TextMesh = TitleText.GetComponent(TextMesh);
			titletextpurple.text = "Purple";
			PlayerPrefs.SetString("Player2", "Purple");
			PlayerPrefs.Save();
			}
			Glass.active = true;
			camera.orthographicSize = 5;
			DisSection.active = false;
			Powerup.active = false;
			Info.active = true;
			transform.position = new Vector3 (0, 0, -10);
			if(war == 10){
			p1 = p1 + 2.5f;
			war1 = 10;
			var chance : TextMesh = ChanceText.GetComponent(TextMesh);
			chance.text = "Chance = " + p1;
			var power : TextMesh = PowerupText.GetComponent(TextMesh);
			power.text = "Powerups = 0";
			var total : TextMesh = TotalText.GetComponent(TextMesh);
			total.text = "Total = " + p1;
			PlayerPrefs.SetFloat("Player1Hearts", p1);
			PlayerPrefs.SetFloat("Player2Hearts", 3);
			PlayerPrefs.Save();
			}
			else if(war == 0){
			var chancefail : TextMesh = ChanceText.GetComponent(TextMesh);
			chancefail.text = "Chance = 0";
			var powerfail : TextMesh = PowerupText.GetComponent(TextMesh);
			powerfail.text = "Powerups = 0";
			var totalfail : TextMesh = TotalText.GetComponent(TextMesh);
			totalfail.text = "Total = 0";
			}
			war = 0;
			PlayerPrefs.SetInt("Menu", 2);
			PlayerPrefs.Save();
			}
		}
	}
			if(Input.GetMouseButtonDown(0)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, hit)){
			if(hit.transform.name == "CancelButton"){
			Section = hit.transform.name;
			Powerup.active = false;
			Info.active = true;
			Glass.active = false;
			camera.orthographicSize = 5;
			DisSection.active = true;
			PlayerPrefs.SetInt("Menu", 0);
			PlayerPrefs.Save();
			}
			if(hit.transform.name == "WarButton"){
			if(war1 == 10){
			Powerup.active = false;
			Info.active = true;
			Background.active = true;
			Wall.active = false;
			DisSection.active = false;
			Land.active = false;
			Glass.active = false;
			audio.Pause();
			audio.clip = Warmusic;
			audio.Play();
			PlayerPrefs.SetInt("War", 10);
			PlayerPrefs.SetInt("Ended", 0);
			PlayerPrefs.SetInt("Paused", 0);
			PlayerPrefs.Save();
			}
			}
			if(hit.transform.name == "PowerupButton"){
			if(war1 == 10){
			Info.active = false;
			Powerup.active = true;
			}
			}
			if(hit.transform.name == "InfoButton"){
			if(war1 == 10){
			Powerup.active = false;
			Info.active = true;
			}
			}
		}
	}
}