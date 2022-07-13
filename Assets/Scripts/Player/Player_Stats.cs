using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//changes
public class Player_Stats : MonoBehaviour
{
    public Player_Storage storage;
    public Image panel;

    void Start() {
        storage.mental_health = 1f;
    }

    void Update(){
        if(storage.mental_health > 0){
            storage.mental_health -= 0.001f;
            panel.fillAmount = storage.mental_health;
        }
    }
}
