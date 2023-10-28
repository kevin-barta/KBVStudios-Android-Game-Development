using UnityEngine;
using System.Collections;

public class SampleAgent : MonoBehaviour {
	private int Car1;
	private int Car2;
	private int Car3;
	private int Car4;
	private int Car5;
	private int Car6;
	private int Car7;
	private int Car8;
	private int Car9;
	private int Car10;
	private int Car11;
	private int Car12;
	private int WaypointCar1;
	private int WaypointCar2;
	private int WaypointCar3;
	private int WaypointCar4;
	private int WaypointCar5;
	private int WaypointCar6;
	private int WaypointCar7;
	private int WaypointCar8;
	private int WaypointCar9;
	private int WaypointCar10;
	private int WaypointCar11;
	private int WaypointCar12;
	private int NumberOfWaypoints = 0;
	private string WayCar1 = "Waypoint0";
	private string WayCar2 = "Waypoint0";
	private string WayCar3 = "Waypoint0";
	private string WayCar4 = "Waypoint0";
	private string WayCar5 = "Waypoint0";
	private string WayCar6 = "Waypoint0";
	private string WayCar7 = "Waypoint0";
	private string WayCar8 = "Waypoint0";
	private string WayCar9 = "Waypoint0";
	private string WayCar10 = "Waypoint0";
	private string WayCar11 = "Waypoint0";
	private string WayCar12 = "Waypoint0";
	private string LastWayCar1 = "Waypoint0";
	private string LastWayCar2 = "Waypoint0";
	private string LastWayCar3 = "Waypoint0";
	private string LastWayCar4 = "Waypoint0";
	private string LastWayCar5 = "Waypoint0";
	private string LastWayCar6 = "Waypoint0";
	private string LastWayCar7 = "Waypoint0";
	private string LastWayCar8 = "Waypoint0";
	private string LastWayCar9 = "Waypoint0";
	private string LastWayCar10 = "Waypoint0";
	private string LastWayCar11 = "Waypoint0";
	private string LastWayCar12 = "Waypoint0";


	void Start (){
		NumberOfWaypoints = 9;
		PlayerPrefs.SetInt ("WayCar1", 0);
		PlayerPrefs.SetInt ("WayCar2", 0);
		PlayerPrefs.SetInt ("WayCar3", 0);
		PlayerPrefs.SetInt ("WayCar4", 0);
		PlayerPrefs.SetInt ("WayCar5", 0);
		PlayerPrefs.SetInt ("WayCar6", 0);
		PlayerPrefs.SetInt ("WayCar7", 0);
		PlayerPrefs.SetInt ("WayCar8", 0);
		PlayerPrefs.SetInt ("WayCar9", 0);
		PlayerPrefs.SetInt ("WayCar10", 0);
		PlayerPrefs.SetInt ("WayCar11", 0);
		PlayerPrefs.SetInt ("WayCar12", 0);
		PlayerPrefs.SetInt ("WaypointCar1", 0);
		PlayerPrefs.SetInt ("WaypointCar2", 0);
		PlayerPrefs.SetInt ("WaypointCar3", 0);
		PlayerPrefs.SetInt ("WaypointCar4", 0);
		PlayerPrefs.SetInt ("WaypointCar5", 0);
		PlayerPrefs.SetInt ("WaypointCar6", 0);
		PlayerPrefs.SetInt ("WaypointCar7", 0);
		PlayerPrefs.SetInt ("WaypointCar8", 0);
		PlayerPrefs.SetInt ("WaypointCar9", 0);
		PlayerPrefs.SetInt ("WaypointCar10", 0);
		PlayerPrefs.SetInt ("WaypointCar11", 0);
		PlayerPrefs.SetInt ("WaypointCar12", 0);
		PlayerPrefs.Save ();
		PlayerPrefs.Save ();
	}

