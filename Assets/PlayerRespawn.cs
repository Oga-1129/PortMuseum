using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Fade fade;    //フェードキャンバス取得
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Respawn()
    {
        Player.transform.position = this.transform.position;
        Player.transform.rotation = this.transform.rotation;
        fade.FadeOut(1f);
        Debug.Log("落ちました");
    }
}
