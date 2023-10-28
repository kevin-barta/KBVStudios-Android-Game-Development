#pragma strict
private var ray : Ray;
private var hit : RaycastHit;
var Play : GameObject;
var Play1 : int = 0;
var Score : TextMesh;
var Highscore : TextMesh;
var score1 : int = 0;
var highscore1 : int = 0;

function Start () {
score1 = PlayerPrefs.GetInt("Highscore0");
highscore1 = PlayerPrefs.GetInt("Highscore");
Score.GetComponent(TextMesh).text = "Best " + score1;
Highscore.GetComponent(TextMesh).text = "Score " + highscore1;
}

function Update () {
if(Input.GetMouseButtonDown(0)){
	ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, hit)){
			if(hit.transform.name == "Play"){
			Play.transform.localScale += Vector3(0.2,0.2,0);
			Play1 = 10;
			}
		}
	}
if(Input.GetMouseButtonUp(0)){
if(Play1 == 10){
Play.transform.localScale -= Vector3(0.2,0.2,0);
Play1 = 0;
}
	ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, hit)){
			if(hit.transform.name == "Play"){
			Application.LoadLevel(1);
			}
		}
	}
}