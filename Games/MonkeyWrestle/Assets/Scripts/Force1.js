#pragma strict
private var ray : Ray;
private var hit : RaycastHit;
var Player2 : GameObject;
var Smoke : GameObject;
var Legs : GameObject;
var x : int = 10;
var jump1 : AudioClip;
var jump2 : AudioClip;

function Update() {
if(x == 10){
if(PlayerPrefs.GetInt("Fin") == 0){
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(PlayerPrefs.GetInt("P2") == 10){
if(hit.transform.name == "topleft" || hit.transform.name == "centerleft" || hit.transform.name == "bottomleft"){
if(PlayerPrefs.GetInt("Grounded") == 10){
x = 0;
Instantiate(Smoke, Vector3 (Legs.transform.position.x, Legs.transform.position.y, 0), transform.rotation);
PlayerPrefs.SetInt("Grounded", 0);
PlayerPrefs.SetInt("Smoke1", 0);
PlayerPrefs.Save();
Player2.GetComponent.<Rigidbody2D>().AddForce(Vector2.up * 1800);
Force();
}
else if(PlayerPrefs.GetInt("P2") == 10){
x = 0;
Force();
}
}
}
}
}
if((PlayerPrefs.GetInt("Grounded") == 10) && (PlayerPrefs.GetInt("P1") == 10)){
x = 0;
Force();
}
else if(PlayerPrefs.GetInt("P1") == 10){
x = 0;
Player2.GetComponent.<Rigidbody2D>().AddForce(Vector2.up * 200);
Force();
}
}
}
}

function Force (){
var randomwaitforsecs = Random.Range(0.1f,6f);
if((PlayerPrefs.GetInt("Grounded") == 10) && (PlayerPrefs.GetInt("P1") == 10)){
yield WaitForSeconds (2);
if(PlayerPrefs.GetInt("Grounded") == 10){
Instantiate(Smoke, Vector3 (Legs.transform.position.x, Legs.transform.position.y, 0), transform.rotation);
PlayerPrefs.SetInt("Grounded", 0);
PlayerPrefs.SetInt("Smoke1", 0);
PlayerPrefs.Save();
Player2.GetComponent.<Rigidbody2D>().AddForce(Vector2.up * 1800);
}
else{
Player2.GetComponent.<Rigidbody2D>().AddForce(Vector2.up * 200);
}
}
if(PlayerPrefs.GetInt("P2") == 10){
yield WaitForSeconds (randomwaitforsecs);
Player2.GetComponent.<Rigidbody2D>().AddForce(Vector2.up * 200);
}
if (PlayerPrefs.GetInt("Jump")== 10){
if(PlayerPrefs.GetInt("Sound") == 0){
GetComponent.<AudioSource>().clip = jump2;
GetComponent.<AudioSource>().Play();
}
}
else{
if(PlayerPrefs.GetInt("Sound") == 0){
GetComponent.<AudioSource>().clip = jump1;
GetComponent.<AudioSource>().Play();
}
}
PlayerPrefs.SetInt("Jump", 10);
PlayerPrefs.Save();
yield WaitForSeconds (0.5);
x = 10;
PlayerPrefs.SetInt("Jump", 0);
PlayerPrefs.Save();
}