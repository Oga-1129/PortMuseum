using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpCl_Profile : MonoBehaviour
{
    GameObject AnimUI;
    Animation_UI animuiscript;
    public int ButtonUINum;

    void Start()
    {
        AnimUI = GameObject.Find("ProfileUI");
        animuiscript = AnimUI.GetComponent<Animation_UI>();
    }

    public void OnClick()
    {
        if (animuiscript.OpenProfile[ButtonUINum] == false)
        {
            animuiscript.OpenProfile[ButtonUINum] = true;
        }
        else
        {
            animuiscript.OpenProfile[ButtonUINum] = false;
        }
    }
}
