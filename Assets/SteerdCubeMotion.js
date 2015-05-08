#pragma strict

var speed : float = 5;
//var minimumDistance : float = 20;
var target : Transform;

function Update () {
	var offsetTargetPosition = target.position + Random.onUnitSphere * 2;
	var moveDirection = offsetTargetPosition - transform.position;
	transform.forward = moveDirection.normalized;
// transform.LookAt(target);

  transform.position += transform.forward * speed * Time.deltaTime;
//if(Vector3.Distance(transform.position, target.position) >minimumDistance){

//  transform.position += moveDirection.normalized * speed * Time.deltaTime;}
}