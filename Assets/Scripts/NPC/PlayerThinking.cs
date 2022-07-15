using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThinking : MonoBehaviour
{
    public bool showMessage = false;
    ShowPlayerThink think;

    private void Start()
    {
        think = GetComponent<ShowPlayerThink>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && showMessage == true)
        {Debug.Log("У нас получилось!");
            think.DisplayDialog();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        showMessage = true;
    }

    private void OnTriggerExit(Collider other)
    {
        showMessage = false;
    }

}
