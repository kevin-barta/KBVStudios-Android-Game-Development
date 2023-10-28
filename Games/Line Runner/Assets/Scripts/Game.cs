using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SVGImporter;

public class Game : MonoBehaviour {
	public List<Transform> holder;
	public GameObject Holder;
	private Vector2 prevplayerlocation = new Vector2(0, 0);
	public bool xaxis;
	public bool yaxis;
	private bool lastxaxis;
	private bool lastyaxis;
	public int lastpausedx;
	public int lastpausedy;
	public Vector2 holderposition = new Vector2(0, 0);

	void Start () {
		//Create a bezel (black line) on screens larger than a aspect ratio of 2.
		int size;
		if((float)Screen.width / Screen.height > 1){
			size = Mathf.CeilToInt((GetComponent<Camera>().orthographicSize / ((float)Screen.height / Screen.width)) / 4);
		}
		else{
			size = Mathf.CeilToInt(GetComponent<Camera> ().orthographicSize / 4);
		}
		holderposition = new Vector2(size, size);

		GameObject pg = GameObject.Find ("0,0");
		for(int i = -size; i < size + 1; i++){
			for(int j = -size; j < size + 1; j++){
				GameObject g1 = (GameObject)Instantiate (pg);
				g1.name = i + "," + j;
				g1.transform.transform.position = new Vector3 (i * 10, j * 10, 0);
				g1.transform.parent = Holder.transform;
				if (j % 2 == 0 && i % 2 == 0) {
					g1.GetComponent<SVGRenderer> ().color = new Color (0, 0.5f, 1, 1);
				}
				else if (j % 2 == 0 && i % 2 != 0) {
					g1.GetComponent<SVGRenderer>().color = new Color(0, 0.4f, 1, 1);
				}
				else if (j % 2 != 0 && i % 2 == 0) {
					g1.GetComponent<SVGRenderer>().color = new Color(0, 0.4f, 1, 1);
				}
				else{
					g1.GetComponent<SVGRenderer>().color = new Color(0, 0.5f, 1, 1);
				}
			}
		}
		Destroy (pg);
		lastxaxis = xaxis;
		lastyaxis = yaxis;
	}

	void Update () {
		float tt = Time.deltaTime * 10;
		if (xaxis == true && yaxis == true) {
			transform.position = new Vector3 (transform.position.x + tt, transform.position.y + tt, -100);
			if (lastpausedx != Mathf.FloorToInt (transform.position.x) || lastpausedy != Mathf.FloorToInt (transform.position.y)) {
				if (Mathf.Abs(Mathf.FloorToInt (transform.position.x) % 10) == 5 && Mathf.Abs(Mathf.FloorToInt (transform.position.y) % 10) == 5) {
					lastpausedx = Mathf.FloorToInt (transform.position.x);
					lastpausedy = Mathf.FloorToInt (transform.position.y);
					transform.position = new Vector3 (lastpausedx, lastpausedy, -100);
					//UnityEditor.EditorApplication.isPaused = true;
				}
			}
		}
		else if (xaxis == false && yaxis == true) {
			transform.position = new Vector3 (transform.position.x - tt, transform.position.y + tt, -100);
			if (lastpausedx != Mathf.CeilToInt (transform.position.x) || lastpausedy != Mathf.FloorToInt (transform.position.y)) {
				if (Mathf.Abs(Mathf.CeilToInt (transform.position.x) % 10) == 5 && Mathf.Abs(Mathf.FloorToInt (transform.position.y) % 10) == 5) {
					lastpausedx = Mathf.CeilToInt (transform.position.x);
					lastpausedy = Mathf.FloorToInt (transform.position.y);
					transform.position = new Vector3 (lastpausedx, lastpausedy, -100);
					//UnityEditor.EditorApplication.isPaused = true;
				}
			}
		}
		else if (xaxis == true && yaxis == false) {
			transform.position = new Vector3 (transform.position.x + tt, transform.position.y - tt, -100);
			if (lastpausedx != Mathf.FloorToInt (transform.position.x) || lastpausedy != Mathf.CeilToInt (transform.position.y)) {
				if (Mathf.Abs(Mathf.FloorToInt (transform.position.x) % 10) == 5 && Mathf.Abs(Mathf.CeilToInt (transform.position.y) % 10) == 5) {
					lastpausedx = Mathf.FloorToInt (transform.position.x);
					lastpausedy = Mathf.CeilToInt (transform.position.y);
					transform.position = new Vector3 (lastpausedx, lastpausedy, -100);
					//UnityEditor.EditorApplication.isPaused = true;
				}
			}
		}
		else if (xaxis == false && yaxis == false) {
			transform.position = new Vector3 (transform.position.x - tt, transform.position.y - tt, -100);
			if (lastpausedx != Mathf.CeilToInt (transform.position.x) || lastpausedy != Mathf.CeilToInt (transform.position.y)) {
				if (Mathf.Abs(Mathf.CeilToInt (transform.position.x) % 10) == 5 && Mathf.Abs(Mathf.CeilToInt (transform.position.y) % 10) == 5) {
					lastpausedx = Mathf.CeilToInt (transform.position.x);
					lastpausedy = Mathf.CeilToInt (transform.position.y);
					transform.position = new Vector3 (lastpausedx, lastpausedy, -100);
					//UnityEditor.EditorApplication.isPaused = true;
				}
			}
		}
		lastxaxis = xaxis;
		lastyaxis = yaxis;

		if (Input.GetKey (KeyCode.RightArrow)) {
			if (xaxis == true && yaxis == true) {
				yaxis = false;
			}
			else if (xaxis == false && yaxis == true) {
				xaxis = true;
			}
			else if (xaxis == true && yaxis == false) {
				xaxis = false;
			}
			else if (xaxis == false && yaxis == false) {
				yaxis = true;
			}
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			if (xaxis == true && yaxis == true) {
				xaxis = false;
			}
			else if (xaxis == false && yaxis == true) {
				yaxis = false;
			}
			else if (xaxis == true && yaxis == false) {
				yaxis = true;
			}
			else if (xaxis == false && yaxis == false) {
				xaxis = true;
			}
		}


		int size;
		if((float)Screen.width / Screen.height > 1){
			size = Mathf.CeilToInt((GetComponent<Camera>().orthographicSize / ((float)Screen.height / Screen.width)) / 4);
		}
		else{
			size = Mathf.CeilToInt(GetComponent<Camera> ().orthographicSize / 4);
		}


		Vector2 playerdistance = new Vector2 (transform.position.x - prevplayerlocation.x, transform.position.y - prevplayerlocation.y);
		prevplayerlocation = new Vector2(transform.position.x, transform.position.y);
		if(playerdistance.x > 0 && playerdistance.y > 0){
			if(holderposition.x + 1 < (transform.position.x / 10) + size){
				BackgroundUpRight (size);
			}
		}
		else if(playerdistance.x < 0 && playerdistance.y > 0){
			if(holderposition.x - (size * 2) - 1 > (transform.position.x / 10) - size){
				BackgroundUpLeft (size);
			}
		}
		else if(playerdistance.x > 0 && playerdistance.y < 0){
			if(holderposition.x + 1 < (transform.position.x / 10) + size){
				BackgroundDownRight (size);
			}
		}
		else if(playerdistance.x < 0 && playerdistance.y < 0){
			if(holderposition.x - (size * 2) - 1 > (transform.position.x / 10) - size){
				BackgroundDownLeft (size);
			}
		}
	}

