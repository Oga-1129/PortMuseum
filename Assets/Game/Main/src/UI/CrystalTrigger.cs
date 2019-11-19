using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalTrigger : MonoBehaviour
{
    GameObject AnimUI;
    AnimationUI animuiscript;

    GameObject Player;
    Locomotion locomotionscript;

    GameObject Camera;
    CameraAnimSRC cameraanimuiscript;
    // Start is called before the first frame update
    void Start()
    {
        AnimUI = GameObject.Find("ProfileUI");
        animuiscript = AnimUI.GetComponent<AnimationUI>();

        Player = GameObject.Find("Robot_Gray");
        locomotionscript = Player.GetComponent<Locomotion>();

        Camera = GameObject.Find("Cameramachine");
        cameraanimuiscript = Camera.GetComponent<CameraAnimSRC>();
    }


    //何かがコリジョンに当たった時
    void OnTriggerEnter(Collider obj)
    {
        //当たったもののタグがRobotの時
        if (obj.gameObject.tag == "Robot")
        {
            locomotionscript.SeachBool = true;
            cameraanimuiscript.Crystal_Approach = true;
        }
    }

    //当たっていたものが離れた時
    void OnTriggerExit(Collider obj)
    {
        //離れたもののタグがRobotの時
        if (obj.gameObject.tag == "Robot")
        {
            locomotionscript.SeachBool = false;
            cameraanimuiscript.Crystal_Approach = false;
        }
    }
}
