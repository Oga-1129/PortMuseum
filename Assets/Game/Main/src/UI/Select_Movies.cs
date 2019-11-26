using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_Movies : MonoBehaviour
{
    //動画の番号
    public int MoviesNum;

    GameObject receiver;
    Create_Controller createscript;

    void Start()
    {
        receiver = GameObject.Find("Create_Controller");
        createscript = receiver.GetComponent<Create_Controller>();
    }

    public void OnClick()
    {
        //動画の注文
        createscript.moviesnum = MoviesNum;
    }
}
