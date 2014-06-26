using UnityEngine;
using System.Collections;

public class ObjectDesc4 : MonoBehaviour {

    public string description ;
    public string[,] desc = new string[16, 2];
    public int objec;
    public bool switchOn = false;
    public bool switch1 = false;
    public Transform D1;
    public Transform D2;
    private Sprite img;
    private Sprite imgH;
    // Use this for initialization
    void Start()
    {

        desc [0, 0] = "carpet";       
        desc [1, 0] = "carpet2";
        desc [2, 0] = "chandlier";
        desc [3, 0] = "clock";
        desc [4, 0] = "drawer";
        desc [5, 0] = "drawer2";
        desc [6, 0] = "frame1";
        desc [7, 0] = "frame2";
        desc [8, 0] = "frame3";
        desc [9, 0] = "gun";
        desc [10, 0] = "hat";
        desc [11, 0] = "ink";
        desc [12, 0] = "sofa";
        desc [13, 0] = "stand";
        desc [14, 0] = "table";
        desc [15, 0] = "wine";

        desc [0, 1] = "Room_carpet";       
        desc [1, 1] = "Room_carpet2";
        desc [2, 1] = "Room_chandelier";
        desc [3, 1] = "Room_clock";
        desc [4, 1] = "Room_drawer1";
        desc [5, 1] = "Room_drawer2";
        desc [6, 1] = "Room_frame1";
        desc [7, 1] = "Room_frame2";
        desc [8, 1] = "Room_frame3";
        desc [9, 1] = "Room_gun";
        desc [10, 1] = "Room_hat";
        desc [11, 1] = "Room_ink";
        desc [12, 1] = "Room_sofa";
        desc [13, 1] = "Room_stand";
        desc [14, 1] = "Room_table";
        desc [15, 1] = "Room_wine";


        
        description = name;
        
        for (int i=0; i<16; i++)
        {
            if (name == desc [i, 0])
                objec = i;
        }
        description = desc [objec, 1];
        img=Resources.Load<Sprite>("gang room/"+desc[objec,0]);
        imgH = Resources.Load<Sprite>("gang room/" + desc [objec, 0] + "_highlighted");
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
    void OnMouseOver()
    {


        gameObject.GetComponent<SpriteRenderer>().sprite = imgH;
    }

    
    void OnMouseExit()
    {
        switchOn = false;
        gameObject.GetComponent<SpriteRenderer>().sprite = img;
    }
    
    void OnGUI()
    {
        if (switchOn)
        {
            GUI.Box(new Rect(Screen.width * 3 / 8, Screen.height * 3 / 8, Screen.width / 4, Screen.height / 4), description);
            
        }
        
    }
}
