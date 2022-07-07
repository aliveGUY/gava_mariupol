using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item_Display : MonoBehaviour
{

    public Text textName;
    public Image Sprite;
    public Button delete_btn;
    public Player_Storage storage;

    public void Init(Item item){
        if(textName != null){
            textName.text = item.Name;
        }
        if(Sprite != null){
            Sprite.sprite = item.sprite;
        }
    }

    void Start () {
		delete_btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		storage.storage_items.RemoveAt(transform.GetSiblingIndex());
        Destroy(gameObject);
	}
}
