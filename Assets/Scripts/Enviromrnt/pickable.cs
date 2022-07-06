using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickable : clickable
{
    [SerializeField] Item item; 
    [SerializeField] Inventory targetInventory;

    void OnTriggerEnter(Collider collider)
    {
        targetInventory.AddItem(item);
        Destroy(gameObject);
    }

    // Might delete later
    void FixedUpdate(){
        if(this.clicked){
            targetInventory.AddItem(item);
            Destroy(gameObject);
        }
    }
}
