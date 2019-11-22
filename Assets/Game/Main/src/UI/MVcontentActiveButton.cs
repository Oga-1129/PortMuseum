using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVcontentActiveButton : MonoBehaviour
{

    GameObject[] MVActive = new GameObject[4];
    MoviesContentActive[] createscript = new MoviesContentActive[4];

    void Start()
    {
        MVActive[0] = GameObject.Find("OnMoviesContent");
        createscript[0] = MVActive[0].GetComponent<MoviesContentActive>();

        MVActive[1] = GameObject.Find("NoMoviesContent");
        createscript[1] = MVActive[1].GetComponent<MoviesContentActive>();

        MVActive[2] = GameObject.Find("MoviesSelecter");
        createscript[2] = MVActive[2].GetComponent<MoviesContentActive>();

        MVActive[3] = GameObject.Find("MoviesListView");
        createscript[3] = MVActive[3].GetComponent<MoviesContentActive>();
    }

    public void OnClick()
    {
        for (int i = 0; i < 4; i++)
        {
            createscript[i].Active();
        }
    }
}
