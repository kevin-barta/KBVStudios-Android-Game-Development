#pragma strict
private var ray : Ray;
private var hit : RaycastHit;
var x : int = 0;
var y : int = 0;
var z : int = 0;
var land1;
var land2;
var land3;
var land4;
var land5;
var Level1 : GameObject;
var Level2 : GameObject;
var Level3 : GameObject;
var Level4 : GameObject;
var Level5 : GameObject;
var Level6 : GameObject;
var Level7 : GameObject;
var topright : GameObject;
var topleft : GameObject;
var centerright : GameObject;
var centerleft : GameObject;
var bottomright : GameObject;
var bottomleft : GameObject;
var P1 : GameObject;
var P2 : GameObject;
var fight : GameObject;
var ready : GameObject;
var smoke1 : GameObject;
var text1 : GameObject;
var text2 : GameObject;
var text3 : GameObject;
var text4 : GameObject;
var text5 : GameObject;
var text6 : GameObject;
var text7 : GameObject;
var text8 : GameObject;
var text11 : GameObject;
var text12 : GameObject;
var text13 : GameObject;
var text14 : GameObject;
var text15 : GameObject;
var text16 : GameObject;
var text17 : GameObject;
var text18 : GameObject;
var text19 : GameObject;
var Player0 : GameObject;
var Player1 : GameObject;
var Player2 : GameObject;
var Player3 : GameObject;
var Player4 : GameObject;
var Player5 : GameObject;
var Player6 : GameObject;
var Player7 : GameObject;
var Player8 : GameObject;
var Player9 : GameObject;
var Star1 : GameObject;
var Star2 : GameObject;
var Star3 : GameObject;
var Star4 : GameObject;
var Star5 : GameObject;
var Star6 : GameObject;
var Star7 : GameObject;
var Star8 : GameObject;
var Star9 : GameObject;
var Star10 : GameObject;
var start : AudioClip;
var P1Slider : RectTransform;
var P2Slider : RectTransform;
var P1Slider1 : GameObject;
var P2Slider1 : GameObject;

