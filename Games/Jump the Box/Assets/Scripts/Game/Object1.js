#pragma strict
var Skid : AudioClip;

function OnTriggerEnter2D(other : Collider2D) {
if (other.gameObject.name == "Hit") {
audio.volume = 1;
audio.PlayOneShot(Skid);
if(PlayerPrefs.GetInt("Location") == 2){
transform.position = new Vector3 (-1.9, transform.position.y, -7);
}
if(PlayerPrefs.GetInt("Location") == 3){
transform.position = new Vector3 (-1.1, transform.position.y, -7);
}
if(PlayerPrefs.GetInt("Location") == 6){
if(PlayerPrefs.GetInt("LocationDouble") == 1){
transform.position = new Vector3 (-1.9, transform.position.y, -7);
}
if(PlayerPrefs.GetInt("LocationDouble") == 2){
transform.position = new Vector3 (-1.9, transform.position.y, -7);
}
if(PlayerPrefs.GetInt("LocationDouble") == 3){
transform.position = new Vector3 (-1.1, transform.position.y, -7);
}
if(PlayerPrefs.GetInt("LocationDouble") == 4){
transform.position = new Vector3 (-1.1, transform.position.y, -7);
}
}
}
}