using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextDay : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        LevelController.instance.isEndGame();
    }
}
