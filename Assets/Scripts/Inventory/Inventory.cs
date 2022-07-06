using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Player_Storage storage;
    public Inventory_Display InventoryPrefab;
    private Inventory_Display inventory;
    
    void Start()
    {
        inventory = (Inventory_Display)Instantiate(InventoryPrefab);
        inventory.Init(storage.storage_items);
    }

    public void AddItem(Item item) {
        storage.storage_items.Add(item);
        inventory.AddItem(item);
    }
}
