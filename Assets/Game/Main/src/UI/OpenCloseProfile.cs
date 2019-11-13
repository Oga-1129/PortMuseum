using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseProfile : MonoBehaviour
{
    GameObject AnimUI;
    AnimationUI animuiscript;
    public int ButtonUINum;

    void Start(){
        AnimUI = GameObject.Find("ProfileUI");
        animuiscript = AnimUI.GetComponent<AnimationUI>();
    }

    public void OnClick()
    {
        if(animuiscript.OpenProfile[ButtonUINum] == false)
        {
            animuiscript.OpenProfile[ButtonUINum] = true;
        }else{
            animuiscript.OpenProfile[ButtonUINum] = false;
        }
    }
}
