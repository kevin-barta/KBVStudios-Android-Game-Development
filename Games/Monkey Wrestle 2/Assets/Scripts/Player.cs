using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public HingeJoint2D P1Foot;
	public HingeJoint2D P2Foot;

	void Start () {
		
	}

	//Build Up force by higher on the screen

	void Update () {
		if(Input.GetKeyDown(KeyCode.W)){
			JointMotor2D jm = P1Foot.motor;
			jm.motorSpeed = -1000;
			P1Foot.motor = jm;
		}
		else if(Input.GetKeyUp(KeyCode.W)){
			JointMotor2D jm = P1Foot.motor;
			jm.motorSpeed = 500;
			P1Foot.motor = jm;
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			JointMotor2D jm = P2Foot.motor;
			jm.motorSpeed = 1000;
			P2Foot.motor = jm;
		}
		else if(Input.GetKeyUp(KeyCode.UpArrow)){
			JointMotor2D jm = P2Foot.motor;
			jm.motorSpeed = -500;
			P2Foot.motor = jm;
		}
	}
}
