#pragma strict

private var ray : Ray;
private var hit : RaycastHit;

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
}

function Update () {
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(hit.transform.name == "Continue"){
PlayerPrefs.SetInt ("GameScore", 0);
PlayerPrefs.Save ();
Application.LoadLevel(0);
}
}
}
}