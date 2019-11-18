using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeObject : MonoBehaviour
{
    GameObject receiver;
    CreateController createscript;


    //生成するゲームオブジェクト
    public GameObject target;

    public int mkobjnum;

    void Start()
    {
        receiver = GameObject.Find("CreateController");
        createscript = receiver.GetComponent<CreateController>();
    }
    public void OnClick()
    {
        if (createscript.makelimit > createscript.createnum)
        {
            createscript.objectnum[createscript.createnum] = mkobjnum;
            createscript.createobject(0.0, 0.0, 0.0, 0.0, 0, mkobjnum);
        }
    }
}
