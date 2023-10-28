#pragma strict

var LevelOn : int = 0;
public var l19_rock5 : GameObject;
public var l19_ice30 : GameObject;
public var l19_stoprock5 : GameObject;
public var l19_trick1 : GameObject;
public var l20_rock5 : GameObject;
public var l20_rock6 : GameObject;
public var l20_rock13 : GameObject;
public var l20_ice30 : GameObject;
public var l20_stoprock5 : GameObject;
public var l20_stoprock6 : GameObject;
public var l20_stoprock7 : GameObject;
public var l20_trick1 : GameObject;
public var l20_trick2 : GameObject;
public var l20_button2 : GameObject;
public var l20_ice29 : GameObject;
public var l20_ice22 : GameObject;
var Button : AudioClip;

function Start () {
LevelOn = PlayerPrefs.GetInt("Level");
}

function OnTriggerEnter2D(other : Collider2D) {
if (other.gameObject.tag == "Trick1") {
if (LevelOn == 19){
l19_ice30.active = true;
l19_rock5.active = false;
l19_stoprock5.active = false;
l19_trick1.active = false;
if(PlayerPrefs.GetInt("SoundChanged") == 10){
audio.volume = PlayerPrefs.GetFloat("Sound");
}
else {
audio.volume = 1;
}
audio.PlayOneShot(Button);
}
if (LevelOn == 20){
l20_ice30.active = true;
l20_ice22.active = true;
l20_rock5.active = false;
l20_rock6.active = false;
l20_stoprock5.active = false;
l20_stoprock6.active = false;
l20_trick1.active = false;
l20_button2.active = true;
if(PlayerPrefs.GetInt("SoundChanged") == 10){
audio.volume = PlayerPrefs.GetFloat("Sound");
}
else {
audio.volume = 1;
}
audio.PlayOneShot(Button);
}
}
if (other.gameObject.tag == "Trick2") {
if (LevelOn == 20){
l20_ice29.active = true;
l20_stoprock7.active = false;
l20_rock13.active = false;
l20_trick2.active = false;
if(PlayerPrefs.GetInt("SoundChanged") == 10){
audio.volume = PlayerPrefs.GetFloat("Sound");
}
else {
audio.volume = 1;
}
audio.PlayOneShot(Button);
}
}
}