using UnityEngine;
using System.Collections;

public class RoomClick02 : MonoBehaviour {
    string Level="window";
    public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var tf=((transform.position.x+transform.lossyScale.x*5>=target.position.x)&&(transform.position.x-transform.lossyScale.x*5<=target.position.x)
                &&(transform.position.y+transform.lossyScale.y*5>=target.position.y)&&(transform.position.y-transform.lossyScale.y*5<=target.position.y));
        
        if(tf&&Input.GetKey(KeyCode.Space))
            Application.LoadLevel(Level);
	}
}
