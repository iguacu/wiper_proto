using UnityEngine;
using System.Collections;

public class objectDesc : MonoBehaviour
{
    public string description ;
    public string[,] desc = new string[18, 2];
    public int objec;
    public bool switchOn = false;
    public Transform D1;
    public Transform D2;
    public Transform D3;
    // Use this for initialization
    void Start()
    {
        desc [0, 0] = "Room_bed";       
        desc [1, 0] = "Room_book";
        desc [2, 0] = "Room_carpet";
        desc [3, 0] = "Room_chair";
        desc [4, 0] = "Room_desk";
        desc [5, 0] = "Room_drobe";
        desc [6, 0] = "Room_flower";
        desc [7, 0] = "Room_frame1";
        desc [8, 0] = "Room_frame2";
        desc [9, 0] = "Room_ID";
        desc [10, 0] = "Room_stand";
        desc [11, 0] = "Room_sunglass";
        desc [12, 0] = "Room_table";
        desc [13, 0] = "Room_wine";
        desc [14, 0] = "Room_trashbin";

        desc [0, 1] = "Room_bed";
        desc [1, 1] = "Room_book";
        desc [2, 1] = "Room_carpet";
        desc [3, 1] = "Room_chair";
        desc [4, 1] = "Room_desk";
        desc [5, 1] = "Room_drobe";
        desc [6, 1] = "Room_flower";
        desc [7, 1] = "Room_frame1";
        desc [8, 1] = "Room_frame2";
        desc [9, 1] = "Room_ID";
        desc [10, 1] = "Room_stand";
        desc [11, 1] = "Room_sunglass";
        desc [12, 1] = "Room_table";
        desc [13, 1] = "Room_wine";
        desc [14, 1] = "Room_trashbin";
        description = name;
       
        for (int i=0; i<18; i++)
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
        if (!(objec == 14 || objec == 10))
        {
            switchOn = !switchOn;
        }
        else if (objec == 14)
        {
            D1.position = new Vector3(D1.position.x, D1.position.y, -7);
            D2.position = new Vector3(D2.position.x, D2.position.y, -7);

        } else if (objec == 10)
        {
            D3.position =new Vector3(D3.position.x,D3.position.y,-7);
        }
       
    }
    void OnMouseExit()
    {
        switchOn=false;
    }

    void OnGUI()
    {
        if (switchOn )
        {
            GUI.Box(new Rect(Screen.width*3 / 8, Screen.height*3 / 8, Screen.width / 4, Screen.height / 4), description);

        }

    }
}
