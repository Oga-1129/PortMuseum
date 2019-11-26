using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_Script : MonoBehaviour
{
    public bool Active;
    bool Instance = true;

    void Update()
    {
        if (Instance)
        {
            setActive();
            Instance = false;
        }
    }
    public void setActive()
    {
        if (!Active)
        {
            gameObject.SetActive(true);
            Active = true;
        }
        else
        {
            gameObject.SetActive(false);
            Active = false;
        }
    }
}