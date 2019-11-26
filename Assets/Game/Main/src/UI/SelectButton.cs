using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
    //Transformボタンのオブジェクト
    GameObject[] objGetmv = new GameObject[6];
    //Transformボタンのスクリプト
    Move_Scale[] scriptmv = new Move_Scale[6];

    GameObject receiver;
    Create_Controller createscript;


    GameObject Destroy_Controller;
    Destroy_Controller destcontscript;

    GameObject DeleteButton;
    Delete_Button Deletescript;

    public float[] savests = new float[6];

    int buttonnum = 0;


    //動画番号の保存
    int moviesNum;

    GameObject Load;
    Load_Controller loadscript;

    Color color;
    Image image;

    void Start()
    {

        DeleteButton = GameObject.Find("DeleteButton");
        Deletescript = DeleteButton.GetComponent<Delete_Button>();


        receiver = GameObject.Find("Create_Controller");
        createscript = receiver.GetComponent<Create_Controller>();

        Destroy_Controller = GameObject.Find("Destroy_Controller");
        destcontscript = Destroy_Controller.GetComponent<Destroy_Controller>();

        Load = GameObject.Find("Load_Controller");
        loadscript = Load.GetComponent<Load_Controller>();

        image = GetComponent<Image>();


        buttonnum = createscript.createnum + createscript.destroy_num;

        objGetmv[0] = GameObject.Find("posx+");
        objGetmv[1] = GameObject.Find("posx-");
        objGetmv[2] = GameObject.Find("posz+");
        objGetmv[3] = GameObject.Find("posz-");

        objGetmv[4] = GameObject.Find("roty+");
        objGetmv[5] = GameObject.Find("roty-");

        for (int i = 0; i < 6; i++)
        {
            scriptmv[i] = objGetmv[i].GetComponent<Move_Scale>();
        }
    }

    public void onClick()
    {
        createscript.move_num = buttonnum;

    }

    public void Update()
    {
        if (buttonnum == createscript.move_num)
        {
            image.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else
        {
            image.color = new Color(0.01568628f, 0.9921569f, 0.8862745f);

        }

        //座標の保存
        if (createscript.move_num == buttonnum)
        {
            if (Deletescript.Delete == true)
            {
                //ボタンの破棄
                DestroyButton();
                //一度だけ実行させるため
                Deletescript.Delete = false;
                //番号の移動
                destcontscript.numberchange = true;
                //破壊された番号の保存
                destcontscript.destroybuttonnum = buttonnum;
                //どのオブジェクトも動かさない
                createscript.move_num = 0;
            }
            moviesNum = createscript.moviesnum;
        }
        if (destcontscript.numberchange && destcontscript.destroybuttonnum < buttonnum)
        {
            Debug.Log(buttonnum);
            buttonnum--;
            Debug.Log(buttonnum);
        }

    }

    public void DestroyButton()
    {
        //ボタンを消す
        Destroy(this.gameObject);
    }
}
