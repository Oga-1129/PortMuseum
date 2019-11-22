using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoviesNum : MonoBehaviour
{

    GameObject receiver;
    CreateController createscript;
    int Buttonnum = 0;
    public GameObject ButtonNum = null; // Textオブジェクト

    string[] MoviesName = new string[6] { "", "RPG", "shooting", "DengerCar", "RifleRange", "AlarmClock" };
    Text buttontext;
    // Start is called before the first frame update
    void Start()
    {
        buttontext = ButtonNum.GetComponent<Text>();

        receiver = GameObject.Find("CreateController");
        createscript = receiver.GetComponent<CreateController>();
    }

    // Update is called once per frame
    void Update()
    {
        Buttonnum = createscript.moviesnum;
        //何の動画を選択か
        switch (Buttonnum)
        {
            case 0:
                buttontext.text = "NoSelect";
                break;

            case 1:
                buttontext.text = "" + MoviesName[Buttonnum];
                break;

            case 2:
                buttontext.text = "" + MoviesName[Buttonnum];
                break;

            case 3:
                buttontext.text = "" + MoviesName[Buttonnum];
                break;

            case 4:
                buttontext.text = "" + MoviesName[Buttonnum];
                break;

            case 5:
                buttontext.text = "" + MoviesName[Buttonnum];
                break;

            default:
                buttontext.text = "Error";
                break;
        }
    }
}
