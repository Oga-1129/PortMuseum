using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartClick : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent <Animator> ();
    }

    public void OnClick()
    {
        animator.SetBool("Start",true);
    }

    public void MotionEnd()
    {
        animator.SetBool("Start",false);
        SceneManager.LoadScene("Main");
    }
}
