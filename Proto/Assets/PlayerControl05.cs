using UnityEngine;
using System.Collections;

public class PlayerControl05 : MonoBehaviour
{

    // Use this for initialization
    int pX = 0;
    int pY = 0;
    int xmax = GlobalLogic02.wX;
    int ymax = GlobalLogic02.wY;

    void Update()
    {
        transform.position = GlobalLogic02.window [pX, pY].transform.position+new Vector3(0,0,-4);
        GlobalLogic02.curX = pX;
        GlobalLogic02.curY = pY;        
    }

    void OnGUI()
    {
        if ((pY < ymax - 1))
        { 
            if (Event.current.Equals(Event.KeyboardEvent("w")))
            {                
                pY++;
            }             
        }
        if (pY > 0)
        {
            if (Event.current.Equals(Event.KeyboardEvent("s")))
            {                
                pY--;
            }            
        }
        if ((pX > 0))
        {      
            if (Event.current.Equals(Event.KeyboardEvent("a")))
            {                
                pX--;
            }            
        }
        if ((pX < xmax - 1))
        {
            if (Event.current.Equals(Event.KeyboardEvent("d")))
            {                
                pX++;
            }
        }        
    }
}
