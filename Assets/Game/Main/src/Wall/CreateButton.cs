using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateButton : MonoBehaviour
{
    [SerializeField]
    GameObject characterPre = null;//生成するもの
    GameObject character = null;
    [SerializeField]
    Transform characterParent = null;//親

    GameObject receiver;
    CreateController createscript;

    void Start()
    {
        receiver = GameObject.Find("CreateController");
        createscript = receiver.GetComponent<CreateController>();
    }

    public void MakeButton()
    {
        if(createscript.createnum < createscript.makelimit){
            //ボタン生成
            character=(GameObject)Instantiate(characterPre,transform.position,transform.rotation,characterParent);
        }
    }
}
