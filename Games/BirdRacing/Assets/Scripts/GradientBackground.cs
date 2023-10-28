using UnityEngine;
using System.Collections;

public class GradientBackground : MonoBehaviour {
	
	public Color topColor;
	public Color bottomColor;
	public Color newColor;
	public int gradientLayer = 7;
	public DestroyAtGame DontDestroy;
	private Mesh mesh;
	private GameObject gradientPlane;
	private int colourswait = 0;
	private int colourswait1 = 0;
	private int randomcolour = 0;
	private float Colourtime = 0f;
	private float Colourtime1 = 0f;
	
	void Awake () {	
		gradientLayer = Mathf.Clamp(gradientLayer, 0, 31);
		if (!GetComponent<Camera>()) {
			Debug.LogError ("Must attach GradientBackground script to the camera");
			return;
		}
		
		GetComponent<Camera>().clearFlags = CameraClearFlags.Depth;
		GetComponent<Camera>().cullingMask = GetComponent<Camera>().cullingMask & ~(1 << gradientLayer);
		Camera gradientCam = new GameObject("Gradient Cam",typeof(Camera)).GetComponent<Camera>();
		gradientCam.depth = GetComponent<Camera>().depth-1;
		gradientCam.cullingMask = 1 << gradientLayer;
		
		mesh = new Mesh();
		mesh.vertices = new Vector3[4]
		{new Vector3(-100f, .577f, 1f), new Vector3(100f, .577f, 1f), new Vector3(-100f, -.577f, 1f), new Vector3(100f, -.577f, 1f)};
		
		mesh.colors = new Color[4] {topColor,topColor,bottomColor,bottomColor};
		
		mesh.triangles = new int[6] {0, 1, 2, 1, 3, 2};
		
		Material mat = new Material("Shader \"Vertex Color Only\"{Subshader{BindChannels{Bind \"vertex\", vertex Bind \"color\", color}Pass{}}}");
		gradientPlane = new GameObject("Gradient Plane", typeof(MeshFilter), typeof(MeshRenderer));
		
		((MeshFilter)gradientPlane.GetComponent(typeof(MeshFilter))).mesh = mesh;
		gradientPlane.GetComponent<Renderer>().material = mat;
		gradientPlane.layer = gradientLayer;
		while(colourswait != 3){
			colourswait = colourswait + 1;
			if(colourswait1 == 0){
				topColor = bottomColor;
				bottomColor = newColor;
			}
			colourswait1 = 0;
			randomcolour = Random.Range (1, 6);
			if(randomcolour == 1){
				newColor = new Color32(255,42,85,255);
			}
			else if(randomcolour == 2){
				newColor = new Color32(255,149,0,255);
			}
			else if(randomcolour == 3){
				newColor = new Color32(52,170,220,255);
			}
			else if(randomcolour == 4){
				newColor = new Color32(116,86,221,255);
			}
			if(bottomColor == newColor){
				colourswait = colourswait - 1;
				colourswait1 = 10;
			}
			mesh.colors = new Color[4] {topColor,topColor,bottomColor,bottomColor};
			((MeshFilter)gradientPlane.GetComponent (typeof(MeshFilter))).mesh = mesh;
		}
		colourswait = 0;
		gradientCam.gameObject.AddComponent (DontDestroy.GetType());
		gradientPlane.AddComponent (DontDestroy.GetType());
	}

	void Update () {
		if(colourswait == 0){
			colourswait = 10;
			if(colourswait1 == 0){
				topColor = bottomColor;
				bottomColor = newColor;
			}
			colourswait1 = 0;
			randomcolour = Random.Range (1, 5);
			if(randomcolour == 1){
				newColor = new Color32(255,42,85,255);
			}
			else if(randomcolour == 2){
				newColor = new Color32(255,149,0,255);
			}
			else if(randomcolour == 3){
				newColor = new Color32(52,170,220,255);
			}
			else if(randomcolour == 4){
				newColor = new Color32(95,60,216,255);
			}
			if(bottomColor != newColor){
				StartCoroutine(CWait());
				Colourtime = Time.time;
			}
			else if(bottomColor == newColor){
				colourswait = 0;
				colourswait1 = 10;
			}
		}
		if(bottomColor != newColor){
			Colourtime1 = Time.time - Colourtime;
			var topColor1 = Color.Lerp (topColor, bottomColor, Colourtime1 /4);
			var bottomColor1 = Color.Lerp (bottomColor, newColor, Colourtime1 /4);
			mesh.colors = new Color[4] {topColor1,topColor1,bottomColor1,bottomColor1};
			((MeshFilter)gradientPlane.GetComponent (typeof(MeshFilter))).mesh = mesh;
		}
	}

	IEnumerator CWait() {
		yield return new WaitForSeconds(8);
		colourswait = 0;
	}
	
}