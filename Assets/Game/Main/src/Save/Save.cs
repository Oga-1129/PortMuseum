using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public int saveNum;
    public bool saving;
    // Start is called before the first frame update
    public void OnClick()
    {
        Debug.Log("セーブデータ" + saveNum + "にセーブしました（仮）");
        saving = true;
    }
}
