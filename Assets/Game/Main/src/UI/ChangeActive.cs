using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeActive : MonoBehaviour
{

    public GameObject[] NPC = new GameObject[0];

    AIMove[] aiscript = new AIMove[2];
    public int AI_arraysize;



    //Script配列
    ActiveScript[] ActScript = new ActiveScript[3];

    public int Activearraysize;

    //ObjectName配列
    public GameObject[] ObjName = new GameObject[4];
    // string[] ObjName = new string[4] { "PlayCanvas", "BuildCanvas", "MainCamera", "Camera" };
    // string[] ObjName = new string[2] { "PlayCanvas", "BuildCanvas" };

    void Start()
    {
        // for (int i = 0; i < 4; i++)
        // {
        //     Object[i] = GameObject.Find(ObjName[i]);
        //     ActScript[i] = Object[i].GetComponent<ActiveScript>();
        // }

        for (int i = 0; i < Activearraysize; i++)
        {
            ActScript[i] = ObjName[i].GetComponent<ActiveScript>();
        }

        for (int j = 0; j < AI_arraysize; j++)
        {
            aiscript[j] = NPC[j].GetComponent<AIMove>();
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

        for (int i = 0; i < Activearraysize; i++)
        {
            ActScript[i].setActive();
        }

        for (int j = 0; j < AI_arraysize; j++)
        {
            aiscript[j].move = true;
        }
        // for (int i = 0; i < 2; i++)
        // {
        //     ActScript[i].setActive();
        // }
    }
}
