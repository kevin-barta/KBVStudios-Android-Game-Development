#pragma strict
import UnityEngine.UI;

public static var RGB : String = "";
var Red : float = 255f;
var Green : float = 0f;
var Blue : float = 0f;
var RedColour : float = 255f;
var GreenColour : float = 0f;
var BlueColour : float = 0f;
var HueSlider : Image;

function OnValueChanged(Hue : float){
	if(Hue >= 1276f){
    Red = 255f;
    Green = 0f;
    Blue = 1530f - Hue;
    }
    else if(Hue >= 1021f){
    Red = Hue - 1020f;
    Green = 0f;
    Blue = 255f;
    }
    else if(Hue >= 766f){
    Red = 0f;
    Green = 1020 - Hue;
    Blue = 255f;
    }
    else if(Hue >= 511f){
    Red = 0f;
    Green = 255f;
    Blue = Hue - 510f;
    }
    else if(Hue >= 256f){
    Red = 510 - Hue;
    Green = 255f;
    Blue = 0f;
    }
    else if(Hue >= 0f){
	Red = 255f;
	Green = Hue;
	Blue = 0f;
    }
    RedColour = Red / 255f;
    GreenColour = Green / 255f;
    BlueColour = Blue / 255f;
    RGB = Hue.ToString("0000");
    HueSlider.color = new Color(RedColour, GreenColour, BlueColour);
}