#pragma strict
import System.Collections.Generic;
var RedFlag : Sprite;
var BlueFlag : Sprite;
var YellowFlag : Sprite;
var GreenFlag : Sprite;
var CyanFlag : Sprite;
var PurpleFlag : Sprite;
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

function Start () {
if(PlayerPrefs.GetInt("NewGame") == 0){
   var i : int;
   var numbersred : int [] = new int[13];
   var numbersblue : int [] = new int[13];
   var numbersyellow : int [] = new int[13];
   var numbersgreen : int [] = new int[13];
   var numberscyan : int [] = new int[13];
   var numberspurple : int [] = new int[13];
   var sectionnumber : int = 0;
   //using a string variable to keep record of the used numbers
   var usedNumbers : String = "-";
   var usedNumbersRed : String = "-";
   var usedNumbersBlue : String = "-";
   var usedNumbersYellow : String = "-";
   var usedNumbersGreen : String = "-";
   var usedNumbersCyan : String = "-";
   var usedNumbersPurple : String = "-";
   //red
   for (i = 0; i < 13; i++)
   {
      //get a random number between 0 - 80, 0 and 80 included on the random numbers
      var randomNumber : int = Random.Range(1,78);
      //Checking if the random number you get is unique, if you already have it in the string means that this random number is repeated, the "-X-" is to make the difference between the numbers, like -1- from -11-, if you dont have the "-X-" the 1 is in 21 and would be a "repeated" number
      while(usedNumbers.Contains("-"+randomNumber.ToString()+"-"))
      {
         //if a number is repeated, then get a new random number
         randomNumber = Random.Range(1,79);
      }
      usedNumbers+= randomNumber.ToString()+"-";
      usedNumbersRed+= randomNumber.ToString()+"-";
      numbersred[i] = randomNumber;
      sectionnumber = randomNumber;
   } 
       
   //blue
   for (i = 0; i < 13; i++)
   {
      //get a random number between 0 - 120, 0 and 120 included on the random numbers
      //Checking if the random number you get is unique, if you already have it in the string means that this random number is repeated, the "-X-" is to make the difference between the numbers, like -1- from -11-, if you dont have the "-X-" the 1 is in 21 and would be a "repeated" number
      while(usedNumbers.Contains("-"+randomNumber.ToString()+"-"))
      {
         //if a number is repeated, then get a new random number
         randomNumber = Random.Range(1,79);
      }
      usedNumbers+= randomNumber.ToString()+"-";
      usedNumbersBlue+= randomNumber.ToString()+"-";
      numbersblue[i] = randomNumber;
      sectionnumber = randomNumber;
   }
      
   //yellow
   for (i = 0; i < 13; i++)
   {
      //get a random number between 0 - 120, 0 and 120 included on the random numbers
      //Checking if the random number you get is unique, if you already have it in the string means that this random number is repeated, the "-X-" is to make the difference between the numbers, like -1- from -11-, if you dont have the "-X-" the 1 is in 21 and would be a "repeated" number
      while(usedNumbers.Contains("-"+randomNumber.ToString()+"-"))
      {
         //if a number is repeated, then get a new random number
         randomNumber = Random.Range(1,79);
      }
      usedNumbers+= randomNumber.ToString()+"-";
      usedNumbersYellow+= randomNumber.ToString()+"-";
      numbersyellow[i] = randomNumber;
      sectionnumber = randomNumber;
   }
      
   //green
   for (i = 0; i < 13; i++)
   {
      //get a random number between 0 - 120, 0 and 120 included on the random numbers
      //Checking if the random number you get is unique, if you already have it in the string means that this random number is repeated, the "-X-" is to make the difference between the numbers, like -1- from -11-, if you dont have the "-X-" the 1 is in 21 and would be a "repeated" number
      while(usedNumbers.Contains("-"+randomNumber.ToString()+"-"))
      {
         //if a number is repeated, then get a new random number
         randomNumber = Random.Range(1,79);
      }
      usedNumbers+= randomNumber.ToString()+"-";
      usedNumbersGreen+= randomNumber.ToString()+"-";
      numbersgreen[i] = randomNumber;
      sectionnumber = randomNumber;
   }
      
   //cyan
   for (i = 0; i < 13; i++)
   {
      //get a random number between 0 - 120, 0 and 120 included on the random numbers
      //Checking if the random number you get is unique, if you already have it in the string means that this random number is repeated, the "-X-" is to make the difference between the numbers, like -1- from -11-, if you dont have the "-X-" the 1 is in 21 and would be a "repeated" number
      while(usedNumbers.Contains("-"+randomNumber.ToString()+"-"))
      {
         //if a number is repeated, then get a new random number
         randomNumber = Random.Range(1,79);
      }
      usedNumbers+= randomNumber.ToString()+"-";
      usedNumbersCyan+= randomNumber.ToString()+"-";
      numberscyan[i] = randomNumber;
      sectionnumber = randomNumber;
   }
      
   //purple
   for (i = 0; i < 13; i++)
   {
      //get a random number between 0 - 120, 0 and 120 included on the random numbers
      //Checking if the random number you get is unique, if you already have it in the string means that this random number is repeated, the "-X-" is to make the difference between the numbers, like -1- from -11-, if you dont have the "-X-" the 1 is in 21 and would be a "repeated" number
      while(usedNumbers.Contains("-"+randomNumber.ToString()+"-"))
      {
         //if a number is repeated, then get a new random number
         randomNumber = Random.Range(1,79);
      }
      usedNumbers+= randomNumber.ToString()+"-";
      usedNumbersPurple+= randomNumber.ToString()+"-";
      numberspurple[i] = randomNumber;
      sectionnumber = randomNumber;
   }
        PlayerPrefs.SetString("Red", usedNumbersRed);
        PlayerPrefs.SetString("Blue", usedNumbersBlue);
        PlayerPrefs.SetString("Yellow", usedNumbersYellow);
        PlayerPrefs.SetString("Green", usedNumbersGreen);
        PlayerPrefs.SetString("Cyan", usedNumbersCyan);
        PlayerPrefs.SetString("Purple", usedNumbersPurple);
        PlayerPrefs.Save();
        
        //red
        if(usedNumbersRed.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersRed.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersRed.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagRed", typeof(Sprite)) as Sprite;
		}
		
		//blue
		if(usedNumbersBlue.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersBlue.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersBlue.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagBlue", typeof(Sprite)) as Sprite;
      	}
      	
      	//yellow
      	if(usedNumbersYellow.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersYellow.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersYellow.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagYellow", typeof(Sprite)) as Sprite;
		}
        
        //green
        if(usedNumbersGreen.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersGreen.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersGreen.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagGreen", typeof(Sprite)) as Sprite;
		}
        
        //cyan
        if(usedNumbersCyan.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersCyan.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersCyan.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagCyan", typeof(Sprite)) as Sprite;
		}
      
        //purple
        if(usedNumbersPurple.Contains("-"+1+"-")){
        Section1.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+2+"-")){
 		Section2.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+3+"-")){
 		Section3.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+4+"-")){
 		Section4.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+5+"-")){
		Section5.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+6+"-")){
		Section6.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+7+"-")){
		Section7.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+8+"-")){
		Section8.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+9+"-")){
		Section9.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+10+"-")){
		Section10.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+11+"-")){
        Section11.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+12+"-")){
 		Section12.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+13+"-")){
 		Section13.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+14+"-")){
 		Section14.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+15+"-")){
		Section15.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+16+"-")){
		Section16.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+17+"-")){
		Section17.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+18+"-")){
		Section18.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+19+"-")){
		Section19.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+20+"-")){
		Section20.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+21+"-")){
        Section21.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+22+"-")){
 		Section22.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+23+"-")){
 		Section23.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+24+"-")){
 		Section24.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+25+"-")){
		Section25.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+26+"-")){
		Section26.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+27+"-")){
		Section27.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+28+"-")){
		Section28.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+29+"-")){
		Section29.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+30+"-")){
		Section30.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+31+"-")){
        Section31.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+32+"-")){
 		Section32.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+33+"-")){
 		Section33.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+34+"-")){
 		Section34.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+35+"-")){
		Section35.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+36+"-")){
		Section36.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+37+"-")){
		Section37.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+38+"-")){
		Section38.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+39+"-")){
		Section39.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+40+"-")){
		Section40.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+41+"-")){
        Section41.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+42+"-")){
 		Section42.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+43+"-")){
 		Section43.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+44+"-")){
 		Section44.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+45+"-")){
		Section45.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+46+"-")){
		Section46.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+47+"-")){
		Section47.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+48+"-")){
		Section48.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+49+"-")){
		Section49.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+50+"-")){
		Section50.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+51+"-")){
        Section51.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+52+"-")){
 		Section52.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+53+"-")){
 		Section53.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+54+"-")){
 		Section54.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+55+"-")){
		Section55.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+56+"-")){
		Section56.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+57+"-")){
		Section57.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+58+"-")){
		Section58.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+59+"-")){
		Section59.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+60+"-")){
		Section60.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+61+"-")){
        Section61.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+62+"-")){
 		Section62.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+63+"-")){
 		Section63.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+64+"-")){
 		Section64.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+65+"-")){
		Section65.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+66+"-")){
		Section66.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+67+"-")){
		Section67.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+68+"-")){
		Section68.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+69+"-")){
		Section69.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+70+"-")){
		Section70.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+71+"-")){
        Section71.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+72+"-")){
 		Section72.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+73+"-")){
 		Section73.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
 		}
 		if(usedNumbersPurple.Contains("-"+74+"-")){
 		Section74.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+75+"-")){
		Section75.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+76+"-")){
		Section76.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+77+"-")){
		Section77.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
		if(usedNumbersPurple.Contains("-"+78+"-")){
		Section78.GetComponent(SpriteRenderer).sprite =  Resources.Load("flagPurple", typeof(Sprite)) as Sprite;
		}
        Section.active = false;
        Section.active = true;
        }
}