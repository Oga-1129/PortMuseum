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
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();

        AnimUI = GameObject.Find("ProfileUI");
        animuiscript = AnimUI.GetComponent<AnimationUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Gage){
            animator.SetBool("FirstMove", true);
        }else{
            animator.SetBool("FirstMove", false);
        }

        if(Login){
            animator.SetBool("LoginText", true);
        }   
    }
    //アニメーションの終了時呼び出し
    public void MotionEnd()
    {
        animuiscript.OpenUI = true;
    }
}
