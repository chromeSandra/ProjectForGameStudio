

function Update () {
 if(Input.anyKeyDown){
 transform.position += transform.forward;
 transform.forward.x += 0.3;
 }
}