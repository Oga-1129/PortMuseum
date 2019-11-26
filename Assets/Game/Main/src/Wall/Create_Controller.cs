using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create_Controller : MonoBehaviour
{
    public int createnum;
    public int move_num;

    //オブジェクト破棄時加算

    public int makelimit;
    public int destroy_num;

    GameObject Load;
    Load_Controller loadscript;

    GameObject[] objGet = new GameObject[6];
    Move_Scale[] script = new Move_Scale[6];
    //オブジェクトの座標保存
    public float[,] Scale = new float[49, 6];
    //生成済みかの確認保存用
    public int[] creflag = new int[48];
    //壁の番号を保存
    public int[] objectnum = new int[48];
    //動画の番号を保存
    public int[] videonum = new int[48];

    //選ばれたボタンの番号
    public int moviesnum;

    public GameObject UsesNum = null; // Textオブジェクト
    Text numtext;
    Text Selecttext;

    [SerializeField]
    GameObject characterPre = null;//生成するもの
    GameObject character = null;
    [SerializeField]
    Transform characterParent = null;//親
    // Start is called before the first frame update
    void Start()
    {
        numtext = UsesNum.GetComponent<Text>();
        Load = GameObject.Find("Load_Controller");
        loadscript = Load.GetComponent<Load_Controller>();

        objGet[0] = GameObject.Find("posx+");
        objGet[1] = GameObject.Find("posx-");
        objGet[2] = GameObject.Find("posz+");
        objGet[3] = GameObject.Find("posz-");

        objGet[4] = GameObject.Find("roty+");
        objGet[5] = GameObject.Find("roty-");


        for (int i = 0; i < 6; i++)
        {
            script[i] = objGet[i].GetComponent<Move_Scale>();
        }
    }

    // Update is called once per frame
    public void indate()
    {
        createnum++;
    }

    public void createobject(double positionxp, double positionxm, double positionzp, double positionzm, int num, int objnum)
    {
        if (createnum <= makelimit)
        {
            Debug.Log(objnum);
            Instantiate(loadscript.target[objnum], new Vector3(((float)positionxp + (float)positionxm), 0.0f, ((float)positionzp + (float)positionzm)), Quaternion.identity);
        }
    }

    void Update()
    {
        numtext.text = createnum + "/" + makelimit;
    }

    public void MakeButton()
    {
        if (createnum < makelimit)
        {
            //ボタン生成
            character = (GameObject)Instantiate(characterPre, transform.position, transform.rotation, characterParent);
        }
    }
}
