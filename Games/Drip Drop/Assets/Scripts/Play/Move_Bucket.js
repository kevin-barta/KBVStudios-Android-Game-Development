#pragma strict

private var ray : Ray;
private var hit : RaycastHit;

function Update () {
	if(Input.GetMouseButton(0)){
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, hit)){
			if(hit.transform.name == "Bucketmove"){
			     transform.position.x = hit.point.x;
			}
		}
	}
}