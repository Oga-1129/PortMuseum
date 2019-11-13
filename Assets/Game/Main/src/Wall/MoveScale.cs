using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScale : MonoBehaviour
{
    GameObject receiver;
    CreateController createscript;

    //変更箇所の数値
    public int num;

    //変更値
    public float changescale = 0f;

    void Start()
    {
        receiver = GameObject.Find("CreateController");
        createscript = receiver.GetComponent<CreateController>();
    }
    public void OnClick() 
    {
        createscript.Scale[createscript.move_num,num] += changescale;
    }
}
