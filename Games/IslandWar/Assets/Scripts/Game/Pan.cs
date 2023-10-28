/*using UnityEngine;

public class Pan : MonoBehaviour
{
	public int LevelArea = 10;
	
	public int ScrollArea = 25;
	public int ScrollSpeed = 25;
	public int DragSpeed = 100;
	
	public int ZoomSpeed = 25;
	public int ZoomMin = 13;
	public int ZoomMax = 60;
	
	public int PanSpeed = 50;
	
	// Update is called once per frame
	void Update()
	{
		// Init camera translation for this frame.
		var translation = Vector2.zero;
		
		// Zoom in or out
		var zoomDelta = Input.GetAxis("Mouse ScrollWheel")*ZoomSpeed*Time.deltaTime;
		if (zoomDelta!=0)
		{
			translation -= Vector2.up * ZoomSpeed * zoomDelta;
		}
		
		// Start panning camera if zooming in close to the ground or if just zooming out.
		var pan = camera.transform.eulerAngles.x - zoomDelta * PanSpeed;
		if (zoomDelta < 0 || camera.transform.position.y < (ZoomMax / 2))
		{
			camera.transform.eulerAngles = new Vector2(pan, 0);
		}
		
		// Move camera with arrow keys
		translation += new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		
		// Move camera with mouse
		if (Input.GetMouseButton(2)) // MMB
		{
			// Hold button and drag camera around
			translation -= new Vector2(Input.GetAxis("Mouse X") * DragSpeed * Time.deltaTime, 
			                           Input.GetAxis("Mouse Y") * DragSpeed * Time.deltaTime);
		}
		else
		{
			// Move camera if mouse pointer reaches screen borders
			if (Input.mousePosition.x < ScrollArea)
			{
				translation += Vector2.right * -ScrollSpeed * Time.deltaTime;
			}
			
			if (Input.mousePosition.x >= Screen.width - ScrollArea)
			{
				translation += Vector2.right * ScrollSpeed * Time.deltaTime;
			}
			
			if (Input.mousePosition.y < ScrollArea)
			{
				translation += Vector2.up * -ScrollSpeed * Time.deltaTime;
			}
			
			if (Input.mousePosition.y > Screen.height - ScrollArea)
			{
				translation += Vector2.up * ScrollSpeed * Time.deltaTime;
			}
		}
		
		// Keep camera within level and zoom area
		var desiredPosition = camera.transform.position + translation;
		if (desiredPosition.x < -LevelArea || LevelArea < desiredPosition.x)
		{
			translation.x = 0;
		}
		if (desiredPosition.y < ZoomMin || ZoomMax < desiredPosition.y)
		{
			translation.y = 0;
		}
		
		// Finally move camera parallel to world axis
		camera.transform.localPosition += translation;
	}
}*/

using UnityEngine;
using System.Collections;

public class Pan : MonoBehaviour {

	public float speed = 0.01F;
	void Start () {
		PlayerPrefs.SetInt ("War", 0);
		PlayerPrefs.Save ();
	}
	void Update() {
		if(PlayerPrefs.GetInt("War") == 0){
				if (PlayerPrefs.GetInt ("Menu") == 0) {
						if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Moved) {
								Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
								transform.Translate (-touchDeltaPosition.x * speed / 10f, -touchDeltaPosition.y * speed / 10f, 0);
						}
						if (Input.GetKey ("up")) {
								transform.Translate (0, 1 * speed, 0);
						}
						if (Input.GetKey ("down")) {
								transform.Translate (0, -1 * speed, 0);
						}
						if (Input.GetKey ("left")) {
								transform.Translate (-1 * speed, 0, 0);
						}
						if (Input.GetKey ("right")) {
								transform.Translate (1 * speed, 0, 0);
						}
						if (transform.position.x > 6.8) {
								transform.position = new Vector3 (6.79f, transform.position.y, -10);
						}
						if (transform.position.x < -6.8) {
								transform.position = new Vector3 (-6.79f, transform.position.y, -10);
						}
						if (transform.position.y > 4.3) {
								transform.position = new Vector3 (transform.position.x, 4.29f, -10);
						}
						if (transform.position.y < -4.3) {
								transform.position = new Vector3 (transform.position.x, -4.29f, -10);
						}
				}
		}
}
}