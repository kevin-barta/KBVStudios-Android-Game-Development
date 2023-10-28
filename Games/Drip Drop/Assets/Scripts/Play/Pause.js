#pragma strict

	var isPause = false;
var MainMenu : Rect = new Rect(-3,-3,Screen.width + 49,Screen.height - 39);
 
function Update () {
 if( Input.GetKeyDown(KeyCode.Escape))
   {
      isPause = !isPause;
      if(isPause)
         Time.timeScale = 0;
      else
         Time.timeScale = 1;
   }
}
 
function OnGUI()
{
   if(isPause)
       GUI.Window(0, MainMenu, TheMainMenu, "Pause Menu");
}
 
function TheMainMenu () {
if(GUILayout.Button("To Resume Press Back Button")){
}
if(GUILayout.Button("Restart")){
Application.LoadLevel("Play");
Time.timeScale = 1;
}
if(GUILayout.Button("Quit")){
Application.LoadLevel(0);
}
}
