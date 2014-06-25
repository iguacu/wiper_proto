using UnityEngine;
using System.Collections;

public class ItemListButton : MonoBehaviour {

    bool isShowItemList = false;
    public GameObject ItemInventoryObject0; 
    public GameObject ItemInventoryObject1;
    public GameObject ItemInventoryObject2;

    // Use this for initialization
	void Start () {
	
	}

    void ShowItemList()
    {
        //already shown item inven -> go to false
        if (isShowItemList == true)
        {
            ItemInventoryObject0.SetActive(false);
            ItemInventoryObject1.SetActive(false);
            ItemInventoryObject2.SetActive(false);
            isShowItemList = false;
        } else
        {
            ItemInventoryObject0.SetActive(true);
            ItemInventoryObject1.SetActive(true);
            ItemInventoryObject2.SetActive(true);
            isShowItemList = true;
        }
    }
	
	// Update called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0) )
        {
            Vector3 posFor2D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit2D = Physics2D.Raycast(posFor2D, Vector2.zero);
            if (hit2D != null && hit2D.collider != null)
            {
                if(hit2D.collider.gameObject == this.gameObject)
                {
                    ShowItemList();
                    Debug.Log("fuck");
                }
                    
                    
            }
        }
  
    }
}
