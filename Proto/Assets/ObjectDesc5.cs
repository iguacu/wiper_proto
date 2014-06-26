using UnityEngine;
using System.Collections;

public class ObjectDesc5 : MonoBehaviour {
    public string description ;
    public string[,] desc = new string[10, 2];
    public int objec;
    public bool switchOn = false;
    public bool switch1 = false;
    public Transform D1;
    public Transform D2;
    public Sprite img;
    public Sprite imgH;

    // Use this for initialization
    void Start()
    {
        desc [0, 0] = "bed";       
        desc [1, 0] = "clock";
        desc [2, 0] = "cross";
        desc [3, 0] = "frame";
        desc [4, 0] = "guestlist";
        desc [5, 0] = "list";
        desc [6, 0] = "stand";
        desc [7, 0] = "table";
        desc [8, 0] = "TV";
        desc [9, 0] = "vodka";

        desc [0, 1] = "Room_bed";       
        desc [1, 1] = "Room_clock";
        desc [2, 1] = "Room_cross";
        desc [3, 1] = "Room_frame";
        desc [4, 1] = "Room_guestlist";
        desc [5, 1] = "Room_list";
        desc [6, 1] = "Room_stand";
        desc [7, 1] = "Room_table";
        desc [8, 1] = "Room_TV";
        desc [9, 1] = "Room_vodka";
        

        
        
        description = name;
        
        for (int i=0; i<10; i++)
        {
            if (name == desc [i, 0])
                objec = i;
        }
        description = desc [objec, 1];
        img=Resources.Load<Sprite>("master room/"+desc[objec,0]);
        imgH = Resources.Load<Sprite>("master room/" + desc [objec, 0] + "_highlighted");
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
