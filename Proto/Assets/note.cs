using UnityEngine;
using System.Collections;

public class note : MonoBehaviour {
    bool switchOn=false;

    private string textAreaString;

    // Use this for initialization
    void Start () {
        textAreaString = GlobalLogic02.note;
    }
    void OnGUI()
    {
        if (switchOn)
        {
            textAreaString = GUI.TextArea(new Rect(850, 150, 150, 150), textAreaString, 1000);
            GlobalLogic02.note = textAreaString;
        }
      
    }
	void OnMouseDown()
    {
        switchOn = !switchOn;
    }
	
	// Update is called once per frame
	void Update () {
  
	}
}
