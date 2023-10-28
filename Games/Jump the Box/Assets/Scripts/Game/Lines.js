#pragma strict
var LinesLeft1 : GameObject;
var LinesRight1 : GameObject;

function Start () {
Lines();
}

function Lines () {
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.05;
LinesRight1.transform.position.y = -0.05;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.10;
LinesRight1.transform.position.y = -0.10;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.15;
LinesRight1.transform.position.y = -0.15;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.20;
LinesRight1.transform.position.y = -0.20;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.25;
LinesRight1.transform.position.y = -0.25;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.30;
LinesRight1.transform.position.y = -0.30;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.35;
LinesRight1.transform.position.y = -0.35;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.40;
LinesRight1.transform.position.y = -0.40;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.45;
LinesRight1.transform.position.y = -0.45;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.50;
LinesRight1.transform.position.y = -0.50;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.55;
LinesRight1.transform.position.y = -0.55;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.60;
LinesRight1.transform.position.y = -0.60;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.65;
LinesRight1.transform.position.y = -0.65;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.70;
LinesRight1.transform.position.y = -0.70;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.75;
LinesRight1.transform.position.y = -0.75;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.80;
LinesRight1.transform.position.y = -0.80;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.85;
LinesRight1.transform.position.y = -0.85;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.90;
LinesRight1.transform.position.y = -0.90;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = -0.95;
LinesRight1.transform.position.y = -0.95;
yield WaitForSeconds (0.01);
LinesLeft1.transform.position.y = 0;
LinesRight1.transform.position.y = 0;
LinesRepeat();
}

function LinesRepeat () {
Lines();
}