using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickable : MonoBehaviour
{
    public bool clicked {get; set; }
    public void OnMouseOver()
    {
        if(Input.GetMouseButton(0)){
            clicked = true;
        }
    }
}
