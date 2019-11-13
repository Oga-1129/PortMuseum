using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour
{
    GameObject SaveMenu;
    SaveMenu savemenuscript;
    void Start()
    {
        SaveMenu = GameObject.Find("SaveMenu");
        savemenuscript = SaveMenu.GetComponent<SaveMenu>();
    }
    public void OnClick()
    {
        if(!savemenuscript.selectdata)
        {
            savemenuscript.selectdata = true;
        }else{
            savemenuscript.selectdata = false;
        }
    }
}
