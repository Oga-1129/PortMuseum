using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Movies_Controller : MonoBehaviour
{
    public VideoClip videoClip;
    public GameObject screen;
    public GameObject move_receiver;
    Movies_Receiver script_receiver;

    GameObject receiver;
    CreateController createscript;

    int buttonnum = 0;
    int moviesNum = 0;

    bool MoviesStart = false;

    GameObject Load;
    LoadController loadscript;

    void Start()
    {
        receiver = GameObject.Find("CreateController");
        createscript = receiver.GetComponent<CreateController>();

        Load = GameObject.Find("LoadController");
        loadscript = Load.GetComponent<LoadController>();

        var videoPlayer = screen.AddComponent<VideoPlayer>();	// videoPlayeコンポーネントの追加
        script_receiver = move_receiver.GetComponent<Movies_Receiver>();

        moviesNum = createscript.moviesnum;
        Debug.Log("CreateNum" + createscript.createnum);
        Debug.Log("MoviesNum" + moviesNum);
        if (createscript.creflag[createscript.createnum] == 0)
        {
            videoClip = loadscript.targetvideo[moviesNum];
        }
        else
        {
            videoClip = loadscript.targetvideo[createscript.videonum[createscript.createnum]];
        }

        videoPlayer.source = VideoSource.VideoClip; // 動画ソースの設定
        videoPlayer.clip = videoClip;

        videoPlayer.isLooping = true;	// ループの設定

        buttonnum = createscript.createnum;
    }

    // Update is called once per frame
    void Update()
    {
        var videoPlayer = GetComponent<VideoPlayer>();

        if (createscript.move_num == buttonnum)
        {
            moviesNum = createscript.moviesnum;
            createscript.videonum[buttonnum] = moviesNum;
        }

        if (MoviesStart)
        {
            videoPlayer.Play();// 動画を再生する。
        }
        else
        {
            videoPlayer.Pause();// 動画を一時停止する。
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        // 物体がトリガーに接触しとき、１度だけ呼ばれる
        MoviesStart = true;
    }

    private void OnTriggerExit(Collider collision)
    {
        // 物体がトリガーと離れたとき、１度だけ呼ばれる
        MoviesStart = false;
    }
}
