using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMove : MonoBehaviour
{
    private Animator animator;
    public bool Load;

    //セーブデータの番号
    public int selectDataNum;

    //セーブデータの番号をMainシーンに持って行く用
    public static int setSaveData;

    public bool ReSelect;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Load)
        {
            animator.SetBool("Load", true);
        }
        else
        {
            animator.SetBool("Load", false);
        }

        switch (selectDataNum)
        {
            case 1:
                animator.SetBool("Data01", true);
                break;

            case 2:
                animator.SetBool("Data02", true);
                break;

            case 3:
                animator.SetBool("Data03", true);
                break;

            case 4:
                animator.SetBool("Data04", true);
                break;

            case 5:
                animator.SetBool("Data05", true);
                break;

            default:
                break;
        }

        if (ReSelect)
        {
            animator.SetBool("Data01", false);
            animator.SetBool("Data02", false);
            animator.SetBool("Data03", false);
            animator.SetBool("Data04", false);
            animator.SetBool("Data05", false);
            ReSelect = false;
            selectDataNum = 0;
        }

        setSaveData = selectDataNum;

    }
}
