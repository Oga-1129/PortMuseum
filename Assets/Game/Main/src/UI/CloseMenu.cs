using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMenu : MonoBehaviour
{
    GameObject AnimUI;
    AnimationUI animuiscript;

    void Start()
    {
        AnimUI = GameObject.Find("ProfileUI");
        animuiscript = AnimUI.GetComponent<AnimationUI>();
    }
    //メニューを閉じるアニメーション
    public void OnClick()
    {
        animuiscript.OpenUI = false;
    }
}
