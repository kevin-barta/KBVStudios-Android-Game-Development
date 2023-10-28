#pragma strict
import System.Collections.Generic;
var RedFlag : Sprite;
var BlueFlag : Sprite;
var YellowFlag : Sprite;
var GreenFlag : Sprite;
var CyanFlag : Sprite;
var PurpleFlag : Sprite;
var usedNumbers1Red : String = "";
var usedNumbers1Blue : String = "";
var usedNumbers1Yellow : String = "";
var usedNumbers1Green : String = "";
var usedNumbers1Cyan : String = "";
var usedNumbers1Purple : String = "";
var ReloadwasCalled : int = 0;
var Reload1 : GameObject;
var Section : GameObject;
var Section1 : GameObject;
var Section2 : GameObject;
var Section3 : GameObject;
var Section4 : GameObject;
var Section5 : GameObject;
var Section6 : GameObject;
var Section7 : GameObject;
var Section8 : GameObject;
var Section9 : GameObject;
var Section10 : GameObject;
var Section11 : GameObject;
var Section12 : GameObject;
var Section13 : GameObject;
var Section14 : GameObject;
var Section15 : GameObject;
var Section16 : GameObject;
var Section17 : GameObject;
var Section18 : GameObject;
var Section19 : GameObject;
var Section20 : GameObject;
var Section21 : GameObject;
var Section22 : GameObject;
var Section23 : GameObject;
var Section24 : GameObject;
var Section25 : GameObject;
var Section26 : GameObject;
var Section27 : GameObject;
var Section28 : GameObject;
var Section29 : GameObject;
var Section30 : GameObject;
var Section31 : GameObject;
var Section32 : GameObject;
var Section33 : GameObject;
var Section34 : GameObject;
var Section35 : GameObject;
var Section36 : GameObject;
var Section37 : GameObject;
var Section38 : GameObject;
var Section39 : GameObject;
var Section40 : GameObject;
var Section41 : GameObject;
var Section42 : GameObject;
var Section43 : GameObject;
var Section44 : GameObject;
var Section45 : GameObject;
var Section46 : GameObject;
var Section47 : GameObject;
var Section48 : GameObject;
var Section49 : GameObject;
var Section50 : GameObject;
var Section51 : GameObject;
var Section52 : GameObject;
var Section53 : GameObject;
var Section54 : GameObject;
var Section55 : GameObject;
var Section56 : GameObject;
var Section57 : GameObject;
var Section58 : GameObject;
var Section59 : GameObject;
var Section60 : GameObject;
var Section61 : GameObject;
var Section62 : GameObject;
var Section63 : GameObject;
var Section64 : GameObject;
var Section65 : GameObject;
var Section66 : GameObject;
var Section67 : GameObject;
var Section68 : GameObject;
var Section69 : GameObject;
var Section70 : GameObject;
var Section71 : GameObject;
var Section72 : GameObject;
var Section73 : GameObject;
var Section74 : GameObject;
var Section75 : GameObject;
var Section76 : GameObject;
var Section77 : GameObject;
var Section78 : GameObject;

/*function Update () {
if(ReloadwasCalled == 0){
ReloadwasCalled = 10;
Reload();
}
}*/

function Start () {
		usedNumbers1Red = PlayerPrefs.GetString("Red");
		usedNumbers1Blue = PlayerPrefs.GetString("Blue");
		usedNumbers1Yellow = PlayerPrefs.GetString("Yellow");
		usedNumbers1Green = PlayerPrefs.GetString("Green");
		usedNumbers1Cyan = PlayerPrefs.GetString("Cyan");
		usedNumbers1Purple = PlayerPrefs.GetString("Purple");
        if(usedNumbers1Red.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Red.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Red.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		
		//blue
		if(usedNumbers1Blue.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Blue.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Blue.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
      	}
      	
      	//yellow
      	if(usedNumbers1Yellow.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Yellow.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Yellow.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
        
        //green
        if(usedNumbers1Green.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Green.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Green.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
        
        //cyan
        if(usedNumbers1Cyan.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Cyan.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Cyan.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
      
        //purple
        if(usedNumbers1Purple.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbers1Purple.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbers1Purple.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
        Section.active = false;
        Section.active = true;
        //PlayerPrefs.GetInt("ReloadwasCalled", 0);
        //PlayerPrefs.Save();
}