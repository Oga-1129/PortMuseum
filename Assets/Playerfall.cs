using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerfall : MonoBehaviour
{
    public Fade fade;    //フェードキャンバス取得
    public GameObject RespawnPoint;

    PlayerRespawn Respawnscript;
    // Start is called before the first frame update
    void Start()
    {
        Respawnscript = RespawnPoint.GetComponent<PlayerRespawn>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            fade.FadeIn(1f, () =>
            {
                Respawnscript.Respawn();
            });
        }
    }
}
