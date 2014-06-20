#pragma strict


var pX=0;
var pY=0;
var xmax=2;
var ymax=2;
function Update () {
          if((pY<ymax-1))   
          { 
                     if(Input.GetKey(KeyCode.W))
                     {
                      transform.position.y=GlobalLogic.window[pX,pY].transform.position.y;
                      pY++;
                     } 
                     
           }
           if(pY>0)
           {
                     if(Input.GetKey(KeyCode.S))
                     {
                      transform.position.y=GlobalLogic.window[pX,pY].transform.position.y;
                      pY--;
                     }
                     
          }
          if((pX>0))   
          {      
                     if(Input.GetKey(KeyCode.A))
                     {
                      transform.position.x=GlobalLogic.window[pX,pY].transform.position.x;
                      pX--;
                     }
                     
                     }
           if((pX<xmax-1))
           {
                     if(Input.GetKey(KeyCode.D))
                     {
                      transform.position.x=GlobalLogic.window[pX,pY].transform.position.x;
                      pX++;
                     }
          }
}
