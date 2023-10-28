#pragma strict

private var ray : Ray;
private var hit : RaycastHit;
var Pause : int = 0;
function Update () {
if(Input.GetMouseButtonDown(0)){
	ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, hit)){
			if(hit.transform.name == "pauseicon"){
			if(Pause == 10){
			Time.timeScale = 1;
			PlayerPrefs.SetInt("Paused", 0);
			PlayerPrefs.Save();
			Pause = 0;
			}
			else if(Pause == 0){
			Time.timeScale = 0;
			PlayerPrefs.SetInt("Paused", 10);
			PlayerPrefs.Save();
			Pause = 10;
			}
			}
		}
	}
}