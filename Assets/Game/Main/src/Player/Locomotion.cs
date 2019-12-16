using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{

    //Unityの公式スクリプトレファンスにあるものと同じ
    //十字キーのみで操作(矢印キー＝前後左右移動)
    //CharacterControllerが必要

    //移動速度
    public float SPEED = 5.0f;

    public bool SeachBool;

    private CharacterController controller;

    public GameObject AnimUI;
    Animation_UI animuiscript;

    public GameObject CrystalBarUI;
    Crystal_Bar crystalbarscript;

    public GameObject CrystalCanvas;
    Crystal_Canvas crystalcanvasscript;

    private Animator animator;


    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();

        // 自分に設定されているAnimatorコンポーネントを習得する
        this.animator = GetComponent<Animator>();

        animuiscript = AnimUI.GetComponent<Animation_UI>();

        crystalbarscript = CrystalBarUI.GetComponent<Crystal_Bar>();

        crystalcanvasscript = CrystalCanvas.GetComponent<Crystal_Canvas>();
    }//Start()

    // Update is called once per frame
    //先ほど作成したJoystick
    [SerializeField]
    private Joystick _Velocityjoystick = null;
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            crystalcanvasscript.Gage = true;
        }
        Vector3 pos = transform.position;
        controller.SimpleMove(transform.forward * _Velocityjoystick.Position.y * SPEED);

        //方向転換
        transform.Rotate(new Vector3(0, _Velocityjoystick.Position.x, 0));

        //アニメーションブレンド
        GetComponent<Animator>().SetFloat("X", _Velocityjoystick.Position.x);
        GetComponent<Animator>().SetFloat("Y", _Velocityjoystick.Position.y);
    }//Update()
}