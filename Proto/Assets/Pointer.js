#pragma strict

var distance = -3;
var lift = 1.5;

function Update () {
 transform.position=Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
 Camera.main.ScreenToWorldPoint(Input.mousePosition).y,-3);
 Vector3(0, lift, distance);
// transform.LookAt(target);
}