#pragma strict

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
Application.LoadLevel(1);
}