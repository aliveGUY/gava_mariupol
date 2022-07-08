using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Item")]
public class Item : ScriptableObject
{
    public string Name;
    public Sprite sprite;
}
