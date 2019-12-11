using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VCamera : MonoBehaviour
{
    public CinemachineVirtualCamera vcamera1;
    public CinemachineVirtualCamera vcamera2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vcamera1.Priority += 100;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            vcamera2.Priority += 100;
        }
    }
}
