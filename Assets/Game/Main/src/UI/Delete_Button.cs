using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Button : MonoBehaviour
{
    GameObject receiver;
    Create_Controller createscript;
    public bool Delete = false;

    void Start()
    {
        receiver = GameObject.Find("Create_Controller");
        createscript = receiver.GetComponent<Create_Controller>();
    }

    public void OnClick()
    {
        Delete = true;
    }
}
