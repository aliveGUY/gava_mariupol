using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//changes
public class Player_Stats : MonoBehaviour
{
    public Player_Storage storage;
    public Image mental;
    public GameObject hunger;
    public TMP_Text number_hunger;

    private int boundary = 100;

    void Start() {
        storage.mental_health = 1f;
        storage.hunger = 100;
    }

    void Update(){
        if(storage.hunger < 60) {
            boundary = 60;
        }

        if(storage.hunger < 30) {
            boundary = 30;
        }
        if(storage.mental_health > boundary){
            storage.mental_health -= 0.1f;
            mental.fillAmount = storage.mental_health;
        }

        hunger_handler();
    }

    public void hunger_handler() {
        if(storage.hunger > 0) {
            storage.hunger -= 0.1f;
            number_hunger.text = $"{storage.hunger}";
        }

    }
}
