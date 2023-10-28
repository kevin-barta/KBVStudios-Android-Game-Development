/*#pragma strict
private var ray : Ray;
private var hit : RaycastHit;
var Paused : boolean = false;
var left : boolean = false;
var right : boolean = false;
var Started : boolean = false;
var doubledrop : int = 0;
var Player1 : GameObject;
var Player2 : GameObject;
var Score : GameObject;
private var PlayScore : int = 0;
var il : int = 0;
var ir : int = 0;

function Start () {
//yield WaitForSeconds(2);
//Started = true;
}
function Update () {
//if(Started == true){
if(PlayScore == 10){
Score.GetComponent(TextMesh).characterSize = 0.009f;
}
else if(PlayScore == 100){
Score.GetComponent(TextMesh).characterSize = 0.007f;
}
else if(PlayScore == 1000){
Score.GetComponent(TextMesh).characterSize = 0.005f;
}
if(Input.GetMouseButtonUp(0)){
	ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, hit)){
		//for (var i = 0; i < Input.touchCount; ++i) {
		/*if (Input.GetTouch(0).position.x > Screen.width/2) {
		il = 0;
		print (Input.GetTouch(0).position.x);
		print (Screen.width/2);
		}
		else if (Input.GetTouch(1).position.x > Screen.width/2) {
		il = 1;
		print (Input.GetTouch(1).position.x);
		print (Screen.width/2);
		}
		if (Input.GetTouch(0).position.x < Screen.width/2) {
		ir = 0;
		print (Input.GetTouch(0).position.x);
		print (Screen.width/2);
		}
		else if (Input.GetTouch(1).position.x < Screen.width/2) {
		print (Input.GetTouch(1).position.x);
		print (Screen.width/2);
		ir = 1;
		}
        if (Input.GetTouch(il).phase == TouchPhase.Ended) {
		if(hit.transform.name == "Left"){
				if(PlayerPrefs.GetInt("Location") == 2){
					PlayerPrefs.SetInt("Location", 0);
					PlayerPrefs.Save();
					Player1.GetComponent(BoxCollider2D).enabled = false;
					PlayScore = PlayScore + 1;
					Score.GetComponent(TextMesh).text = PlayScore.ToString();
					Player1.transform.position = new Vector3 (-1.1, -4, -7);
				}
				if(PlayerPrefs.GetInt("Location") == 3){
					PlayerPrefs.SetInt("Location", 0);
					PlayerPrefs.Save();
					Player1.GetComponent(BoxCollider2D).enabled = false;
					PlayScore = PlayScore + 1;
					Score.GetComponent(TextMesh).text = PlayScore.ToString();
					Player1.transform.position = new Vector3 (-1.9, -4, -7);
				}
				else if(PlayerPrefs.GetInt("Location") == 6){
					if(doubledrop == 0){
						doubledrop = 5;
						left = true;
						Player1.GetComponent(BoxCollider2D).enabled = false;
						if(PlayerPrefs.GetInt("LocationDouble") == 1){
						Player1.transform.position = new Vector3 (-1.1, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 2){
						Player1.transform.position = new Vector3 (-1.1, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 3){
						Player1.transform.position = new Vector3 (-1.9, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 4){
						Player1.transform.position = new Vector3 (-1.9, -4, -7);
						}
					}
					else if(doubledrop == 5 && left == false){
						PlayerPrefs.SetInt("Location", 0);
						PlayerPrefs.Save();
						doubledrop = 0;
						left = false;
						right = false;
						Player1.GetComponent(BoxCollider2D).enabled = false;
						PlayScore = PlayScore + 1;
						Score.GetComponent(TextMesh).text = PlayScore.ToString();
						if(PlayerPrefs.GetInt("LocationDouble") == 1){
						Player1.transform.position = new Vector3 (-1.1, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 2){
						Player1.transform.position = new Vector3 (-1.1, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 3){
						Player1.transform.position = new Vector3 (-1.9, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 4){
						Player1.transform.position = new Vector3 (-1.9, -4, -7);
						}
					}
				}
				else if(PlayerPrefs.GetInt("Location") == 0){
					Paused = true;
					//Time.timeScale = 0;
				}
			}
			//if (Input.GetTouch(ir).phase == TouchPhase.Ended) {
			if(hit.transform.name == "Right"){
				if(PlayerPrefs.GetInt("Location") == 4){
					PlayerPrefs.SetInt("Location", 0);
					PlayerPrefs.Save();
					Player2.GetComponent(BoxCollider2D).enabled = false;
					PlayScore = PlayScore + 1;
					Score.GetComponent(TextMesh).text = PlayScore.ToString();
					Player2.transform.position = new Vector3 (1.9, -4, -7);
				}
				if(PlayerPrefs.GetInt("Location") == 5){
					PlayerPrefs.SetInt("Location", 0);
					PlayerPrefs.Save();
					Player2.GetComponent(BoxCollider2D).enabled = false;
					PlayScore = PlayScore + 1;
					Score.GetComponent(TextMesh).text = PlayScore.ToString();
					Player2.transform.position = new Vector3 (1.1, -4, -7);
				}
				if(PlayerPrefs.GetInt("Location") == 6){
					if(doubledrop == 0){
						right = true;
						doubledrop = 5;
						Player2.GetComponent(BoxCollider2D).enabled = false;
						if(PlayerPrefs.GetInt("LocationDouble") == 1){
						Player2.transform.position = new Vector3 (1.9, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 2){
						Player2.transform.position = new Vector3 (1.1, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 3){
						Player2.transform.position = new Vector3 (1.9, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 4){
						Player2.transform.position = new Vector3 (1.1, -4, -7);
						}
					}
					if(doubledrop == 5 && right == false){
						PlayerPrefs.SetInt("Location", 0);
						PlayerPrefs.Save();
						doubledrop = 0;
						left = false;
						right = false;
						Player2.GetComponent(BoxCollider2D).enabled = false;
						PlayScore = PlayScore + 1;
						Score.GetComponent(TextMesh).text = PlayScore.ToString();
						if(PlayerPrefs.GetInt("LocationDouble") == 1){
						Player2.transform.position = new Vector3 (1.9, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 2){
						Player2.transform.position = new Vector3 (1.1, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 3){
						Player2.transform.position = new Vector3 (1.9, -4, -7);
						}
						else if(PlayerPrefs.GetInt("LocationDouble") == 4){
						Player2.transform.position = new Vector3 (1.1, -4, -7);
						}
					}
				}
			else if(PlayerPrefs.GetInt("Location") == 0){
				Paused = true;
				//Time.timeScale = 0;
		}
	}
}
}
}*/
//}
#pragma strict
private var ray : Ray;
private var hit : RaycastHit;
var Error : boolean = false;
var left : boolean = false;
var right : boolean = false;
var Started : boolean = false;
var Player1 : GameObject;
var Player2 : GameObject;
var Score : GameObject;
private var PlayScore : int = 0;
var il : int = 5;
var ir : int = 5;
var location1 : int = 10;

