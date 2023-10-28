#pragma strict

function OnCollisionEnter2D(other : Collision2D) {
if (other.gameObject.tag == "Object") {
Time.timeScale = 0.01;
yield WaitForSeconds (0.01);
Time.timeScale = 0.5;
}
}