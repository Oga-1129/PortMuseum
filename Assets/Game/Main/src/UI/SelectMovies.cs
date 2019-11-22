using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMovies : MonoBehaviour
{
    //動画の番号
    public int MoviesNum;

    GameObject receiver;
    CreateController createscript;

    void Start()
    {
        receiver = GameObject.Find("CreateController");
        createscript = receiver.GetComponent<CreateController>();
    }

    public void OnClick()
    {
        //動画の注文
        createscript.moviesnum = MoviesNum;
    }
}
