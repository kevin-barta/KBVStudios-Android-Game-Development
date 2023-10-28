#pragma strict
import UnityEngine.UI;

var Place : Text;
var Car1 : float = 0; 
var Car2 : float = 0; 
var Car3 : float = 0; 
var Car4 : float = 0; 
var Car5 : float = 0; 
var Car6 : float = 0; 
var Car7 : float = 0; 
var Car8 : float = 0; 
var Car9 : float = 0; 
var Car10 : float = 0; 
var Car11 : float = 0; 
var Car12 : float = 0; 
var RankCar1 : int = 1;
var RankCar2 : int = 1;
var RankCar3 : int = 1;
var RankCar4 : int = 1;
var RankCar5 : int = 1;
var RankCar6 : int = 1;
var RankCar7 : int = 1;
var RankCar8 : int = 1;
var RankCar9 : int = 1;
var RankCar10 : int = 1;
var RankCar11 : int = 1;
var RankCar12 : int = 1;
var NCar1Display : GameObject;
var NCar2Display : GameObject;
var NCar3Display : GameObject;
var NCar4Display : GameObject;
var NCar5Display : GameObject;
var NCar6Display : GameObject;
var NCar7Display : GameObject;
var NCar8Display : GameObject;
var NCar9Display : GameObject;
var NCar10Display : GameObject;
var NCar11Display : GameObject;
var NCar12Display : GameObject;

function Start () {
}

