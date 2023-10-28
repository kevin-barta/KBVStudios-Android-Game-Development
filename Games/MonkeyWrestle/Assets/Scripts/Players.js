#pragma strict
var Drag : int = 0;
var Player1Star : int = 0;
var Player2Star : int = 0;
var land1;
var land2;
var land3;
var land4;
var land5;
var Level1 : GameObject;
var Level2 : GameObject;
var Level3 : GameObject;
var Level4 : GameObject;
var Level5 : GameObject;
var Level6 : GameObject;
var Level7 : GameObject;
var smoke1 : GameObject;
var Player1Head : GameObject;
var Player2Head : GameObject;
var StarCrash : GameObject;
var fight : GameObject;
var Star1 : GameObject;
var Star2 : GameObject;
var Star3 : GameObject;
var Star4 : GameObject;
var Star5 : GameObject;
var Star6 : GameObject;
var Star7 : GameObject;
var Star8 : GameObject;
var Star9 : GameObject;
var Star10 : GameObject;
var StarWin : GameObject;
var PurpleWin: GameObject;
var BlueWin : GameObject;
var PlayerColour : GameObject;
var Smoke : GameObject; 
var c0 : GameObject;
var c1 : GameObject;
var c2 : GameObject;
var c3 : GameObject;
var c4 : GameObject;
var c5 : GameObject;
var c6 : GameObject;
var c7 : GameObject;
var c8 : GameObject;
var c9 : GameObject;
var start : AudioClip;
var end : AudioClip;
var smash1 : AudioClip;
var Player2 = "";
var Player1 = "";
var Player1Respawn : GameObject;
var Player2Respawn : GameObject;

function Start (){
PlayerPrefs.SetInt("restart", 0);
PlayerPrefs.SetInt("Fin", 0);
PlayerPrefs.Save();
}

