using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Button : MonoBehaviour
{
    public GameObject SaveMenu;
    Save_Menu savemenuscript;
    void Start()
    {
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
