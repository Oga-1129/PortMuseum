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

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Object[i] = GameObject.Find(ObjName[i]);
            ActScript[i] = Object[i].GetComponent<ActiveScript>();
        }
    }
    public void OnClick()
    {
        for (int i = 0; i < 3; i++)
        {
            ActScript[i].setActive();
        }
    }
}
