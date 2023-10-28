#pragma strict

private var ray : Ray;
private var hit : RaycastHit;
var pic1 : Texture2D;
var pic2 : Texture2D;

function Start () {
System.GC.Collect();
Resources.UnloadUnusedAssets();
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("MainMenu");
    PlayerPrefs.SetInt("HowToPlay", 0);
    PlayerPrefs.Save();
}

function Update () {
if(Input.GetMouseButtonDown(0)){
ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, hit)){
if(hit.transform.name == "Play"){
Application.LoadLevel(7);
}
if(hit.transform.name == "Kbvstudios"){
if (GoogleAnalytics.instance)
    GoogleAnalytics.instance.LogScreen("Kbvstudios");
Application.OpenURL("http://www.kbvstudios.com/");
}
}
}
}

function OnGUI () {
    var centeredStyle = GUIStyle(GUI.skin.label);

		if (GUI.Button (Rect (.01 * Screen.width, .87 * Screen.height, .2 * Screen.width, .2 * Screen.height), pic1, GUI.skin.GetStyle ("Label"))){
		Application.LoadLevel(3);
		if (GoogleAnalytics.instance)
        GoogleAnalytics.instance.LogScreen("StoreOpened");
		}
		if (GUI.Button (Rect (.78 * Screen.width, .87 * Screen.height, .2 * Screen.width, .2 * Screen.height), pic2, GUI.skin.GetStyle ("Label"))){
		Application.LoadLevel(4);
		if (GoogleAnalytics.instance)
        GoogleAnalytics.instance.LogScreen("SettingsOpened");
		}
    }