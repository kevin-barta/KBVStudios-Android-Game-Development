#pragma strict
var Drag : int = 0;
var Smoke : GameObject;

function Start (){
PlayerPrefs.SetInt("Smoke", 0);
PlayerPrefs.Save();
}

function OnCollisionEnter2D(collision : Collision2D) {
if (collision.gameObject.tag == "Ground") {
if (PlayerPrefs.GetInt("Smoke") == 0){
if (gameObject.name == "characters_0" || gameObject.name == "characters_2" || gameObject.name == "characters_5" || gameObject.name == "characters_6" || gameObject.name == "characters_7"){
Instantiate(Smoke, Vector3 (transform.position.x, transform.position.y, 0), Smoke.transform.rotation);
PlayerPrefs.SetInt("Smoke", 10);
PlayerPrefs.Save();
}
}
if (PlayerPrefs.GetInt("Smoke1") == 0){
if (gameObject.name == "characters_1" || gameObject.name == "characters_3" || gameObject.name == "characters_4" || gameObject.name == "characters_8" || gameObject.name == "characters_9"){
Instantiate(Smoke, Vector3 (transform.position.x, transform.position.y, 0), Smoke.transform.rotation);
PlayerPrefs.SetInt("Smoke1", 10);
PlayerPrefs.Save();
}
}
PlayerPrefs.SetInt("Grounded", 10);
PlayerPrefs.Save();
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