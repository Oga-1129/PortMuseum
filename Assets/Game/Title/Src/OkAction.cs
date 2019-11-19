using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OkAction : MonoBehaviour
{
    public Fade fade;              //フェードキャンバス取得
    public void OnClick()
    {
        fade.FadeIn(1f, () =>
        {
            SceneManager.LoadScene("Main");
        });
    }
}
