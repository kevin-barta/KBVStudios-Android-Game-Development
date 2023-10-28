#pragma strict

private var ray : Ray;
private var hit : RaycastHit;
private var TutorialFin : int = 10;

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
}

function Update () {
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(hit.transform.name == "Continue"){
Application.LoadLevel(1);
}
}
}
}