function Start() {
if(PlayerPrefs.GetInt("P2") == 10){
P2.SetActive(true);
}
else if(PlayerPrefs.GetInt("P1") == 10){
P1.SetActive(true);
}
P1Slider1.SetActive(true);
P2Slider1.SetActive(true);
var colour : int = Mathf.Abs(Random.Range(1,5));
var level : int = Mathf.Abs(Random.Range(1,8));
if(level == 1){
Level1.SetActive(true);
}
if(level == 2){
Level2.SetActive(true);
}
if(level == 3){
Level3.SetActive(true);
}
if(level == 4){
Level4.SetActive(true);
}
if(level == 5){
Level5.SetActive(true);
}
if(level == 6){
Level6.SetActive(true);
}
if(level == 7){
Level7.SetActive(true);
}
if(colour == 1){
for(land1 in GameObject.FindGameObjectsWithTag("land_1")) {
var textures1 = Resources.LoadAll("land"); 
land1.GetComponent(SpriteRenderer).sprite = textures1[7]; 
}
for(land2 in GameObject.FindGameObjectsWithTag("land_2")) {
var textures2 = Resources.LoadAll("land"); 
land2.GetComponent(SpriteRenderer).sprite = textures2[3]; 
}
for(land3 in GameObject.FindGameObjectsWithTag("land_3")) {
var textures3 = Resources.LoadAll("land"); 
land3.GetComponent(SpriteRenderer).sprite = textures3[8]; 
}
for(land4 in GameObject.FindGameObjectsWithTag("land_4")) {
var textures4 = Resources.LoadAll("land"); 
land4.GetComponent(SpriteRenderer).sprite = textures4[13]; 
}
for(land5 in GameObject.FindGameObjectsWithTag("land_5")) {
land5.GetComponent(SpriteRenderer).sprite = Resources.Load(("land4"), typeof(Sprite)) as Sprite; 
}
var smokes1 = Resources.LoadAll("smoke"); 
smoke1.GetComponent(SpriteRenderer).sprite = smokes1[2];
text1.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);
text2.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);
text3.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);
text4.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);
text5.GetComponent.<TextMesh>().color = Color(0,0.5,0,1); 
text6.GetComponent.<TextMesh>().color = Color(0,0.5,0,1); 
text7.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);
text8.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);
text11.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);
text12.GetComponent.<TextMesh>().color = Color(0,0.5,0,1); 
text13.GetComponent.<TextMesh>().color = Color(0,0.5,0,1); 
text14.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);
text15.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);
text16.GetComponent.<TextMesh>().color = Color(0,0.5,0,1); 
text17.GetComponent.<TextMesh>().color = Color(0,0.5,0,1); 
text18.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);  
text19.GetComponent.<TextMesh>().color = Color(0,0.5,0,1);    
}
if(colour == 2){
for(land1 in GameObject.FindGameObjectsWithTag("land_1")) {
var textures6 = Resources.LoadAll("land"); 
land1.GetComponent(SpriteRenderer).sprite = textures6[9]; 
}
for(land2 in GameObject.FindGameObjectsWithTag("land_2")) {
var textures7 = Resources.LoadAll("land"); 
land2.GetComponent(SpriteRenderer).sprite = textures7[4]; 
}
for(land3 in GameObject.FindGameObjectsWithTag("land_3")) {
var textures8 = Resources.LoadAll("land"); 
land3.GetComponent(SpriteRenderer).sprite = textures8[10]; 
}
for(land4 in GameObject.FindGameObjectsWithTag("land_4")) {
var textures9 = Resources.LoadAll("land"); 
land4.GetComponent(SpriteRenderer).sprite = textures9[14]; 
}
for(land5 in GameObject.FindGameObjectsWithTag("land_5")) {
land5.GetComponent(SpriteRenderer).sprite = Resources.Load(("land5"), typeof(Sprite)) as Sprite; 
}
var smokes2 = Resources.LoadAll("smoke"); 
smoke1.GetComponent(SpriteRenderer).sprite = smokes2[4];
text1.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text2.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text3.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text4.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text5.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text6.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text7.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text8.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text11.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text12.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text13.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text14.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text15.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text16.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text17.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text18.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
text19.GetComponent.<TextMesh>().color = Color(0.5,0,0,1);
}
if(colour == 3){
for(land1 in GameObject.FindGameObjectsWithTag("land_1")) {
var textures11 = Resources.LoadAll("land"); 
land1.GetComponent(SpriteRenderer).sprite = textures11[11]; 
}
for(land2 in GameObject.FindGameObjectsWithTag("land_2")) {
var textures12 = Resources.LoadAll("land"); 
land2.GetComponent(SpriteRenderer).sprite = textures12[5]; 
}
for(land3 in GameObject.FindGameObjectsWithTag("land_3")) {
var textures13 = Resources.LoadAll("land"); 
land3.GetComponent(SpriteRenderer).sprite = textures13[16]; 
}
for(land4 in GameObject.FindGameObjectsWithTag("land_4")) {
var textures14 = Resources.LoadAll("land"); 
land4.GetComponent(SpriteRenderer).sprite = textures14[15]; 
}
for(land5 in GameObject.FindGameObjectsWithTag("land_5")) {
land5.GetComponent(SpriteRenderer).sprite = Resources.Load(("land3"), typeof(Sprite)) as Sprite; 
}
var smokes3 = Resources.LoadAll("smoke"); 
smoke1.GetComponent(SpriteRenderer).sprite = smokes3[3];
text1.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text2.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text3.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text4.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text5.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text6.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text7.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text8.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text11.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text12.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text13.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text14.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text15.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text16.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text17.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text18.GetComponent.<TextMesh>().color = Color(0,0,1,1);
text19.GetComponent.<TextMesh>().color = Color(0,0,1,1);
}
if(colour == 4){
var smokes4 = Resources.LoadAll("smoke"); 
smoke1.GetComponent(SpriteRenderer).sprite = smokes4[1];
text1.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text2.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text3.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text4.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text5.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text6.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text7.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text8.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text11.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text12.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text13.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text14.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text15.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text16.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text17.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text18.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
text19.GetComponent.<TextMesh>().color = Color(1,0.5,0,1);
}
}

function Update () {
if(z == 0){
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(PlayerPrefs.GetInt("P2") == 10){
if(hit.transform.name == "centerp2"){
x = 6;
topright.GetComponent.<Renderer>().enabled = false;
centerright.GetComponent.<Renderer>().enabled = false;
bottomright.GetComponent.<Renderer>().enabled = false;
}
if(hit.transform.name == "centerp1"){
y = 5;
topleft.GetComponent.<Renderer>().enabled = false;
centerleft.GetComponent.<Renderer>().enabled = false;
bottomleft.GetComponent.<Renderer>().enabled = false;
}
if(x == 6 && y == 5){
text11.SetActive(false);
text13.SetActive(false);
text16.SetActive(false);
GetComponent(CustomName).enabled = false;
Fight();
}
}
else if(PlayerPrefs.GetInt("P1") == 10){
if(hit.transform.name == "centerp1" || hit.transform.name == "centerp2"){
x = 6;
y = 5;
topright.GetComponent.<Renderer>().enabled = false;
topleft.GetComponent.<Renderer>().enabled = false;
centerright.GetComponent.<Renderer>().enabled = false;
centerleft.GetComponent.<Renderer>().enabled = false;
bottomright.GetComponent.<Renderer>().enabled = false;
bottomleft.GetComponent.<Renderer>().enabled = false;
text1.SetActive(false);
text3.SetActive(false);
text6.SetActive(false);
GetComponent(CustomName).enabled = false;
Fight();
}
}
}
}
}
}