function Start () {
yield WaitForSeconds(2);
Started = true;
}
function Update () {
if(Started == true){
if(PlayScore == 10){
Score.GetComponent(TextMesh).characterSize = 0.009f;
}
else if(PlayScore == 100){
Score.GetComponent(TextMesh).characterSize = 0.007f;
}
else if(PlayScore == 1000){
Score.GetComponent(TextMesh).characterSize = 0.005f;
}
		if (Input.touchCount == 1) {
		il = 5;
		ir = 5;
		if (Input.GetTouch(0).position.x > Screen.width/2) {
		il = 0;
		}
		else if (Input.GetTouch(0).position.x < Screen.width/2) {
		ir = 0;
		}
        if (il == 0) {
				if(PlayerPrefs.GetInt("Location") == 2){
				if(location1 == 10){
					location1 = 2;
					Location ();
					}
				}
				if(PlayerPrefs.GetInt("Location") == 3){
				if(location1 == 10){
					location1 = 3;
					Location ();
					}
				}
				else if(PlayerPrefs.GetInt("Location") == 0){
				if(location1 == 10){
					location1 = 0;
					Location ();
					}
				}
			}
			if (ir == 0) {
				if(PlayerPrefs.GetInt("Location") == 4){
				if(location1 == 10){
					location1 = 4;
					Location ();
					}
				}
				if(PlayerPrefs.GetInt("Location") == 5){
				if(location1 == 10){
					location1 = 5;
					Location ();
					}
				}
			else if(PlayerPrefs.GetInt("Location") == 0){
			if(location1 == 10){
				location1 = 0;
				Location ();
			}
		}
	}
}
		else if (Input.touchCount == 0) {
				if(PlayerPrefs.GetInt("Location") == 6){
				if(location1 == 10){
						location1 = 6;
						Location ();
						}
					}
					else if(PlayerPrefs.GetInt("Location") == 0){
					if(location1 == 10){
					location1 = 0;
					Location ();
					}
				}
				else{
				if(location1 == 10){
				location1 = 0;
				Location ();
				}
				//Time.timeScale = 1;
				//Application.LoadLevel(0);
				}
			}
		else if (Input.touchCount > 2) {
		if(location1 == 10){
		location1 = 0;
		Location ();
		}
		}
	}
}

