#pragma strict
var timer : float = 0.0;
var spawning : boolean = false;
var Started : boolean = false;
var box : Rigidbody2D;
var box2 : Rigidbody2D;
var drop1 : Transform;
var drop2 : Transform;
var drop3 : Transform;
var drop4 : Transform;
var randomtime : int = 3;

function Start (){
PlayerPrefs.SetInt("Location", 0);
PlayerPrefs.Save();
yield WaitForSeconds(2);
Started = true;
}
function Update () {
if(Started == true){
 //check if spawning at the moment, if not add to timer
 if(!spawning){
  timer += Time.deltaTime;
 }
 //when timer reaches 0.5 seconds, call Spawn function
 if(timer >= randomtime){
  Spawn();
  }
 }
}
 
function Spawn(){
 //set spawning to true, to stop timer counting in the Update function
 spawning = true;
 //reset the timer to 0 so process can start over
 timer = 0;
 
 //select a random number, inside a maths function absolute command to ensure it is a whole number
 var randomdrop : int = Mathf.Abs(Random.Range(1,7));
 var randomdrop1 : int = Mathf.Abs(Random.Range(1,3));
 var randomdrop2 : int = Mathf.Abs(Random.Range(1,3));
 var randomitem : int = Mathf.Abs(Random.Range(1,2));
 var randomitem1 : int = 0;
 //create a location 'Transform' type variable to store one of 2 possible locations declared at top of script
 var location : Transform;
 var pickitem : Rigidbody2D;
 //check what randomdrop is, and select one of the 2 locations, based on that number
 if(randomdrop == 1){
  randomitem1 = 1;
  location = drop1;
  PlayerPrefs.SetInt("Location", 2);
  PlayerPrefs.Save();
 }
  else if(randomdrop == 2){
  randomitem1 = 1;
  location = drop2;
  PlayerPrefs.SetInt("Location", 3);
  PlayerPrefs.Save();
 }
 else if(randomdrop == 3){
  randomitem1 = 2;
  location = drop3;
  PlayerPrefs.SetInt("Location", 4);
  PlayerPrefs.Save();
 }
  else if(randomdrop == 4){
  randomitem1 = 2;
  location = drop4;
  PlayerPrefs.SetInt("Location", 5);
  PlayerPrefs.Save();
 }
  else if(randomdrop == 5){
  if(randomdrop1 == 1){
  randomitem1 = 1;
  location = drop1;
  PlayerPrefs.SetInt("Location", 6);
  PlayerPrefs.SetInt("LocationDouble", 1);
  PlayerPrefs.Save();
  	if(randomitem1 == 1){
  	pickitem = box;
  	}
  	if(randomitem1 == 2){
  	pickitem = box2;
  	}
  	var thingToMake1 : Rigidbody2D = Instantiate(pickitem, location.position, location.rotation);
  	location = drop3;
  	randomitem1 = 2;
 }
 else if(randomdrop1 == 2){
  location = drop1;
  randomitem1 = 1;
  PlayerPrefs.SetInt("Location", 6);
  PlayerPrefs.SetInt("LocationDouble", 2);
  PlayerPrefs.Save();
  	if(randomitem1 == 1){
  	pickitem = box;
  	}
  	if(randomitem1 == 2){
  	pickitem = box2;
  	}
  	var thingToMake2 : Rigidbody2D = Instantiate(pickitem, location.position, location.rotation);
  	location = drop4;
  	randomitem1 = 2;
 }
 }
 else if(randomdrop == 6){
  if(randomdrop2 == 1){
  randomitem1 = 1;
  location = drop2;
  PlayerPrefs.SetInt("Location", 6);
  PlayerPrefs.SetInt("LocationDouble", 3);
  PlayerPrefs.Save();
  	if(randomitem1 == 1){
  	pickitem = box;
  	}
  	if(randomitem1 == 2){
  	pickitem = box2;
  	}
  	var thingToMake3 : Rigidbody2D = Instantiate(pickitem, location.position, location.rotation);
  	location = drop3;
  	randomitem1 = 2;
 }
   else if(randomdrop2 == 2){
   randomitem1 = 1;
  location = drop2;
  PlayerPrefs.SetInt("Location", 6);
  PlayerPrefs.SetInt("LocationDouble", 4);
  PlayerPrefs.Save();
  	if(randomitem1 == 1){
  	pickitem = box;
  	}
  	if(randomitem1 == 2){
  	pickitem = box2;
  	}
  	var thingToMake4 : Rigidbody2D = Instantiate(pickitem, location.position, location.rotation);
  	location = drop4;
  	randomitem1 = 2;
 }
 }
  //check what randomitem is, and select one of the 1 items, based on that number
  if(randomitem1 == 1){
  pickitem = box;
  }
  if(randomitem1 == 2){
  pickitem = box2;
  }
 //create the object at point of the location variable
  var thingToMake : Rigidbody2D = Instantiate(pickitem, location.position, location.rotation);
 //halt script for 0.2 second before returning to the start of the process
 //set spawning back to false so timer may start again
 spawning = false;
 randomtime = Random.Range(2,5);
}