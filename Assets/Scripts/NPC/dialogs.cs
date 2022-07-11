using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogs : MonoBehaviour
{
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed primary button.");
    }
}
