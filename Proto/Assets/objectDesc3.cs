using UnityEngine;
using System.Collections;

public class objectDesc3 : MonoBehaviour
{

    public string description ;
    public string[,] desc = new string[19, 2];
    public int objec;
    public bool switchOn = false;
    public bool switch1 = false;
    public Transform D1;
    public Transform D2;
    // Use this for initialization
    void Start()
    {
        desc [0, 0] = "Room_carpet";       
        desc [1, 0] = "Room_chair1";
        desc [2, 0] = "Room_chair2";
        desc [3, 0] = "Room_chandelier";
        desc [4, 0] = "Room_coushion1";
        desc [5, 0] = "Room_coushion2";
        desc [6, 0] = "Room_coushion3";
        desc [7, 0] = "Room_flower";
        desc [8, 0] = "Room_frame";
        desc [9, 0] = "Room_glass1";
        desc [10, 0] = "Room_glass2";
        desc [11, 0] = "Room_gun";
        desc [12, 0] = "Room_police_doc";
        desc [13, 0] = "Room_stand";
        desc [14, 0] = "Room_table";
        desc [15, 0] = "Room_table2";
        desc [16, 0] = "Room_TV";
        desc [17, 0] = "Room_window1";
        desc [18, 0] = "Room_window2";
        
        desc [0, 1] = "Room_carpet";       
        desc [1, 1] = "Room_chair1";
        desc [2, 1] = "Room_chair2";
        desc [3, 1] = "Room_chandelier";
        desc [4, 1] = "Room_coushion1";
        desc [5, 1] = "Room_coushion2";
        desc [6, 1] = "Room_coushion3";
        desc [7, 1] = "Room_flower";
        desc [8, 1] = "Room_frame";
        desc [9, 1] = "Room_glass1";
        desc [10, 1] = "Room_glass2";
        desc [11, 1] = "Room_gun";
        desc [12, 1] = "Room_police_doc";
        desc [13, 1] = "Room_stand";
        desc [14, 1] = "Room_table";
        desc [15, 1] = "Room_table2";
        desc [16, 1] = "Room_TV";
        desc [17, 1] = "Room_window1";
        desc [18, 1] = "Room_window2";
        
        
        description = name;
        
        for (int i=0; i<19; i++)
        {
            if (name == desc [i, 0])
                objec = i;
        }
        description = desc [objec, 1];
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        if (!(objec == 11 || objec == 12))
        {
            switchOn = !switchOn;
        }
        else if (objec == 12 && !switch1)
        {
            D1.position = new Vector3(D1.position.x, D1.position.y, -7);
            D2.position = new Vector3(D2.position.x, D2.position.y, -6);
            switch1 = true;
        } 
        else if (objec == 12 && switch1)
        {
            D1.position = new Vector3(D1.position.x, D1.position.y, 10);
            D2.position = new Vector3(D2.position.x, D2.position.y, 11);
            switch1 = false;
        } else if (objec == 11)
        {

        }
        
        
    }

    void OnMouseExit()
    {
        switchOn = false;
    }
    
    void OnGUI()
    {
        if (switchOn)
        {
            GUI.Box(new Rect(Screen.width * 3 / 8, Screen.height * 3 / 8, Screen.width / 4, Screen.height / 4), description);
            
        }
        
    }
}
