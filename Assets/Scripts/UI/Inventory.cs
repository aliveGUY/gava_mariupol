using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Player_Storage storage;
    public Inventory_Display inventory;
    public GameObject Inventory_panel;
    public Button inventory_btn;
    private bool inv_open = false;
    
    void Start()
    {
        inventory_btn.onClick.AddListener(OpenInventory);
        inventory.Init(storage.storage_items);
            Debug.Log(inventory_btn);

    }

    public void AddItem(Item item) {
        storage.storage_items.Add(item);
        inventory.AddItem(item);
    }

    public void OpenInventory()
    {
        if(!inv_open) {
            Inventory_panel.SetActive(true);
            inv_open = true;
        } else {
            Inventory_panel.SetActive(false);
            inv_open = false;
        }
        
    }
}
