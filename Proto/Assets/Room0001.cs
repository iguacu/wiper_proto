using UnityEngine;
using System.Collections;

public class Room0001 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    if (GlobalLogic02.nameofActor == "Danielle")
            Application.LoadLevel("ep0102");
        else Application.LoadLevel("ep0202");
    }
}
