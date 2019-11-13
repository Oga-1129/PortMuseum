using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movies_Receiver : MonoBehaviour
{
    public int moves;
    public bool[] moves_on;

    // Start is called before the first frame update
    void Start()
    {
        moves_on = new bool[moves];
        for(int i = 0; i < moves;i++)
        {
            moves_on[i] = false;
        }
    }
}
