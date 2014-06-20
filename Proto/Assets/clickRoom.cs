using UnityEngine;
using System.Collections;

public class clickRoom : MonoBehaviour {

	public Transform target;
	
    void onMouseDown(){
		target.position = transform.position;
	}
}
