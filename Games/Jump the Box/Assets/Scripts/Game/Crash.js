#pragma strict
var Crash : AudioClip;

function OnTriggerEnter2D(other : Collider2D) {
if (other.gameObject.tag == "Object") {
if(PlayerPrefs.GetInt("Location") == 0){
}
else{
audio.volume = 1;
audio.PlayOneShot(Crash);
}
}
}