function Update () {
Car1 = PlayerPrefs.GetFloat("Car1");
Car2 = PlayerPrefs.GetFloat("Car2");
Car3 = PlayerPrefs.GetFloat("Car3");
Car4 = PlayerPrefs.GetFloat("Car4");
Car5 = PlayerPrefs.GetFloat("Car5");
Car6 = PlayerPrefs.GetFloat("Car6");
Car7 = PlayerPrefs.GetFloat("Car7");
Car8 = PlayerPrefs.GetFloat("Car8");
Car9 = PlayerPrefs.GetFloat("Car9");
Car10 = PlayerPrefs.GetFloat("Car10");
Car11 = PlayerPrefs.GetFloat("Car11");
Car12 = PlayerPrefs.GetFloat("Car12");
RankCar1 = 1;
RankCar2 = 1;
RankCar3 = 1;
RankCar4 = 1;
RankCar5 = 1;
RankCar6 = 1;
RankCar7 = 1;
RankCar8 = 1;
RankCar9 = 1;
RankCar10 = 1;
RankCar11 = 1;
RankCar12 = 1;
if(Car1 < Car2){
RankCar1 = RankCar1 + 1;
}
if(Car1 < Car3){
RankCar1 = RankCar1 + 1;
}
if(Car1 < Car4){
RankCar1 = RankCar1 + 1;
}
if(Car1 < Car5){
RankCar1 = RankCar1 + 1;
}
if(Car1 < Car6){
RankCar1 = RankCar1 + 1;
}
if(Car1 < Car7){
RankCar1 = RankCar1 + 1;
}
if(Car1 < Car8){
RankCar1 = RankCar1 + 1;
}
if(Car1 < Car9){
RankCar1 = RankCar1 + 1;
}
if(Car1 < Car10){
RankCar1 = RankCar1 + 1;
}
if(Car1 < Car11){
RankCar1 = RankCar1 + 1;
}
if(Car1 < Car12){
RankCar1 = RankCar1 + 1;
}
if(Car2 < Car1){
RankCar2 = RankCar2 + 1;
}
if(Car2 < Car3){
RankCar2 = RankCar2 + 1;
}
if(Car2 < Car4){
RankCar2 = RankCar2 + 1;
}
if(Car2 < Car5){
RankCar2 = RankCar2 + 1;
}
if(Car2 < Car6){
RankCar2 = RankCar2 + 1;
}
if(Car2 < Car7){
RankCar2 = RankCar2 + 1;
}
if(Car2 < Car8){
RankCar2 = RankCar2 + 1;
}
if(Car2 < Car9){
RankCar2 = RankCar2 + 1;
}
if(Car2 < Car10){
RankCar2 = RankCar2 + 1;
}
if(Car2 < Car11){
RankCar2 = RankCar2 + 1;
}
if(Car2 < Car12){
RankCar2 = RankCar2 + 1;
}
if(Car3 < Car1){
RankCar3 = RankCar3 + 1;
}
if(Car3 < Car2){
RankCar3 = RankCar3 + 1;
}
if(Car3 < Car4){
RankCar3 = RankCar3 + 1;
}
if(Car3 < Car5){
RankCar3 = RankCar3 + 1;
}
if(Car3 < Car6){
RankCar3 = RankCar3 + 1;
}
if(Car3 < Car7){
RankCar3 = RankCar3 + 1;
}
if(Car3 < Car8){
RankCar3 = RankCar3 + 1;
}
if(Car3 < Car9){
RankCar3 = RankCar3 + 1;
}
if(Car3 < Car10){
RankCar3 = RankCar3 + 1;
}
if(Car3 < Car11){
RankCar3 = RankCar3 + 1;
}
if(Car3 < Car12){
RankCar3 = RankCar3 + 1;
}
if(Car4 < Car1){
RankCar4 = RankCar4 + 1;
}
if(Car4 < Car2){
RankCar4 = RankCar4 + 1;
}
if(Car4 < Car3){
RankCar4 = RankCar4 + 1;
}
if(Car4 < Car5){
RankCar4 = RankCar4 + 1;
}
if(Car4 < Car6){
RankCar4 = RankCar4 + 1;
}
if(Car4 < Car7){
RankCar4 = RankCar4 + 1;
}
if(Car4 < Car8){
RankCar4 = RankCar4 + 1;
}
if(Car4 < Car9){
RankCar4 = RankCar4 + 1;
}
if(Car4 < Car10){
RankCar4 = RankCar4 + 1;
}
if(Car4 < Car11){
RankCar4 = RankCar4 + 1;
}
if(Car4 < Car12){
RankCar4 = RankCar4 + 1;
}
if(Car5 < Car1){
RankCar5 = RankCar5 + 1;
}
if(Car5 < Car2){
RankCar5 = RankCar5 + 1;
}
if(Car5 < Car3){
RankCar5 = RankCar5 + 1;
}
if(Car5 < Car4){
RankCar5 = RankCar5 + 1;
}
if(Car5 < Car6){
RankCar5 = RankCar5 + 1;
}
if(Car5 < Car7){
RankCar5 = RankCar5 + 1;
}
if(Car5 < Car8){
RankCar5 = RankCar5 + 1;
}
if(Car5 < Car9){
RankCar5 = RankCar5 + 1;
}
if(Car5 < Car10){
RankCar5 = RankCar5 + 1;
}
if(Car5 < Car11){
RankCar5 = RankCar5 + 1;
}
if(Car5 < Car12){
RankCar5 = RankCar5 + 1;
}
if(Car6 < Car1){
RankCar6 = RankCar6 + 1;
}
if(Car6 < Car2){
RankCar6 = RankCar6 + 1;
}
if(Car6 < Car3){
RankCar6 = RankCar6 + 1;
}
if(Car6 < Car4){
RankCar6 = RankCar6 + 1;
}
if(Car6 < Car5){
RankCar6 = RankCar6 + 1;
}
if(Car6 < Car7){
RankCar6 = RankCar6 + 1;
}
if(Car6 < Car8){
RankCar6 = RankCar6 + 1;
}
if(Car6 < Car9){
RankCar6 = RankCar6 + 1;
}
if(Car6 < Car10){
RankCar6 = RankCar6 + 1;
}
if(Car6 < Car11){
RankCar6 = RankCar6 + 1;
}
if(Car6 < Car12){
RankCar6 = RankCar6 + 1;
}
if(Car7 < Car1){
RankCar7 = RankCar7 + 1;
}
if(Car7 < Car2){
RankCar7 = RankCar7 + 1;
}
if(Car7 < Car3){
RankCar7 = RankCar7 + 1;
}
if(Car7 < Car4){
RankCar7 = RankCar7 + 1;
}
if(Car7 < Car5){
RankCar7 = RankCar7 + 1;
}
if(Car7 < Car6){
RankCar7 = RankCar7 + 1;
}
if(Car7 < Car8){
RankCar7 = RankCar7 + 1;
}
if(Car7 < Car9){
RankCar7 = RankCar7 + 1;
}
if(Car7 < Car10){
RankCar7 = RankCar7 + 1;
}
if(Car7 < Car11){
RankCar7 = RankCar7 + 1;
}
if(Car7 < Car12){
RankCar7 = RankCar7 + 1;
}
if(Car8 < Car1){
RankCar8 = RankCar8 + 1;
}
if(Car8 < Car2){
RankCar8 = RankCar8 + 1;
}
if(Car8 < Car3){
RankCar8 = RankCar8 + 1;
}
if(Car8 < Car4){
RankCar8 = RankCar8 + 1;
}
if(Car8 < Car5){
RankCar8 = RankCar8 + 1;
}
if(Car8 < Car6){
RankCar8 = RankCar8 + 1;
}
if(Car8 < Car7){
RankCar8 = RankCar8 + 1;
}
if(Car8 < Car9){
RankCar8 = RankCar8 + 1;
}
if(Car8 < Car10){
RankCar8 = RankCar8 + 1;
}
if(Car8 < Car11){
RankCar8 = RankCar8 + 1;
}
if(Car8 < Car12){
RankCar8 = RankCar8 + 1;
}
if(Car9 < Car1){
RankCar9 = RankCar9 + 1;
}
if(Car9 < Car2){
RankCar9 = RankCar9 + 1;
}
if(Car9 < Car3){
RankCar9 = RankCar9 + 1;
}
if(Car9 < Car4){
RankCar9 = RankCar9 + 1;
}
if(Car9 < Car5){
RankCar9 = RankCar9 + 1;
}
if(Car9 < Car6){
RankCar9 = RankCar9 + 1;
}
if(Car9 < Car7){
RankCar9 = RankCar9 + 1;
}
if(Car9 < Car8){
RankCar9 = RankCar9 + 1;
}
if(Car9 < Car10){
RankCar9 = RankCar9 + 1;
}
if(Car9 < Car11){
RankCar9 = RankCar9 + 1;
}
if(Car9 < Car12){
RankCar9 = RankCar9 + 1;
}
if(Car10 < Car1){
RankCar10 = RankCar10 + 1;
}
if(Car10 < Car2){
RankCar10 = RankCar10 + 1;
}
if(Car10 < Car3){
RankCar10 = RankCar10 + 1;
}
if(Car10 < Car4){
RankCar10 = RankCar10 + 1;
}
if(Car10 < Car5){
RankCar10 = RankCar10 + 1;
}
if(Car10 < Car6){
RankCar10 = RankCar10 + 1;
}
if(Car10 < Car7){
RankCar10 = RankCar10 + 1;
}
if(Car10 < Car8){
RankCar10 = RankCar10 + 1;
}
if(Car10 < Car9){
RankCar10 = RankCar10 + 1;
}
if(Car10 < Car11){
RankCar10 = RankCar10 + 1;
}
if(Car10 < Car12){
RankCar10 = RankCar10 + 1;
}
if(Car11 < Car1){
RankCar11 = RankCar11 + 1;
}
if(Car11 < Car2){
RankCar11 = RankCar11 + 1;
}
if(Car11 < Car3){
RankCar11 = RankCar11 + 1;
}
if(Car11 < Car4){
RankCar11 = RankCar11 + 1;
}
if(Car11 < Car5){
RankCar11 = RankCar11 + 1;
}
if(Car11 < Car6){
RankCar11 = RankCar11 + 1;
}
if(Car11 < Car7){
RankCar11 = RankCar11 + 1;
}
if(Car11 < Car8){
RankCar11 = RankCar11 + 1;
}
if(Car11 < Car9){
RankCar11 = RankCar11 + 1;
}
if(Car11 < Car10){
RankCar11 = RankCar11 + 1;
}
if(Car11 < Car12){
RankCar11 = RankCar11 + 1;
}
if(Car12 < Car1){
RankCar12 = RankCar12 + 1;
}
if(Car12 < Car2){
RankCar12 = RankCar12 + 1;
}
if(Car12 < Car3){
RankCar12 = RankCar12 + 1;
}
if(Car12 < Car4){
RankCar12 = RankCar12 + 1;
}
if(Car12 < Car5){
RankCar12 = RankCar12 + 1;
}
if(Car12 < Car6){
RankCar12 = RankCar12 + 1;
}
if(Car12 < Car7){
RankCar12 = RankCar12 + 1;
}
if(Car12 < Car8){
RankCar12 = RankCar12 + 1;
}
if(Car12 < Car9){
RankCar12 = RankCar12 + 1;
}
if(Car12 < Car10){
RankCar12 = RankCar12 + 1;
}
if(Car12 < Car11){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar11){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar10){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar9){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar8){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar7){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar6){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar5){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar4){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar3){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar2){
RankCar12 = RankCar12 + 1;
}
if(RankCar12 == RankCar1){
RankCar12 = RankCar12 + 1;
}
if(RankCar11 == RankCar10){
RankCar11 = RankCar11 + 1;
}
if(RankCar11 == RankCar9){
RankCar11 = RankCar11 + 1;
}
if(RankCar11 == RankCar8){
RankCar11 = RankCar11 + 1;
}
if(RankCar11 == RankCar7){
RankCar11 = RankCar11 + 1;
}
if(RankCar11 == RankCar6){
RankCar11 = RankCar11 + 1;
}
if(RankCar11 == RankCar5){
RankCar11 = RankCar11 + 1;
}
if(RankCar11 == RankCar4){
RankCar11 = RankCar11 + 1;
}
if(RankCar11 == RankCar3){
RankCar11 = RankCar11 + 1;
}
if(RankCar11 == RankCar2){
RankCar11 = RankCar11 + 1;
}
if(RankCar11 == RankCar1){
RankCar11 = RankCar11 + 1;
}
if(RankCar10 == RankCar9){
RankCar10 = RankCar10 + 1;
}
if(RankCar10 == RankCar8){
RankCar10 = RankCar10 + 1;
}
if(RankCar10 == RankCar7){
RankCar10 = RankCar10 + 1;
}
if(RankCar10 == RankCar6){
RankCar10 = RankCar10 + 1;
}
if(RankCar10 == RankCar5){
RankCar10 = RankCar10 + 1;
}
if(RankCar10 == RankCar4){
RankCar10 = RankCar10 + 1;
}
if(RankCar10 == RankCar3){
RankCar10 = RankCar10 + 1;
}
if(RankCar10 == RankCar2){
RankCar10 = RankCar10 + 1;
}
if(RankCar10 == RankCar1){
RankCar10 = RankCar10 + 1;
}
if(RankCar9 == RankCar8){
RankCar9 = RankCar9 + 1;
}
if(RankCar9 == RankCar7){
RankCar9 = RankCar9 + 1;
}
if(RankCar9 == RankCar6){
RankCar9 = RankCar9 + 1;
}
if(RankCar9 == RankCar5){
RankCar9 = RankCar9 + 1;
}
if(RankCar9 == RankCar4){
RankCar9 = RankCar9 + 1;
}
if(RankCar9 == RankCar3){
RankCar9 = RankCar9 + 1;
}
if(RankCar9 == RankCar2){
RankCar9 = RankCar9 + 1;
}
if(RankCar9 == RankCar1){
RankCar9 = RankCar9 + 1;
}
if(RankCar8 == RankCar7){
RankCar8 = RankCar8 + 1;
}
if(RankCar8 == RankCar6){
RankCar8 = RankCar8 + 1;
}
if(RankCar8 == RankCar5){
RankCar8 = RankCar8 + 1;
}
if(RankCar8 == RankCar4){
RankCar8 = RankCar8 + 1;
}
if(RankCar8 == RankCar3){
RankCar8 = RankCar8 + 1;
}
if(RankCar8 == RankCar2){
RankCar8 = RankCar8 + 1;
}
if(RankCar8 == RankCar1){
RankCar8 = RankCar8 + 1;
}
if(RankCar7 == RankCar6){
RankCar7 = RankCar7 + 1;
}
if(RankCar7 == RankCar5){
RankCar7 = RankCar7 + 1;
}
if(RankCar7 == RankCar4){
RankCar7 = RankCar7 + 1;
}
if(RankCar7 == RankCar3){
RankCar7 = RankCar7 + 1;
}
if(RankCar7 == RankCar2){
RankCar7 = RankCar7 + 1;
}
if(RankCar7 == RankCar1){
RankCar7 = RankCar7 + 1;
}
if(RankCar6 == RankCar5){
RankCar6 = RankCar6 + 1;
}
if(RankCar6 == RankCar4){
RankCar6 = RankCar6 + 1;
}
if(RankCar6 == RankCar3){
RankCar6 = RankCar6 + 1;
}
if(RankCar6 == RankCar2){
RankCar6 = RankCar6 + 1;
}
if(RankCar6 == RankCar1){
RankCar6 = RankCar6 + 1;
}
if(RankCar5 == RankCar4){
RankCar5 = RankCar5 + 1;
}
if(RankCar5 == RankCar3){
RankCar5 = RankCar5 + 1;
}
if(RankCar5 == RankCar2){
RankCar5 = RankCar5 + 1;
}
if(RankCar5 == RankCar1){
RankCar5 = RankCar5 + 1;
}
if(RankCar4 == RankCar3){
RankCar4 = RankCar4 + 1;
}
if(RankCar4 == RankCar2){
RankCar4 = RankCar4 + 1;
}
if(RankCar4 == RankCar1){
RankCar4 = RankCar4 + 1;
}
if(RankCar3 == RankCar2){
RankCar3 = RankCar3 + 1;
}
if(RankCar3 == RankCar1){
RankCar3 = RankCar3 + 1;
}
if(RankCar2 == RankCar1){
RankCar2 = RankCar2 + 1;
}
var numbers = Resources.LoadAll("numbers");
if(RankCar1 == 1){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar1 == 2){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar1 == 3){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar1 == 4){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar1 == 5){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar1 == 6){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar1 == 7){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar1 == 8){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar1 == 9){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar1 == 10){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar1 == 11){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar1 == 12){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar2 == 1){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar2 == 2){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar2 == 3){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar2 == 4){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar2 == 5){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar2 == 6){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar2 == 7){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar2 == 8){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar2 == 9){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar2 == 10){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar2 == 11){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar2 == 12){
NCar2Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar3 == 1){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar3 == 2){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar3 == 3){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar3 == 4){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar3 == 5){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar3 == 6){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar3 == 7){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar3 == 8){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar3 == 9){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar3 == 10){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar3 == 11){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar3 == 12){
NCar3Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar4 == 1){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar4 == 2){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar4 == 3){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar4 == 4){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar4 == 5){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar4 == 6){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar4 == 7){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar4 == 8){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar4 == 9){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar4 == 10){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar4 == 11){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar4 == 12){
NCar4Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar5 == 1){
NCar1Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar5 == 2){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar5 == 3){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar5 == 4){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar5 == 5){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar5 == 6){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar5 == 7){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar5 == 8){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar5 == 9){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar5 == 10){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar5 == 11){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar5 == 12){
NCar5Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar6 == 1){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar6 == 2){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar6 == 3){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar6 == 4){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar6 == 5){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar6 == 6){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar6 == 7){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar6 == 8){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar6 == 9){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar6 == 10){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar6 == 11){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar6 == 12){
NCar6Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar7 == 1){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar7 == 2){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar7 == 3){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar7 == 4){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar7 == 5){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar7 == 6){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar7 == 7){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar7 == 8){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar7 == 9){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar7 == 10){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar7 == 11){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar7 == 12){
NCar7Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar8 == 1){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar8 == 2){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar8 == 3){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar8 == 4){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar8 == 5){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar8 == 6){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar8 == 7){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar8 == 8){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar8 == 9){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar8 == 10){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar8 == 11){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar8 == 12){
NCar8Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar9 == 1){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar9 == 2){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar9 == 3){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar9 == 4){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar9 == 5){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar9 == 6){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar9 == 7){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar9 == 8){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar9 == 9){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar9 == 10){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar9 == 11){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar9 == 12){
NCar9Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar10 == 1){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar10 == 2){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar10 == 3){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar10 == 4){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar10 == 5){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar10 == 6){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar10 == 7){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar10 == 8){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar10 == 9){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar10 == 10){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar10 == 11){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar10 == 12){
NCar10Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar11 == 1){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar11 == 2){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar11 == 3){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar11 == 4){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar11 == 5){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar11 == 6){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar11 == 7){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar11 == 8){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar11 == 9){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar11 == 10){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar11 == 11){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar11 == 12){
NCar11Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar12 == 1){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[1];
}
if(RankCar12 == 2){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[2];
}
if(RankCar12 == 3){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[3];
}
if(RankCar12 == 4){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[4];
}
if(RankCar12 == 5){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[5];
}
if(RankCar12 == 6){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[6];
}
if(RankCar12 == 7){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[7];
}
if(RankCar12 == 8){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[8];
}
if(RankCar12 == 9){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[9];
}
if(RankCar12 == 10){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[10];
}
if(RankCar12 == 11){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[11];
}
if(RankCar12 == 12){
NCar12Display.GetComponent(SpriteRenderer).sprite = numbers[12];
}
if(RankCar10 == 1){
Place.text = "1st";
}
else if(RankCar10 == 2){
Place.text = "2nd";
}
else if(RankCar10 == 3){
Place.text = "3rd";
}
else if(RankCar10 > 3){
Place.text = RankCar10 + "th";
}
}