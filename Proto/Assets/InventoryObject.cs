using UnityEngine;
using System.Collections;

public class InventoryObject : MonoBehaviour {

    public enum ItemIndex {gun, pen, paper};
    public ItemIndex itemIndex;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) )
        {
            Vector3 posFor2D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit2D = Physics2D.Raycast(posFor2D, Vector2.zero);
            if (hit2D != null && hit2D.collider != null)
            {
                if(hit2D.collider.gameObject == this.gameObject)
                {
                    if(itemIndex == ItemIndex.gun)
                    {
                        Debug.Log("You clicked gun!");
                    }
                    else if(itemIndex == ItemIndex.pen)
                    {
                        Debug.Log("You clicked nothing");
                    }
                    else if(itemIndex == ItemIndex.paper)
                   {
                        Debug.Log("You clicked nothing");
                    }
                }
                
                
            }
        }
	}
}
