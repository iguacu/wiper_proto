using UnityEngine;
using System.Collections;

public class returnOutside : MonoBehaviour {
    bool sceneSuccess=false;
    public string Level="hotel01";	
	void OnMouseDown()
	{
        GlobalLogic02.curMoney++;
		Application.LoadLevel (Level);
	}
}
