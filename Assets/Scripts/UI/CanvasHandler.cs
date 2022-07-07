using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasHandler : MonoBehaviour
{
    public Button inventory;
    private bool inv_open = false;

    void Start()
    {
        inventory.onClick.AddListener(OpenInventory);
    }

    public void OpenInventory()
    {
        if(!inv_open) {
            inv_open = true;
            Debug.Log("opend");
        } else {
            inv_open = false;
            Debug.Log("closed");
        }
        
    }
    
}
