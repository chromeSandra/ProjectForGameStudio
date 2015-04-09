#pragma strict

function Start () {

}

function Update () {
    if(Input.anyKeyDown)
   { MoveCube();
    Debug.Log("BBBBBBBB");}
}

function MoveCube(){
   for(var i : float = -5; i < 5; i += 0.01){
   transform.position.x = i;
   
   yield WaitForSeconds(4);
  
    Debug.Log(i);
   }
}