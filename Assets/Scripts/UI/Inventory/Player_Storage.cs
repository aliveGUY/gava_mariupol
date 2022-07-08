using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player Storage")]
public class Player_Storage : ScriptableObject
{
    public List<Item> storage_items {get; set; }
}
