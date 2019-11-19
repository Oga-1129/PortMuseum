using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeActive : MonoBehaviour
{

    //GameObject配列
    GameObject[] Object = new GameObject[3];

    //Script配列
    ActiveScript[] ActScript = new ActiveScript[3];

    //ObjectName配列
    string[] ObjName = new string[3] { "PlayCanvas", "BuildCanvas", "MainCamera" };
    // string[] ObjName = new string[4] { "PlayCanvas", "BuildCanvas", "MainCamera", "Camera" };
    // string[] ObjName = new string[2] { "PlayCanvas", "BuildCanvas" };

    void Start()
    {
        // for (int i = 0; i < 4; i++)
        // {
        //     Object[i] = GameObject.Find(ObjName[i]);
        //     ActScript[i] = Object[i].GetComponent<ActiveScript>();
        // }

        for (int i = 0; i < 3; i++)
        {
            Object[i] = GameObject.Find(ObjName[i]);
            ActScript[i] = Object[i].GetComponent<ActiveScript>();
        }

        // for (int i = 0; i < 2; i++)
        // {
        //     Object[i] = GameObject.Find(ObjName[i]);
        //     ActScript[i] = Object[i].GetComponent<ActiveScript>();
        // }
    }
    public void OnClick()
    {

        // for (int i = 0; i < 4; i++)
        // {
        //     ActScript[i].setActive();
        // }

        for (int i = 0; i < 3; i++)
        {
            ActScript[i].setActive();
        }

        // for (int i = 0; i < 2; i++)
        // {
        //     ActScript[i].setActive();
        // }
    }
}
