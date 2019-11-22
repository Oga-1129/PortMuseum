using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimSRC : MonoBehaviour
{
    private Animator animator;
    public bool Crystal_Approach;
    // Start is called before the first frame update
    void Start()
    {
        // 自分に設定されているAnimatorコンポーネントを習得する
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Crystal_Approach)
        {
            animator.SetBool("Forward", true);
        }
        else
        {
            animator.SetBool("Forward", false);
        }

    }
}
