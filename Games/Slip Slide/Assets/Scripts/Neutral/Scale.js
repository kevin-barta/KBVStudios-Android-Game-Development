#pragma strict

var ScreenRatio : float = 0.0f;
var OldRatio : float = 62.5f;
var NewRatio : float = 0.0f;

function Start () {
ScreenRatio = 100 * Screen.width;
ScreenRatio = ScreenRatio / Screen.height;
NewRatio = ScreenRatio + 100 - OldRatio;
NewRatio = NewRatio / 100;
transform.position.x = transform.position.x * NewRatio;
transform.localScale.x = transform.localScale.x * NewRatio;
}