#pragma strict

var C : int = 0;
var CE : int = 0;
var CE1 : int = 0;
var Random3 : int = 0;
var Random4 : int = 0;
var Hacked : int = 0;
var Hacked1 : int = 0;
var Decrypting : int = 0;
var Decrypt : int = 0;
var Encrypt : int = 0;
var userid : String = "";

function Start () {
userid = PlayerPrefs.GetString("id");
var form = new WWWForm();
form.AddField("userid", userid);
form.AddField("coins", C);
var w = WWW("http://kbvstudios.com/birdracing.php", form);
yield w;
if(w.error) {
print(w.error);
}
else {
userid = w.text;
PlayerPrefs.SetString("id", userid);
PlayerPrefs.Save();
}
}

function Update (){
if(Encrypt == 1){
Encrypt = 0;
Encryption();
}
if(Decrypt == 1){
Decrypt = 0;
Decryption();
}
}

function Decryption (){
CE1 = PlayerPrefs.GetInt("CE");
C = PlayerPrefs.GetInt("Coins");
Random3 = 51;
Random4 = 5677;
Decrypting = 10;
while(Decrypting == 10){
Random4 = Random4 + 1;
CE = CE1;
CE = CE / Random3;
CE = CE + Random4;
CE = CE / Random3;
CE = CE - Random4;
if(C == CE){
Decrypting = 0;
Hacked = 0;
}
else if(Random3 == 91 && Random4 == 5683){
Decrypting = 0;
Hacked = 10;
}
else if(Random4 == 5683){
Random4 = 5677;
Random3 = Random3 + 1;
}
}
if(Hacked == 10){
print("Number Was Hacked!");
if(Hacked1 == 10){
print("Number Was Reset!");
}
}
if(Hacked == 0){
print("Number Was Not Hacked!");
}
}

function Encryption (){
var Random1 : int = Mathf.Abs(Random.Range(51,92));
var Random2 : int = Mathf.Abs(Random.Range(5678,5684));
CE = C;
CE = CE + Random2;
CE = CE * Random1;
CE = CE - Random2;
CE = CE * Random1;
PlayerPrefs.SetInt("Coins", C);
PlayerPrefs.SetInt("CE", CE);
PlayerPrefs.Save();
var form = new WWWForm();
form.AddField("coins", C);
form.AddField("userid", userid);
var w = WWW("http://kbvstudios.com/birdracing.php", form);
yield w;
}