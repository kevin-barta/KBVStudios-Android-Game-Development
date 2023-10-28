#pragma strict

function Start () {
Flash ();
}
function Flash () {
yield WaitForSeconds(7);
GetComponent.<TextMesh>().fontSize = 240;
yield WaitForSeconds(0.05);
GetComponent.<TextMesh>().fontSize = 200;
yield WaitForSeconds(0.05);
GetComponent.<TextMesh>().fontSize = 240;
yield WaitForSeconds(0.05);
GetComponent.<TextMesh>().fontSize = 200;
yield WaitForSeconds(0.05);
GetComponent.<TextMesh>().fontSize = 240;
yield WaitForSeconds(0.05);
GetComponent.<TextMesh>().fontSize = 200;
yield WaitForSeconds(0.05);
GetComponent.<TextMesh>().fontSize = 240;
yield WaitForSeconds(0.05);
GetComponent.<TextMesh>().fontSize = 200;

var randomColor : int = Mathf.Abs(Random.Range(1,11));
if(randomColor == 1){
GetComponent.<TextMesh>().color = Color(0,0,0,1);
 }
 else if(randomColor == 2){
 GetComponent.<TextMesh>().color = Color(0,0,1,1);
 }
 else if(randomColor == 3){
 GetComponent.<TextMesh>().color = Color(0,1,1,1);
 }
  else if(randomColor == 4){
  GetComponent.<TextMesh>().color = Color(1, 0.92, 0.016, 1);
 }
  else if(randomColor == 5){
  GetComponent.<TextMesh>().color = Color(0,1,0,1);
 }
   else if(randomColor == 6){
   GetComponent.<TextMesh>().color = Color(1,0.92,0.016,1);
 }
 else if(randomColor == 7){
   GetComponent.<TextMesh>().color = Color(0.46,0,0.87,1);
 }
 else if(randomColor == 8){
   GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
 }
 else if(randomColor == 9){
   GetComponent.<TextMesh>().color = Color(0.65,0.56,1,1);
 }
 else if(randomColor == 10){
   GetComponent.<TextMesh>().color = Color(0.5,0.5,0.5,1);
 }
Start ();
}