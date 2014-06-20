using UnityEngine;
using System.Collections;

public class returnOutside : MonoBehaviour {
    bool sceneSuccess=false;
    public string Level="hotel01";	
	void OnMouseDown()
	{
       
		Application.LoadLevel (Level);
	}
}
