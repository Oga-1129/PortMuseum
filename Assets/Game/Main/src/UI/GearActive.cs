using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearActive : MonoBehaviour
{
    public bool active = false;
    public void GearActives()
    {
        if (active == true)
        {
            gameObject.SetActive(false);
            active = false;
        }
        else
        {
            gameObject.SetActive(true);
            active = true;
        }
    }
}
