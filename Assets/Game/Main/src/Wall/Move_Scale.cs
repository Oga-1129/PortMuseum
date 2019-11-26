using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Scale : MonoBehaviour
{
    GameObject receiver;
    Create_Controller createscript;

    //変更箇所の数値
    public int num;

    //変更値
    public float changescale = 0f;

    void Start()
    {
        receiver = GameObject.Find("Create_Controller");
        createscript = receiver.GetComponent<Create_Controller>();
    }
    public void OnClick()
    {
        createscript.Scale[createscript.move_num, num] += changescale;
    }
}
