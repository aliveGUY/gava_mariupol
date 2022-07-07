using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Player_Storage storage;
    public Inventory_Display InventoryPrefab;
    private Inventory_Display inventory;

    public GameObject test;
    public Button inventory_btn;
    private bool inv_open = false;
    
    void Start()
    {
        inventory_btn.onClick.AddListener(OpenInventory);

        inventory = (Inventory_Display)Instantiate(InventoryPrefab);
        inventory.Init(storage.storage_items);
    }

    public void AddItem(Item item) {
        storage.storage_items.Add(item);
        inventory.AddItem(item);
    }

    public void OpenInventory()
    {
        if(!inv_open) {
            test.SetActive(true);
            inv_open = true;
            Debug.Log("opend");
        } else {
            test.SetActive(false);
            inv_open = false;
            Debug.Log("closed");
        }
        
    }
}
