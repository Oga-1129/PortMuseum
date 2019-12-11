using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_Back : MonoBehaviour
{
    public bool title_back;
    public GameObject save;
    Save savescript;

    public Fade fade;              //フェードキャンバス取得

    void Start()
    {
        savescript = save.GetComponent<Save>();
    }
    public void OnClick()
    {
        title_back = true;
        savescript.saving = true;
        fade.FadeIn(1f, () =>
        {
            SceneManager.LoadScene("Title");
        });
    }
}
