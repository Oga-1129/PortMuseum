using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Load_Controller : MonoBehaviour
{

    public GameObject DB;
    MappingDataBase dbscript;

    public GameObject receiver;
    Create_Controller createscript;

    GameObject Make_Object;
    Make_Object makeobjscript;

    public GameObject[] target = new GameObject[4];

    //動画の種類
    public VideoClip[] targetvideo = new VideoClip[6];

    //座標保存用変数群
    public double positionxp;
    public double positionxm;

    public double positionzp;
    public double positionzm;

    public double rotationyp;

    public double rotationym;

    public int objectnum;
    public int createflag;

    public bool Install;

    public int loadnum;

    public int makes;

    public int moviesnum;



    // Start is called before the first frame update
    void Start()
    {

        Install = true;
        dbscript = DB.GetComponent<MappingDataBase>();

        createscript = receiver.GetComponent<Create_Controller>();


        for (loadnum = 1; loadnum <= 48; loadnum++)
        {
            dbscript.SelectDataBase(loadnum);
            if (createflag == 1)
            {
                //受け取ったデータを配列に保存
                createscript.Scale[loadnum, 0] = (float)positionxp;
                createscript.Scale[loadnum, 1] = (float)positionxm;
                createscript.Scale[loadnum, 2] = (float)positionzp;
                createscript.Scale[loadnum, 3] = (float)positionzm;
                createscript.Scale[loadnum, 4] = (float)rotationyp;
                createscript.Scale[loadnum, 5] = (float)rotationym;
                createscript.creflag[loadnum] = makes;
                createscript.objectnum[loadnum] = objectnum;
                createscript.videonum[loadnum] = moviesnum;
                createscript.createobject(createscript.Scale[loadnum, 0], createscript.Scale[loadnum, 1], createscript.Scale[loadnum, 2], createscript.Scale[loadnum, 3], loadnum, createscript.objectnum[loadnum - 1]);
                createscript.MakeButton();
            }
        }
    }
}
