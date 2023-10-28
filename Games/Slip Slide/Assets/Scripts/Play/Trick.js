#pragma strict

var LevelOn : int = 0;
public var l7_ice19 : GameObject;
public var l7_lava2 : GameObject;
public var l7_stoplava1 : GameObject;
public var l7_trick1 : GameObject;
public var l7_ice22 : GameObject;
public var l7_lava3 : GameObject;
public var l7_stoplava2 : GameObject;
public var l7_trick2 : GameObject;
public var l9_ice14 : GameObject;
public var l9_lava1 : GameObject;
public var l9_stoplava1 : GameObject;
public var l9_trick1 : GameObject;
public var l10_ice19 : GameObject;
public var l10_lava4 : GameObject;
public var l10_stoplava1 : GameObject;
public var l10_trick1 : GameObject;
public var l11_ice19 : GameObject;
public var l11_lava3 : GameObject;
public var l11_stoplava1 : GameObject;
public var l11_trick1 : GameObject;
public var l11_ice22 : GameObject;
public var l11_slow2 : GameObject;
public var l11_stopslow1 : GameObject;
public var l11_trick2 : GameObject;
public var l11_ice5 : GameObject;
public var l11_rock1 : GameObject;
public var l11_stoprock1 : GameObject;
public var l11_trick3 : GameObject;
public var l11_ice11 : GameObject;
public var l11_rock7 : GameObject;
public var l11_stoprock2 : GameObject;
public var l11_trick4 : GameObject;
public var l12_ice2 : GameObject;
public var l12_slow4 : GameObject;
public var l12_stopslow1 : GameObject;
public var l12_trick1 : GameObject;
public var l12_ice16 : GameObject;
public var l12_lava1 : GameObject;
public var l12_stoplava1 : GameObject;
public var l12_ice17 : GameObject;
public var l12_lava2 : GameObject;
public var l12_stoplava2 : GameObject;
public var l12_trick2 : GameObject;
public var l13_ice3 : GameObject;
public var l13_slow1 : GameObject;
public var l13_stopslow1 : GameObject;
public var l13_trick3 : GameObject;
public var l13_ice26 : GameObject;
public var l13_lava1 : GameObject;
public var l13_stoplava1 : GameObject;
public var l13_trick2 : GameObject;
public var l13_ice18 : GameObject;
public var l13_rock10 : GameObject;
public var l13_stoprock1 : GameObject;
public var l13_trick1 : GameObject;
public var l13_ice27 : GameObject;
public var l13_rock5 : GameObject;
public var l13_stoprock2 : GameObject;
public var l14_ice6 : GameObject;
public var l14_slow4 : GameObject;
public var l14_stopslow1 : GameObject;
public var l14_trick2 : GameObject;
public var l14_ice24 : GameObject;
public var l14_rock4 : GameObject;
public var l14_stoprock1 : GameObject;
public var l14_trick1 : GameObject;
public var l14_slow5 : GameObject;
public var l14_stopslow2 : GameObject;
public var l14_rock13 : GameObject;
public var l14_stoprock2 : GameObject;
public var l15_trick1 : GameObject;
public var l15_ice32 : GameObject;
public var l15_ice26 : GameObject;
public var l15_ice21 : GameObject;
public var l15_ice27 : GameObject;
public var l15_slow3 : GameObject;
public var l15_stopslow1 : GameObject;
public var l15_stoplava1 : GameObject;
public var l15_stoplava2 : GameObject;
public var l15_stoplava3 : GameObject;
public var l15_stoplava4 : GameObject;
public var l15_stoplava5 : GameObject;
public var l15_stoplava6 : GameObject;
public var l15_stoplava7 : GameObject;
public var l15_stoplava8 : GameObject;
public var l15_lava1 : GameObject;
public var l15_lava2 : GameObject;
public var l15_lava3 : GameObject;
public var l15_lava4 : GameObject;
public var l15_lava5 : GameObject;
public var l15_lava6 : GameObject;
public var l15_lava7 : GameObject;
public var l15_lava8 : GameObject;
public var l15_stoprock1 : GameObject;
public var l15_stoprock2 : GameObject;
public var l15_stoprock3 : GameObject;
public var l15_stoprock4 : GameObject;
public var l15_stoprock5 : GameObject;
public var l15_stoprock6 : GameObject;
public var l15_rock1 : GameObject;
public var l15_rock2 : GameObject;
public var l15_rock3 : GameObject;
public var l15_rock4 : GameObject;
public var l15_rock5 : GameObject;
public var l15_rock6 : GameObject;
public var l15_rock7 : GameObject;
public var l15_rock8 : GameObject;
public var l15_rock9 : GameObject;
public var l17_ice26 : GameObject;
public var l17_ice4 : GameObject;
public var l17_rock15 : GameObject;
public var l17_stoprock8 : GameObject;
public var l17_stopslow : GameObject;
public var l17_slow1 : GameObject;
public var l17_trick1 : GameObject;

function Start () {
LevelOn = PlayerPrefs.GetInt("Level");
}

