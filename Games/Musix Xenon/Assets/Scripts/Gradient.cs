using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Gradient : MonoBehaviour {

	public Material mat;
	public int gradientLayer = 7;
	private Mesh mesh;
	private GameObject gradientPlane;
	private Camera cam;
	private int colour = -1;
	private int colour1 = -1;
	private int colour2 = -1;
	public Color colorrel;
	private float time = 0f;
	private bool loaded;

	void Awake () {
		gameObject.name = "Controller1";
		if (GameObject.Find ("Controller") != null) {
			Gradient oldgradient = GameObject.Find ("Controller").GetComponent<Gradient> ();
			colour = oldgradient.colour;
			colour1 = oldgradient.colour1;
			Destroy (oldgradient.gameObject);
			Destroy (GameObject.Find("Gradient Cam"));
			Destroy (GameObject.Find("Gradient Plane"));
		}
		gameObject.name = "Controller";
		gradientLayer = Mathf.Clamp(gradientLayer, 0, 31);
		cam = GameObject.Find ("Main Camera").GetComponent<Camera>();
		cam.clearFlags = CameraClearFlags.Depth;
		cam.cullingMask = cam.cullingMask & ~(1 << gradientLayer);
		Camera gradientCam = new GameObject("Gradient Cam",typeof(Camera)).GetComponent<Camera>();
		gradientCam.gameObject.AddComponent<NotDestroy> ();
		gradientCam.depth = cam.depth-1;
		gradientCam.cullingMask = 1 << gradientLayer;

		mesh = new Mesh();
		mesh.vertices = new Vector3[4]
		{new Vector3(-100f, .577f, 1f), new Vector3(100f, .577f, 1f), new Vector3(-100f, -.577f, 1f), new Vector3(100f, -.577f, 1f)};

		mesh.triangles = new int[6] {0, 1, 2, 1, 3, 2};

		gradientPlane = new GameObject("Gradient Plane", typeof(MeshFilter), typeof(MeshRenderer));
		gradientPlane.AddComponent<NotDestroy> ();
		((MeshFilter)gradientPlane.GetComponent(typeof(MeshFilter))).mesh = mesh;
		gradientPlane.GetComponent<Renderer>().material = mat;
		gradientPlane.layer = gradientLayer;
		((MeshFilter)gradientPlane.GetComponent (typeof(MeshFilter))).mesh = mesh;
		if (colour == -1) {
			colour = Random.Range (1, 1147);
			colour1 = colour - 300;
			colour2 = colour - 150;
			if (colour1 < 0) {
				colour1 = 1146 + colour1;
			}
			if (colour2 < 0) {
				colour2 = 1146 + colour2;
			}
		}
	}

	void Update () {
		if(SceneManager.GetActiveScene().buildIndex == 2 && loaded == false){
			cam = GameObject.Find ("Main Camera").GetComponent<Camera>();
			cam.clearFlags = CameraClearFlags.Depth;
			cam.cullingMask = cam.cullingMask & ~(1 << gradientLayer);
			loaded = true;
		}
		if(SceneManager.GetActiveScene().buildIndex == 3 && loaded == true){
			cam = GameObject.Find ("Main Camera").GetComponent<Camera>();
			cam.clearFlags = CameraClearFlags.Depth;
			cam.cullingMask = cam.cullingMask & ~(1 << gradientLayer);
			loaded = false;
		}
		if (Time.time >= time) {
			time = Time.time + 0.01f;
			colour++;
			colour1++;
			colour2++;
			if (colour >= 1146) {
				colour = colour - 1146;
			}
			if (colour1 >= 1146) {
				colour1 = colour1 - 1146;
			}
			if(colour2 >= 1146){
				colour2 = colour2 - 1146;
			}
			colorrel = IntToColor (colour2);
			mesh.colors = new Color[4] { IntToColor(colour), IntToColor(colour), IntToColor(colour1), IntToColor(colour1) };
			((MeshFilter)gradientPlane.GetComponent (typeof(MeshFilter))).mesh = mesh;
		}
	}

	private Color IntToColor (int col) {
		int red = 0;
		int green = 0;
		int blue = 0;
		if (col >= 956) {
			red = 255;
			green = 64;
			blue = 1211 - col;
		}
		else if (col >= 765) {
			red = col - 702;
			green = 64;
			blue = 255;
		}
		else if (col >= 574) {
			red = 64;
			green = 829 - col;
			blue = 255;
		}
		else if (col >= 383) {
			red = 64;
			green = 255;
			blue = col - 320;
		}
		else if (col >= 192) {
			red = 447 - col;
			green = 255;
			blue = 64;
		}
		else if (col >= 0) {
			red = 255;
			green = col + 64;
			blue = 64;
		}
		Color colours = new Color(red/255f, green/255f, blue/255f);
		return colours;
	}
}