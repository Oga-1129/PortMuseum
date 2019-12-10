using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{

    //Unityの公式スクリプトレファンスにあるものと同じ
    //十字キーのみで操作(矢印キー＝前後左右移動)
    //CharacterControllerが必要

    public float forwardspeed = 6.0F;    //前進速度
    public float angleSpeed = 200;
    public float jumpSpeed = 8.0F;   //ジャンプ力
    public float gravity = 20.0F;    //重力の大きさ
    float minAngle = 0.0F;
    float maxAngle = 90.0F;


    //移動速度
    private const float SPEED = 5.0f;

    public bool SeachBool;

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    private float h, v;

    GameObject AnimUI;
    Animation_UI animuiscript;

    GameObject CrystalBarUI;
    Crystal_Bar crystalbarscript;

    GameObject CrystalCanvas;
    Crystal_Canvas crystalcanvasscript;

    private Animator animator;

    // 設定したフラグの名前
    private const string key_isRun = "IsRun";
    private const string key_isJump = "IsJump";

    private const string playerspeed = "Speed";

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();

        rb = this.transform.GetComponent<Rigidbody>();

        // 自分に設定されているAnimatorコンポーネントを習得する
        this.animator = GetComponent<Animator>();

        AnimUI = GameObject.Find("ProfileUI");
        animuiscript = AnimUI.GetComponent<Animation_UI>();

        CrystalBarUI = GameObject.Find("Crystal_Bar");
        crystalbarscript = CrystalBarUI.GetComponent<Crystal_Bar>();

        CrystalCanvas = GameObject.Find("Crystal_Canvas");
        crystalcanvasscript = CrystalCanvas.GetComponent<Crystal_Canvas>();
    }//Start()

    // Update is called once per frame
    //先ほど作成したJoystick
    [SerializeField]
    private Joystick _Velocityjoystick = null;
    void Update()
    {
        Vector3 pos = transform.position;
        // pos.x += _Velocityjoystick.Position.x * SPEED;
        //

        // transform.position = pos;
        controller.SimpleMove(transform.forward * _Velocityjoystick.Position.y * SPEED);

        //方向転換
        transform.Rotate(new Vector3(0, _Velocityjoystick.Position.x, 0));

        //アニメーションブレンド
        GetComponent<Animator>().SetFloat("X", _Velocityjoystick.Position.x);
        GetComponent<Animator>().SetFloat("Y", _Velocityjoystick.Position.y);
    }//Update()
}