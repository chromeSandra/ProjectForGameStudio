#pragma strict
var speed = 5.0f;
function Start () {
Debug.Log("I started;");
Debug.Log(1.0f/Time.deltaTime);
}

function Move(){
 transform.Translate(0, speed*Time.deltaTime, 0);
 
 }