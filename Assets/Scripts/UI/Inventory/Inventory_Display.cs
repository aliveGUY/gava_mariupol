using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Display : MonoBehaviour
{
    public Transform targetTransform;
    public Item_Display itemDisplayPrefab;
    
    public void Init(List<Item> items){
        foreach(Item item in items){
            Item_Display display = (Item_Display)Instantiate(itemDisplayPrefab);
            display.transform.SetParent(targetTransform);
            display.Init(item);
        }
    }

    public void AddItem(Item item){
        Item_Display display = (Item_Display)Instantiate(itemDisplayPrefab);
        display.transform.SetParent(targetTransform);
        display.Init(item);
    }
}
