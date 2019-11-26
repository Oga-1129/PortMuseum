using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Make_Object : MonoBehaviour
{
    GameObject receiver;
    Create_Controller createscript;


    //生成するゲームオブジェクト
    public GameObject target;

    public int mkobjnum;

    void Start()
    {
        receiver = GameObject.Find("Create_Controller");
        createscript = receiver.GetComponent<Create_Controller>();
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
