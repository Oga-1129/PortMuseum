using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_num : MonoBehaviour
{
    GameObject receiver;
    CreateController createscript;

    GameObject destroycontroller;
    DestroyController destcontscript;
    int Buttonnum = 0;
    
    public GameObject ButtonNum = null; // Textオブジェクト
    Text buttontext;

    
    // Start is called before the first frame update
    void Start()
    {
        buttontext = ButtonNum.GetComponent<Text> ();

        receiver = GameObject.Find("CreateController");
        createscript = receiver.GetComponent<CreateController>();
        destroycontroller = GameObject.Find("DestroyController");
        destcontscript = destroycontroller.GetComponent<DestroyController>();


        Buttonnum = createscript.createnum;
    }

    // Update is called once per frame
    void Update()
    {
        buttontext.text = "" + Buttonnum;
        if(destcontscript.numberchange && destcontscript.destroybuttonnum < Buttonnum)
        {
            Buttonnum--;
            if(Buttonnum == createscript.createnum)
            {
                destcontscript.numberchange = false;
            }
        }
    }
}
