#pragma strict

private var ray : Ray;
private var hit : RaycastHit;
public var googleAnalytics : GoogleAnalyticsV4;

function Start () {
googleAnalytics.LogScreen("MainMenu");
System.GC.Collect();
Resources.UnloadUnusedAssets();
}

function Update () {
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(hit.transform.name == "Play"){
googleAnalytics.LogScreen("Tutorial");
Application.LoadLevel(3);
Time.timeScale = 1.0f;
}
if(hit.transform.name == "Info"){
googleAnalytics.LogScreen("Kbvstudios");
Application.OpenURL("http://www.kbvstudios.com/");
}
}
}
}