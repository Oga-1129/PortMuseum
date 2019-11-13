using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateController : MonoBehaviour
{
    public int createnum;
    public int move_num;

    //オブジェクト破棄時加算

    public int makelimit;
    public int destroy_num;

    GameObject Load;
    LoadController loadscript;

    GameObject[] objGet = new GameObject[6];
    MoveScale[] script = new MoveScale[6];  
    //オブジェクトの座標保存
    public float[,] Scale = new float[48,6];
    //生成済みかの確認保存用
    public int[] creflag = new int[48];
    //壁の番号を保存
    public int[] objectnum = new int[48];
    //動画の番号を保存
    public int[] videonum = new int[48];

    //選ばれたボタンの番号
    public int moviesnum;

    public GameObject UsesNum = null; // Textオブジェクト
    public GameObject SelectNum = null; // Textオブジェクト
    Text numtext;
    Text Selecttext;

    int Selectnum = 0;
    // Start is called before the first frame update
    void Start()
    {
        numtext = UsesNum.GetComponent<Text> ();
        Selecttext = SelectNum.GetComponent<Text> ();
        Load = GameObject.Find("LoadController");
        loadscript = Load.GetComponent<LoadController>();

        objGet[0] = GameObject.Find("posx+");
        objGet[1] = GameObject.Find("posx-");
        objGet[2] = GameObject.Find("posz+");
        objGet[3] = GameObject.Find("posz-");

        objGet[4] = GameObject.Find("roty+");
        objGet[5] = GameObject.Find("roty-");


        for(int i = 0; i < 6; i++){
            script[i] = objGet[i].GetComponent<MoveScale>();
        }
    }

    // Update is called once per frame
    public void indate()
    {
        createnum++;
    }

    public void createobject(double positionxp, double positionxm, double positionzp, double positionzm, int num, int objnum)
    {
        if(createnum < makelimit){
            //座標0,0,0に生成
            Instantiate (loadscript.target[objnum], new Vector3 (((float)positionxp + (float)positionxm), 0.0f, ((float)positionzp + (float)positionzm)), Quaternion.identity);
        }
    }

    void Update()
    {
        numtext.text = createnum + "/" + makelimit;

        Selectnum = move_num;
        if(Selectnum != 0){
            Selecttext.text = "" + Selectnum;
        }else{
            Selecttext.text = "NoSelect";
        }
    }
}
