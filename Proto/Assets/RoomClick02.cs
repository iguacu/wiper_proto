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
        
        if (tf && Input.GetKey(KeyCode.Space)&&GlobalLogic02.windowT[GlobalLogic02.curX,GlobalLogic02.curY])
        {
            GameObject.Find("Window " + (GlobalLogic02.curY + 1) + "0" + (GlobalLogic02.curX + 1)).GetComponent<SpriteRenderer>().sprite = GlobalLogic02.windowN1;
            Application.LoadLevel(Level);
        }
	}
}
