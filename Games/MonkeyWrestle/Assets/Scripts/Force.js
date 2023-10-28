#pragma strict
private var ray : Ray;
private var hit : RaycastHit;
var Player1 : GameObject;
var Player2 : GameObject;
var MainCamera : GameObject;
var Arms : GameObject;
var Smoke : GameObject;
var Legs : GameObject;
var x : int = 10;
var jump1 : AudioClip;
var jump2 : AudioClip;

function Update () {
if(PlayerPrefs.GetInt("Hardcore") == 10){
MainCamera.transform.rotation = Arms.transform.rotation;
}
MainCamera.transform.position.x = Arms.transform.position.x;
MainCamera.transform.position.y = Arms.transform.position.y;
if(x == 10){
if(Input.GetMouseButtonDown(0)){
if(PlayerPrefs.GetInt("P1") == 10){
if(PlayerPrefs.GetInt("Fin") == 0){
if(PlayerPrefs.GetInt("Grounded") == 10){
x = 0;
Instantiate(Smoke, Vector3 (Legs.transform.position.x, Legs.transform.position.y, 0), Smoke.transform.rotation);
PlayerPrefs.SetInt("Grounded", 0);
PlayerPrefs.SetInt("Smoke", 0);
PlayerPrefs.Save();
Player1.GetComponent.<Rigidbody2D>().AddForce(Vector2.up * 1800);
Force();
}
else{
x = 0;
Player1.GetComponent.<Rigidbody2D>().AddForce(Vector2.up * 200);
Force();
}
}
}
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(PlayerPrefs.GetInt("P2") == 10){
if(hit.transform.name == "topright" || hit.transform.name == "centerright" || hit.transform.name == "bottomright"){
if(PlayerPrefs.GetInt("Fin") == 0){
if(PlayerPrefs.GetInt("Grounded") == 10){
x = 0;
Instantiate(Smoke, Vector3 (Legs.transform.position.x, Legs.transform.position.y, 0), Smoke.transform.rotation);
PlayerPrefs.SetInt("Grounded", 0);
PlayerPrefs.SetInt("Smoke", 0);
PlayerPrefs.Save();
Player1.GetComponent.<Rigidbody2D>().AddForce(Vector2.up * 1800);
Force();
}
else{
x = 0;
Player1.GetComponent.<Rigidbody2D>().AddForce(Vector2.up * 200);
Force();
}
}
}
}
}
}
}
}

function Force (){
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