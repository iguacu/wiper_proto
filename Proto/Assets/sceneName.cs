using UnityEngine;
using System.Collections;

public class sceneName : MonoBehaviour {
    public int j=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
    void OnMouseDown()
    {
        GlobalLogic02.currentSceneStage [0]++;
        if (name == "Room_Danielle_ID_R")
        {
            GlobalLogic02.nameofActor = "Danielle";
           
        } else if (name == "Room_Linda_ID_R")
        {
            GlobalLogic02.nameofActor = "Linda Lee";

        }
        Application.LoadLevel("hotel01");
    }
}
