using UnityEngine;
using System.Collections;

public class skiptohotel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        Application.LoadLevel("hotel01");
    }
}
