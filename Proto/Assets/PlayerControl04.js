#pragma strict


var pX=0;
var pY=0;
var xmax=2;
var ymax=2;
function Update () {
          
                      transform.position=GlobalLogic.window[pX,pY].transform.position;
                     
}
function OnGUI () {
       if((pY<ymax-1))   
          { 
                     if(Event.current.Equals (Event.KeyboardEvent ("w")))
                     {
                      
                      pY++;
                     } 
                     
           }
           if(pY>0)
           {
                     if(Event.current.Equals (Event.KeyboardEvent ("s")))
                     {
                      
                      pY--;
                     }
                     
          }
          if((pX>0))   
          {      
                     if(Event.current.Equals (Event.KeyboardEvent ("a")))
                     {
                      
                      pX--;
                     }
                     
                     }
           if((pX<xmax-1))
           {
                     if(Event.current.Equals (Event.KeyboardEvent ("d")))
                     {
  
                      pX++;
                     }
          }
         
    }