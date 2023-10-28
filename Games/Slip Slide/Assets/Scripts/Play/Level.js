#pragma strict

public var level1 : GameObject;
public var level2 : GameObject;
public var level3 : GameObject;
public var level4 : GameObject;
public var level5 : GameObject;
public var level6 : GameObject;
public var level7 : GameObject;
public var level8 : GameObject;
public var level9 : GameObject;
public var level10 : GameObject;
public var level11 : GameObject;
public var level12 : GameObject;
public var level13 : GameObject;
public var level14 : GameObject;
public var level15 : GameObject;
public var level16 : GameObject;
public var level17 : GameObject;
public var level18 : GameObject;
public var level19 : GameObject;
public var level20 : GameObject;

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
if(PlayerPrefs.GetInt("Level") == 1) {
level1.active = true;
}
if(PlayerPrefs.GetInt("Level") == 2) {
level2.active = true;
}
if(PlayerPrefs.GetInt("Level") == 3) {
level3.active = true;
}
if(PlayerPrefs.GetInt("Level") == 4) {
level4.active = true;
}
if(PlayerPrefs.GetInt("Level") == 5) {
level5.active = true;
}
if(PlayerPrefs.GetInt("Level") == 6) {
level6.active = true;
}
if(PlayerPrefs.GetInt("Level") == 7) {
level7.active = true;
}
if(PlayerPrefs.GetInt("Level") == 8) {
level8.active = true;
}
if(PlayerPrefs.GetInt("Level") == 9) {
level9.active = true;
}
if(PlayerPrefs.GetInt("Level") == 10) {
level10.active = true;
}
if(PlayerPrefs.GetInt("Level") == 11) {
level11.active = true;
}
if(PlayerPrefs.GetInt("Level") == 12) {
level12.active = true;
}
if(PlayerPrefs.GetInt("Level") == 13) {
level13.active = true;
}
if(PlayerPrefs.GetInt("Level") == 14) {
level14.active = true;
}
if(PlayerPrefs.GetInt("Level") == 15) {
level15.active = true;
}
if(PlayerPrefs.GetInt("Level") == 16) {
level16.active = true;
}
if(PlayerPrefs.GetInt("Level") == 17) {
level17.active = true;
}
if(PlayerPrefs.GetInt("Level") == 18) {
level18.active = true;
}
if(PlayerPrefs.GetInt("Level") == 19) {
level19.active = true;
}
if(PlayerPrefs.GetInt("Level") == 20) {
level20.active = true;
}
System.GC.Collect();
Resources.UnloadUnusedAssets();
}