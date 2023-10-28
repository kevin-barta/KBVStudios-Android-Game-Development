#pragma strict
import UnityEngine.UI;

var PanelGame : GameObject;
var PanelPowerUps : GameObject;
var Bird8 : GameObject;
var Bird11 : GameObject;
var Bird12 : GameObject;
var Bird13 : GameObject;
var Bird14 : GameObject;
var Bird15 : GameObject;
var Bird16 : GameObject;
var Bird17 : GameObject;
var Bird18 : GameObject;
var Bird21 : Transform;
var Bird22 : Transform;
var Bird23 : Transform;
var Bird24 : Transform;
var Bird25 : Transform;
var Bird26 : Transform;
var Bird27 : Transform;
var Bird28 : Transform;
var MiniMapBird1 : Transform;
var MiniMapBird2 : Transform;
var MiniMapBird3 : Transform;
var MiniMapBird4 : Transform;
var MiniMapBird5 : Transform;
var MiniMapBird6 : Transform;
var MiniMapBird7 : Transform;
var Countdown : Text;
var Countdown1 : Text;
var PowerupText : Text;
var PowerupMainText : Text;
var Powerup : Image;
var Back1 : Image;
var Back2 : Button;
var CountdownSound : AudioClip;
var Music : AudioSource;
var MiniMapCamera : Transform;
var BirdCamera : Transform;
var CameraMaxView : Transform;
private var Bird1Dis : float = 0f;
private var Bird2Dis : float = 0f;
private var Bird3Dis : float = 0f;
private var Bird4Dis : float = 0f;
private var Bird5Dis : float = 0f;
private var Bird6Dis : float = 0f;
private var Bird7Dis : float = 0f;
private var Bird8Dis : float = 0f;
private var Bird1Distance : int = 0;
private var Bird2Distance : int = 0;
private var Bird3Distance : int = 0;
private var Bird4Distance : int = 0;
private var Bird5Distance : int = 0;
private var Bird6Distance : int = 0;
private var Bird7Distance : int = 0;
private var Bird8Distance : int = 0;
private var Bird1DistanceO : int = 0;
private var Bird2DistanceO : int = 0;
private var Bird3DistanceO : int = 0;
private var Bird4DistanceO : int = 0;
private var Bird5DistanceO : int = 0;
private var Bird6DistanceO : int = 0;
private var Bird7DistanceO : int = 0;
private var Bird8DistanceO : int = 0;
private var Tutorial : int = 0;

function Awake (){
	if(PlayerPref.GetString(39) == "1"){
		PlayerPref.SetString(39, "0");
		Time.timeScale = 0;
		PanelGame.transform.localScale = new Vector3(0, 0, 0);
		PanelPowerUps.transform.localScale = new Vector3(1, 1, 1);
		Tutorial = 1;
	}
	if(PlayerPref.GetString(38).Substring(1, 1) == "0"){
		Music.mute = true;
	}
}

function Start () {
	yield WaitForSeconds(4);
	if(PlayerPref.GetString(38).Substring(0, 1) == "1"){
		GetComponent.<AudioSource>().PlayOneShot(CountdownSound);
	}
	Countdown.text = "3";
	Countdown1.text = "3";
	yield WaitForSeconds(1);
	Countdown.text = "2";
	Countdown1.text = "2";
	yield WaitForSeconds(1);
	Countdown.text = "1";
	Countdown1.text = "1";
	yield WaitForSeconds(1);
	Countdown.text = "GO";
	Countdown1.text = "GO";
	Bird11.GetComponent(Rigidbody).constraints = RigidbodyConstraints.None;
	Bird12.GetComponent(Rigidbody).constraints = RigidbodyConstraints.None;
	Bird13.GetComponent(Rigidbody).constraints = RigidbodyConstraints.None;
	Bird14.GetComponent(Rigidbody).constraints = RigidbodyConstraints.None;
	Bird15.GetComponent(Rigidbody).constraints = RigidbodyConstraints.None;
	Bird16.GetComponent(Rigidbody).constraints = RigidbodyConstraints.None;
	Bird17.GetComponent(Rigidbody).constraints = RigidbodyConstraints.None;
	Bird18.GetComponent(Rigidbody).constraints = RigidbodyConstraints.None;
	(Bird8.GetComponent("AeroplaneController")as MonoBehaviour).enabled = true;
	yield WaitForSeconds(1);
	Countdown.text = "";
	Countdown1.text = "";
}

