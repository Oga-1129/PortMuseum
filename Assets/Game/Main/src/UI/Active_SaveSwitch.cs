using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_SaveSwitch : MonoBehaviour
{
    GameObject Save_Menus;
    Active_Save Save_Menuscript;

    public bool Open;

    void Start()
    {
        Save_Menus = GameObject.Find("Active_Save");
        Save_Menuscript = Save_Menus.GetComponent<Active_Save>();
    }

    public void onClick()
    {
        if (!Open)
        {
            Open = true;
        }
        else
        {
            Open = false;
        }
        //UIの表示/非表示を切り替える
        Save_Menuscript.Active_Saves();
    }
}
