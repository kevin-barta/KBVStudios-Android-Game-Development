#pragma strict
private var ray : Ray;
private var hit : RaycastHit;
var Error1 : GameObject;
var Timer : TextMesh;
var time : int = 0;
var nothing : String = "";
var nothing1 : int = 0;

function Start () {
PlayerPrefs.SetInt("Error", 0);
PlayerPrefs.Save();
}

function Update () {
if(nothing1 == 0){
if(PlayerPrefs.GetInt("Error") == 5){
nothing1 = 5;
Error();
}
}
if(Input.GetMouseButtonDown(0)){
	ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, hit)){
			if(hit.transform.name == "Restart"){
			Time.timeScale = 1;
			Application.LoadLevel(1);
			}
			if(hit.transform.name == "Exit"){
			Time.timeScale = 1;
			Application.LoadLevel(0);
			}
		}
	}
}
function Error () {
Error1.active = true;
Time.timeScale = 0;
Timer.GetComponent(TextMesh).text = nothing;
	if(Input.touchCount == 2){
		if (Input.GetTouch(0).position.x > Screen.width/2 && Input.GetTouch(1).position.x < Screen.width/2) {
		Time.timeScale = 0.00001;
		time = 3;
		Timer.GetComponent(TextMesh).text = time.ToString();
		yield WaitForSeconds (0.00001);
		if(Input.touchCount == 2){
		time = 2;
		Timer.GetComponent(TextMesh).text = time.ToString();
		yield WaitForSeconds (0.00001);
		}
		if(Input.touchCount == 2){
		time = 1;
		Timer.GetComponent(TextMesh).text = time.ToString();
		yield WaitForSeconds (0.00001);
		}
		if(Input.touchCount == 2){
		time = 0;
		PlayerPrefs.SetInt("Error", 0);
		PlayerPrefs.Save();
		Error1.active = false;
		Time.timeScale = 1;
		}
		}
		else if (Input.GetTouch(0).position.x < Screen.width/2 && Input.GetTouch(1).position.x > Screen.width/2) {
		Time.timeScale = 0.00001;
		time = 3;
		Timer.GetComponent(TextMesh).text = time.ToString();
		yield WaitForSeconds (0.00001);
		if(Input.touchCount == 2){
		time = 2;
		Timer.GetComponent(TextMesh).text = time.ToString();
		yield WaitForSeconds (0.00001);
		}
		if(Input.touchCount == 2){
		time = 1;
		Timer.GetComponent(TextMesh).text = time.ToString();
		yield WaitForSeconds (0.00001);
		}
		if(Input.touchCount == 2){
		time = 0;
		PlayerPrefs.SetInt("Error", 0);
		PlayerPrefs.Save();
		Error1.active = false;
		Time.timeScale = 1;
		}
		}
	}
	nothing1 = 0;
}