function OnTriggerEnter2D(other : Collider2D) {
if (other.gameObject.tag == "Trick1") {
if (LevelOn == 8){
yield WaitForSeconds(0.5);
l7_ice19.active = false;
l7_lava2.active = true;
l7_stoplava1.active = true;
l7_trick1.active = false;
}
if (LevelOn == 9){
yield WaitForSeconds(0.5);
l9_ice14.active = false;
l9_lava1.active = true;
l9_stoplava1.active = true;
l9_trick1.active = false;
}
if (LevelOn == 10){
yield WaitForSeconds(0.5);
l10_ice19.active = false;
l10_lava4.active = true;
l10_stoplava1.active = true;
l10_trick1.active = false;
}
if (LevelOn == 11){
yield WaitForSeconds(0.5);
l11_ice19.active = false;
l11_lava3.active = true;
l11_stoplava1.active = true;
l11_trick1.active = false;
}
if (LevelOn == 12){
yield WaitForSeconds(0.5);
l12_ice2.active = false;
l12_slow4.active = true;
l12_stopslow1.active = true;
l12_trick1.active = false;
}
if (LevelOn == 13){
l13_ice18.active = false;
l13_rock10.active = true;
l13_stoprock1.active = true;
l13_trick1.active = false;
l13_ice27.active = true;
l13_rock5.active = false;
l13_stoprock2.active = false;
}
if (LevelOn == 14){
l14_ice24.active = false;
l14_rock13.active = true;
l14_stoprock2.active = true;
l14_trick1.active = false;
l14_slow5.active = true;
l14_stopslow2.active = true;
l14_rock4.active = false;
l14_stoprock1.active = false;
}
if (LevelOn == 15){
l15_trick1.active = false;
l15_ice32.active = true;
l15_ice26.active = false;
l15_ice27.active = false;
l15_ice21.active = true;
l15_slow3.active = true;
l15_stopslow1.active = true;
l15_stoplava1.active = true;
l15_stoplava2.active = true;
l15_stoplava3.active = true;
l15_stoplava4.active = true;
l15_stoplava5.active = true;
l15_stoplava6.active = true;
l15_stoplava7.active = true;
l15_stoplava8.active = true;
l15_lava1.active = true;
l15_lava2.active = true;
l15_lava3.active = true;
l15_lava4.active = true;
l15_lava5.active = true;
l15_lava6.active = true;
l15_lava7.active = true;
l15_lava8.active = true;
l15_stoprock1.active = false;
l15_stoprock2.active = false;
l15_stoprock3.active = false;
l15_stoprock4.active = false;
l15_stoprock5.active = false;
l15_stoprock6.active = false;
l15_rock1.active = false;
l15_rock2.active = false;
l15_rock3.active = false;
l15_rock4.active = false;
l15_rock5.active = false;
l15_rock6.active = false;
l15_rock7.active = false;
l15_rock8.active = false;
l15_rock9.active = false;
}
if (LevelOn == 17){
l17_ice26.active = true;
l17_ice4.active = false;
l17_rock15.active = false;
l17_stoprock8.active = false;
l17_trick1.active = false;
l17_slow1.active = true;
l17_stopslow.active = true;
}
}
if (other.gameObject.tag == "Trick2") {
if (LevelOn == 8){
yield WaitForSeconds(0.5);
l7_ice22.active = false;
l7_lava3.active = true;
l7_stoplava2.active = true;
l7_trick2.active = false;
}
if (LevelOn == 11){
yield WaitForSeconds(0.5);
l11_ice22.active = false;
l11_slow2.active = true;
l11_stopslow1.active = true;
l11_trick2.active = false;
}
if (LevelOn == 12){
yield WaitForSeconds(0.5);
l12_ice16.active = false;
l12_lava1.active = true;
l12_stoplava1.active = true;
l12_ice17.active = false;
l12_lava2.active = true;
l12_stoplava2.active = true;
l12_trick2.active = false;
}
if (LevelOn == 13){
l13_ice26.active = false;
l13_lava1.active = true;
l13_stoplava1.active = true;
l13_trick2.active = false;
}
if (LevelOn == 14){
l14_ice6.active = false;
l14_slow4.active = true;
l14_stopslow1.active = true;
l14_trick2.active = false;
}
}
if (other.gameObject.tag == "Trick3") {
if (LevelOn == 11){
yield WaitForSeconds(0.5);
l11_ice5.active = false;
l11_rock1.active = true;
l11_stoprock1.active = true;
l11_trick3.active = false;
}
if (LevelOn == 13){
yield WaitForSeconds(0.5);
l13_ice3.active = false;
l13_slow1.active = true;
l13_stopslow1.active = true;
l13_trick3.active = false;
}
}
if (other.gameObject.tag == "Trick4") {
if (LevelOn == 11){
yield WaitForSeconds(0.5);
l11_ice11.active = false;
l11_rock7.active = true;
l11_stoprock2.active = true;
l11_trick4.active = false;
}
}
}