	private void BackgroundUpRight (int size){
		foreach(Transform child in Holder.transform){
			if (child.position.x / 10 == holderposition.x - (size * 2)) {
				child.position = new Vector3(child.position.x + (size * 20) + 10, child.position.y, 0);
				if (child.GetComponent<SVGRenderer> ().color == new Color (0, 0.5f, 1, 1)) {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.4f, 1, 1);
				}
				else {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.5f, 1, 1);
				}
			}
			if (child.position.y / 10 == holderposition.y - (size * 2)) {
				child.position = new Vector3(child.position.x, child.position.y + (size * 20) + 10, 0);
				if (child.GetComponent<SVGRenderer> ().color == new Color (0, 0.5f, 1, 1)) {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.4f, 1, 1);
				}
				else {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.5f, 1, 1);
				}
			}
		}
		holderposition.x++;
		holderposition.y++;
	}

	private void BackgroundUpLeft (int size){
		foreach(Transform child in Holder.transform){
			if (child.position.x / 10 == holderposition.x) {
				child.position = new Vector3(child.position.x - (size * 20) - 10, child.position.y, 0);
				if (child.GetComponent<SVGRenderer> ().color == new Color (0, 0.5f, 1, 1)) {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.4f, 1, 1);
				}
				else {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.5f, 1, 1);
				}
			}
			if (child.position.y / 10 == holderposition.y - (size * 2)) {
				child.position = new Vector3(child.position.x, child.position.y + (size * 20) + 10, 0);
				if (child.GetComponent<SVGRenderer> ().color == new Color (0, 0.5f, 1, 1)) {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.4f, 1, 1);
				}
				else {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.5f, 1, 1);
				}
			}
		}
		holderposition.x--;
		holderposition.y++;
	}

	private void BackgroundDownRight (int size){
		foreach(Transform child in Holder.transform){
			if (child.position.x / 10 == holderposition.x - (size * 2)) {
				child.position = new Vector3(child.position.x + (size * 20) + 10, child.position.y, 0);
				if (child.GetComponent<SVGRenderer> ().color == new Color (0, 0.5f, 1, 1)) {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.4f, 1, 1);
				}
				else {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.5f, 1, 1);
				}
			}
			if (child.position.y / 10 == holderposition.y) {
				child.position = new Vector3(child.position.x, child.position.y - (size * 20) - 10, 0);
				if (child.GetComponent<SVGRenderer> ().color == new Color (0, 0.5f, 1, 1)) {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.4f, 1, 1);
				}
				else {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.5f, 1, 1);
				}
			}
		}
		holderposition.x++;
		holderposition.y--;
	}

	private void BackgroundDownLeft (int size){
		foreach(Transform child in Holder.transform){
			if (child.position.x / 10 == holderposition.x) {
				child.position = new Vector3(child.position.x - (size * 20) - 10, child.position.y, 0);
				if (child.GetComponent<SVGRenderer> ().color == new Color (0, 0.5f, 1, 1)) {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.4f, 1, 1);
				}
				else {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.5f, 1, 1);
				}
			}
			if (child.position.y / 10 == holderposition.y) {
				child.position = new Vector3(child.position.x, child.position.y - (size * 20) - 10, 0);
				if (child.GetComponent<SVGRenderer> ().color == new Color (0, 0.5f, 1, 1)) {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.4f, 1, 1);
				}
				else {
					child.GetComponent<SVGRenderer> ().color = new Color (0, 0.5f, 1, 1);
				}
			}
		}
		holderposition.x--;
		holderposition.y--;
	}
}

