using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpCl_Profile : MonoBehaviour
{
    public GameObject AnimUI;
    Animation_UI animuiscript;
    public int ButtonUINum;

    void Start()
    {
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
