#pragma strict
public var googleAnalytics : GoogleAnalyticsV3;
var x : int = 10;
var Loading1 : TextMesh;

function Start () {
googleAnalytics.LogScreen("Reload");
System.GC.Collect();
Resources.UnloadUnusedAssets();
yield WaitForSeconds(0.5);
Application.LoadLevel(1);
}

function Update () {
if(x == 10){
x = 0;
Loading();
}
}

function Loading () {
Loading1.GetComponent(TextMesh).text = "LOADING ";
yield WaitForSeconds(0.25);
Loading1.GetComponent(TextMesh).text = "LOADING .";
yield WaitForSeconds(0.25);
Loading1.GetComponent(TextMesh).text = "LOADING ..";
yield WaitForSeconds(0.25);
Loading1.GetComponent(TextMesh).text = "LOADING ...";
yield WaitForSeconds(1);
x = 10;
}