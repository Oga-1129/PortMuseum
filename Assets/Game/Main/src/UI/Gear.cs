﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    GameObject Gears;
    GearActive Gearscript;

    public bool Open;

    void Start()
    {
        Gears = GameObject.Find("Gear-Active");
        Gearscript = Gears.GetComponent<GearActive>();
    }

    public void onClick()
    {
        if(!Open)
        {
            Open = true;
        }else{
            Open = false;
        }
        //UIの表示/非表示を切り替える
        Gearscript.GearActives();
    }
}
