#pragma strict
var Music : AudioSource;

function Awake (){
	if(PlayerPref.GetString(38).Substring(1, 1) == "0"){
		Music.mute = true;
	}
}

function Start () {
	yield WaitForSeconds (9);
	Application.LoadLevel(1);
}