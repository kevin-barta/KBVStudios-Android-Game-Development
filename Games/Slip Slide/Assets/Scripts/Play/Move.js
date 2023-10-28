#pragma strict
var player : Transform;  // Drag your player here
private var fp : Vector2;  // first finger position
private var lp : Vector2;  // last finger position
var speed : float = 0.1;
var Move : int = 5;
var Left1 : int = 1;
var Right1 : int = 1;
var Up1 : int = 1;
var Down1 : int = 1;
var Allow : int = 3;
private var NMoves : int =  0;
private var NTime1 : int =  0;
private var TM : int = 0;
private var TT : int = 0;
var LavaDie : AudioClip;

function Start (){
System.GC.Collect();
Resources.UnloadUnusedAssets();
yield WaitForSeconds(1);
TM = PlayerPrefs.GetInt("TotalM");
TT = PlayerPrefs.GetInt("TotalT");
NMoves = 0;
}
function Update()
{
    if(Input.GetKeyDown(KeyCode.LeftArrow)){
    if (Allow == 3){
          if (Left1 == 1){
          Move = 5;
          NMoves = NMoves + 1;
          Left();
          }
          }
    }
    if(Input.GetKeyDown(KeyCode.RightArrow)){
    if (Allow == 3){
          if (Right1 == 1){
          Move = 5;
          NMoves = NMoves + 1;
          Right();
          }
          }
    }
    if(Input.GetKeyDown(KeyCode.UpArrow)){
    if (Allow == 3){
          if (Up1 == 1){
          Move = 5;
          NMoves = NMoves + 1;
          Up();
          }
          }
    }
    if(Input.GetKeyDown(KeyCode.DownArrow)){
    if (Allow == 3){
          if (Down1 == 1){
          Move = 5;
          NMoves = NMoves + 1;
          Down();
          }
          }
    }
    for (var touch : Touch in Input.touches)
    {
          if (touch.phase == TouchPhase.Began)
          {
                fp = touch.position;
                lp = touch.position;
          }
          if (touch.phase == TouchPhase.Moved )
          {
                lp = touch.position;
          }
          if(touch.phase == TouchPhase.Ended)
          { 
      
          if((fp.x - lp.x) > 80){ // left swipe
          if (Allow == 3){
          if (Left1 == 1){
          Move = 5;
          NMoves = NMoves + 1;
          Left();
          }
          }
          }
          else if((fp.x - lp.x) < -80){ // right swipe
          if (Allow == 3){
          if (Right1 == 1){
          Move = 5;
          NMoves = NMoves + 1;
          Right();
          }
          }
          }
          else if((fp.y - lp.y) < -80 ){ // up swipe
          if (Allow == 3){
          if (Up1 == 1){
          Move = 5;
          NMoves = NMoves + 1;
          Up();
          }
          }
          }
          else if((fp.y - lp.y) > 80 ){ // down swipe
          if (Allow == 3){
          if (Down1 == 1){
          Move = 5;
          NMoves = NMoves + 1;
          Down();
          }
          }
          }
     }
 }
}
function OnTriggerEnter2D(other : Collider2D) {
if (other.gameObject.tag == "Carpet") {
Move = 0;
transform.position.x = other.transform.position.x;
yield WaitForSeconds(0.1);
Left1 = 1;
Right1 = 1;
Up1 = 1;
Down1 = 1;
}
if (other.gameObject.tag == "Lava") {
Move = 0;
transform.position.x = other.transform.position.x;
if(PlayerPrefs.GetInt("SoundChanged") == 10){
audio.volume = PlayerPrefs.GetFloat("Sound");
}
else {
audio.volume = 1;
}
audio.PlayOneShot(LavaDie);
yield WaitForSeconds(0.4);
Application.LoadLevel(6);
}
}
function OnCollisionEnter2D(collision : Collision2D) {
if (collision.gameObject.tag == "Stop") {
Move = 0;
Left1 = 0;
}
if (collision.gameObject.tag == "Stop1") {
Move = 0;
Right1 = 0;
}
if (collision.gameObject.tag == "Stop2") {
Move = 0;
Up1 = 0;
}
if (collision.gameObject.tag == "Stop3") {
Move = 0;
Down1 = 0;
}
if (collision.gameObject.tag == "Rock") {
Move = 0;
}
if (collision.gameObject.tag == "Box") {
Move = 0;
yield WaitForSeconds(0.1);
Left1 = 1;
Right1 = 1;
Up1 = 1;
Down1 = 1;
}
if (collision.gameObject.tag == "Done") {
NTime1 = Time.timeSinceLevelLoad;
yield WaitForSeconds(0.5);
PlayerPrefs.SetInt("TotalM", TM);
PlayerPrefs.SetInt("TotalT", TT);
PlayerPrefs.SetInt("NumM", NMoves);
PlayerPrefs.SetInt("NumT", NTime1);
PlayerPrefs.Save();
if (TM >= NMoves && TT >= NTime1){
PlayerPrefs.SetString("TF", "s under");
PlayerPrefs.SetString("MF", " under");
PlayerPrefs.SetInt("Try", 1);
PlayerPrefs.SetInt("Med", 4);
PlayerPrefs.Save();
Application.LoadLevel(5);
}
else if (TM >= NMoves && TT <= NTime1){
PlayerPrefs.SetString("TF", "s over");
PlayerPrefs.SetString("MF", " under");
PlayerPrefs.SetInt("Try", 2);
PlayerPrefs.SetInt("Med", 3);
PlayerPrefs.Save();
Application.LoadLevel(5);
}
else if (TM <= NMoves && TT >= NTime1){
PlayerPrefs.SetString("TF", "s under");
PlayerPrefs.SetString("MF", " over");
PlayerPrefs.SetInt("Try", 3);
PlayerPrefs.SetInt("Med", 3);
PlayerPrefs.Save();
Application.LoadLevel(5);
}
else if (TM <= NMoves && TT <= NTime1){
Application.LoadLevel(6);
}
}
}
function Left(){
Allow = 0;
PlayerPrefs.SetInt("T", NMoves);
PlayerPrefs.Save();
while (Move == 5)
{
transform.position.x -= speed;
transform.Rotate(0, 0, 50 * Time.deltaTime);
yield WaitForFixedUpdate();
}
Left1 = 0;
Right1 = 1;
Up1 = 1;
Down1 = 1;
Allow = 3;
}
function Right(){
Allow = 0;
PlayerPrefs.SetInt("T", NMoves);
PlayerPrefs.Save();
while (Move == 5)
{
transform.position.x += speed;
transform.Rotate(0, 0, -50 * Time.deltaTime);
yield WaitForFixedUpdate();
}
Left1 = 1;
Right1 = 0;
Up1 = 1;
Down1 = 1;
Allow = 3;
}
function Up(){
Allow = 0;
PlayerPrefs.SetInt("T", NMoves);
PlayerPrefs.Save();
while (Move == 5)
{
transform.position.y += speed;
transform.Rotate(0, 0, 50 * Time.deltaTime);
yield WaitForFixedUpdate();
}
Left1 = 1;
Right1 = 1;
Up1 = 0;
Down1 = 1;
Allow = 3;
}
function Down(){
Allow = 0;
PlayerPrefs.SetInt("T", NMoves);
PlayerPrefs.Save();
while (Move == 5)
{
transform.position.y -= speed;
transform.Rotate(0, 0, -50 * Time.deltaTime);
yield WaitForFixedUpdate();
}
Left1 = 1;
Right1 = 1;
Up1 = 1;
Down1 = 0;
Allow = 3;
}