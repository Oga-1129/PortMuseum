using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_Save : MonoBehaviour
{
    //アクティブ・非アクティブ用変数
    public bool active = false;

    public void Active_Saves()
    {
        if (active)
        {
            //非アクティブ化
            gameObject.SetActive(false);
            active = false;
        }
        else
        {
            //アクティブ化
            gameObject.SetActive(true);
            active = true;
        }
    }
}
