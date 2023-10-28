var timer : float = 0.0;
var timer2 : float = 0.0;
var spawning : boolean = false;
var prefab : Rigidbody2D;
var prefab4 : Rigidbody2D;
var prefab5 : Rigidbody2D;
var spawn1 : Transform;
var spawn2 : Transform;
var spawn3 : Transform;
var spawn4 : Transform;
var spawn5 : Transform;
 
function Update () {
 //check if spawning at the moment, if not add to timer
 if(!spawning){
  timer += Time.deltaTime;
 }
 //when timer reaches 0.5 seconds, call Spawn function
 if(timer >= 0.5){
  Spawn();
 }
}
 
function Spawn(){
 //set spawning to true, to stop timer counting in the Update function
 spawning = true;
 //reset the timer to 0 so process can start over
 timer = 0;
 
 //select a random number, inside a maths function absolute command to ensure it is a whole number
 var randomPick : int = Mathf.Abs(Random.Range(1,6));
 if (PlayerPrefs.GetInt ("GameScore") > 500) {
 var randomLive : int = Mathf.Abs(Random.Range(1,71));
 }
 else {
 var randomDirty : int = Mathf.Abs(Random.Range(7,71));
 }
 //create a location 'Transform' type variable to store one of 5 possible locations declared at top of script
 var location : Transform;
 var pickprefab : Rigidbody2D;
 //check what randomPick is, and select one of the 5 locations, based on that number
 if(randomPick == 1){
  location = spawn1;
 }
 else if(randomPick == 2){
  location = spawn2;
 }
 else if(randomPick == 3){
  location = spawn3;
 }
  else if(randomPick == 4){
  location = spawn4;
 }
  else if(randomPick == 5){
  location = spawn5;
 }
 
 if (PlayerPrefs.GetInt ("GameScore") > 500) {
 if(randomLive == 7){
  pickprefab = prefab4;
 }
 else if(randomLive >= 8){
  pickprefab = prefab;
 }
 else if(randomLive == 1){
  pickprefab = prefab5;
 }
 else if(randomLive == 2){
  pickprefab = prefab5;
 }
 else if(randomLive == 3){
  pickprefab = prefab5;
 }
 else if(randomLive == 4){
  pickprefab = prefab5;
 }
 else if(randomLive == 5){
  pickprefab = prefab5;
 }
 else if(randomLive == 6){
  pickprefab = prefab5;
 }
 }
 else {
 if(randomDirty == 7){
  pickprefab = prefab4;
 }
 else if(randomDirty >= 8){
  pickprefab = prefab;
 }
 }
 //create the object at point of the location variable
  var thingToMake : Rigidbody2D = Instantiate(pickprefab, location.position, location.rotation);

 
 //halt script for 0.2 second before returning to the start of the process
 yield WaitForSeconds(0.3);
 //set spawning back to false so timer may start again
 spawning = false;
 }