using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SVGImporter;

public class LevelCreator : MonoBehaviour {

	public GameObject land0;
	public GameObject land1;
	public GameObject land2;
	public GameObject land3;
	public GameObject land4;
	public GameObject land5;
	public GameObject land6;
	public GameObject land7;
	private Ray ray;
	private RaycastHit hit;
	private Vector3 p = new Vector3 ();
	private Vector3 pOld = new Vector3 ();
	private Transform land;
	public List<Transform> landholder;
	public List<Transform> allLocations;
	public List<Transform> pieceLocations;

	private Color green = new Color(0, 1, 0, 0.5f);
	private Color blue = new Color(0, 0.5f, 1, 0.5f);

	// Use this for initialization
	void Start () {
		/*GameObject pg = GameObject.Find ("0,0");
		for(int i = 0; i < 20; i++){
			for(int j = 0; j < 20; j++){
				GameObject g1 = (GameObject)Instantiate (pg);
				g1.name = i + "," + j;
				g1.transform.transform.position = new Vector3 (i * 10, j * 10, 0);
				g1.transform.parent = GameObject.Find ("Locations").transform;
			}
		}*/
	}

	public void PieceStateChanged (){
		foreach (Transform t in allLocations) {
			t.transform.eulerAngles = Vector3.zero;
			t.GetComponent<SVGRenderer> ().color = green;
		}
		allLocations.Clear ();
		pieceLocations.Clear ();
		List<Vector2> allpos = new List<Vector2> ();
		List<Vector2> allarea = new List<Vector2> ();
		List<Vector3> allconnect = new List<Vector3> ();
		foreach (Transform t1 in landholder) {
			GetAllPieces (t1, ref allpos, ref allarea, ref allconnect);
		}
		foreach (Vector2 pos in allpos){
			ChangePiece(pos.x, pos.y, true);
		}
		foreach (Vector2 area in allarea){
			ChangePiece(area.x, area.y, false);
		}
		foreach (Vector3 connect in allconnect){
			ChangePiece(connect.x, connect.y, connect.z);
		}
	}

	private void ChangePiece (float tposx, float tposy, bool isPiece){
		try{
			Transform t = GameObject.Find (tposx + "," + tposy).transform;
			t.GetComponent<SVGRenderer>().color = Color.clear;
			allLocations.Add (t);
			if(isPiece){
				pieceLocations.Add(t);
			}
		}
		catch{
			
		}
	}

	private void ChangePiece (float tconx, float tcony, float tconz){
		try{
			Transform t = GameObject.Find (tconx + "," + tcony).transform;
			if(tconz == 0){
				t.GetComponent<SVGRenderer>().color = blue;
			}
			else if(tconz == 90){
				t.GetComponent<SVGRenderer>().color = new Color(1, 0, 0, 0.5f);
			}
			else if(tconz == 180){
				t.GetComponent<SVGRenderer>().color = new Color(1, 1, 0, 0.5f);
			}
			else if(tconz == 270){
				t.GetComponent<SVGRenderer>().color = new Color(1, 0, 1, 0.5f);
			}
			t.eulerAngles = new Vector3(0, 0, tconz);
			allLocations.Add (t);
		}
		catch{

		}
	}

	private void DeletePiece(List<Vector2> temppiece, bool isPiece){
		foreach (Vector2 v in temppiece) {
			try {
				Transform t = GameObject.Find (v.x + "," + v.y).transform;
				allLocations.Remove (t);
				if(isPiece){
					pieceLocations.Remove(t);
				}
				if (!allLocations.Contains (t)) {
					t.GetComponent<SVGRenderer> ().color = green;
					t.transform.eulerAngles = Vector3.zero;
				}
			}
			catch {
				
			}
		}
	}

	private void DeletePiece(List<Vector3> tempplaceable){
		foreach (Vector3 v in tempplaceable) {
			try {
				Transform t = GameObject.Find (v.x + "," + v.y).transform;
				allLocations.Remove (t);
				if (!allLocations.Contains (t)) {
					t.GetComponent<SVGRenderer> ().color = green;
					t.transform.eulerAngles = Vector3.zero;
				}
			}
			catch {

			}
		}
	}

