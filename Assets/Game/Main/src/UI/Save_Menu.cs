﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Menu : MonoBehaviour
{
    public GameObject Gears;
    Gear Gearscript;
    private Animator animator;

    public bool selectdata;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Gearscript = Gears.GetComponent<Gear>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gearscript.Open)
        {
            animator.SetBool("Open", true);
        }
        else
        {
            animator.SetBool("Open", false);
        }

        if (selectdata)
        {
            animator.SetBool("DataSelect", true);
        }
        else
        {
            animator.SetBool("DataSelect", false);
        }
    }
}
