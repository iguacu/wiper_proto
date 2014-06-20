#pragma strict
static var time;
static var money;
static var window : Transform[,]=new Transform[2,2];

function Start () {
money=0;
time=1;
          for(var i=0;i<2;i++)
          {
                    for(var j=0;j<2;j++)
                    {
                              window[i,j]=GameObject.Find("Window "+(j+1)+"0"+(i+1)).transform;
                    }
          }
}

function Update () {

}