#pragma strict

var ColourPlayer2 : String = "";
var Player1 : GameObject;
var Player2 : GameObject;
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
var Players : float = 0F;
var Player1oldx : float = 0F;

function Start () {
ColourPlayer2 = PlayerPrefs.GetString("Player2");
if(ColourPlayer2 == "Red"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("red_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Blue"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Yellow"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("yellow_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Green"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("green_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Cyan"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("cyan_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Purple"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("purple_stand", typeof(Sprite)) as Sprite;
}
}

function Update () {
if (PlayerPrefs.GetInt("Ended") == 0){
if (Nowjumping == 5){
if (Player2.transform.position.y < -3.5) {
Nowjumping = 0;
if(ColourPlayer2 == "Red"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("red_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Blue"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Yellow"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("yellow_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Green"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("green_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Cyan"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("cyan_stand", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Purple"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("purple_stand", typeof(Sprite)) as Sprite;
}
}
}
if (Player2.transform.position.x > 16.5) {
Player2.transform.position = new Vector3 (16.49f, Player2.transform.position.y, 0);
}
if (Player2.transform.position.x < -16.5) {
Player2.transform.position = new Vector3 (-16.49f, Player2.transform.position.y, 0);
}
Closecombat ();
}
}

function Closecombat (){
if (Nowjumping == 0){
Players = Player1.transform.position.x - Player2.transform.position.x;
if(ColourPlayer2 == "Red"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("red_jump", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Blue"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("blue_jump", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Yellow"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("yellow_jump", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Green"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("green_jump", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Cyan"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("cyan_jump", typeof(Sprite)) as Sprite;
}
if(ColourPlayer2 == "Purple"){
Player2.GetComponent(SpriteRenderer).sprite =  Resources.Load("purple_jump", typeof(Sprite)) as Sprite;
}
if ((Players < 33) && (Players > 0)) {
Nowjumping = 5;
Player2.rigidbody.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
Player1oldx = Player1.transform.position.x;
while (Player1oldx - Player2.transform.position.x > 0.1){
Player2.transform.Translate (0.01, 0, 0);
yield WaitForSeconds (0.01);
}
}
else if ((Players > -33) && (Players < 0)) {
Nowjumping = 5;
Player2.rigidbody.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
Player1oldx = Player1.transform.position.x;
while (Player2.transform.position.x - Player1oldx > 0.1){
Player2.transform.Translate (-0.01, 0, 0);
yield WaitForSeconds (0.01);
}
}
}
}