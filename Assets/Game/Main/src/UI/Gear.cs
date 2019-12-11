using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public GameObject Gears;
    Active_Save Gearscript;

    public bool Open;

    void Start()
    {
        Gearscript = Gears.GetComponent<Active_Save>();
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
        Gearscript.Active_Saves();
    }
}
