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
    Active_Script[] ActScript = new Active_Script[3];

    public int Activearraysize;

    //ObjectName配列
    public GameObject[] ObjName = new GameObject[4];

    void Start()
    {
        for (int i = 0; i < Activearraysize; i++)
        {
            ActScript[i] = ObjName[i].GetComponent<Active_Script>();
        }

        for (int j = 0; j < AI_arraysize; j++)
        {
            aiscript[j] = NPC[j].GetComponent<AIMove>();
        }

    }
    public void OnClick()
    {
        for (int i = 0; i < Activearraysize; i++)
        {
            ActScript[i].setActive();
        }

        for (int j = 0; j < AI_arraysize; j++)
        {
            aiscript[j].move = true;
        }
    }
}
