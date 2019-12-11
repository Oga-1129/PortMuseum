using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal_Canvas : MonoBehaviour
{
    public bool Gage;
    public bool Login;
    private Animator animator;
    public GameObject AnimUI;
    Animation_UI animuiscript;

    public GameObject Crystal_BarUI;
    Crystal_Bar Crystal_Barscript;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();

        animuiscript = AnimUI.GetComponent<Animation_UI>();

        Crystal_Barscript = Crystal_BarUI.GetComponent<Crystal_Bar>();
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
        Crystal_Barscript.barmove = true;
    }
}
