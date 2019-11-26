using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movies_ContentActive : MonoBehaviour
{
    //アクティブ・非アクティブの変更用変数
    public bool Movies_ON;

    // Update is called once per frame
    public void Active()
    {
        if (Movies_ON)
        {
            //アクティブ化
            gameObject.SetActive(true);
            //アクティブ・非アクティブの変更用
            Movies_ON = false;
        }
        else
        {
            //非アクティブ化
            gameObject.SetActive(false);
            //アクティブ・非アクティブの変更用
            Movies_ON = true;
        }
    }
}
