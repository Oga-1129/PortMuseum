using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal_Trigger : MonoBehaviour
{
    public GameObject AnimUI;
    Animation_UI animuiscript;

    public GameObject Player;
    Locomotion locomotionscript;

    public GameObject Camera;
    CameraAnimSRC cameraanimuiscript;
    // Start is called before the first frame update
    void Start()
    {
        animuiscript = AnimUI.GetComponent<Animation_UI>();

        locomotionscript = Player.GetComponent<Locomotion>();

        cameraanimuiscript = Camera.GetComponent<CameraAnimSRC>();
    }


    //何かがコリジョンに当たった時
    void OnTriggerEnter(Collider obj)
    {
        //当たったもののタグがRobotの時
        if (obj.gameObject.tag == "Player")
        {
            locomotionscript.SeachBool = true;
            cameraanimuiscript.Crystal_Approach = true;
        }
    }

    //当たっていたものが離れた時
    void OnTriggerExit(Collider obj)
    {
        //離れたもののタグがRobotの時
        if (obj.gameObject.tag == "Player")
        {
            locomotionscript.SeachBool = false;
            cameraanimuiscript.Crystal_Approach = false;
        }
    }
}
