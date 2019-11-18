using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCanvas : MonoBehaviour
{
    public bool Gage;
    public bool Login;
    private Animator animator;
    GameObject AnimUI;
    AnimationUI animuiscript;

    GameObject CrystalBarUI;
    CrystalBar crystalbarscript;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();

        AnimUI = GameObject.Find("ProfileUI");
        animuiscript = AnimUI.GetComponent<AnimationUI>();

        CrystalBarUI = GameObject.Find("Slider");
        crystalbarscript = CrystalBarUI.GetComponent<CrystalBar>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gage)
        {
            animator.SetBool("FirstMove", true);
        }
        else
        {
            animator.SetBool("FirstMove", false);
        }

        if (Login)
        {
            animator.SetBool("LoginText", true);
        }
    }
    //アニメーションの終了時呼び出し
    public void MotionEnd()
    {
        animuiscript.OpenUI = true;
    }

    public void GageStart()
    {
        crystalbarscript.barmove = true;
    }
}
