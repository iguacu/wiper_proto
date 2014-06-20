using UnityEngine;
using System.Collections;

public class returnOutside : MonoBehaviour {
    bool sceneSuccess=false;
    string Level="Room 0"+GlobalLogic02.curScene+"0"+GlobalLogic02.currentSceneStage[GlobalLogic02.curScene];	
	void OnMouseDown()
	{
        if (sceneSuccess)
        {
            GlobalLogic02.currentSceneStage [GlobalLogic02.curScene]++;
        }

		Application.LoadLevel (Level);
	}
}
