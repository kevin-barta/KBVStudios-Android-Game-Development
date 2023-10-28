#pragma strict

var ColourPlayer1 : String = "";
var Player1 : GameObject;
var MainCamera : GameObject;
var leftarrow : GameObject;
var rightarrow : GameObject;
var jumpbutton : GameObject;
var pausebutton : GameObject;
var hearts : GameObject;
var winner : GameObject;
var p1hearts1 : GameObject;
var p1hearts2 : GameObject;
var p1hearts3 : GameObject;
var p1hearts4 : GameObject;
var p1hearts5 : GameObject;
var p1hearts : float = 0f;
var Jump : int = 0;
var Walk : int = 0;
var Walkright : int = 0;
var Walkleft : int = 0;
var Nowjumping : int = 0;
private var ray : Ray;
private var hit : RaycastHit;
var speedright : float = 0.1F;
var speedleft : float = -0.1F;
var speed : float = 0.1F;

function Start () {
leftarrow.active = true;
rightarrow.active = true;
jumpbutton.active = true;
pausebutton.active = true;
hearts.active = true;
winner.active = true;
p1hearts = PlayerPrefs.GetFloat("Player1Hearts");
if(p1hearts == 3){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
}
if(p1hearts == 3.5){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("hearthalf", typeof(Sprite)) as Sprite;
}
if(p1hearts == 4){
p1hearts1.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts2.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts3.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
p1hearts4.GetComponent(SpriteRenderer).sprite =  Resources.Load("heartfull", typeof(Sprite)) as Sprite;
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
MainCamera.transform.position = new Vector3 (-10f, MainCamera.transform.position.y, -10);
ColourPlayer1 = PlayerPrefs.GetString("Player1");
if(ColourPlayer1 == "Red"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("red_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Blue"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Yellow"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("yellow_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Green"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("green_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Cyan"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("cyan_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Purple"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("purple_stand", typeof(Sprite)) as Sprite;
}
}

function Update () {
if (PlayerPrefs.GetInt("Ended") == 0){
if (Nowjumping == 10){
if (Player1.transform.position.y < -4) {
Nowjumping = 0;
if(ColourPlayer1 == "Red"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("red_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Blue"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Yellow"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("yellow_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Green"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("green_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Cyan"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("cyan_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Purple"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("purple_stand", typeof(Sprite)) as Sprite;
}
}
}
if(Input.GetMouseButtonUp(0)){
	if(Walk == 10){
	Walk = 0;
	Walkleft = 0;
	Walkright = 0;
	}
}
if(PlayerPrefs.GetInt("Paused") == 0){
if(Walkleft == 10){
Player1.transform.Translate (-1 * speedleft, 0, 0);
MainCamera.transform.Translate (-1 * speed, 0, 0);
}
else if(Walkright == 10){
Player1.transform.Translate (1 * speedright, 0, 0);
MainCamera.transform.Translate (1 * speed, 0, 0);
}
}
if (Player1.transform.position.x > 16.5) {
Player1.transform.position = new Vector3 (16.49f, Player1.transform.position.y, -1);
}
if (Player1.transform.position.x < -16.5) {
Player1.transform.position = new Vector3 (-16.49f, Player1.transform.position.y, -1);
}
if (MainCamera.transform.position.x > 10) {
MainCamera.transform.position = new Vector3 (9.99f, MainCamera.transform.position.y, -10);
}
if (MainCamera.transform.position.x < -10) {
MainCamera.transform.position = new Vector3 (-9.99f, MainCamera.transform.position.y, -10);
}
if(Input.GetMouseButtonDown(0)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, hit)){
			if(hit.transform.name == "right"){
			Walkright = 10;
			Walk = 10;
			Walking();
			}
			if(hit.transform.name == "left"){
			Walkleft = 10;
			Walk = 10;
			Walking();
			}
			if(hit.transform.name == "jump"){
			Jump = 10;
			Jumping();
			}
		}
	}
}
if(PlayerPrefs.GetInt("Ended") == 10){
Walk = 0;
Walkleft = 0;
Walkright = 0;
}
}
function Walking (){
while(Walk == 10){
if(Walkleft == 10){
Player1.transform.rotation = Quaternion.Euler(0, 180, 0);
}
else if(Walkright == 10){
Player1.transform.rotation = Quaternion.Euler(0, 0, 0);
}
if(ColourPlayer1 == "Red"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("red_walk01", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("red_walk02", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("red_walk03", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
}
else if(ColourPlayer1 == "Blue"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_walk01", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_walk02", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_walk03", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
}
else if(ColourPlayer1 == "Yellow"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("yellow_walk01", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("yellow_walk02", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("yellow_walk03", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
}
else if(ColourPlayer1 == "Green"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("green_walk01", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("green_walk02", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("green_walk03", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
}
else if(ColourPlayer1 == "Cyan"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("cyan_walk01", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("cyan_walk02", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("cyan_walk03", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
}
else if(ColourPlayer1 == "Purple"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("purple_walk01", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("purple_walk02", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("purple_walk03", typeof(Sprite)) as Sprite;
yield WaitForSeconds (0.15);
}
}
if(ColourPlayer1 == "Red"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("red_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Blue"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Yellow"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("yellow_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Green"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("green_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Cyan"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("cyan_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Purple"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("purple_stand", typeof(Sprite)) as Sprite;
}
}
function Jumping () {
if(PlayerPrefs.GetInt("Paused") == 0){
if(Jump == 10){
if(Nowjumping == 0){
Nowjumping = 10;
if(ColourPlayer1 == "Red"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("red_jump", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Blue"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_jump", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Yellow"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("yellow_jump", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Green"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("green_jump", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Cyan"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("cyan_jump", typeof(Sprite)) as Sprite;
}
if(ColourPlayer1 == "Purple"){
Player1.GetComponent(SpriteRenderer).sprite =  Resources.Load("purple_jump", typeof(Sprite)) as Sprite;
}
Player1.rigidbody.AddForce(Vector3.up *10, ForceMode.VelocityChange);
}
}
}
}