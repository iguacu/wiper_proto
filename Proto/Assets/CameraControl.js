#pragma strict

var target : Transform;
var distance = -10;
var lift = 0;

function Update () {
 transform.position=Vector3(target.position.x,-0.5,target.position.z)+ Vector3(0, lift, distance);
// transform.LookAt(target);
}