	void OnTriggerEnter (Collider other){
		if (WaypointCar1 == NumberOfWaypoints) {
			WaypointCar1 = -1;
		}
		if (WaypointCar2 == NumberOfWaypoints) {
			WaypointCar2 = -1;
		}
		if (WaypointCar3 == NumberOfWaypoints) {
			WaypointCar3 = -1;
		}
		if (WaypointCar4 == NumberOfWaypoints) {
			WaypointCar4 = -1;
		}
		if (WaypointCar5 == NumberOfWaypoints) {
			WaypointCar5 = -1;
		}
		if (WaypointCar6 == NumberOfWaypoints) {
			WaypointCar6 = -1;
		}
		if (WaypointCar7 == NumberOfWaypoints) {
			WaypointCar7 = -1;
		}
		if (WaypointCar8 == NumberOfWaypoints) {
			WaypointCar8 = -1;
		}
		if (WaypointCar9 == NumberOfWaypoints) {
			WaypointCar9 = -1;
		}
		if (WaypointCar10 == NumberOfWaypoints) {
			WaypointCar10 = -1;
		}
		if (WaypointCar11 == NumberOfWaypoints) {
			WaypointCar11 = -1;
		}
		if (WaypointCar12 == NumberOfWaypoints) {
			WaypointCar12 = -1;
		}
		if (other.gameObject.name == "CarAiWaypointBased1"){
			if(WayCar1 == PlayerPrefs.GetString("WayCar1")){
			Car1 = Car1 + 1000;
			WaypointCar1 = WaypointCar1 + 1;
			WayCar1 = "Waypoint" + WaypointCar1;
			PlayerPrefs.SetInt("WaypointCar1", WaypointCar1);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "CarAiWaypointBased2"){
			if(WayCar2 == PlayerPrefs.GetString("WayCar2")){
			Car2 = Car2 + 1000;
			WaypointCar2 = WaypointCar2 + 1;
			WayCar2 = "Waypoint" + WaypointCar2;
			PlayerPrefs.SetInt("WaypointCar2", WaypointCar2);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "CarAiWaypointBased3"){
			if(WayCar3 == PlayerPrefs.GetString("WayCar3")){
			Car3 = Car3 + 1000;
			WaypointCar3 = WaypointCar3 + 1;
			WayCar3 = "Waypoint" + WaypointCar3;
			PlayerPrefs.SetInt("WaypointCar3", WaypointCar3);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "CarAiWaypointBased4"){
			if(WayCar4 == PlayerPrefs.GetString("WayCar4")){
			Car4 = Car4 + 1000;
			WaypointCar4 = WaypointCar4 + 1;
			WayCar4 = "Waypoint" + WaypointCar4;
			PlayerPrefs.SetInt("WaypointCar4", WaypointCar4);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "CarAiWaypointBased5"){
			if(WayCar5 == PlayerPrefs.GetString("WayCar5")){
			Car5 = Car5 + 1000;
			WaypointCar5 = WaypointCar5 + 1;
			WayCar5 = "Waypoint" + WaypointCar5;
			PlayerPrefs.SetInt("WaypointCar5", WaypointCar5);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "CarAiWaypointBased6"){
			if(WayCar6 == PlayerPrefs.GetString("WayCar6")){
			Car6 = Car6 + 1000;
			WaypointCar6 = WaypointCar6 + 1;
			WayCar6 = "Waypoint" + WaypointCar6;
			PlayerPrefs.SetInt("WaypointCar6", WaypointCar6);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "CarAiWaypointBased7"){
			if(WayCar7 == PlayerPrefs.GetString("WayCar7")){
			Car7 = Car7 + 1000;
			WaypointCar7 = WaypointCar7 + 1;
			WayCar7 = "Waypoint" + WaypointCar7;
			PlayerPrefs.SetInt("WaypointCar7", WaypointCar7);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "CarAiWaypointBased8"){
			if(WayCar8 == PlayerPrefs.GetString("WayCar8")){
			Car8 = Car8 + 1000;
			WaypointCar8 = WaypointCar8 + 1;
			WayCar8 = "Waypoint" + WaypointCar8;
			PlayerPrefs.SetInt("WaypointCar8", WaypointCar8);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "CarAiWaypointBased9"){
			if(WayCar9 == PlayerPrefs.GetString("WayCar9")){
			Car9 = Car9 + 1000;
			WaypointCar9 = WaypointCar9 + 1;
			WayCar9 = "Waypoint" + WaypointCar9;
			PlayerPrefs.SetInt("WaypointCar9", WaypointCar9);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "Car10"){
			if(WayCar10 == PlayerPrefs.GetString("WayCar10")){
			Car10 = Car10 + 1000;
			WaypointCar10 = WaypointCar10 + 1;
			WayCar10 = "Waypoint" + WaypointCar10;
			PlayerPrefs.SetInt("WaypointCar10", WaypointCar10 -1);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "CarAiWaypointBased11"){
			if(WayCar11 == PlayerPrefs.GetString("WayCar11")){
			Car11 = Car11 + 1000;
			WaypointCar11 = WaypointCar11 + 1;
			WayCar11 = "Waypoint" + WaypointCar11;
			PlayerPrefs.SetInt("WaypointCar11", WaypointCar11);
			PlayerPrefs.Save();
			}
		}
		if (other.gameObject.name == "CarAiWaypointBased12"){
			if(WayCar12 == PlayerPrefs.GetString("WayCar12")){
			Car12 = Car12 + 1000;
			WaypointCar12 = WaypointCar12 + 1;
			WayCar12 = "Waypoint" + WaypointCar12;
			PlayerPrefs.SetInt("WaypointCar12", WaypointCar12);
			PlayerPrefs.Save();
			}
		}
	}
}