#pragma strict
import UnityEngine.UI;

var color : Color;
var ColourRandom : int;
var Clicked1 : int = 10;

function Start (){
ColourRandom = Random.Range(1,13);
Clicked1 = 10;
}

function Update (){
if(Clicked1 == 10){
Clicked1 = 0;
for(var gameObj1 : GameObject in GameObject.FindObjectsOfType(GameObject)){
	if(gameObj1.name == "PreviewIcon"){
		if(ColourRandom == 1){
			color = Color(1, 0, 0, 1);
		}
		else if(ColourRandom == 2){
			color = Color(1, 0.5, 0, 1);
		}
		else if(ColourRandom == 3){
			color = Color(1, 1, 0, 1);
		}
		else if(ColourRandom == 4){
			color = Color(0.5, 1, 0, 1);
		}
		else if(ColourRandom == 5){
			color = Color(0, 1, 0, 1);
		}
		else if(ColourRandom == 6){
			color = Color(0, 1, 0.5, 1);
		}
		else if(ColourRandom == 7){
			color = Color(0, 1, 1, 1);
		}
		else if(ColourRandom == 8){
			color = Color(0, 0.5, 1, 1);
		}
		else if(ColourRandom == 9){
			color = Color(0, 0, 1, 1);
		}
		else if(ColourRandom == 10){
			color = Color(0.5, 0, 1, 1);
		}
		else if(ColourRandom == 11){
			color = Color(1, 0, 1, 1);
		}
		else if(ColourRandom == 12){
			color = Color(1, 0, 0.5, 1);
		}
		gameObj1.GetComponent(Image).color = color;
	}
}
ColourRandom = ColourRandom + 1;
if(ColourRandom == 13){
ColourRandom = 1;
}
UpdateRestart();
}
}

function UpdateRestart () {
yield WaitForSeconds (1);
Clicked1 = 10;
}