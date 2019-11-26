using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close_Menu : MonoBehaviour
{
    GameObject AnimUI;
    Animation_UI animuiscript;

    void Start()
    {
        AnimUI = GameObject.Find("ProfileUI");
        animuiscript = AnimUI.GetComponent<Animation_UI>();
    }
    //メニューを閉じるアニメーション
    public void OnClick()
    {
        animuiscript.OpenUI = false;
    }
}
