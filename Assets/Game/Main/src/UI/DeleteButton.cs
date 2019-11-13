using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButton : MonoBehaviour
{
    GameObject receiver;
    CreateController createscript;
    public bool Delete = false;
    
    void Start()
    {
        receiver = GameObject.Find("CreateController");
        createscript = receiver.GetComponent<CreateController>();
    }

    public void OnClick()
    {
        Delete = true;
    }
}
