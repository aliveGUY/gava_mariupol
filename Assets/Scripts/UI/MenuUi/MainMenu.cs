using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public Button fsButton;
    public Button scButton;
    public Button thButton;
    int levelComplete; 

    //public Button reset;
  
    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        scButton.interactable = false; 
        thButton.interactable = false;

        switch (levelComplete)
        { case 1: scButton.interactable = true; break;
          case 2: scButton.interactable = true; thButton.interactable = true; break;
        }
    }
    public void LoadTo(int level)
    {SceneManager.LoadScene(level);}

    public void Reset()
    {
        scButton.interactable = false;
        thButton.interactable = false;
        PlayerPrefs.DeleteAll();
    }

    void Update()
    {
        
    }
}