	private void AddPiece(List<Vector2> temppiece, List<Vector2> temparea, List<Vector3> tempplaceable){
		foreach(Vector2 v in temppiece){
			ChangePiece(v.x, v.y, true);
		}
		foreach(Vector2 v in temparea){
			ChangePiece(v.x, v.y, false);
		}
		foreach(Vector3 v in tempplaceable){
			ChangePiece(v.x, v.y, v.z);
		}
	}

	/// <summary>
	/// Gets All Area Pieces.
	/// </summary>
	/// <param name="piece">The piece that your finding other piece positions with.</param>
	/// <param name="piecePos">All pieces positions that the piece takes up.</param>
	/// <param name="areaPos">All negative surrounding area that another piece cannot take up.</param>
	/// <param name="placeablePos">All connective piece locations relative to this piece.</param>
	public void GetAllPieces(Transform piece, ref List<Vector2> piecePos, ref List<Vector2> areaPos, ref List<Vector3> placeablePos){
		Vector2 tpos = new Vector2 (piece.position.x, piece.position.y);
		Vector3 rot = new Vector3(0, Mathf.RoundToInt(piece.eulerAngles.y), Mathf.RoundToInt(piece.eulerAngles.z));
		switch (piece.GetComponent<SVGRenderer> ().vectorGraphics.name) {
		case "land0":
			return;
		case "land1":
			if (rot.y == 0 && rot.z == 0 || rot.y == 180 && rot.z == 180) {
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 2));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1, 0));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1, 0));
			}
			else if(rot.z == 90){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 2));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 1, 90));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 1, 90));
			}
			else if(rot.y == 0 && rot.z == 180 || rot.y == 180 && rot.z == 0){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 2));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1, 180));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1, 180));
			}
			else if(rot.z == 270){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 2));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 1, 270));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 1, 270));
			}
			break;
		case "land2":
			if (rot.y == 0 && rot.z == 0 || rot.y == 180 && rot.z == 270) {
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 5) / 10), Mathf.RoundToInt ((tpos.y + 5) / 10), "U", 1));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 5) / 10), Mathf.RoundToInt ((tpos.y + 5) / 10), "L", 1));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 5) / 10), Mathf.RoundToInt ((tpos.y + 5) / 10), "DIA UR", 1, 180));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 5) / 10), Mathf.RoundToInt ((tpos.y + 5) / 10), "DIA DL", 1, 90));
			}
			else if(rot.y == 0 && rot.z == 90 || rot.y == 180 && rot.z == 180){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 5) / 10), Mathf.RoundToInt ((tpos.y - 5) / 10), "D", 1));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 5) / 10), Mathf.RoundToInt ((tpos.y - 5) / 10), "L", 1));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 5) / 10), Mathf.RoundToInt ((tpos.y - 5) / 10), "DIA UL", 1, 270));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 5) / 10), Mathf.RoundToInt ((tpos.y - 5) / 10), "DIA DR", 1, 180));
			}
			else if(rot.y == 0 && rot.z == 180 || rot.y == 180 && rot.z == 90){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 5) / 10), Mathf.RoundToInt ((tpos.y - 5) / 10), "D", 1));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 5) / 10), Mathf.RoundToInt ((tpos.y - 5) / 10), "R", 1));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 5) / 10), Mathf.RoundToInt ((tpos.y - 5) / 10), "DIA UR", 1, 270));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 5) / 10), Mathf.RoundToInt ((tpos.y - 5) / 10), "DIA DL", 1, 0));
			}
			else if(rot.y == 0 && rot.z == 270 || rot.y == 180 && rot.z == 0){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 5) / 10), Mathf.RoundToInt ((tpos.y + 5) / 10), "U", 1));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 5) / 10), Mathf.RoundToInt ((tpos.y + 5) / 10), "R", 1));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 5) / 10), Mathf.RoundToInt ((tpos.y + 5) / 10), "DIA UL", 1, 0));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 5) / 10), Mathf.RoundToInt ((tpos.y + 5) / 10), "DIA DR", 1, 90));
			}
			break;
		case "land3":
			if (rot.y == 0 && rot.z == 0 || rot.y == 180 && rot.z == 270) {
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 2));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 2));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1, 0));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 1, 270));
			}
			else if(rot.y == 0 && rot.z == 90 || rot.y == 180 && rot.z == 180){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 2));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 2));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1, 0));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 1, 90));
			}
			else if(rot.y == 0 && rot.z == 180 || rot.y == 180 && rot.z == 90){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 2));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 2));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1, 180));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 1, 90));
			}
			else if(rot.y == 0 && rot.z == 270 || rot.y == 180 && rot.z == 0){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 2));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1));
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 2));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1, 180));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 1, 270));
			}
			break;
		case "land4":
			if (rot.y == 0 && rot.z == 0 || rot.y == 180 && rot.z == 180) {
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 2));
				if (rot.y == 0) {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1, 0));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1, 0));
				}
				else {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1, 0));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1, 0));
				}
			}
			else if(rot.y == 0 && rot.z == 90 || rot.y == 180 && rot.z == 90){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 2));
				if(rot.y == 0){
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 1, 90));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1, 90));
				}
				else{
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 1, 90));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1, 90));
				}
			}
			else if(rot.y == 0 && rot.z == 180 || rot.y == 180 && rot.z == 0){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 2));
				if (rot.y == 0) {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1, 180));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1, 180));
				}
				else {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1, 180));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1, 180));
				}
			}
			else if(rot.y == 0 && rot.z == 270 || rot.y == 180 && rot.z == 270){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 2));
				if (rot.y == 0) {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 1, 270));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1, 270));
				}
				else {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 1, 270));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1, 270));
				}
			}
			break;
		case "land5":
			if (rot.y == 0 && rot.z == 0 || rot.y == 180 && rot.z == 270) {
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1));
				if (rot.y == 0) {
					placeablePos.AddRange (GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1, 0));
					placeablePos.AddRange (GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1, 0));
				}
				else {
					placeablePos.AddRange (GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1, 270));
					placeablePos.AddRange (GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1, 270));
				}
			}
			else if(rot.y == 0 && rot.z == 90 || rot.y == 180 && rot.z == 180){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1));
				if (rot.y == 0) {
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1, 90));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1, 90));
				}
				else {
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1, 0));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1, 0));
				}

			}
			else if(rot.y == 0 && rot.z == 180 || rot.y == 180 && rot.z == 90){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1));
				if (rot.y == 0) {
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1, 180));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1, 180));
				}
				else {
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1, 90));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1, 90));
				}
			}
			else if(rot.y == 0 && rot.z == 270 || rot.y == 180 && rot.z == 0){
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1));
				if (rot.y == 0) {
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1, 270));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1, 270));
				}
				else {
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1, 180));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1, 180));
				}
			}

			if(rot.y == 0 && rot.z == 0){
				piecePos.Add(new Vector2(tpos.x / 10 + 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 + 1));
			}
			else if(rot.y == 0 && rot.z == 90){
				piecePos.Add(new Vector2(tpos.x / 10 - 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 + 1));
			}
			else if(rot.y == 0 && rot.z == 180){
				piecePos.Add(new Vector2(tpos.x / 10 - 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 - 1));
			}
			else if(rot.y == 0 && rot.z == 270){
				piecePos.Add(new Vector2(tpos.x / 10 + 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 - 1));
			}
			else if(rot.y == 180 && rot.z == 0){
				piecePos.Add(new Vector2(tpos.x / 10 - 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 + 1));
			}
			else if(rot.y == 180 && rot.z == 90){
				piecePos.Add(new Vector2(tpos.x / 10 + 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 + 1));
			}
			else if(rot.y == 180 && rot.z == 180){
				piecePos.Add(new Vector2(tpos.x / 10 + 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 - 1));
			}
			else if(rot.y == 180 && rot.z == 270){
				piecePos.Add(new Vector2(tpos.x / 10 - 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 - 1));
			}
			break;
		case "land6":
			if (rot.y == 0 && rot.z == 0 || rot.y == 180 && rot.z == 0) {
				if (rot.y == 0) {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y + 10) / 10), "L", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y + 10) / 10), "R", 1, 90));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y + 10) / 10), "DIA DL", 1, 90));
				}
				else {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y + 10) / 10), "R", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y + 10) / 10), "L", 1, 90));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y + 10) / 10), "DIA DR", 1, 90));
				}
			}
			else if(rot.y == 0 && rot.z == 90 || rot.y == 180 && rot.z == 270){
				if (rot.y == 0) {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 10) / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 10) / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1, 180));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 10) / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1, 180));
				}
				else {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 10) / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 10) / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1, 180));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x - 10) / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1, 180));
				}
			}
			else if(rot.y == 0 && rot.z == 180 || rot.y == 180 && rot.z == 180){
				if (rot.y == 0) {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y - 10) / 10), "R", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y - 10) / 10), "L", 1, 270));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y - 10) / 10), "DIA UR", 1, 270));
				}
				else {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y - 10) / 10), "L", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y - 10) / 10), "R", 1, 270));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt ((tpos.y - 10) / 10), "DIA UL", 1, 270));
				}
			}
			else if(rot.y == 0 && rot.z == 270 || rot.y == 180 && rot.z == 90){
				if (rot.y == 0) {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 10) / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 10) / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1, 0));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 10) / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1, 0));
				}
				else {
					areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 10) / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 10) / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1, 0));
					placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt ((tpos.x + 10) / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1, 0));
				}
			}

			if(rot.y == 0 && rot.z == 0){
				piecePos.Add(new Vector2(tpos.x / 10 + 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 + 1));
			}
			else if(rot.y == 0 && rot.z == 90){
				piecePos.Add(new Vector2(tpos.x / 10 - 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 + 1));
			}
			else if(rot.y == 0 && rot.z == 180){
				piecePos.Add(new Vector2(tpos.x / 10 - 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 - 1));
			}
			else if(rot.y == 0 && rot.z == 270){
				piecePos.Add(new Vector2(tpos.x / 10 + 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 - 1));
			}
			else if(rot.y == 180 && rot.z == 0){
				piecePos.Add(new Vector2(tpos.x / 10 - 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 + 1));
			}
			else if(rot.y == 180 && rot.z == 90){
				piecePos.Add(new Vector2(tpos.x / 10 + 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 + 1));
			}
			else if(rot.y == 180 && rot.z == 180){
				piecePos.Add(new Vector2(tpos.x / 10 + 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 - 1));
			}
			else if(rot.y == 180 && rot.z == 270){
				piecePos.Add(new Vector2(tpos.x / 10 - 1, tpos.y / 10));
				piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10 - 1));
			}
			break;
		case "land7":
			if (rot.y == 0 && rot.z == 0 || rot.y == 180 && rot.z == 270) {
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UL", 1));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1, 180));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 1, 90));
			}
			else if (rot.y == 0 && rot.z == 90 || rot.y == 180 && rot.z == 180) {
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DL", 1));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1, 180));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "L", 1, 270));
			}
			else if (rot.y == 0 && rot.z == 180 || rot.y == 180 && rot.z == 90) {
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA DR", 1));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "D", 1, 0));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 1, 270));
			}
			else if (rot.y == 0 && rot.z == 270 || rot.y == 180 && rot.z == 0) {
				areaPos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "DIA UR", 1));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "U", 1, 0));
				placeablePos.AddRange(GetRelativePieceLocation (Mathf.RoundToInt (tpos.x / 10), Mathf.RoundToInt (tpos.y / 10), "R", 1, 90));
			}
			break;
		}
		if (tpos.x % 10 != 0 && tpos.x % 10 != 0) {
			piecePos.Add(new Vector2((tpos.x + 5) / 10, (tpos.y + 5) / 10));
			piecePos.Add(new Vector2((tpos.x + 5) / 10, (tpos.y - 5) / 10));
			piecePos.Add(new Vector2((tpos.x - 5) / 10, (tpos.y + 5) / 10));
			tpos.x -= 5;
			tpos.y -= 5;
		}
		piecePos.Add(new Vector2(tpos.x / 10, tpos.y / 10));

	}

	/// <summary>
	/// Gets the relative piece location.
	/// </summary>
	/// <returns>The relative piece location.</returns>
	/// <param name="posx">The name of the pieces position in the x axis</param>
    /// <param name="posy">The name of the pieces position in the y axis</param>
	/// <param name="direction">The direction of the piece you are trying to find. (U, D, L, R, DIA)</param>
	/// <param name="distance">The distance between your piece and the piece you are trying to find.</param>
	private Vector2[] GetRelativePieceLocation (int posx, int posy, string direction, int distance){
		Vector2 [] allpos = new Vector2[distance];
		for (int i = 0; i < distance; i++) {
			switch (direction) {
			case "U":
				posy += 1;
				break;
			case "D":
				posy -= 1;
				break;
			case "L":
				posx -= 1;
				break;
			case "R":
				posx += 1;
				break;
			case "DIA UL":
				posx -= 1;
				posy += 1;
				break;
			case "DIA UR":
				posx += 1;
				posy += 1;
				break;
			case "DIA DL":
				posx -= 1;
				posy -= 1;
				break;
			case "DIA DR":
				posx += 1;
				posy -= 1;
				break;
			}
			allpos[i] = new Vector2(posx, posy);
		}
		return allpos;
	}

	/// <summary>
	/// Gets the relative piece location.
	/// </summary>
	/// <returns>The relative piece location.</returns>
	/// <param name="posx">The name of the pieces position in the x axis</param>
	/// <param name="posy">The name of the pieces position in the y axis</param>
	/// <param name="direction">The direction of the piece you are trying to find. (U, D, L, R, DIA)</param>
	/// <param name="distance">The distance between your piece and the piece you are trying to find.</param>
	/// <param name="facing">The rotation of the piece's black strip. (R = 0, U = 90, L = 180, D = 270)</param>
	private Vector3[] GetRelativePieceLocation (int posx, int posy, string direction, int distance, int facing){
		Vector3 [] allcon = new Vector3[distance];
		for (int i = 0; i < distance; i++) {
			switch (direction) {
			case "U":
				posy += 1;
				break;
			case "D":
				posy -= 1;
				break;
			case "L":
				posx -= 1;
				break;
			case "R":
				posx += 1;
				break;
			case "DIA UL":
				posx -= 1;
				posy += 1;
				break;
			case "DIA UR":
				posx += 1;
				posy += 1;
				break;
			case "DIA DL":
				posx -= 1;
				posy -= 1;
				break;
			case "DIA DR":
				posx += 1;
				posy -= 1;
				break;
			}
			allcon[i] = new Vector3(posx, posy, facing);
		}
		return allcon;
	}

	public bool PositionChecker (Transform landpiece){
		List<Vector2> temppiece = new List<Vector2> ();
		List<Vector2> temparea = new List<Vector2> ();
		List<Vector3> tempplaceable = new List<Vector3> ();
		GetAllPieces (landpiece, ref temppiece, ref temparea, ref tempplaceable);
		DeletePiece (temppiece, true);
		DeletePiece (temparea, false);
		DeletePiece (tempplaceable);
		Vector3 poschanged = (p - landpiece.position) / 10;
		foreach(Vector2 tpiece in temppiece){
			try{
				Transform t = GameObject.Find (Mathf.RoundToInt(tpiece.x  + poschanged.x) + "," + Mathf.RoundToInt(tpiece.y + poschanged.y)).transform;
				if (t.GetComponent<SVGRenderer> ().color == Color.clear) {
					AddPiece (temppiece, temparea, tempplaceable);
					return false;
				}
			}
			catch{
			
			}
		}
		foreach(Vector2 tarea in temparea){
			try{
				Transform t = GameObject.Find (Mathf.RoundToInt(tarea.x  + poschanged.x) + "," + Mathf.RoundToInt(tarea.y + poschanged.y)).transform;
				if (pieceLocations.Contains(t) && t.GetComponent<SVGRenderer> ().color == Color.clear) {
					AddPiece (temppiece, temparea, tempplaceable);
					return false;
				}
			}
			catch{

			}
		}
		/*foreach(Vector3 tplaceable in tempplaceable){
			try{
				Transform t = GameObject.Find (Mathf.RoundToInt(tplaceable.x  + poschanged.x) + "," + Mathf.RoundToInt(tplaceable.y + poschanged.y)).transform;
				validlocations.Remove (t);
				if (t.GetComponent<SVGRenderer> ().color == Color.clear) {
					AddPiece (temppiece, tempplaceable);
					return false;
				}
			}
			catch{
			
			}
		}*/
		/*switch (landpiece.GetComponent<SVGRenderer> ().vectorGraphics.name) {
		case "land0":
			return true;   
		case "land2": 
			if(GameObject.Find(Mathf.RoundToInt ((p.x + 5) / 10) + "," + Mathf.RoundToInt ((p.y + 5) / 10)).GetComponent<SVGRenderer>().color == Color.clear){
				AddPiece (temppiece, tempplaceable);
				return false;
			}
			else if(GameObject.Find(Mathf.RoundToInt ((p.x - 5) / 10) + "," + Mathf.RoundToInt ((p.y + 5) / 10)).GetComponent<SVGRenderer>().color == Color.clear){
				AddPiece (temppiece, tempplaceable);
				return false;
			}
			else if(GameObject.Find(Mathf.RoundToInt ((p.x + 5) / 10) + "," + Mathf.RoundToInt ((p.y - 5) / 10)).GetComponent<SVGRenderer>().color == Color.clear){
				AddPiece (temppiece, tempplaceable);
				return false;
			}
			else if(GameObject.Find(Mathf.RoundToInt ((p.x - 5) / 10) + "," + Mathf.RoundToInt ((p.y - 5) / 10)).GetComponent<SVGRenderer>().color == Color.clear){
				AddPiece (temppiece, tempplaceable);
				return false;
			}
			break;
		case "land5": case "land6":
			if(GameObject.Find(Mathf.RoundToInt ((p.x + 5) / 10) + "," + Mathf.RoundToInt ((p.y + 5) / 10)).GetComponent<SVGRenderer>().color == Color.clear){
				AddPiece (temppiece, tempplaceable);
				return false;
			}
			else if(GameObject.Find(Mathf.RoundToInt ((p.x - 5) / 10) + "," + Mathf.RoundToInt ((p.y + 5) / 10)).GetComponent<SVGRenderer>().color == Color.clear){
				AddPiece (temppiece, tempplaceable);
				return false;
			}
			else if(GameObject.Find(Mathf.RoundToInt ((p.x + 5) / 10) + "," + Mathf.RoundToInt ((p.y - 5) / 10)).GetComponent<SVGRenderer>().color == Color.clear){
				AddPiece (temppiece, tempplaceable);
				return false;
			}
			else if(GameObject.Find(Mathf.RoundToInt ((p.x - 5) / 10) + "," + Mathf.RoundToInt ((p.y - 5) / 10)).GetComponent<SVGRenderer>().color == Color.clear){
				AddPiece (temppiece, tempplaceable);
				return false;
			}
			break;
		default:
			//Color game = GameObject.Find (Mathf.RoundToInt (p.x / 10) + "," + Mathf.RoundToInt (p.y / 10)).GetComponent<SVGRenderer> ().color;
			//print (p.x + "," + p.y + "," + game.r + "," + game.g + "," + game.b + "," + game.a + "," + Time.time + "," + Time.frameCount);
			if(GameObject.Find(Mathf.RoundToInt (p.x / 10) + "," + Mathf.RoundToInt (p.y / 10)).GetComponent<SVGRenderer>().color == Color.clear){
				//print ("False: " + Time.time);
				AddPiece (temppiece, tempplaceable);
				return false;
			}
			break;
		}*/
		return true;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.S)){
			SaveLand ("test");
		}
		if(Input.GetKeyDown(KeyCode.L)){
			LoadLand ("test");
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.tag == "land") {
					hit.transform.eulerAngles = new Vector3(0, hit.transform.eulerAngles.y, hit.transform.eulerAngles.z + 90);
					PieceStateChanged ();
				}
			}
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.tag == "land") {
					hit.transform.eulerAngles = new Vector3(0, hit.transform.eulerAngles.y, hit.transform.eulerAngles.z - 90);
					PieceStateChanged ();
				}
			}
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.tag == "land") {
					hit.transform.eulerAngles = new Vector3(0, hit.transform.eulerAngles.y + 180, hit.transform.eulerAngles.z);
					PieceStateChanged ();
				}
			}
		}
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.tag == "land") {
					hit.transform.eulerAngles = new Vector3(0, hit.transform.eulerAngles.y - 180, hit.transform.eulerAngles.z);
					PieceStateChanged ();
				}
			}
		}
		if (Input.GetMouseButtonDown (0)) {
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.tag == "land") {
					land = hit.transform;
				}
			}
		}
		if (Input.GetMouseButtonUp (0)) {
			land = null;
		}
		if (Input.GetMouseButton (0)) {
			if (land != null) {
				bool landcoll = false;
				p = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y));
				for(int i = 0; i < land.childCount; i++)
				{
					Destroy(land.GetChild (i).gameObject);
				}
				List<RaycastHit> hits = new List<RaycastHit>();
				//hits.AddRange(Physics.RaycastAll(p, transform.forward, 1000f));
				/*switch (land.GetComponent<SVGRenderer> ().vectorGraphics.name) {
				case "land0":
					p.x = Mathf.Clamp (Mathf.RoundToInt (p.x / 10) * 10, 0, 190);
					p.y = Mathf.Clamp (Mathf.RoundToInt (p.y / 10) * 10, 0, 190);
					break;
				case "land2":
					p.x = Mathf.Clamp (Mathf.RoundToInt ((p.x - 10) / 10) * 10 + 5, 5, 185);
					p.y = Mathf.Clamp (Mathf.RoundToInt ((p.y - 10) / 10) * 10 + 5, 5, 185);
					hits.AddRange(Physics.RaycastAll(p, transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x, p.y + 5, p.z), transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x, p.y - 5, p.z), transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x + 5, p.y, p.z), transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x - 5, p.y, p.z), transform.forward, 1000f));
					break;
				case "land5":
					p.x = Mathf.Clamp (Mathf.RoundToInt (p.x / 10) * 10, 10, 190);
					p.y = Mathf.Clamp (Mathf.RoundToInt (p.y / 10) * 10, 10, 180);
					hits.AddRange(Physics.RaycastAll(p, transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x, p.y + 5, p.z), transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x, p.y - 5, p.z), transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x + 5, p.y, p.z), transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x - 5, p.y, p.z), transform.forward, 1000f));
					break;
				case "land6":
					p.x = Mathf.Clamp (Mathf.RoundToInt (p.x / 10) * 10, 10, 190);
					p.y = Mathf.Clamp (Mathf.RoundToInt (p.y / 10) * 10, 0, 180);
					hits.AddRange(Physics.RaycastAll(p, transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x, p.y + 5, p.z), transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x, p.y - 5, p.z), transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x + 5, p.y, p.z), transform.forward, 1000f));
					hits.AddRange (Physics.RaycastAll (new Vector3 (p.x - 5, p.y, p.z), transform.forward, 1000f));
					break;
				default:
					p.x = Mathf.Clamp (Mathf.RoundToInt (p.x / 10) * 10, 0, 190);
					p.y = Mathf.Clamp (Mathf.RoundToInt (p.y / 10) * 10, 0, 190);
					hits.AddRange(Physics.RaycastAll(p, transform.forward, 1000f));
					break;
				}
				foreach(RaycastHit hit in hits){
					if (hit.transform.tag == "land" && hit.transform != land)
						landcoll = true;
				}*/
				switch (land.GetComponent<SVGRenderer> ().vectorGraphics.name) {
				case "land0":
					break;   
				case "land2": 
					p.x = Mathf.Clamp (Mathf.RoundToInt ((p.x - 10) / 10) * 10 + 5, 5, 185);
					p.y = Mathf.Clamp (Mathf.RoundToInt ((p.y - 10) / 10) * 10 + 5, 5, 185);
					break;
				case "land5":
				case "land6":
					p.x = Mathf.Clamp (Mathf.RoundToInt (p.x / 10) * 10, 10, 180);
					p.y = Mathf.Clamp (Mathf.RoundToInt (p.y / 10) * 10, 10, 180);
					break;
				default:
					p.x = Mathf.Clamp (Mathf.RoundToInt (p.x / 10) * 10, 0, 190);
					p.y = Mathf.Clamp (Mathf.RoundToInt (p.y / 10) * 10, 0, 190);
					break;
				}
					
				if ((p.x != land.position.x || p.y != land.position.y) && PositionChecker (land) == true) {
					pOld = land.position;
					if (land.GetComponent<SVGRenderer> ().vectorGraphics.name != "land0") {
						p.z = 0;
					}
					else {
						p.z = 1;
					}
					land.position = p;
					PieceStateChanged ();
				}
				else
					print (2);
			}
		}
	}

	public void CreateLand (GameObject l){
		GameObject g = (GameObject)Instantiate (l);
		g.transform.parent = GameObject.Find ("LandHolder").transform;
		landholder.Add (g.transform);
		land = g.transform;
		if(l == land0){
			g.transform.position = new Vector3 (g.transform.position.x, g.transform.position.y, 1);
		}
		else{
			g.transform.position = new Vector3 (g.transform.position.x, g.transform.position.y, 0);
		}
		PieceStateChanged ();
	}

	public void SaveLand (string filename){
		string savedata = "";
		foreach(Transform child in landholder){
			switch(child.GetComponent<SVGRenderer>().vectorGraphics.name){
			case "land0":
				savedata += 0;
				break;
			case "land1":
				savedata += 1;
				break;
			case "land2":
				savedata += 2;
				break;
			case "land3":
				savedata += 3;
				break;
			case "land4":
				savedata += 4;
				break;
			case "land5":
				savedata += 5;
				break;
			case "land6":
				savedata += 6;
				break;
			case "land7":
				savedata += 7;
				break;
			}
			savedata += (child.transform.position.x / 5).ToString("00");
			savedata += (child.transform.position.y / 5).ToString("00");
			switch(Mathf.RoundToInt(child.eulerAngles.y)){
			case 0:
				savedata += 0;
				break;
			case 180:
				savedata += 1;
				break;
			}
			switch(Mathf.RoundToInt(child.eulerAngles.z)){
			case 0:
				savedata += 0;
				break;
			case 90:
				savedata += 1;
				break;
			case 180:
				savedata += 2;
				break;
			case 270:
				savedata += 3;
				break;
			}
			savedata += ",";
		}
		print (savedata.Substring(0, savedata.Length - 1));
		PlayerPref.SetString (filename, savedata.Substring(0, savedata.Length - 1));
	}

	public void LoadLand (string filename){
		string[] savedata = PlayerPref.GetString (filename).Split (',');
		foreach (string childdata in savedata) {
			GameObject g = null;
			int roty = 0;
			int rotz = 0;
			switch (int.Parse(childdata.Substring(0, 1))) {
			case 0:
				g = (GameObject)Instantiate (land0);
				break;
			case 1:
				g = (GameObject)Instantiate (land1);
				break;
			case 2:
				g = (GameObject)Instantiate (land2);
				break;
			case 3:
				g = (GameObject)Instantiate (land3);
				break;
			case 4:
				g = (GameObject)Instantiate (land4);
				break;
			case 5:
				g = (GameObject)Instantiate (land5);
				break;
			case 6:
				g = (GameObject)Instantiate (land6);
				break;
			case 7:
				g = (GameObject)Instantiate (land7);
				break;
			}
			if (int.Parse(childdata.Substring(0, 1)) == 0) {
				g.transform.position = new Vector3 (int.Parse (childdata.Substring (1, 2)) * 5, int.Parse (childdata.Substring (3, 2)) * 5, 1);
			}
			else {
				g.transform.position = new Vector3 (int.Parse (childdata.Substring (1, 2)) * 5, int.Parse (childdata.Substring (3, 2)) * 5, 0);
			}
			switch (int.Parse(childdata.Substring(5, 1))) {
			case 0:
				roty = 0;
				break;
			case 1:
				roty = 180;
				break;
			}
			switch (int.Parse(childdata.Substring(6, 1))) {
			case 0:
				rotz = 0;
				break;
			case 1:
				rotz = 90;
				break;
			case 2:
				rotz = 180;
				break;
			case 3:
				rotz = 270;
				break;
			}
			g.transform.eulerAngles = new Vector3 (0, roty, rotz);
			g.transform.parent = GameObject.Find ("LandHolder").transform;
			landholder.Add (g.transform);
		}
	}
}
