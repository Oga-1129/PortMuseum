using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Button : MonoBehaviour
{
    GameObject SaveMenu;
    Save_Menu savemenuscript;
    void Start()
    {
        SaveMenu = GameObject.Find("Save_Menu");
        savemenuscript = SaveMenu.GetComponent<Save_Menu>();
    }
    public void OnClick()
    {
        if (!savemenuscript.selectdata)
        {
            savemenuscript.selectdata = true;
        }
        else
        {
            savemenuscript.selectdata = false;
        }
    }
}
