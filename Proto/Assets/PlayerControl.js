#pragma strict
var speed=10;
var xmove=true;
var ymove=true;
//var col : Array;
//var row : Array;
var pw=1;
var ph=1;
var wind_w=0.4;
var wind_h=0.3;
var x1=-4.37602;
var x2=-2.91359;
var y1=-4.80434;
var y2=-3.98713;
function xMove()
{
  if(((transform.position.x<=x1+wind_w/2)&&(transform.position.x>=x1-wind_w/2))||((transform.position.x<=x2+wind_w/2)&&(transform.position.x>=x2-wind_w/2)))
  {
  xmove=true; 
  }
  
}
function yMove()
{
  if(((transform.position.y<=y1+wind_h/2)&&(transform.position.y>=y1-wind_h/2))||((transform.position.y<=y2+wind_h/2)&&(transform.position.y>=y2-wind_h/2)))
  {
  ymove=true; 
  } 
  
}

function Update () {
          xMove();
          yMove();


           if(xmove)
           {
                     if(Input.GetKey(KeyCode.W))
                     {
                      transform.position.y+=speed*Time.deltaTime;
                     } 
                     if(Input.GetKey(KeyCode.S))
                     {
                      transform.position.y-=speed*Time.deltaTime;
                     }
           }
           if(ymove)
           {
                     if(Input.GetKey(KeyCode.A))
                     {
                      transform.position.x-=speed*Time.deltaTime;
                     }
                     
                     if(Input.GetKey(KeyCode.D))
                     {
                      transform.position.x+=speed*Time.deltaTime;
                     }
           }
          xmove=false;
          ymove=false;
          xMove();
          yMove();
}

