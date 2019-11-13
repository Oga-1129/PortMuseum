using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAction : MonoBehaviour
{
    GameObject Canvas;
    LoadMove loadmovescript;


    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        loadmovescript = Canvas.GetComponent<LoadMove>();
    }


    public void OnClick()
    {
       loadmovescript.ReSelect = true;
    }
}
