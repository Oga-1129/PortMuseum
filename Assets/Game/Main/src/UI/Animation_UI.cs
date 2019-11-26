using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_UI : MonoBehaviour
{
    private Animator animator;
    public bool OpenUI = false;

    GameObject Crystal_Canvas;
    Crystal_Canvas Crystal_Canvasscript;

    public bool[] OpenProfile = new bool[4];
    void Start()
    {
        animator = GetComponent<Animator>();

        Crystal_Canvas = GameObject.Find("Crystal_Canvas");
        Crystal_Canvasscript = Crystal_Canvas.GetComponent<Crystal_Canvas>();
    }

    void Update()
    {
        if (OpenUI)
        {
            animator.SetBool("Open", true);
        }
        else
        {
            animator.SetBool("Open", false);
        }

        if (OpenProfile[0] == true)
        {
            animator.SetBool("Profile", true);
        }
        else
        {
            animator.SetBool("Profile", false);
        }

        if (OpenProfile[1] == true)
        {
            animator.SetBool("Skill", true);
        }
        else
        {
            animator.SetBool("Skill", false);
        }

        if (OpenProfile[2] == true)
        {
            animator.SetBool("Hobby", true);
        }
        else
        {
            animator.SetBool("Hobby", false);
        }

        if (OpenProfile[3] == true)
        {
            animator.SetBool("Carrer", true);
        }
        else
        {
            animator.SetBool("Carrer", false);
        }
    }

    public void MotionEnd02()
    {
        Crystal_Canvasscript.Gage = false;
    }
}
