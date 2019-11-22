using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveScript : MonoBehaviour
{
    public bool Active;
    bool Instance = true;

    void Update()
    {
        if (Instance == true)
        {
            setActive();
            Instance = false;
        }
    }
    public void setActive()
    {
        if (Active == false)
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