function OnCollisionEnter2D(collision : Collision2D) {
if (collision.gameObject.tag == "Ground") {
Instantiate(Smoke, Vector3 (transform.position.x, transform.position.y, 0), Smoke.transform.rotation);
PlayerPrefs.SetInt("Grounded", 10);
PlayerPrefs.Save();
}
if (gameObject.name == "characters_0"){
if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Ground2"){
if (PlayerPrefs.GetInt("restart") == 0){
PlayerPrefs.SetInt("restart", 10);
PlayerPrefs.SetInt("Fin", 10);
PlayerPrefs.Save();
if(PlayerPrefs.GetInt("Sound") == 0){
GetComponent.<AudioSource>().clip = smash1;
GetComponent.<AudioSource>().Play();
}
BlueWin.active = true;
StarCrash.active = true;
StarCrash.GetComponent(SpriteRenderer).color = Controller.P1Colour;
StarCrash.transform.position.x = Player1Head.transform.position.x;
StarCrash.transform.position.y = Player1Head.transform.position.y;
if(Player2Star == 0){
Star6.GetComponent(SpriteRenderer).color = Controller.P2Colour;
}
if(Player2Star == 1){
Star7.GetComponent(SpriteRenderer).color = Controller.P2Colour;
}
if(Player2Star == 2){
Star8.GetComponent(SpriteRenderer).color = Controller.P2Colour;
}
if(Player2Star == 3){
Star9.GetComponent(SpriteRenderer).color = Controller.P2Colour;
}
if(Player2Star == 4){
Star10.GetComponent(SpriteRenderer).color = Controller.P2Colour;
StarWin.GetComponent(SpriteRenderer).color = Controller.P2Colour;
StarWin.active = true;
yield WaitForSeconds (2);
if(PlayerPrefs.GetInt("Sound") == 0){
GetComponent.<AudioSource>().clip = end;
GetComponent.<AudioSource>().Play();
}
}
if(PlayerPrefs.GetInt("P1") == 10){
Player1 = PlayerPrefs.GetString("Player1");
Player1 = Player1.ToUpper();
if(Player1.Length > 8){
Player1 = Player1.Substring(0,8);
}
if(String.IsNullOrEmpty(Player1)){
Player1 = "PLAYER 1";
}
BlueWin.GetComponent(TextMesh).text = Player1;
PlayerColour.GetComponent(TextMesh).text = Player1;
}
else if(PlayerPrefs.GetInt("P2") == 10){
Player2 = PlayerPrefs.GetString("Player2");
Player2 = Player2.ToUpper();
if(Player2.Length > 8){
Player2 = Player2.Substring(0,8);
}
if(String.IsNullOrEmpty(Player2)){
Player2 = "PLAYER 2";
}
BlueWin.GetComponent(TextMesh).text = Player2;
PlayerColour.GetComponent(TextMesh).text = Player2;
}
Player2Star = Player2Star + 1;
Time.timeScale = 0.5;
yield WaitForSeconds (0.5);
Time.timeScale = 1;
StarCrash.active = false;
if(Player2Star == 5){
PlayerPrefs.SetInt("Fin", 0);
PlayerPrefs.Save();
}
yield WaitForSeconds (4.5);
if(Player2Star != 5){
StarCrash.active = false;
c0.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c0.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c2.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c2.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c5.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c5.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c7.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c7.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c6.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c6.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c1.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c1.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c4.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c4.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c8.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c8.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c3.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c3.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c9.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c9.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c0.transform.position = Vector3(-0.9891587, 1.160895, -5);
c0.transform.rotation = Quaternion.Euler(0, 0, 0);
c2.transform.position = Vector3(-0.64064, -0.05319196, -2);
c2.transform.rotation = Quaternion.Euler(0, 0, 270);
c5.transform.position = Vector3(-0.8182503, 0.7884912, -1);
c5.transform.rotation = Quaternion.Euler(0, 0, 0);
c7.transform.position = Vector3(-0.4798832, 0.1576366, -3);
c7.transform.rotation = Quaternion.Euler(0, 0, 45);
c6.transform.position = Vector3(-0.4663583, 0.9295555, -4);
c6.transform.rotation = Quaternion.Euler(0, 0, 0);
c1.transform.position = Vector3(0.9668487, 1.160895, -5);
c1.transform.rotation = Quaternion.Euler(0, 0, 0);
c4.transform.position = Vector3(0.7894014, 0.7884912, -1);
c4.transform.rotation = Quaternion.Euler(0, 0, 0);
c8.transform.position = Vector3(0.4241691, 0.1576366, -3);
c8.transform.rotation = Quaternion.Euler(0, 0, 315);
c3.transform.position = Vector3(0.5822707, -0.05319196, -2);
c3.transform.rotation = Quaternion.Euler(0, 0, 90);
c9.transform.position = Vector3(0.4490559, 0.9295555, -4);
c9.transform.rotation = Quaternion.Euler(0, 0, 0);
fight.SetActive(true);
Relevel();
yield WaitForSeconds (0.5);
fight.SetActive(false);
PlayerPrefs.SetInt("restart", 0);
PlayerPrefs.SetInt("Fin", 0);
PlayerPrefs.SetInt("Smoke", 0);
PlayerPrefs.SetInt("Smoke1", 0);
PlayerPrefs.Save();
}
StarCrash.active = false;
yield WaitForSeconds (1);
BlueWin.active = false;
}
}
}
if (gameObject.name == "characters_1"){
if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Ground2"){
if (PlayerPrefs.GetInt("restart") == 0){
PlayerPrefs.SetInt("restart", 10);
PlayerPrefs.SetInt("Fin", 10);
PlayerPrefs.Save();
if(PlayerPrefs.GetInt("Sound") == 0){
GetComponent.<AudioSource>().clip = smash1;
GetComponent.<AudioSource>().Play();
}
PurpleWin.active = true;
StarCrash.active = true;
StarCrash.GetComponent(SpriteRenderer).color = Controller.P2Colour;
StarCrash.transform.position.x = Player2Head.transform.position.x;
StarCrash.transform.position.y = Player2Head.transform.position.y;
if(Player1Star == 0){
Star1.GetComponent(SpriteRenderer).color = Controller.P1Colour;
}
if(Player1Star == 1){
Star2.GetComponent(SpriteRenderer).color = Controller.P1Colour;
}
if(Player1Star == 2){
Star3.GetComponent(SpriteRenderer).color = Controller.P1Colour;
}
if(Player1Star == 3){
Star4.GetComponent(SpriteRenderer).color = Controller.P1Colour;
}
if(Player1Star == 4){
Star5.GetComponent(SpriteRenderer).color = Controller.P1Colour;
StarWin.GetComponent(SpriteRenderer).color = Controller.P1Colour;
StarWin.active = true;
PlayerColour.GetComponent(TextMesh).text = Player1;
yield WaitForSeconds (2);
if(PlayerPrefs.GetInt("Sound") == 0){
GetComponent.<AudioSource>().clip = end;
GetComponent.<AudioSource>().Play();
}
}
if(PlayerPrefs.GetInt("P1") == 10){
Player1 = "OPPONENT";
PurpleWin.GetComponent(TextMesh).text = Player1;
PlayerColour.GetComponent(TextMesh).text = Player1;
}
else if(PlayerPrefs.GetInt("P2") == 10){
Player2 = PlayerPrefs.GetString("Player1");
Player2 = Player2.ToUpper();
if(Player2.Length > 8){
Player2 = Player2.Substring(0,8);
}
if(String.IsNullOrEmpty(Player2)){
Player2 = "PLAYER 1";
}
PurpleWin.GetComponent(TextMesh).text = Player2;
PlayerColour.GetComponent(TextMesh).text = Player2;
}
Player1Star = Player1Star + 1;
Time.timeScale = 0.5;
yield WaitForSeconds (0.5);
Time.timeScale = 1;
if(Player1Star == 5){
PlayerPrefs.SetInt("Fin", 0);
PlayerPrefs.Save();
}
yield WaitForSeconds (4.5);
if(Player1Star != 5){
StarCrash.active = false;
c0.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c0.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c2.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c2.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c5.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c5.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c7.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c7.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c6.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c6.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c1.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c1.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c4.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c4.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c8.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c8.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c3.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c3.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c9.GetComponent.<Rigidbody2D>().velocity = Vector3.zero;
c9.GetComponent.<Rigidbody2D>().angularVelocity = 0;
c0.transform.position = Vector3(-0.9891587, 1.160895, -5);
c0.transform.rotation = Quaternion.Euler(0, 0, 0);
c2.transform.position = Vector3(-0.64064, -0.05319196, -2);
c2.transform.rotation = Quaternion.Euler(0, 0, 270);
c5.transform.position = Vector3(-0.8182503, 0.7884912, -1);
c5.transform.rotation = Quaternion.Euler(0, 0, 0);
c7.transform.position = Vector3(-0.4798832, 0.1576366, -3);
c7.transform.rotation = Quaternion.Euler(0, 0, 45);
c6.transform.position = Vector3(-0.4663583, 0.9295555, -4);
c6.transform.rotation = Quaternion.Euler(0, 0, 0);
c1.transform.position = Vector3(0.9668487, 1.160895, -5);
c1.transform.rotation = Quaternion.Euler(0, 0, 0);
c4.transform.position = Vector3(0.7894014, 0.7884912, -1);
c4.transform.rotation = Quaternion.Euler(0, 0, 0);
c8.transform.position = Vector3(0.4241691, 0.1576366, -3);
c8.transform.rotation = Quaternion.Euler(0, 0, 315);
c3.transform.position = Vector3(0.5822707, -0.05319196, -2);
c3.transform.rotation = Quaternion.Euler(0, 0, 90);
c9.transform.position = Vector3(0.4490559, 0.9295555, -4);
c9.transform.rotation = Quaternion.Euler(0, 0, 0);
fight.SetActive(true);
Relevel();
yield WaitForSeconds (1);
fight.SetActive(false);
PlayerPrefs.SetInt("restart", 0);
PlayerPrefs.SetInt("Fin", 0);
PlayerPrefs.SetInt("Smoke", 0);
PlayerPrefs.SetInt("Smoke1", 0);
PlayerPrefs.Save();
}
StarCrash.active = false;
yield WaitForSeconds (1);
PurpleWin.active = false;
}
}
}
}

