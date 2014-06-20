using UnityEngine;
using System.Collections;

public class returnOutside : MonoBehaviour {
    bool sceneSuccess=false;
    public string Level="hotel01";	
	void OnMouseDown()
	{
        if (sceneSuccess)
            GlobalLogic02.currentSceneStage [GlobalLogic02.curScene]++;

		Application.LoadLevel (Level);
	}
}
