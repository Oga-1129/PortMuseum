using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeActive : MonoBehaviour
{

    //GameObject配列
    GameObject[] Object = new GameObject[4];

    //Script配列
    ActiveScript[] ActScript = new ActiveScript[4];

    //ObjectName配列
    string[] ObjName = new string[4]{"PlayCanvas" , "PlayerActive" , "BuildCanvas" , "MainCamera"};

    void Start(){
        for(int i = 0; i < 4; i++){
            Object[i] = GameObject.Find(ObjName[i]);
            ActScript[i] = Object[i].GetComponent<ActiveScript>();
        }
    }
    public void OnClick() 
    {
        for(int i = 0; i < 4; i++)
        {
            ActScript[i].setActive();
        }
    }
}
