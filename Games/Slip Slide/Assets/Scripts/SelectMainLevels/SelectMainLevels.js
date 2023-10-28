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
if(hit.transform.name == "Levels10"){
PlayerPrefs.SetInt("LMain", 10);
PlayerPrefs.Save();
Application.LoadLevel(1);
}
if(hit.transform.name == "Levels20"){
PlayerPrefs.SetInt("LMain", 20);
PlayerPrefs.Save();
Application.LoadLevel(1);
}
}
}
}