function OnTriggerEnter2D(other : Collider2D){
if (other.gameObject.name == "Limit Zero"){
GetComponent.<Rigidbody2D>().drag = 0;
}
if (other.gameObject.name == "Limit One"){
if (Drag == 0){
GetComponent.<Rigidbody2D>().drag = 1;
Drag = 10;
}
}
if (other.gameObject.name == "Limit Two"){
if (Drag == 10){
GetComponent.<Rigidbody2D>().drag = 2;
Drag = 20;
}
}
}

function Relevel () {
var colour : int = Mathf.Abs(Random.Range(1,5));
var level : int = Mathf.Abs(Random.Range(1,8));
Level1.SetActive(false);
Level2.SetActive(false);
Level3.SetActive(false);
Level4.SetActive(false);
Level5.SetActive(false);
Level6.SetActive(false);
Level7.SetActive(false);
if(level == 1){
Level1.SetActive(true);
}
if(level == 2){
Level2.SetActive(true);
}
if(level == 3){
Level3.SetActive(true);
}
if(level == 4){
Level4.SetActive(true);
}
if(level == 5){
Level5.SetActive(true);
}
if(level == 6){
Level6.SetActive(true);
}
if(level == 7){
Level7.SetActive(true);
}
if(colour == 1){
for(land1 in GameObject.FindGameObjectsWithTag("land_1")) {
var textures1 = Resources.LoadAll("land"); 
land1.GetComponent(SpriteRenderer).sprite = textures1[7]; 
}
for(land2 in GameObject.FindGameObjectsWithTag("land_2")) {
var textures2 = Resources.LoadAll("land"); 
land2.GetComponent(SpriteRenderer).sprite = textures2[3]; 
}
for(land3 in GameObject.FindGameObjectsWithTag("land_3")) {
var textures3 = Resources.LoadAll("land"); 
land3.GetComponent(SpriteRenderer).sprite = textures3[8]; 
}
for(land4 in GameObject.FindGameObjectsWithTag("land_4")) {
var textures4 = Resources.LoadAll("land"); 
land4.GetComponent(SpriteRenderer).sprite = textures4[13]; 
}
for(land5 in GameObject.FindGameObjectsWithTag("land_5")) {
land5.GetComponent(SpriteRenderer).sprite = Resources.Load(("land4"), typeof(Sprite)) as Sprite; 
}
var smokes1 = Resources.LoadAll("smoke"); 
smoke1.GetComponent(SpriteRenderer).sprite = smokes1[2];
}
if(colour == 2){
for(land1 in GameObject.FindGameObjectsWithTag("land_1")) {
var textures6 = Resources.LoadAll("land"); 
land1.GetComponent(SpriteRenderer).sprite = textures6[9]; 
}
for(land2 in GameObject.FindGameObjectsWithTag("land_2")) {
var textures7 = Resources.LoadAll("land"); 
land2.GetComponent(SpriteRenderer).sprite = textures7[4]; 
}
for(land3 in GameObject.FindGameObjectsWithTag("land_3")) {
var textures8 = Resources.LoadAll("land"); 
land3.GetComponent(SpriteRenderer).sprite = textures8[10]; 
}
for(land4 in GameObject.FindGameObjectsWithTag("land_4")) {
var textures9 = Resources.LoadAll("land"); 
land4.GetComponent(SpriteRenderer).sprite = textures9[14]; 
}
for(land5 in GameObject.FindGameObjectsWithTag("land_5")) {
land5.GetComponent(SpriteRenderer).sprite = Resources.Load(("land5"), typeof(Sprite)) as Sprite; 
}
var smokes2 = Resources.LoadAll("smoke"); 
smoke1.GetComponent(SpriteRenderer).sprite = smokes2[4];
}
if(colour == 3){
for(land1 in GameObject.FindGameObjectsWithTag("land_1")) {
var textures11 = Resources.LoadAll("land"); 
land1.GetComponent(SpriteRenderer).sprite = textures11[11]; 
}
for(land2 in GameObject.FindGameObjectsWithTag("land_2")) {
var textures12 = Resources.LoadAll("land"); 
land2.GetComponent(SpriteRenderer).sprite = textures12[5]; 
}
for(land3 in GameObject.FindGameObjectsWithTag("land_3")) {
var textures13 = Resources.LoadAll("land"); 
land3.GetComponent(SpriteRenderer).sprite = textures13[16]; 
}
for(land4 in GameObject.FindGameObjectsWithTag("land_4")) {
var textures14 = Resources.LoadAll("land"); 
land4.GetComponent(SpriteRenderer).sprite = textures14[15]; 
}
for(land5 in GameObject.FindGameObjectsWithTag("land_5")) {
land5.GetComponent(SpriteRenderer).sprite = Resources.Load(("land3"), typeof(Sprite)) as Sprite; 
}
var smokes3 = Resources.LoadAll("smoke"); 
smoke1.GetComponent(SpriteRenderer).sprite = smokes3[3];
}
if(colour == 4){
for(land1 in GameObject.FindGameObjectsWithTag("land_1")) {
var textures16 = Resources.LoadAll("land"); 
land1.GetComponent(SpriteRenderer).sprite = textures16[1]; 
}
for(land2 in GameObject.FindGameObjectsWithTag("land_2")) {
var textures17 = Resources.LoadAll("land"); 
land2.GetComponent(SpriteRenderer).sprite = textures17[2]; 
}
for(land3 in GameObject.FindGameObjectsWithTag("land_3")) {
var textures18 = Resources.LoadAll("land"); 
land3.GetComponent(SpriteRenderer).sprite = textures18[6]; 
}
for(land4 in GameObject.FindGameObjectsWithTag("land_4")) {
var textures19 = Resources.LoadAll("land"); 
land4.GetComponent(SpriteRenderer).sprite = textures19[12]; 
}
for(land5 in GameObject.FindGameObjectsWithTag("land_5")) {
land5.GetComponent(SpriteRenderer).sprite = Resources.Load(("land2"), typeof(Sprite)) as Sprite; 
}
var smokes4 = Resources.LoadAll("smoke"); 
smoke1.GetComponent(SpriteRenderer).sprite = smokes4[1];
}
yield WaitForSeconds (0.5);
if(PlayerPrefs.GetInt("Sound") == 0){
GetComponent.<AudioSource>().clip = start;
GetComponent.<AudioSource>().Play();
}
//Instantiate(Player1Respawn, Vector3 (0, 0, 0), Player1Respawn.transform.rotation);
//Instantiate(Player2Respawn, Vector3 (0, 0, 0), Player2Respawn.transform.rotation);
/*
c0.transform.position = Vector3(-0.9891587, 1.160895, -5);
c0.transform.rotation = Quaternion.Euler(0, 0, 0);
c2.transform.position = Vector3(-0.64064, -0.05319196, -2);
c2.transform.rotation = Quaternion.Euler(0, 0, 270);
c5.transform.position = Vector3(-0.8182503, 0.7884912, -1);
c5.transform.rotation = Quaternion.Euler(0, 0, 0);
c7.transform.position = Vector3(-0.4798832, 0.1576366, -3);
c7.transform.rotation = Quaternion.Euler(0, 0, 45);
c6.transform.position = Vector3(-0.4663583, 0.9295555, -4);
c6.transform.rotation = Quaternion.Euler(0, 0, 0);
c1.transform.position = Vector3(0.9668487, 1.160895, -5);
c1.transform.rotation = Quaternion.Euler(0, 0, 0);
c4.transform.position = Vector3(0.7894014, 0.7884912, -1);
c4.transform.rotation = Quaternion.Euler(0, 0, 0);
c8.transform.position = Vector3(0.4241691, 0.1576366, -3);
c8.transform.rotation = Quaternion.Euler(0, 0, 315);
c3.transform.position = Vector3(0.5822707, -0.05319196, -2);
c3.transform.rotation = Quaternion.Euler(0, 0, 90);
c9.transform.position = Vector3(0.4490559, 0.9295555, -4);
c9.transform.rotation = Quaternion.Euler(0, 0, 0);
*/
}