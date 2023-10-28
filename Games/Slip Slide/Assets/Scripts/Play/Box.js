#pragma strict

var speed : float = 0.1;

function Start () {

}

function OnTriggerEnter2D(other : Collider2D) {
if (other.gameObject.tag == "Box") {
yield WaitForSeconds (0.1);
transform.position.x = other.transform.position.x;
transform.position.y = other.transform.position.y;
}
}

function OnCollisionEnter2D(collision : Collision2D) {
if (collision.gameObject.tag == "Ball") {
}
}