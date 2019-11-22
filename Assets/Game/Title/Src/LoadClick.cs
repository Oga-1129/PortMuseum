using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadClick : MonoBehaviour
{
    GameObject Canvas;
    LoadMove loadmovescript;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        loadmovescript = Canvas.GetComponent<LoadMove>();
    }

    public void OnClick()
    {
        if (!loadmovescript.Load)
        {
            loadmovescript.Load = true;
        }
        else
        {
            loadmovescript.Load = false;
        }
    }
}
