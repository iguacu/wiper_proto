#pragma strict
var Level="hotel01";

function Update () {
if(Input.GetKey(KeyCode.Tab))
     Application.LoadLevel(Level);
}