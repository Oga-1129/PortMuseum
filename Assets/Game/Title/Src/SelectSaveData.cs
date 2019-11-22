using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSaveData : MonoBehaviour
{
    //セーブデータの番号
    public int DataNum;
    GameObject Canvas;
    LoadMove loadmovescript;


    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        loadmovescript = Canvas.GetComponent<LoadMove>();
    }


    public void OnClick()
    {
        loadmovescript.selectDataNum = DataNum;
    }
}
