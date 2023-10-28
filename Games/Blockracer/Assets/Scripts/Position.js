#pragma strict

function Start () {
PlayerPrefs.SetString("WayCar1", "WayPoint0");
PlayerPrefs.SetString("WayCar2", "WayPoint0");
PlayerPrefs.SetString("WayCar3", "WayPoint0");
PlayerPrefs.SetString("WayCar4", "WayPoint0");
PlayerPrefs.SetString("WayCar5", "WayPoint0");
PlayerPrefs.SetString("WayCar6", "WayPoint0");
PlayerPrefs.SetString("WayCar7", "WayPoint0");
PlayerPrefs.SetString("WayCar8", "WayPoint0");
PlayerPrefs.SetString("WayCar9", "WayPoint0");
PlayerPrefs.SetString("WayCar10", "WayPoint0");
PlayerPrefs.SetString("WayCar11", "WayPoint0");
PlayerPrefs.SetString("WayCar12", "WayPoint0");

}
function OnTriggerEnter (other : Collider){
	if (other.gameObject.name == "CarAiWaypointBased1"){
	PlayerPrefs.SetString("WayCar1", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "CarAiWaypointBased2"){
	PlayerPrefs.SetString("WayCar2", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "CarAiWaypointBased3"){
	PlayerPrefs.SetString("WayCar3", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "CarAiWaypointBased4"){
	PlayerPrefs.SetString("WayCar4", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "CarAiWaypointBased5"){
	PlayerPrefs.SetString("WayCar5", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "CarAiWaypointBased6"){
	PlayerPrefs.SetString("WayCar6", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "CarAiWaypointBased7"){
	PlayerPrefs.SetString("WayCar7", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "CarAiWaypointBased8"){
	PlayerPrefs.SetString("WayCar8", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "CarAiWaypointBased9"){
	PlayerPrefs.SetString("WayCar9", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "Car10"){
	PlayerPrefs.SetString("WayCar10", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "CarAiWaypointBased11"){
	PlayerPrefs.SetString("WayCar11", gameObject.name);
	PlayerPrefs.Save();
	}
	if (other.gameObject.name == "CarAiWaypointBased12"){
	PlayerPrefs.SetString("WayCar12", gameObject.name);
	PlayerPrefs.Save();
	}
}