function Update (){
	if(Tutorial == 1){
		PowerupMainText.text = "TUTORIAL POWERUPS";
		PowerupMainText.enabled = true;
		PowerupText.enabled = false;
		Powerup.enabled = false;
	}
	if(Tutorial == 2){
		Powerup.sprite = Resources.Load("PUPS/PUP_BirdPoop", typeof Sprite);
		Powerup.color = new Color(0.4f, 0.26f, 0.13f);
		PowerupText.text = "Bird Poop: Birds get knocked out when it hits Bird Poop!";
		PowerupMainText.enabled = false;
		PowerupText.enabled = true;
		Powerup.enabled = true;
	}
	if(Tutorial == 3){
		Powerup.sprite = Resources.Load("PUPS/PUP_Worm", typeof Sprite);
		Powerup.color = new Color(0.54f, 0.43f, 0.375f);
		PowerupText.text = "Worms: Gives you a 1x speed boost!";
	}
	if(Tutorial == 4){
		Powerup.sprite = Resources.Load("PUPS/PUP_BirdEgg", typeof Sprite);
		Powerup.color = new Color(1, 0, 0);
		PowerupText.text = "Red Egg: This nasty egg will knockout the opponent in the place infront of you!";
	}
	if(Tutorial == 5){
		Powerup.sprite = Resources.Load("PUPS/PUP_BirdEgg", typeof Sprite);
		Powerup.color = new Color(0, 0.5f, 1);
		PowerupText.text = "Blue Egg: This awesome egg will knockout the opponent in first!";
	}
	if(Tutorial == 6){
		Powerup.sprite = Resources.Load("PUPS/PUP_BirdEgg", typeof Sprite);
		Powerup.color = new Color(0, 0.25f, 0);
		PowerupText.text = "Rotten Egg: This smelly egg will explode if it has been hit or after a few seconds. All birds in the blast get knocked out!";
	}
	if(Tutorial == 7){
		Powerup.sprite = Resources.Load("PUPS/PUP_Fish", typeof Sprite);
		Powerup.color = new Color(1, 1, 0);
		PowerupText.text = "Fish: Gives you a 3x speed boost!";
	}
	if(Tutorial == 8){
		Powerup.sprite = Resources.Load("PUPS/PUP_Oil", typeof Sprite);
		Powerup.color = new Color(0, 0, 0);
		PowerupText.text = "Oil: This will shoot thick black oil at all your opponents reducing visibility!";
	}
	if(Tutorial == 9){
		Powerup.sprite = Resources.Load("PUPS/PUP_Teleport", typeof Sprite);
		Powerup.color = new Color(1, 1, 1);
		PowerupText.text = "Teleport: This colorful beauty will teleport you part way through the track!";
		Powerup.enabled = true;
		PowerupText.enabled = true;
		PowerupMainText.enabled = false;
	}
	if(Tutorial == 10){
		PowerupMainText.text = "PowerUps can be used by touching the screen.";
		Powerup.enabled = false;
		PowerupText.enabled = false;
		PowerupMainText.enabled = true;
	}
	if(Tutorial == 11){
		PowerupMainText.text = "You control your bird by tilting the device left to go left and right to go right!";
	}
	if(Tutorial == 12){
		PowerupMainText.text = "Have fun Kbv Studios!!!";
	}
	if(Tutorial == 13){
		PanelGame.transform.localScale = new Vector3(1, 1, 1);
		PanelPowerUps.transform.localScale = new Vector3(0, 0, 0);
		Time.timeScale = 1;
		Tutorial = 14;
	}
	Bird11.transform.eulerAngles = new Vector3(0, Bird11.transform.eulerAngles.y, 0);
	Bird12.transform.eulerAngles = new Vector3(0, Bird12.transform.eulerAngles.y, 0);
	Bird13.transform.eulerAngles = new Vector3(0, Bird13.transform.eulerAngles.y, 0);
	Bird14.transform.eulerAngles = new Vector3(0, Bird14.transform.eulerAngles.y, 0);
	Bird15.transform.eulerAngles = new Vector3(0, Bird15.transform.eulerAngles.y, 0);
	Bird16.transform.eulerAngles = new Vector3(0, Bird16.transform.eulerAngles.y, 0);
	Bird17.transform.eulerAngles = new Vector3(0, Bird17.transform.eulerAngles.y, 0);
	Bird18.transform.eulerAngles = new Vector3(0, Bird18.transform.eulerAngles.y, 0);
	Bird21.transform.position = Bird11.transform.position;
	Bird22.transform.position = Bird12.transform.position;
	Bird23.transform.position = Bird13.transform.position;
	Bird24.transform.position = Bird14.transform.position;
	Bird25.transform.position = Bird15.transform.position;
	Bird26.transform.position = Bird16.transform.position;
	Bird27.transform.position = Bird17.transform.position;
	Bird28.transform.position = Bird18.transform.position;
	MiniMapBird1.transform.position = Vector3 (Bird11.transform.position.x, MiniMapBird1.transform.position.y, Bird11.transform.position.z);
	MiniMapBird2.transform.position = Vector3 (Bird12.transform.position.x, MiniMapBird2.transform.position.y, Bird12.transform.position.z);
	MiniMapBird3.transform.position = Vector3 (Bird13.transform.position.x, MiniMapBird3.transform.position.y, Bird13.transform.position.z);
	MiniMapBird4.transform.position = Vector3 (Bird14.transform.position.x, MiniMapBird4.transform.position.y, Bird14.transform.position.z);
	MiniMapBird5.transform.position = Vector3 (Bird15.transform.position.x, MiniMapBird5.transform.position.y, Bird15.transform.position.z);
	MiniMapBird6.transform.position = Vector3 (Bird16.transform.position.x, MiniMapBird6.transform.position.y, Bird16.transform.position.z);
	MiniMapBird7.transform.position = Vector3 (Bird17.transform.position.x, MiniMapBird7.transform.position.y, Bird17.transform.position.z);
	MiniMapCamera.position.x = BirdCamera.position.x;
	MiniMapCamera.position.z = BirdCamera.position.z;
	CameraMaxView.position = BirdCamera.position;
	Bird1Dis = ((BirdCamera.transform.position.x - Bird11.transform.position.x)*(BirdCamera.transform.position.x - Bird11.transform.position.x))+((BirdCamera.transform.position.z - Bird11.transform.position.z)*(BirdCamera.transform.position.z - Bird11.transform.position.z));
	Bird2Dis = ((BirdCamera.transform.position.x - Bird12.transform.position.x)*(BirdCamera.transform.position.x - Bird12.transform.position.x))+((BirdCamera.transform.position.z - Bird12.transform.position.z)*(BirdCamera.transform.position.z - Bird12.transform.position.z));
	Bird3Dis = ((BirdCamera.transform.position.x - Bird13.transform.position.x)*(BirdCamera.transform.position.x - Bird13.transform.position.x))+((BirdCamera.transform.position.z - Bird13.transform.position.z)*(BirdCamera.transform.position.z - Bird13.transform.position.z));
	Bird4Dis = ((BirdCamera.transform.position.x - Bird14.transform.position.x)*(BirdCamera.transform.position.x - Bird14.transform.position.x))+((BirdCamera.transform.position.z - Bird14.transform.position.z)*(BirdCamera.transform.position.z - Bird14.transform.position.z));
	Bird5Dis = ((BirdCamera.transform.position.x - Bird15.transform.position.x)*(BirdCamera.transform.position.x - Bird15.transform.position.x))+((BirdCamera.transform.position.z - Bird15.transform.position.z)*(BirdCamera.transform.position.z - Bird15.transform.position.z));
	Bird6Dis = ((BirdCamera.transform.position.x - Bird16.transform.position.x)*(BirdCamera.transform.position.x - Bird16.transform.position.x))+((BirdCamera.transform.position.z - Bird16.transform.position.z)*(BirdCamera.transform.position.z - Bird16.transform.position.z));
	Bird7Dis = ((BirdCamera.transform.position.x - Bird17.transform.position.x)*(BirdCamera.transform.position.x - Bird17.transform.position.x))+((BirdCamera.transform.position.z - Bird17.transform.position.z)*(BirdCamera.transform.position.z - Bird17.transform.position.z));
	Bird8Dis = ((BirdCamera.transform.position.x - Bird18.transform.position.x)*(BirdCamera.transform.position.x - Bird18.transform.position.x))+((BirdCamera.transform.position.z - Bird18.transform.position.z)*(BirdCamera.transform.position.z - Bird18.transform.position.z));
	Bird1DistanceO = Bird1Distance;
	Bird2DistanceO = Bird2Distance;
	Bird3DistanceO = Bird3Distance;
	Bird4DistanceO = Bird4Distance;
	Bird5DistanceO = Bird5Distance;
	Bird6DistanceO = Bird6Distance;
	Bird7DistanceO = Bird7Distance;
	Bird8DistanceO = Bird8Distance;
	Bird1Distance = 0;
	Bird2Distance = 0;
	Bird3Distance = 0;
	Bird4Distance = 0;
	Bird5Distance = 0;
	Bird6Distance = 0;
	Bird7Distance = 0;
	Bird8Distance = 0;
	if(Bird8Dis <= Bird1Dis){
		Bird8Distance = Bird8Distance + 10;
	}
	if(Bird8Dis <= Bird2Dis){
		Bird8Distance = Bird8Distance + 10;
	}
	if(Bird8Dis <= Bird3Dis){
		Bird8Distance = Bird8Distance + 10;
	}
	if(Bird8Dis <= Bird4Dis){
		Bird8Distance = Bird8Distance + 10;
	}
	if(Bird8Dis <= Bird5Dis){
		Bird8Distance = Bird8Distance + 10;
	}
	if(Bird8Dis <= Bird6Dis){
		Bird8Distance = Bird8Distance + 10;
	}
	if(Bird8Dis <= Bird7Dis){
		Bird8Distance = Bird8Distance + 10;
	}
	if(Bird7Dis <= Bird1Dis){
		Bird7Distance = Bird7Distance + 10;
	}
	if(Bird7Dis <= Bird2Dis){
		Bird7Distance = Bird7Distance + 10;
	}
	if(Bird7Dis <= Bird3Dis){
		Bird7Distance = Bird7Distance + 10;
	}
	if(Bird7Dis <= Bird4Dis){
		Bird7Distance = Bird7Distance + 10;
	}
	if(Bird7Dis <= Bird5Dis){
		Bird7Distance = Bird7Distance + 10;
	}
	if(Bird7Dis <= Bird6Dis){
		Bird7Distance = Bird7Distance + 10;
	}
	if(Bird6Dis <= Bird1Dis){
		Bird6Distance = Bird6Distance + 10;
	}
	if(Bird6Dis <= Bird2Dis){
		Bird6Distance = Bird6Distance + 10;
	}
	if(Bird6Dis <= Bird3Dis){
		Bird6Distance = Bird6Distance + 10;
	}
	if(Bird6Dis <= Bird4Dis){
		Bird6Distance = Bird6Distance + 10;
	}
	if(Bird6Dis <= Bird5Dis){
		Bird6Distance = Bird6Distance + 10;
	}
	if(Bird5Dis <= Bird1Dis){
		Bird5Distance = Bird5Distance + 10;
	}
	if(Bird5Dis <= Bird2Dis){
		Bird5Distance = Bird5Distance + 10;
	}
	if(Bird5Dis <= Bird3Dis){
		Bird5Distance = Bird5Distance + 10;
	}
	if(Bird5Dis <= Bird4Dis){
		Bird5Distance = Bird5Distance + 10;
	}
	if(Bird4Dis <= Bird1Dis){
		Bird4Distance = Bird4Distance + 10;
	}
	if(Bird4Dis <= Bird2Dis){
		Bird4Distance = Bird4Distance + 10;
	}
	if(Bird4Dis <= Bird3Dis){
		Bird4Distance = Bird4Distance + 10;
	}
	if(Bird3Dis <= Bird1Dis){
		Bird3Distance = Bird3Distance + 10;
	}
	if(Bird3Dis <= Bird2Dis){
		Bird3Distance = Bird3Distance + 10;
	}
	if(Bird2Dis <= Bird1Dis){
		Bird2Distance = Bird2Distance + 10;
	}
	if(Bird1DistanceO != Bird1Distance){
		Bird11.transform.Find("Materials/Mats/Body").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 2;
		Bird11.transform.Find("Materials/Mats/Wings1").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 1;
		Bird11.transform.Find("Materials/Mats/Wings2").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 1;
		Bird11.transform.Find("Materials/Mats/Claws1").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance;
		Bird11.transform.Find("Materials/Mats/Claws2").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance;
		Bird11.transform.Find("Materials/Mats/Front1/EyesBack1").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 4;
		Bird11.transform.Find("Materials/Mats/Front1/EyesBack2").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 4;
		Bird11.transform.Find("Materials/Mats/Front1/Eyes1").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 5;
		Bird11.transform.Find("Materials/Mats/Front1/Eyes2").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 5;
		Bird11.transform.Find("Materials/Mats/Front1/Beak").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 5;
		Bird11.transform.Find("Materials/Mats/Back1/Icon").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 3;
		Bird11.transform.Find("Materials/Mats/Back1/Icon1").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 3;
		Bird11.transform.Find("Materials/Mats/Wings1/Bird1PUP_1").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance;
		Bird11.transform.Find("Materials/Mats/Wings2/Bird1PUP_2").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance;
		Bird11.transform.Find("Materials/Mats/Oil1").GetComponent(SpriteRenderer).sortingOrder = Bird1Distance + 6;
	}
	if(Bird2DistanceO != Bird2Distance){
		Bird12.transform.Find("Materials/Mats/Body").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance + 2;
		Bird12.transform.Find("Materials/Mats/Wings1").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance + 1;
		Bird12.transform.Find("Materials/Mats/Wings2").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance + 1;
		Bird12.transform.Find("Materials/Mats/Claws1").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance;
		Bird12.transform.Find("Materials/Mats/Claws2").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance;
		Bird12.transform.Find("Materials/Mats/Front2/EyesBack1").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance + 4;
		Bird12.transform.Find("Materials/Mats/Front2/EyesBack2").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance + 4;
		Bird12.transform.Find("Materials/Mats/Front2/Eyes1").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance + 5;
		Bird12.transform.Find("Materials/Mats/Front2/Eyes2").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance + 5;
		Bird12.transform.Find("Materials/Mats/Front2/Beak").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance + 5;
		Bird12.transform.Find("Materials/Mats/Back2/Icon").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance + 3;
		Bird12.transform.Find("Materials/Mats/Wings1/Bird2PUP_1").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance;
		Bird12.transform.Find("Materials/Mats/Wings2/Bird2PUP_2").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance;
		Bird12.transform.Find("Materials/Mats/Oil2").GetComponent(SpriteRenderer).sortingOrder = Bird2Distance + 6;
	}
	if(Bird3DistanceO != Bird3Distance){
		Bird13.transform.Find("Materials/Mats/Body").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance + 2;
		Bird13.transform.Find("Materials/Mats/Wings1").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance + 1;
		Bird13.transform.Find("Materials/Mats/Wings2").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance + 1;
		Bird13.transform.Find("Materials/Mats/Claws1").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance;
		Bird13.transform.Find("Materials/Mats/Claws2").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance;
		Bird13.transform.Find("Materials/Mats/Front3/EyesBack1").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance + 4;
		Bird13.transform.Find("Materials/Mats/Front3/EyesBack2").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance + 4;
		Bird13.transform.Find("Materials/Mats/Front3/Eyes1").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance + 5;
		Bird13.transform.Find("Materials/Mats/Front3/Eyes2").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance + 5;
		Bird13.transform.Find("Materials/Mats/Front3/Beak").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance + 5;
		Bird13.transform.Find("Materials/Mats/Back3/Icon").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance + 3;
		Bird13.transform.Find("Materials/Mats/Wings1/Bird3PUP_1").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance;
		Bird13.transform.Find("Materials/Mats/Wings2/Bird3PUP_2").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance;
		Bird13.transform.Find("Materials/Mats/Oil3").GetComponent(SpriteRenderer).sortingOrder = Bird3Distance + 6;
	}
	if(Bird4DistanceO != Bird4Distance){
		Bird14.transform.Find("Materials/Mats/Body").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance + 2;
		Bird14.transform.Find("Materials/Mats/Wings1").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance + 1;
		Bird14.transform.Find("Materials/Mats/Wings2").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance + 1;
		Bird14.transform.Find("Materials/Mats/Claws1").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance;
		Bird14.transform.Find("Materials/Mats/Claws2").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance;
		Bird14.transform.Find("Materials/Mats/Front4/EyesBack1").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance + 4;
		Bird14.transform.Find("Materials/Mats/Front4/EyesBack2").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance + 4;
		Bird14.transform.Find("Materials/Mats/Front4/Eyes1").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance + 5;
		Bird14.transform.Find("Materials/Mats/Front4/Eyes2").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance + 5;
		Bird14.transform.Find("Materials/Mats/Front4/Beak").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance + 5;
		Bird14.transform.Find("Materials/Mats/Back4/Icon").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance + 3;
		Bird14.transform.Find("Materials/Mats/Wings1/Bird4PUP_1").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance;
		Bird14.transform.Find("Materials/Mats/Wings2/Bird4PUP_2").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance;
		Bird14.transform.Find("Materials/Mats/Oil4").GetComponent(SpriteRenderer).sortingOrder = Bird4Distance + 6;
	}
	if(Bird5DistanceO != Bird5Distance){
		Bird15.transform.Find("Materials/Mats/Body").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 2;
		Bird15.transform.Find("Materials/Mats/Wings1").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 1;
		Bird15.transform.Find("Materials/Mats/Wings2").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 1;
		Bird15.transform.Find("Materials/Mats/Claws1").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance;
		Bird15.transform.Find("Materials/Mats/Claws2").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance;
		Bird15.transform.Find("Materials/Mats/Front5/EyesBack1").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 4;
		Bird15.transform.Find("Materials/Mats/Front5/EyesBack2").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 4;
		Bird15.transform.Find("Materials/Mats/Front5/Eyes1").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 5;
		Bird15.transform.Find("Materials/Mats/Front5/Eyes2").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 5;
		Bird15.transform.Find("Materials/Mats/Front5/Beak").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 5;
		Bird15.transform.Find("Materials/Mats/Back5/Icon").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 3;
		Bird15.transform.Find("Materials/Mats/Back5/Icon1").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 3;
		Bird15.transform.Find("Materials/Mats/Wings1/Bird5PUP_1").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance;
		Bird15.transform.Find("Materials/Mats/Wings2/Bird5PUP_2").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance;
		Bird15.transform.Find("Materials/Mats/Oil5").GetComponent(SpriteRenderer).sortingOrder = Bird5Distance + 6;
	}
	if(Bird6DistanceO != Bird6Distance){
		Bird16.transform.Find("Materials/Mats/Body").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance + 2;
		Bird16.transform.Find("Materials/Mats/Wings1").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance + 1;
		Bird16.transform.Find("Materials/Mats/Wings2").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance + 1;
		Bird16.transform.Find("Materials/Mats/Claws1").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance;
		Bird16.transform.Find("Materials/Mats/Claws2").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance;
		Bird16.transform.Find("Materials/Mats/Front6/EyesBack1").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance + 4;
		Bird16.transform.Find("Materials/Mats/Front6/EyesBack2").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance + 4;
		Bird16.transform.Find("Materials/Mats/Front6/Eyes1").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance + 5;
		Bird16.transform.Find("Materials/Mats/Front6/Eyes2").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance + 5;
		Bird16.transform.Find("Materials/Mats/Front6/Beak").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance + 5;
		Bird16.transform.Find("Materials/Mats/Back6/Icon").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance + 3;
		Bird16.transform.Find("Materials/Mats/Wings1/Bird6PUP_1").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance;
		Bird16.transform.Find("Materials/Mats/Wings2/Bird6PUP_2").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance;
		Bird16.transform.Find("Materials/Mats/Oil6").GetComponent(SpriteRenderer).sortingOrder = Bird6Distance + 6;
	}
	if(Bird7DistanceO != Bird7Distance){
		Bird17.transform.Find("Materials/Mats/Body").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance + 2;
		Bird17.transform.Find("Materials/Mats/Wings1").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance + 1;
		Bird17.transform.Find("Materials/Mats/Wings2").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance + 1;
		Bird17.transform.Find("Materials/Mats/Claws1").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance;
		Bird17.transform.Find("Materials/Mats/Claws2").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance;
		Bird17.transform.Find("Materials/Mats/Front7/EyesBack1").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance + 4;
		Bird17.transform.Find("Materials/Mats/Front7/EyesBack2").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance + 4;
		Bird17.transform.Find("Materials/Mats/Front7/Eyes1").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance + 5;
		Bird17.transform.Find("Materials/Mats/Front7/Eyes2").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance + 5;
		Bird17.transform.Find("Materials/Mats/Front7/Beak").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance + 5;
		Bird17.transform.Find("Materials/Mats/Back7/Icon").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance + 3;
		Bird17.transform.Find("Materials/Mats/Wings1/Bird7PUP_1").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance;
		Bird17.transform.Find("Materials/Mats/Wings2/Bird7PUP_2").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance;
		Bird17.transform.Find("Materials/Mats/Oil7").GetComponent(SpriteRenderer).sortingOrder = Bird7Distance + 6;
	}
	if(Bird8DistanceO != Bird8Distance){
		Bird18.transform.Find("Materials/Mats/Body").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance + 2;
		Bird18.transform.Find("Materials/Mats/Wings1").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance + 1;
		Bird18.transform.Find("Materials/Mats/Wings2").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance + 1;
		Bird18.transform.Find("Materials/Mats/Claws1").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance;
		Bird18.transform.Find("Materials/Mats/Claws2").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance;
		Bird18.transform.Find("Materials/Mats/Front8/EyesBack1").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance + 4;
		Bird18.transform.Find("Materials/Mats/Front8/EyesBack2").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance + 4;
		Bird18.transform.Find("Materials/Mats/Front8/Eyes1").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance + 5;
		Bird18.transform.Find("Materials/Mats/Front8/Eyes2").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance + 5;
		Bird18.transform.Find("Materials/Mats/Front8/Beak").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance + 5;
		Bird18.transform.Find("Materials/Mats/Wings1/Bird8PUP_1").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance;
		Bird18.transform.Find("Materials/Mats/Wings2/Bird8PUP_2").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance;
		Bird18.transform.Find("Materials/Mats/Oil8").GetComponent(SpriteRenderer).sortingOrder = Bird8Distance + 6;
	}
}

public function Next(){
	Tutorial += 1;
	if(Tutorial == 2){
		Back1.color = new Color(1, 1, 1, 1);
		Back2.interactable = true;
	}
}

public function Back(){
	Tutorial -= 1;
	if(Tutorial == 1){
		Back1.color = new Color(1, 1, 1, 0.5f);
		Back2.interactable = false;
	}
}