function Location (){
if(location1 == 0){
	Error = true;
	PlayerPrefs.SetInt("Error", 5);
	PlayerPrefs.Save();
}
else if(location1 == 2){
	Player1.GetComponent(BoxCollider2D).enabled = false;
	PlayScore = PlayScore + 1;
	Score.GetComponent(TextMesh).text = PlayScore.ToString();
	Player1.transform.position = new Vector3 (-1.1, -4, -7);
	yield WaitForSeconds(2);
	PlayerPrefs.SetInt("Location", 0);
	PlayerPrefs.SetInt("", PlayScore);
	PlayerPrefs.Save();
}
else if(location1 == 3){
	Player1.GetComponent(BoxCollider2D).enabled = false;
	PlayScore = PlayScore + 1;
	Score.GetComponent(TextMesh).text = PlayScore.ToString();
	Player1.transform.position = new Vector3 (-1.9, -4, -7);
	yield WaitForSeconds(2);
	PlayerPrefs.SetInt("Location", 0);
	PlayerPrefs.SetInt("Highscore0", PlayScore);
	PlayerPrefs.Save();
}
else if(location1 == 4){
	Player2.GetComponent(BoxCollider2D).enabled = false;
	PlayScore = PlayScore + 1;
	Score.GetComponent(TextMesh).text = PlayScore.ToString();
	Player2.transform.position = new Vector3 (1.9, -4, -7);
	yield WaitForSeconds(2);
	PlayerPrefs.SetInt("Location", 0);
	PlayerPrefs.SetInt("Highscore0", PlayScore);
	PlayerPrefs.Save();
}
else if(location1 == 5){
	Player2.GetComponent(BoxCollider2D).enabled = false;
	PlayScore = PlayScore + 1;
	Score.GetComponent(TextMesh).text = PlayScore.ToString();
	Player2.transform.position = new Vector3 (1.1, -4, -7);
	yield WaitForSeconds(2);
	PlayerPrefs.SetInt("Location", 0);
	PlayerPrefs.SetInt("Highscore0", PlayScore);
	PlayerPrefs.Save();
}
else if(location1 == 6){
	left = false;
	right = false;
	Player1.GetComponent(BoxCollider2D).enabled = false;
	Player2.GetComponent(BoxCollider2D).enabled = false;
	PlayScore = PlayScore + 1;
	Score.GetComponent(TextMesh).text = PlayScore.ToString();
	if(PlayerPrefs.GetInt("LocationDouble") == 1){
	Player1.transform.position = new Vector3 (-1.1, -4, -7);
	Player2.transform.position = new Vector3 (1.9, -4, -7);
	}
	else if(PlayerPrefs.GetInt("LocationDouble") == 2){
	Player1.transform.position = new Vector3 (-1.1, -4, -7);
	Player2.transform.position = new Vector3 (1.1, -4, -7);
	}
	else if(PlayerPrefs.GetInt("LocationDouble") == 3){
	Player1.transform.position = new Vector3 (-1.9, -4, -7);
	Player2.transform.position = new Vector3 (1.9, -4, -7);
	}
	else if(PlayerPrefs.GetInt("LocationDouble") == 4){
	Player1.transform.position = new Vector3 (-1.9, -4, -7);
	Player2.transform.position = new Vector3 (1.1, -4, -7);
	}
	yield WaitForSeconds(2);
	PlayerPrefs.SetInt("Location", 0);
	PlayerPrefs.SetInt("Highscore0", PlayScore);
	PlayerPrefs.Save();
}
location1 = 10;
}