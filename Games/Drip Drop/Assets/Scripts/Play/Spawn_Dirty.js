#pragma strict

var timer : float = 0.0;
var spawning : boolean = false;
var prefab2 : Rigidbody2D;
var spawn6 : Transform;
var spawn7 : Transform;
var spawn8 : Transform;
var spawn9 : Transform;
var score10 : int = 20;
 
function Start () {
  yield WaitForSeconds(20);
  Spawn();
}
function Update () {
 //check if spawning at the moment, if not add to timer
 if(!spawning){
  timer += Time.deltaTime;
 }
 //when timer reaches 0.5 seconds, call Spawn function
  if(timer >= 1.5){
  Spawn();
	}
  }
 
function Spawn(){
 //set spawning to true, to stop timer counting in the Update function
 spawning = true;
 //reset the timer to 0 so process can start over
 timer = 0;
 
 //select a random number, inside a maths function absolute command to ensure it is a whole number
 var randomChoice : int = Mathf.Abs(Random.Range(1,5));
 //create a location 'Transform' type variable to store one of 5 possible locations declared at top of script
 var location1 : Transform;
 
 //check what randomPick is, and select one of the 5 locations, based on that number
 if(randomChoice == 1){
  location1 = spawn6;
 }
 else if(randomChoice == 2){
  location1 = spawn7;
 }
 else if(randomChoice == 3){
  location1 = spawn8;
 }
  else if(randomChoice == 4){
  location1 = spawn9;
 }
 
 //create the object at point of the location variable
  var thingToMake : Rigidbody2D = Instantiate(prefab2, location1.position, location1.rotation);

 
 //halt script for 0.5 second before returning to the start of the process
 if (PlayerPrefs.GetInt ("GameScore") <= 150) {
 yield WaitForSeconds(1.5);
 }
  else if (PlayerPrefs.GetInt ("GameScore") > 150) {
 yield WaitForSeconds(0.5);
 }
 //set spawning back to false so timer may start again
 spawning = false;
 }