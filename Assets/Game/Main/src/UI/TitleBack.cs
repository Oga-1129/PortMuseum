using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleBack : MonoBehaviour
{
    public bool titleback;
    GameObject save;
    Save savescript;

    void Start()
    {
        save = GameObject.Find("SelectSaveData");
        savescript = save.GetComponent<Save>();
    }
    public void OnClick()
    {
        titleback = true;
        savescript.saving = true;
    }
}
