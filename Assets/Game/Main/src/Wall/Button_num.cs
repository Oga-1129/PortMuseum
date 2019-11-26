using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_num : MonoBehaviour
{
    GameObject receiver;
    Create_Controller createscript;

    GameObject Destroy_Controller;
    Destroy_Controller destcontscript;
    int Buttonnum = 0;

    public GameObject ButtonNum = null; // Textオブジェクト
    Text buttontext;


    // Start is called before the first frame update
    void Start()
    {
        buttontext = ButtonNum.GetComponent<Text>();

        receiver = GameObject.Find("Create_Controller");
        createscript = receiver.GetComponent<Create_Controller>();
        Destroy_Controller = GameObject.Find("Destroy_Controller");
        destcontscript = Destroy_Controller.GetComponent<Destroy_Controller>();


        Buttonnum = createscript.createnum;
    }

    // Update is called once per frame
    void Update()
    {
        buttontext.text = "" + Buttonnum;
        if (destcontscript.numberchange && destcontscript.destroybuttonnum < Buttonnum)
        {
            Buttonnum--;
            if (Buttonnum == createscript.createnum)
            {
                destcontscript.numberchange = false;
            }
        }
    }
}
