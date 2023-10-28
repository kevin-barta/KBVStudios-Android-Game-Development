#pragma strict

private var ray : Ray;
private var hit : RaycastHit;
var flagRed : GameObject;
var flagBlue : GameObject;
var flagYellow : GameObject;
var flagGreen : GameObject;
var flagCyan : GameObject;
var flagPurple : GameObject;
var PickedPlayer1 : int = 0;
function Start (){
	while(PickedPlayer1 == 0){
			PlayerPrefs.SetInt("Fun", 1);
			PlayerPrefs.Save();
			if(PlayerPrefs.GetInt("Fun") == 1 && PickedPlayer1 == 0){
			flagRed.active = true;
			flagBlue.active = false;
			flagYellow.active = false;
			flagGreen.active = false;
			flagCyan.active = false;
			flagPurple.active = false;
			PlayerPrefs.SetInt("Fun", 2);
			PlayerPrefs.Save();
			yield WaitForSeconds (0.5);
			}
			if(PlayerPrefs.GetInt("Fun") == 2 && PickedPlayer1 == 0){
			flagRed.active = false;
			flagBlue.active = true;
			flagYellow.active = false;
			flagGreen.active = false;
			flagCyan.active = false;
			flagPurple.active = false;
			PlayerPrefs.SetInt("Fun", 3);
			PlayerPrefs.Save();
			yield WaitForSeconds (0.5);
			}
			if(PlayerPrefs.GetInt("Fun") == 3 && PickedPlayer1 == 0){
			flagRed.active = false;
			flagBlue.active = false;
			flagYellow.active = true;
			flagGreen.active = false;
			flagCyan.active = false;
			flagPurple.active = false;
			PlayerPrefs.SetInt("Fun", 4);
			PlayerPrefs.Save();
			yield WaitForSeconds (0.5);
			}
			if(PlayerPrefs.GetInt("Fun") == 4 && PickedPlayer1 == 0){
			flagRed.active = false;
			flagBlue.active = false;
			flagYellow.active = false;
			flagGreen.active = true;
			flagCyan.active = false;
			flagPurple.active = false;
			PlayerPrefs.SetInt("Fun", 5);
			PlayerPrefs.Save();
			yield WaitForSeconds (0.5);
			}
			if(PlayerPrefs.GetInt("Fun") == 5 && PickedPlayer1 == 0){
			flagRed.active = false;
			flagBlue.active = false;
			flagYellow.active = false;
			flagGreen.active = false;
			flagCyan.active = true;
			flagPurple.active = false;
			PlayerPrefs.SetInt("Fun", 6);
			PlayerPrefs.Save();
			yield WaitForSeconds (0.5);
			}
			if(PlayerPrefs.GetInt("Fun") == 6 && PickedPlayer1 == 0){
			flagRed.active = false;
			flagBlue.active = false;
			flagYellow.active = false;
			flagGreen.active = false;
			flagCyan.active = false;
			flagPurple.active = true;
			PlayerPrefs.SetInt("Fun", 1);
			PlayerPrefs.Save();
			yield WaitForSeconds (0.5);
			}
		}
	}
function Update () {
if(Input.GetMouseButtonDown(0)){
	ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, hit)){
			if(hit.transform.name == "Play"){
			if(PickedPlayer1 == 10){
			Application.LoadLevel(2);
			}
			}
			if(hit.transform.name == "flagRed"){
			flagRed.active = true;
			flagBlue.active = false;
			flagYellow.active = false;
			flagGreen.active = false;
			flagCyan.active = false;
			flagPurple.active = false;
			PlayerPrefs.SetString("Player1", "Red");
			PickedPlayer1 = 10;
			PlayerPrefs.Save();
			}
			if(hit.transform.name == "flagBlue"){
			flagRed.active = false;
			flagBlue.active = true;
			flagYellow.active = false;
			flagGreen.active = false;
			flagCyan.active = false;
			flagPurple.active = false;
			PlayerPrefs.SetString("Player1", "Blue");
			PickedPlayer1 = 10;
			PlayerPrefs.Save();
			}
			if(hit.transform.name == "flagYellow"){
			flagRed.active = false;
			flagBlue.active = false;
			flagYellow.active = true;
			flagGreen.active = false;
			flagCyan.active = false;
			flagPurple.active = false;
			PlayerPrefs.SetString("Player1", "Yellow");
			PickedPlayer1 = 10;
			PlayerPrefs.Save();
			}
			if(hit.transform.name == "flagGreen"){
			flagRed.active = false;
			flagBlue.active = false;
			flagYellow.active = false;
			flagGreen.active = true;
			flagCyan.active = false;
			flagPurple.active = false;
			PlayerPrefs.SetString("Player1", "Green");
			PickedPlayer1 = 10;
			PlayerPrefs.Save();
			}
			if(hit.transform.name == "flagCyan"){
			flagRed.active = false;
			flagBlue.active = false;
			flagYellow.active = false;
			flagGreen.active = false;
			flagCyan.active = true;
			flagPurple.active = false;
			PlayerPrefs.SetString("Player1", "Cyan");
			PickedPlayer1 = 10;
			PlayerPrefs.Save();
			}
			if(hit.transform.name == "flagPurple"){
			flagRed.active = false;
			flagBlue.active = false;
			flagYellow.active = false;
			flagGreen.active = false;
			flagCyan.active = false;
			flagPurple.active = true;
			PlayerPrefs.SetString("Player1", "Purple");
			PickedPlayer1 = 10;
			PlayerPrefs.Save();
			}
		}
	}
}