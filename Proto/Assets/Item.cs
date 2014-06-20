using UnityEngine;
using System.Collections;


[System.Serializable]

public class Item {
	public string itemName;
	public int itemID;
	public string itemDesc;
	public Texture2D itemIcon;
	public ItemType itemType;

	public enum ItemType {
		core,
		side
	}

	public Item(string name, int id, string desc, ItemType type)
	{
		itemName = name;
		itemID = id;
		itemDesc = desc;
//		itemIcon = Resources.Load(Texture2D);
	    itemType = type;
	}
}
