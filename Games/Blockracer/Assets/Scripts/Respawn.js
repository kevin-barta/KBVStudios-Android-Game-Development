#pragma strict
var Waypoint1 : GameObject;
var Waypoint2 : GameObject;
var Waypoint3 : GameObject;
var Waypoint4 : GameObject;
var Waypoint5 : GameObject;
var Waypoint6 : GameObject;
var Waypoint7 : GameObject;
var Waypoint8 : GameObject;
var Waypoint9 : GameObject;
var Waypoint10 : GameObject;
var Waypoint11 : GameObject;
var Waypoint12 : GameObject;
var Car10Collider : GameObject;
var VCar1 : GameObject;
var VCar2 : GameObject;
var VCar3 : GameObject;
var VCar4 : GameObject;
var VCar5 : GameObject;
var VCar6 : GameObject;
var VCar7 : GameObject;
var VCar8 : GameObject;
var VCar9 : GameObject;
var VCar10 : GameObject;
var VCar11 : GameObject;
var VCar12 : GameObject;

function OnTriggerEnter (other : Collider){
	if (other.gameObject.name == "CarAiWaypointBased1"){
	//Waypoint = GameObject.Find("" + Car1);
	VCar1.transform.position = Waypoint1.transform.position;
	VCar1.transform.rotation = Waypoint1.transform.rotation;
	VCar1.transform.rotation.z = 0;
	VCar1.transform.rotation.x = 0;
	VCar1.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar1.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "CarAiWaypointBased2"){
	VCar2.transform.position = Waypoint2.transform.position;
	VCar2.transform.rotation = Waypoint2.transform.rotation;
	VCar2.transform.rotation.z = 0;
	VCar2.transform.rotation.x = 0;
	VCar2.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar2.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "CarAiWaypointBased3"){
	VCar3.transform.position = Waypoint3.transform.position;
	VCar3.transform.rotation = Waypoint3.transform.rotation;
	VCar3.transform.rotation.z = 0;
	VCar3.transform.rotation.x = 0;
	VCar3.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar3.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "CarAiWaypointBased4"){
	VCar4.transform.position = Waypoint4.transform.position;
	VCar4.transform.rotation = Waypoint4.transform.rotation;
	VCar4.transform.rotation.z = 0;
	VCar4.transform.rotation.x = 0;
	VCar4.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar4.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "CarAiWaypointBased5"){
	VCar5.transform.position = Waypoint5.transform.position;
	VCar5.transform.rotation = Waypoint5.transform.rotation;
	VCar5.transform.rotation.z = 0;
	VCar5.transform.rotation.x = 0;
	VCar5.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar5.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "CarAiWaypointBased6"){
	VCar6.transform.position = Waypoint6.transform.position;
	VCar6.transform.rotation = Waypoint6.transform.rotation;
	VCar6.transform.rotation.z = 0;
	VCar6.transform.rotation.x = 0;
	VCar6.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar6.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "CarAiWaypointBased7"){
	VCar7.transform.position = Waypoint7.transform.position;
	VCar7.transform.rotation = Waypoint7.transform.rotation;
	VCar7.transform.rotation.z = 0;
	VCar7.transform.rotation.x = 0;
	VCar7.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar7.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "CarAiWaypointBased8"){
	VCar8.transform.position = Waypoint8.transform.position;
	VCar8.transform.rotation = Waypoint8.transform.rotation;
	VCar8.transform.rotation.z = 0;
	VCar8.transform.rotation.x = 0;
	VCar8.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar8.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "CarAiWaypointBased9"){
	VCar9.transform.position = Waypoint9.transform.position;
	VCar9.transform.rotation = Waypoint9.transform.rotation;
	VCar9.transform.rotation.z = 0;
	VCar9.transform.rotation.x = 0;
	VCar9.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar9.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "Car10"){
	VCar10.transform.position = Waypoint10.transform.position;
	VCar10.transform.rotation = Waypoint10.transform.rotation;
	VCar10.transform.rotation.z = 0;
	VCar10.transform.rotation.x = 0;
	VCar10.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar10.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "CarAiWaypointBased11"){
	VCar11.transform.position = Waypoint11.transform.position;
	VCar11.transform.rotation = Waypoint11.transform.rotation;
	VCar11.transform.rotation.z = 0;
	VCar11.transform.rotation.x = 0;
	VCar11.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar11.rigidbody.constraints = RigidbodyConstraints.None;
	}
	if (other.gameObject.name == "CarAiWaypointBased12"){
	VCar12.transform.position = Waypoint12.transform.position;
	VCar12.transform.rotation = Waypoint12.transform.rotation;
	VCar12.transform.rotation.z = 0;
	VCar12.transform.rotation.x = 0;
	VCar12.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	yield WaitForSeconds(2);
	VCar12.rigidbody.constraints = RigidbodyConstraints.None;
	}
}