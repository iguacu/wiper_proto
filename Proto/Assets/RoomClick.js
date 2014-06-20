#pragma strict
var Level="window";
var target : Transform;

function Update () {
var tf=((transform.position.x+transform.lossyScale.x*5>=target.position.x)&&(transform.position.x-transform.lossyScale.x*5<=target.position.x)
&&(transform.position.y+transform.lossyScale.y*5>=target.position.y)&&(transform.position.y-transform.lossyScale.y*5<=target.position.y));

if(tf&&Input.GetKey(KeyCode.Space))
     Application.LoadLevel(Level);
}

