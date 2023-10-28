using UnityEngine;
using System.Collections;
using SVGImporter;
using UnityEngine.UI;

public class Notes : MonoBehaviour {
	public SVGAsset img1;
	public SVGAsset img2;
	public SVGAsset img3;
	public SVGAsset img4;
	public SVGAsset img5;
	public SVGAsset img6;
	public SVGAsset img7;
	public SVGAsset img8;
	public SVGAsset img9;
	public SVGAsset img10;
	public SVGAsset img11;
	public SVGAsset img12;
	public SVGAsset img13;
	public SVGAsset img14;
	public float id;
	public float centroidx;
	public float centroidy;
	public float pointx;
	public float pointy;
	public float timer;
	private Shape shape;
	private float halfpointx;
	private float halfpointy;
	private float time;

	void Start () {
		transform.localScale = new Vector3(1, 1, 1);
		shape = GameObject.Find ("Shape").GetComponent<Shape>();
		halfpointx = (centroidx + pointx) / 2;
		halfpointy = (centroidy + pointy) / 2;
		timer = Time.time - timer;
		int random = Random.Range (1, 15);
		if(random == 1){
			GetComponent<SVGImage> ().vectorGraphics = img1;
		}
		else if(random == 2){
			GetComponent<SVGImage> ().vectorGraphics = img2;
		}
		else if(random == 3){
			GetComponent<SVGImage> ().vectorGraphics = img3;
		}
		else if(random == 4){
			GetComponent<SVGImage> ().vectorGraphics = img4;
		}
		else if(random == 5){
			GetComponent<SVGImage> ().vectorGraphics = img5;
		}
		else if(random == 6){
			GetComponent<SVGImage> ().vectorGraphics = img6;
		}
		else if(random == 7){
			GetComponent<SVGImage> ().vectorGraphics = img7;
		}
		else if(random == 8){
			GetComponent<SVGImage> ().vectorGraphics = img8;
		}
		else if(random == 9){
			GetComponent<SVGImage> ().vectorGraphics = img9;
		}
		else if(random == 10){
			GetComponent<SVGImage> ().vectorGraphics = img10;
		}
		else if(random == 11){
			GetComponent<SVGImage> ().vectorGraphics = img11;
		}
		else if(random == 12){
			GetComponent<SVGImage> ().vectorGraphics = img12;
		}
		else if(random == 13){
			GetComponent<SVGImage> ().vectorGraphics = img13;
		}
		else if(random == 14){
			GetComponent<SVGImage> ().vectorGraphics = img14;
		}
		if (timer < 0.49f){
			StartCoroutine (Wait ());
		}
		else {
			time = Time.time - timer;
		}
	}

	void Update () {
		if(id == 1 && shape.point1enabled != 2){
			Destroy (gameObject);
		}
		else if(id == 2 && shape.point2enabled != 2){
			Destroy (gameObject);
		}
		else if(id == 3 && shape.point3enabled != 2){
			Destroy (gameObject);
		}
		else if(id == 4 && shape.point4enabled != 2){
			Destroy (gameObject);
		}
		else if(id == 5 && shape.point5enabled != 2){
			Destroy (gameObject);
		}
		else if(id == 6 && shape.point6enabled != 2){
			Destroy (gameObject);
		}
		else if(id == 7 && shape.point7enabled != 2){
			Destroy (gameObject);
		}
		else if(id == 8 && shape.point8enabled != 2){
			Destroy (gameObject);
		}
		if((Time.time - time)*2 >= 1 && time != 0){
			Destroy (gameObject);
		}
		else if (time != 0){
			if(GetComponent<SVGImage> ().enabled == false){
				GetComponent<SVGImage> ().enabled = true;
			}
			GetComponent<RectTransform>().localPosition = Vector3.Lerp (new Vector3(halfpointx, halfpointy, 0), new Vector3(pointx, pointy, 0), (Time.time - time)*2);
		}
	}

	IEnumerator Wait (){
		yield return  new WaitForSeconds (0.5f);
		time = Time.time;
	}
}
