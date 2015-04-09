#pragma strict



function OnMouseDown (){
   transform.localScale.y = 0.2;
   Debug.Log("HI");
}

function OnMouseUp(){
   transform.localScale.y = 0.6;

}