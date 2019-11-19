using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartClick : MonoBehaviour
{
    private Animator animator;

    public Fade fade;              //フェードキャンバス取得

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnClick()
    {
        animator.SetBool("Start", true);
    }

    public void MotionEnd()
    {
        animator.SetBool("Start", false);
        fade.FadeIn(1f, () =>
        {
            SceneManager.LoadScene("Main");
        });
    }
}
