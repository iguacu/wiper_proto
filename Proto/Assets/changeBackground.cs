using UnityEngine;
using System.Collections;

public class changeBackground : MonoBehaviour {

    public Transform target;
    Sprite img;
    SpriteRenderer myRenderer;
    float count;
   // Shader shaderGUItext;
   // Shader shaderSpritesDefault;
	// Use this for initialization
	void Start () {
        img = gameObject.GetComponent<SpriteRenderer>().sprite;
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        //shaderGUItext = Shader.Find("GUI/Text_Shader");
        //shaderSpritesDefault = Shader.Find("Sprites/Default");
        count = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
        int min = GlobalLogic02.min;
        int hour = GlobalLogic02.hour-8;
        count=hour*60+min;
        changeColor();
        target.position=new Vector3(12.0f*Mathf.Cos(Mathf.PI*(600.0f-count)/600.0f),-4+9.0f*Mathf.Sin(Mathf.PI*(600.0f-count)/600.0f),target.position.z);
        //target.position = new Vector3(-10.0f + count * 10.0f / 300.0f, target.position.y, target.position.z);
	}
    void changeColor(){
        myRenderer.color=new Color(0.6f+1.8f*(count-300)*(count-300)/600/600,1.0f-2*(count-300)*(count-300)/600/600,1.0f-2*(count-300)*(count-300)/600/600);


    }
}
