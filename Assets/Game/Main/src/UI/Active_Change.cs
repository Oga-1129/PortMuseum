using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Active_Change : MonoBehaviour
{
    //NPCのオブジェクトを格納する変数
    public GameObject[] NPC = new GameObject[0];
    //NPCの移動用スクリプト格納用変数
    AIMove[] aiscript;
    //NPCの配列数
    public int AI_arraysize;



    //Script配列
    Active_Script[] ActScript;
    //アクティブスクリプト数
    public int Activearraysize;

    //ObjectName配列
    public GameObject[] ObjName = new GameObject[4];

    void Start()
    {
        ActScript = new Active_Script[Activearraysize];
        aiscript = new AIMove[AI_arraysize];
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
            //アクティブ・非アクティブの変更
            ActScript[i].setActive();
        }

        for (int j = 0; j < AI_arraysize; j++)
        {
            aiscript[j].move = true;
        }
    }
}