function Fight (){
if(z == 0){
z = 10;
P1Slider1.SetActive(false);
P2Slider1.SetActive(false);
ready.SetActive(true);
Star1.SetActive(true);
Star2.SetActive(true);
Star3.SetActive(true);
Star4.SetActive(true);
Star5.SetActive(true);
Star6.SetActive(true);
Star7.SetActive(true);
Star8.SetActive(true);
Star9.SetActive(true);
Star10.SetActive(true);
Star1.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star6.GetComponent(SpriteRenderer).color = Controller.P2Colour;
yield WaitForSeconds (0.2);
Star1.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star6.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star2.GetComponent(SpriteRenderer).color = Controller.Colour;
Star7.GetComponent(SpriteRenderer).color = Controller.Colour;
yield WaitForSeconds (0.2);
Star2.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star7.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star3.GetComponent(SpriteRenderer).color = Controller.Colour;
Star8.GetComponent(SpriteRenderer).color = Controller.Colour;
yield WaitForSeconds (0.2);
Star3.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star8.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star4.GetComponent(SpriteRenderer).color = Controller.Colour;
Star9.GetComponent(SpriteRenderer).color = Controller.Colour;
yield WaitForSeconds (0.2);
Star4.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star9.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star5.GetComponent(SpriteRenderer).color = Controller.Colour;
Star10.GetComponent(SpriteRenderer).color = Controller.Colour;
yield WaitForSeconds (0.2);
Star5.GetComponent(SpriteRenderer).color = Controller.Colour;
Star10.GetComponent(SpriteRenderer).color = Controller.Colour;
yield WaitForSeconds (0.3);
Star1.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star6.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star2.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star7.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star3.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star8.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star4.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star9.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star5.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star10.GetComponent(SpriteRenderer).color = Controller.P2Colour;
yield WaitForSeconds (0.3);
Star1.GetComponent(SpriteRenderer).color = Controller.Colour;
Star2.GetComponent(SpriteRenderer).color = Controller.Colour;
Star3.GetComponent(SpriteRenderer).color = Controller.Colour;
Star4.GetComponent(SpriteRenderer).color = Controller.Colour;
Star5.GetComponent(SpriteRenderer).color = Controller.Colour;
Star6.GetComponent(SpriteRenderer).color = Controller.Colour;
Star7.GetComponent(SpriteRenderer).color = Controller.Colour;
Star8.GetComponent(SpriteRenderer).color = Controller.Colour;
Star9.GetComponent(SpriteRenderer).color = Controller.Colour;
Star10.GetComponent(SpriteRenderer).color = Controller.Colour;
yield WaitForSeconds (0.3);
Star1.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star6.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star2.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star7.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star3.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star8.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star4.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star9.GetComponent(SpriteRenderer).color = Controller.P2Colour;
Star5.GetComponent(SpriteRenderer).color = Controller.P1Colour;
Star10.GetComponent(SpriteRenderer).color = Controller.P2Colour;
yield WaitForSeconds (0.3);
Star1.GetComponent(SpriteRenderer).color = Controller.Colour;
Star2.GetComponent(SpriteRenderer).color = Controller.Colour;
Star3.GetComponent(SpriteRenderer).color = Controller.Colour;
Star4.GetComponent(SpriteRenderer).color = Controller.Colour;
Star5.GetComponent(SpriteRenderer).color = Controller.Colour;
Star6.GetComponent(SpriteRenderer).color = Controller.Colour;
Star7.GetComponent(SpriteRenderer).color = Controller.Colour;
Star8.GetComponent(SpriteRenderer).color = Controller.Colour;
Star9.GetComponent(SpriteRenderer).color = Controller.Colour;
Star10.GetComponent(SpriteRenderer).color = Controller.Colour;
ready.SetActive(false);
fight.SetActive(true);
if(PlayerPrefs.GetInt("Sound") == 0){
GetComponent.<AudioSource>().clip = start;
GetComponent.<AudioSource>().Play();
}
GetComponent(Force1).enabled = true;
GetComponent(Force).enabled = true;
Player0.GetComponent.<Rigidbody2D>().gravityScale = 0.3;
Player1.GetComponent.<Rigidbody2D>().gravityScale = 0.3;
Player2.GetComponent.<Rigidbody2D>().gravityScale = 0.3;
Player3.GetComponent.<Rigidbody2D>().gravityScale = 0.3;
Player4.GetComponent.<Rigidbody2D>().gravityScale = 0.3;
Player5.GetComponent.<Rigidbody2D>().gravityScale = 0.3;
Player6.GetComponent.<Rigidbody2D>().gravityScale = 0.3;
Player7.GetComponent.<Rigidbody2D>().gravityScale = 0.3;
Player8.GetComponent.<Rigidbody2D>().gravityScale = 0.3;
Player9.GetComponent.<Rigidbody2D>().gravityScale = 0.3;
yield WaitForSeconds (0.5);
fight.SetActive(false);
}
}

function P1Hue (Hue : float){
PlayerPrefs.SetInt("P1Col", Hue);
PlayerPrefs.SetInt("P1C", 10);
PlayerPrefs.Save();
}

function P2Hue (Hue : float){
PlayerPrefs.SetInt("P2Col", Hue);
PlayerPrefs.SetInt("P2C", 10);
PlayerPrefs.Save();
}