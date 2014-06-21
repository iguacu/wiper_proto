using UnityEngine;
using System.Collections;

public class changeBackground : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        int min = GlobalLogic02.min;
        int hour = GlobalLogic02.hour-8;
        float count=hour*60+min;

        //target.position=new Vector3(10.0*Mathf.Cos(Mathf.PI*(600.0-count)/600.0),-5+10.0*Mathf.Cos(Mathf.PI*(600.0-count)/600.0),target.position.z);
        target.position = new Vector3(-10.0f + count * 10.0f / 300.0f, target.position.y, target.position.z);
	}
}
