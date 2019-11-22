using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviesContentActive : MonoBehaviour
{
    public bool Movies_ON;

    // Update is called once per frame
    public void Active()
    {
        if (Movies_ON)
        {
            gameObject.SetActive(true);
            Movies_ON = false;
        }
        else
        {
            gameObject.SetActive(false);
            Movies_ON = true;
        }
    }
}
